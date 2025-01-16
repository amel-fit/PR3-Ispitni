using FIT.Data;
using FIT.Data._2202IB230046;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;
        
        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prisustvo>().HasOne(s => s.Student).WithMany(p => p.Prisustva);
            modelBuilder.Entity<Prisustvo>().HasOne(n => n.Nastava).WithMany(p => p.Prisustva);

            modelBuilder.Entity<Nastava>().HasOne(p => p.Prostorija).WithMany(n => n.Nastave);
            modelBuilder.Entity<Nastava>().HasOne(p => p.Predmet).WithMany(n => n.Nastave);

            modelBuilder.Entity<Predmet>().HasOne(p => p.SemestarObj).WithMany(p => p.Predmeti).HasForeignKey(p => p.Semestar);
            modelBuilder.Entity<Semestar>().HasMany(s => s.Predmeti);
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<Prisustvo> Prisustva { get; set; }
        public DbSet<Nastava> Nastave { get; set; }
        public DbSet<Prostorija> Prostorije { get; set; }
        
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Semestar> Semestri { get; set; }


    }
}