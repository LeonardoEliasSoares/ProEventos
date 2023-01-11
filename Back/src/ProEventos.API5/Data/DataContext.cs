using Microsoft.EntityFrameworkCore;
using ProEventos.API5.Models;

namespace ProEventos.Api5.Data{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Evento> Eventos { get; set; }

    }
}