﻿using System;
using System.Linq.Expressions;
using BankingApp.Aids.Reflection;

namespace BankingApp.Aids.Services {
    public sealed class ExcelRowClassMapper {

        public ExcelRowClassMapper() { }

        public ExcelRowClassMapper(string name, object value, ExcelRowClassMapperType valueType) {
            Name = name;
            Value = value;
            ValueType = valueType;
        }

        public static ExcelRowClassMapper Create<T>(Expression<Func<T, object>> name, object value, ExcelRowClassMapperType valueType)
            => new ExcelRowClassMapper(GetMember.Name(name), value, valueType);

        public string Name { get; set; }

        public object Value { get; set; }

        public ExcelRowClassMapperType ValueType { get; set; }

    }

}
