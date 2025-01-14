using DLWMS.Data.IB230046;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class DLWMSDbContext : DbContext
    {
        private string dbPutanja;

	   public DLWMSDbContext()
	   {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSPutanja"].ConnectionString;
	   }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentiPredmeti>(entity =>
            {
                entity.HasOne(d => d.Student).WithMany(p => p.StudentiPredmeti).HasForeignKey(d => d.StudentId);
                entity.HasOne(d => d.Predmet).WithMany(p => p.StudentiPredmeti).HasForeignKey(d => d.PredmetId);
            });
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasOne(d => d.Spol).WithMany(p => p.Studenti).HasForeignKey(d => d.SpolId);
            });
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<StudentiPredmeti> StudentiPredmeti { get; set; }
        public DbSet<StudentiUvjerenjaIB230046> StudentiUvjerenjaIB230046 { get; set; }

    }
}
