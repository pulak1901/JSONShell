using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Skell.Interpreter
{
    public class State
    {
        private static ILogger logger;

        // These variables track the state of the interpreter

        internal List<
            Tuple<
                Context<Skell.Types.ISkellType>,
                Context<Skell.Types.Function>,
                bool
            >
        > contexts;

        internal Dictionary<string, Skell.Types.Namespace> all_namespaces;
        private bool flag_returned;

        // These variables act as the public api for handling
        // requests related to variables, functions, namespaces, and names
        public readonly VariableHandler Variables;
        public readonly FunctionHandler Functions;
        public readonly NamespaceHandler Namespaces;

        // More or less intended for debugging purposes
        public readonly NameHandler Names;

        public State()
        {
            logger = Log.ForContext<State>();

            var origin = new Context<Skell.Types.ISkellType>("ORIGIN");
            var functions = new Context<Skell.Types.Function>("ORIGIN");
            
            contexts = new List<Tuple<Context<Skell.Types.ISkellType>, Context<Skell.Types.Function>, bool>>();
            contexts.Add(new Tuple<Context<Types.ISkellType>, Context<Types.Function>, bool>(origin, functions, false));
            
            all_namespaces = new Dictionary<string, Skell.Types.Namespace>();

            this.Variables = new VariableHandler(this);
            this.Functions = new FunctionHandler(this);
            this.Namespaces = new NamespaceHandler(this);
            this.Names = new NameHandler(this);
        }

        internal Context<Skell.Types.ISkellType> current_variables() => contexts.Last().Item1;
        internal Context<Skell.Types.Function> current_functions() => contexts.Last().Item2;
        public bool can_return() => contexts.Last().Item3;
        public bool has_returned() => flag_returned;
        public bool start_return() => flag_returned = true;
        public bool end_return() => flag_returned = false;

        /// <summary>
        /// Safely enter a new returnable context
        /// Any new definitions are lost on switching back with EXIT_CONTEXT
        /// </summary>
        public void ENTER_CONTEXT(string name) {
            var ctx_name = "{" + name + "}";
            var cont = new Context<Skell.Types.ISkellType>(ctx_name);
            var new_functions = new Context<Skell.Types.Function>(ctx_name);

            logger.Verbose($"Entering a new context {cont.name} from {current_variables().name}.");
            
            contexts.Add(new Tuple<Context<Types.ISkellType>, Context<Types.Function>, bool>(cont, new_functions, true));
        }

        /// <summary>
        /// Safely exit the context created by ENTER_RETURNABLE_CONTEXT()
        /// </summary>
        public void EXIT_CONTEXT() {
            var current_name = current_variables().name;
            var tuple = contexts.Last();
            logger.Verbose($"Exiting from {current_name} to {tuple.Item1.name}.");
            contexts.Remove(tuple);
        }

        public class NameHandler
        {
            private string error_not_found = "Name not found";

            private ILogger logger;
            private VariableHandler variables;
            private FunctionHandler functions;
            private NamespaceHandler namespaces;

            public NameHandler(State s)
            {
                logger = Log.ForContext<NameHandler>();
                variables = s.Variables;
                functions = s.Functions;
                namespaces = s.Namespaces;
            }

            /// <summary>
            /// Use to check whether a name can be used for defining something
            /// </summary>
            /// <remark>
            /// Not a specific check, only for checking if a name is open across every type
            /// </remark>
            public bool Available(string s)
                => !Exists(s);

            /// <summary>
            /// Use this before the other functions
            /// </summary>
            public bool Exists(string s)
                => (variables.Exists(s) || functions.Exists(s) || namespaces.Exists(s));

            /// <summary>
            /// Use to check if the name is defined as the expected type
            /// </summary>
            public bool DefinedAs(string s, System.Type type)
            {
                if (Available(s))
                    return false;

                if (variables.Exists(s) && variables.Get(s).GetType() == type)
                    return true;
                else if (functions.Exists(s) && functions.Get(s).GetType() == type)
                    return true;
                else if (namespaces.Exists(s) && namespaces.Get(s).GetType() == type)
                    return true;

                return false;
            }

            /// <summary>
            /// Use to check if the name is defined as a variable
            /// </summary>
            public bool DefinedAsVariable(string s)
            {
                if (Available(s))
                    return false;

                if (variables.Exists(s) && variables.Get(s) is Skell.Types.ISkellType)
                    return true;

                return false;
            }

            /// <summary>
            /// Use to check if the name is defined as an indexable
            /// </summary>
            public bool DefinedAsIndexable(string s)
            {
                if (Available(s))
                    return false;

                if (variables.Exists(s) && variables.Get(s) is Skell.Types.ISkellIndexable)
                    return true;

                return false;
            }

            /// <summary>
            /// Use with DefinedAs to get the value of a name.
            /// </summary>
            public Skell.Types.ISkellNamedType DefinitionOf(string s)
            {
                if (Available(s)) {
                    logger.Error("Attempted to read a name that was invalid");
                    throw new System.Exception(error_not_found);
                }
                
                if (variables.Exists(s))
                    return variables.Get(s);
                else if (functions.Exists(s))
                    return functions.Get(s);
                else
                    return namespaces.Get(s);
            }

            /// <summary>
            /// Opens up a name for use
            /// </summary>
            public void Clear(string s)
            {
                if (variables.Exists(s))
                    variables.Delete(s);
                else if (functions.Exists(s))
                    functions.Delete(s);
                else if (namespaces.Exists(s))
                    namespaces.Delete(s);
            }

        }

        public class VariableHandler
        {
            private State state;

            public VariableHandler(State s)
            {
                state = s;
            }

            public bool Exists(string name) => state.current_variables().Exists(name);

            public Skell.Types.ISkellType Get(string name) => state.current_variables().Get(name);

            public void Set(string name, Skell.Types.ISkellType value) => state.current_variables().Set(name, value);
            
            public void Delete(string name) => state.current_variables().Delete(name);
        }

        public class FunctionHandler
        {
            private State state;

            public FunctionHandler(State s)
            {
                state = s;
            }

            public bool Exists(string name) => state.current_functions().Exists(name);

            public Skell.Types.Function Get(string name) => state.current_functions().Get(name);

            public void Set(string name, Skell.Types.Function value) => state.current_functions().Set(name, value);
            
            public void Delete(string name) => state.current_functions().Delete(name);
        }

        public class NamespaceHandler
        {
            private State state;

            internal NamespaceHandler(State s)
            {
                state = s;
            }

            public void Register(Skell.Types.Namespace ns) => state.all_namespaces.Add(ns.name, ns);

            public bool Exists(string name) => state.all_namespaces.ContainsKey(name);

            public Skell.Types.Namespace Get(string name) => state.all_namespaces[name];

            public void Set(string name, Skell.Types.Namespace ns) => state.all_namespaces[name] = ns;

            public void Delete(string name) => state.all_namespaces.Remove(name);
        }
    }
}