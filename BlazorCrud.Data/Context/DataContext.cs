using BlazorCrud.Model.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Peliculas> Peliculas { get; set; }
    }
}
