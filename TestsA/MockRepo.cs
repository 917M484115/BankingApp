using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApp.Domain.Common;

namespace BankingApp.Tests
{
	internal class MockRepo<T> : IRepository<T> where T : IUniqueEntity
	{
		private readonly List<T> list = new();
		public string SortOrder { get; set; }
		public string SearchString { get; set; }
		public string CurrentFilter { get; set; }
		public string FixedFilter { get; set; }
		public string FixedValue { get; set; }
		public int PageIndex { get; set; }
		public int PageSize { get; set; }
		public int TotalPages { get; set; }
		public bool HasNextPage { get; set; }
		public bool HasPreviousPage { get; set; }

		public async Task Add(T obj) => await Update(obj);
		public async Task Delete(string id)
		{
			var item = await Get(id);
			if (item is not null) list.Remove(item);
		}
		public async Task<List<T>> Get()
		{
			await Task.CompletedTask;
			var pi = (FixedFilter is null) ? null : typeof(T).GetProperty(FixedFilter);
			if (pi is null) return new List<T>(list);
			var l = new List<T>();
			foreach (var item in list)
			{
				var v = pi?.GetValue(item)?.ToString();
				if (v == FixedValue) l.Add(item);
			}
			return new List<T>(l);
		}
		public async Task<T> Get(string id)
		{
			await Task.CompletedTask;
			return (T)GetById(id);
		}
		public object GetById(string id) => list.Find(x => x.Id == id);
		public async Task Update(T obj)
		{
			if (obj is not null)
			{
				await Delete(obj.Id);
				list.Add(obj);
			}
		}
	}
}
