using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockPortfolioManager.Domain.Entities
{
  [Serializable]
  [Table("FinanceiroBovespa", Schema = "StockPortfolioManager")]
  public partial class FinanceiroBovespa
  {
    [Key]
    public int NotaCorretagem_Id { get; set; }
    public decimal Vlr_Liquido_Operacao { get; set; }
    public decimal Tx_Liquidacao { get; set; }
    public decimal Tx_Registro { get; set; }
    public decimal Tx_TermoOpcao { get; set; }
    public decimal Tx_ANA { get; set; }
    public decimal Emolumentos { get; set; }
    public decimal Corretagem { get; set; }
    public decimal ISS_RJ { get; set; }
    public decimal IRRF { get; set; }
    public decimal Outros { get; set; }
    public decimal Vlr_Bruto { get; set; }
  }
}
