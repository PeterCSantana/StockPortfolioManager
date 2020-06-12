using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using StockPortfolioManager.Domain.Interface.Repository;
using StockPortfolioManager.Domain.Interface.Service;

namespace StockPortfolioManager.Domain.Service
{
  public class ServiceBase<T> : IDisposable, IServiceBase<T> where T : class
  {
    private readonly IRepositoryBase<T> _repository;

    public ServiceBase(IRepositoryBase<T> repository)
    {
      _repository = repository;
    }

    public virtual void Add(params T[] items)
    {
      _repository.Add(items);
    }

    public virtual void Delete(params T[] items)
    {
      _repository.Delete(items);
    }

    public virtual void Dispose()
    {
      _repository.Dispose();
    }

    public virtual IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navProperties)
    {
      return _repository.GetList(where, navProperties);
    }

    public virtual IList<T> GetList(Func<T, bool> where, out int TotalPages, int pageIndex = 0, int pageSize = 20, params Expression<Func<T, object>>[] navProperties)
    {
      return _repository.GetList(where, out TotalPages, pageIndex, pageSize, navProperties);
    }

    public virtual T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navProperties)
    {
      return _repository.GetSingle(where, navProperties);
    }

    public virtual void Update(params T[] items)
    {
      _repository.Update(items);
    }
  }
}
