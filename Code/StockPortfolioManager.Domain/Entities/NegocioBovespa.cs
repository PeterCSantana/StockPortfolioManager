using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockPortfolioManager.Domain.Entities
{
  [Serializable]
  [Table("NegocioBovespa", Schema = "StockPortfolioManager")]
  public partial class NegocioBovespa
  {
    [Key]
    public int NotaCorretagem_Id { get; set; }
    public decimal Debentures { get; set; }
    public decimal MV_TotCompra { get; set; }
    public decimal MV_TotVenda { get; set; }
    public decimal MO_TotCompra { get; set; }
    public decimal MO_TotVenda { get; set; }
    public decimal Oper_Termo { get; set; }
    public decimal Oper_TituloPublico { get; set; }
    public decimal Vlr_TotNegocio { get; set; }
  }
}
