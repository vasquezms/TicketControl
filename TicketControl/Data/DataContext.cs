using Microsoft.EntityFrameworkCore;
using TicketControl.Data.Entities;

namespace TicketControl.Data
{
    public class DataContext : DbContext
    {
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {

            }
        public DbSet<Entrance> entrances { get; set; }
        public DbSet<Ticket> tickets { get; set; }


            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Entrance>().HasIndex(c => c.Id).IsUnique();
                modelBuilder.Entity<Ticket>().HasIndex(c => c.Id).IsUnique();

            }
        
    }
}
