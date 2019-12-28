using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TradingManager.Application.Interface;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Application
{
  public class AppBase<T> : IDisposable, IAppBase<T> where T : class
  {
    private readonly IServiceBase<T> _serviceBase;

    public AppBase(IServiceBase<T> serviceBase)
    {
      _serviceBase = serviceBase;
    }

    public virtual void Add(params T[] items)
    {
      _serviceBase.Add(items);
    }

    public virtual void Delete(params T[] items)
    {
      _serviceBase.Delete(items);
    }

    public virtual void Dispose()
    {
      _serviceBase.Dispose();
    }

    public virtual IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navProperties)
    {
      return _serviceBase.GetList(where, navProperties);
    }

    public virtual IList<T> GetList(Func<T, bool> where, out int TotalPages, int pageIndex = 0, int pageSize = 20, params Expression<Func<T, object>>[] navProperties)
    {
      return _serviceBase.GetList(where, out TotalPages, pageIndex, pageIndex, navProperties);
    }

    public virtual T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navProperties)
    {
      return _serviceBase.GetSingle(where, navProperties);
    }

    public virtual void Update(params T[] items)
    {
      _serviceBase.Update(items);
    }
  }
}
