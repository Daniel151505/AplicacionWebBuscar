using Microsoft.EntityFrameworkCore;
using AplicacionWebBuscar.Models;

namespace AplicacionWebBuscar.Data
{
    public class WebAppContext : DbContext
    {
        public DbSet<Formulario> Formularios { get; set; }
        public WebAppContext(DbContextOptions dco) : base(dco){

        }
    }
}