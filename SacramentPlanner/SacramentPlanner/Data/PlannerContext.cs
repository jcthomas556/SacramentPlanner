using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Models;


namespace SacramentPlanner.Data
{
   public class PlannerContext : DbContext
   {
      public PlannerContext(DbContextOptions<PlannerContext> options) : base(options)
      {
      }
      public DbSet<Hymn> Hymns { get; set; }
      public DbSet<Speaker> Speakers { get; set; }

      public DbSet<Planner> Planners { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Hymn>().ToTable("Hymn");
         modelBuilder.Entity<Speaker>().ToTable("Speaker");
      }
   }
}
