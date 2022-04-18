using Microsoft.EntityFrameworkCore;
using WatercoolerApi.Models;

namespace WatercoolerApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}