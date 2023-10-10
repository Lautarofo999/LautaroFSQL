using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Cuenta_Bancarias> Cuentas_Bancarias { get; set; }
        public DbSet<Tarjeta_de_Crédito> Tarjeta_De_Creditos { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-7L92TS0\\SQLEXPRESS;database=Lauti1; trusted_connection=true;Encrypt=False");
        }
    }
    
}
