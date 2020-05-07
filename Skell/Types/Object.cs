using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Skell.Types
{
    public class Object : ISkellIndexableType
    {
        private readonly Dictionary<String, ISkellType> dict;

        public Object()
        {
            dict = new Dictionary<String, ISkellType>();
        }

        /// <summary>
        /// Creates an object with the given keys and values
        /// If the number of keys and values aren't equal, throws IndexOutOfRangeException()
        /// </summary>
        public Object(String[] k, ISkellType[] v)
        {
            if (k.Length != v.Length) {
                throw new System.IndexOutOfRangeException();
            }
            dict = new Dictionary<String, ISkellType>();
            for (int i = 0; i < k.Length; i++) {
                dict.Add(k[i], v[i]);
            }
        }

        public int Count() => dict.Count;

        public ISkellType GetMember(ISkellType index)
        {
            if (index is String s && dict.ContainsKey(s)) {
                return dict[s];
            }
            var range = dict.Keys.Select(i => (Skell.Types.ISkellType) i).ToArray();
            throw new Skell.Problems.IndexOutOfRange(index, new Skell.Types.Array(range));
        }

        public void Insert(ISkellType index, ISkellType value)
        {
            if (index is Skell.Types.String str) {
                dict[str] = value;
            } else {
                throw new Skell.Problems.UnexpectedType(index, typeof(Skell.Types.String));
            }
        }

        public void Delete(ISkellType index)
        {
            if (index is Skell.Types.String str) {
                dict.Remove(str);
            } else {
                throw new Skell.Problems.UnexpectedType(index, typeof(Skell.Types.String));
            }
        }

        public ISkellReturnable IndexOf(ISkellType value)
        {
            foreach (var pair in dict) {
                if (pair.Value == value) {
                    return pair.Key;
                }
            }
            return new Skell.Types.None();
        }

        public static Number operator +(Object a) => throw new Skell.Problems.InvalidOperation("+", a);
        public static Number operator -(Object a) => throw new Skell.Problems.InvalidOperation("-", a);
        public static Number operator +(Object a, Object b) => throw new Skell.Problems.InvalidOperation("+", a, b);
        public static Number operator -(Object a, Object b) => throw new Skell.Problems.InvalidOperation("-", a, b);
        public static Number operator *(Object a, Object b) => throw new Skell.Problems.InvalidOperation("*", a, b);
        public static Number operator /(Object a, Object b) => throw new Skell.Problems.InvalidOperation("/", a, b);

        public static Boolean operator !(Object a) => throw new Skell.Problems.InvalidOperation("!", a);
        public static Boolean operator ==(Object a1, Object a2) => new Boolean(a1.Equals(a2));
        public static Boolean operator !=(Object a1, Object a2) => new Boolean(!a1.Equals(a2));
        public static Boolean operator >(Object a, Object b) => throw new Skell.Problems.InvalidOperation(">", a, b);
        public static Boolean operator >=(Object a, Object b) => throw new Skell.Problems.InvalidOperation(">=", a, b);
        public static Boolean operator <(Object a, Object b) => throw new Skell.Problems.InvalidOperation("<", a, b);
        public static Boolean operator <=(Object a, Object b) => throw new Skell.Problems.InvalidOperation("<=", a, b);

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("{ ");
            for (int i = 0; i < dict.Count; i++) {
                var item = dict.ElementAt(i);
                var key = item.Key;
                var value = item.Value;
                s.Append(key).Append(" : ").Append(value);
                if (i != dict.Count - 1) {
                    s.Append(", ");
                }
            }
            s.Append(" }");
            return s.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Object ob) {
                return dict.Count == ob.dict.Count && !dict.Except(ob.dict).Any();
            }
            return false;
        }
        public override int GetHashCode() => dict.GetHashCode();
    }
}