using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockPortfolioManager.Domain.Entities
{
  [Serializable]
  [Table("Ordem", Schema = "StockPortfolioManager")]
  public partial class Ordem
  {
    [Key]
    public int NotaCorretagem_Id { get; set; }
    public string Mercadoria_Titulo { get; set; }
    public char TipoOrdem { get; set; }
    public char TipoNegocio { get; set; }
    public int Quantidade { get; set; }
    public decimal preco { get; set; }
    public DateTime Vencimento { get; set; }
  }
}
