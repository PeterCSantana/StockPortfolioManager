using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradingManager.Domain.Entities
{
  [Serializable]
  [Table("TaxaBMF", Schema = "TradingManager")]
  public partial class TaxaBMF
  {
    [Key]
    public int NotaCorretagem_Id { get; set; }
    public decimal Vlr_Liquido { get; set; }
    public decimal IRRF_Day_Trade { get; set; }
    public decimal Tx_Operacional { get; set; }
    public decimal Tx_Registro_BMF { get; set; }
    public decimal Tx_BMF { get; set; }
    public decimal Vlr_Bruto { get; set; }
  }
}
