using Microsoft.EntityFrameworkCore;
using TicketControl.Data.Entities;

namespace TicketControl.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Entrance> Entrances { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entrance>().HasIndex(c => c.Description).IsUnique();
            modelBuilder.Entity<Ticket>().HasIndex("Id","EntranceId").IsUnique();

        }
    }
}
