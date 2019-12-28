using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TradingManager.Domain.Interface.Repository;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Domain.Service
{
  public class ServiceBase<T> : IDisposable, IServiceBase<T> where T : class
  {
    private readonly IRepositoryBase<T> _repository;

    public ServiceBase(IRepositoryBase<T> repository)
    {
      _repository = repository;
    }

    public void Add(params T[] items)
    {
      _repository.Add(items);
    }

    public void Delete(params T[] items)
    {
      _repository.Delete(items);
    }

    public void Dispose()
    {
      _repository.Dispose();
    }

    public IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navProperties)
    {
      return _repository.GetList(where, navProperties);
    }

    public IList<T> GetList(Func<T, bool> where, out int TotalPages, int pageIndex = 0, int pageSize = 20, params Expression<Func<T, object>>[] navProperties)
    {
      return _repository.GetList(where, out TotalPages, pageIndex, pageSize, navProperties);
    }

    public T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navProperties)
    {
      return _repository.GetSingle(where, navProperties);
    }

    public void Update(params T[] items)
    {
      _repository.Update(items);
    }
  }
}
