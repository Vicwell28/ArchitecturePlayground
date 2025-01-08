using ArchitecturePlayground.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePlayground.Data
{
    public class ArchitecturePlaygroundDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LENOVOBASURTO,1433;Database=ArchitecturePlayground;Integrated Security=false;User ID=sa;Password=}It3#tP6l4_xQI57nRp8nH#Vm;Connection Timeout=15;Encrypt=true;TrustServerCertificate=true;Pooling=false;")
                    .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                    .EnableSensitiveDataLogging();
            }
        }


        public DbSet<Video> Videos { get; set; } = null!;
        public DbSet<Streamer> Streamers { get; set; } = null!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Video>(entity =>
            {
                entity.HasOne(d => d.Streamer)
                    .WithMany(p => p!.Videos)
                    .HasForeignKey(d => d.StreamerId)
                    .HasPrincipalKey(p => p.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
