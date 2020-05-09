using System;
using System.Collections.Generic;
using System.Linq;
using Skell.Types;

namespace Skell.Library.Functions.Indexable
{
    public class Push : Skell.Types.BuiltinLambda
    {
        public Push()
        {
            argList = new List<Tuple<string, Skell.Types.Specifier>>();
            argList.Add(new Tuple<string, Skell.Types.Specifier>("indexable", Skell.Types.Specifier.Any));
            argList.Add(new Tuple<string, Skell.Types.Specifier>("value", Skell.Types.Specifier.Any));
        }

        public override ISkellReturnable Execute(List<Tuple<int, string, Skell.Types.ISkellType>> args)
        {
            var indexable = args.First().Item3;
            var value = args.Skip(1).First().Item3;

            if (indexable is Skell.Types.Array arr)
                arr.Insert(new Skell.Types.Number(0), value);
            
            return new Skell.Types.None();
        }
    }
}