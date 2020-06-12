using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockPortfolioManager.Domain.Entities
{
  [Serializable]
  [Table("NotaCorretagem", Schema = "StockPortfolioManager")]
  public partial class NotaCorretagem
  {
    [Key]
    public int Id { get; set; }
    public int Numero { get; set; }
    public DateTime Dt_Pregrao { get; set; }
    public int Codigo { get; set; }
    public int Cliente { get; set; }
    public decimal Valor { get; set; }
    public string Documento { get; set; }
    public string TipoNota { get; set; }
  }
}
