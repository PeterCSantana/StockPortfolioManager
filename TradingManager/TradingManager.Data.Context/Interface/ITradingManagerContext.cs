using System;
using System.Data;

namespace TradingManager.Data.Context.Interface
{
  interface ITradingManagerContext : IDisposable
  {
    IDbConnection Connection { get; }
  }
}