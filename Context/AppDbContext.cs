using Sistema_de_Controle_de_Pagamentos.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Controle_de_Pagamentos.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Cliente>? Clientes { get; set; }
    public DbSet<Pagamento>? Pagamentos { get; set; }   

}
