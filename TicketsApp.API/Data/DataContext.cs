using Microsoft.EntityFrameworkCore;
using TicketsApp.API.Models;

namespace TicketsApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {        }

        public DbSet<Value> Values { get; set; }

    }
}