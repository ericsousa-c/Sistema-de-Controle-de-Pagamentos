using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_de_Controle_de_Pagamentos.Models;

public class Pagamento
{
    [Key]
    public int Id { get; set; }
    public Cliente? Cliente { get; set; }    
    public int ClienteId { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public double Valor { get; set; }
    public DateTime? Data { get; set; }

    [Required]
    [StringLength(30)]
    public string? Status {  get; set; }

}
