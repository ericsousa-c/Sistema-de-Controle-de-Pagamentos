using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Controle_de_Pagamentos.Models;
public class Cliente
{
    public Cliente()
    {
        Pagamentos = new Collection<Pagamento>();
    }
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    [Required]
    [StringLength(100)]
    [EmailAddress]
    public string Email {  get; set; }
    public ICollection<Pagamento> Pagamentos { get; set; }
}
