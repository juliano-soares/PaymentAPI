using Entidades.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Configuracoes
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<Payment> Payment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public string GetConnectionString()
        {
            string strcon = "Data Source=DESKTOP-652APCE\\SQLEXPRESS;Initial Catalog=PaymentAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return strcon;
        }
    }
}
