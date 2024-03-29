﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Aids.Methods;
using BankingApp.Aids.Reflection;

namespace BankingApp.Aids.Random
{
    public static class SetRandom
    {
        public static void Values(object o)
        {
            if (o is null) return;
            if (o is IList list) setValuesForList(list);
            else setValuesForProperties(o);
        }
        private static void setValuesForProperties(object o)
        {
            if (o is null) return;
            var t = o.GetType();
            var properties = GetClass.Properties(t);
            foreach (var p in properties)
            {
                if (!p.CanWrite) continue;
                if (p.PropertyType.Name == t.Name) continue;
                var v = GetRandom.Value(p.PropertyType);
                p.SetValue(o, v);
            }
        }

        private static void setValuesForList(IList l)
        {
            if (l is null) return;
            var t = getListElementsType(l);
            for (var c = 0; c <= GetRandom.UInt8(3, 5); c++)
            {
                var v = GetRandom.Value(t);
                l.Add(v);
            }
        }
        private static Type getListElementsType(IList list)
        {
            return Safe.Run(() => {
                var t = list.GetType();
                var types =
                    (from method in t.GetMethods()
                        where method.Name == "get_Item"
                        select method.ReturnType
                    ).Distinct().ToArray();
                return types[0];
            }, (Type)null);
        }
    }
}
