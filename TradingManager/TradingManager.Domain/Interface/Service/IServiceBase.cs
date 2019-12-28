using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TradingManager.Domain.Interface.Service
{
  public interface IServiceBase<T> : IDisposable where T : class
  {
    void Add(params T[] items);
    void Update(params T[] items);
    void Delete(params T[] items);
    T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navProperties);
    IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navProperties);
    IList<T> GetList(Func<T, bool> where, out int TotalPages, int pageIndex = 0, int pageSize = 20, params Expression<Func<T, object>>[] navProperties);
  }
}
