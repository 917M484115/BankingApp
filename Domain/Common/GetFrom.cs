﻿using System.Collections.Generic;
using BankingApp.Aids.Methods;

namespace BankingApp.Domain.Common
{
    public sealed class GetFrom<TRepository, TObject>
        where TRepository : IRepository<TObject> 
        where TObject : class
    {

        internal TRepository repository
            => GetRepository.Instance<TRepository>();
        public TObject ById(string id)
            => Safe.Run(() => repository?.Get(id)?.GetAwaiter().GetResult(), default(TObject));
        public TObject ByAddress(string address)
            => Safe.Run(() => repository?.Get(address)?.GetAwaiter().GetResult(), default(TObject));

        public IReadOnlyList<TObject> ListBy(string field, string value)
        {
            var r = repository;
            return list(r, field, value);
        }
        public IReadOnlyList<TObject> ListBy(string field, string value, string searchString)
        {
            var r = repository;
            if (r is null) return new List<TObject>().AsReadOnly();
            r.SearchString = searchString;

            return list(r, field, value);
        }
        private static IReadOnlyList<TObject> list(TRepository r, string field, string value)
        {
            if (r is null) return new List<TObject>().AsReadOnly();
            r.FixedFilter = field;
            r.FixedValue = value;
            r.PageIndex = -1;
            return r.Get().GetAwaiter().GetResult();
        }

    }
}
