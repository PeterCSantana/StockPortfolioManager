using TradingManager.Domain.Entities;
using TradingManager.Domain.Interface.Repository;
using TradingManager.Domain.Interface.Service;

namespace TradingManager.Domain.Service
{
  public class FinanceiroBovespaService : ServiceBase<FinanceiroBovespa>, IFinanceiroBovespaService
  {
    //private readonly IFinanceiroBovespaRepository _financeiroBovespaRepository;
    
    public FinanceiroBovespaService(IFinanceiroBovespaRepository financeiroBovespaRepository) : base(financeiroBovespaRepository)
    {
      //_financeiroBovespaRepository = financeiroBovespaRepository;
    }
  }
}
