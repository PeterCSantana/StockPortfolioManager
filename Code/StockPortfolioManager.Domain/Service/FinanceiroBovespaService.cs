using StockPortfolioManager.Domain.Entities;
using StockPortfolioManager.Domain.Interface.Repository;
using StockPortfolioManager.Domain.Interface.Service;

namespace StockPortfolioManager.Domain.Service
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
