using DLWMS.Data.IB230046;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
            //throw new NotImplementedException("OnModelCreating!!! Many with many itd...");
            modelBuilder.Entity<StudentiPredmetiIB230046>(entity =>
            {
                entity.HasOne(d => d.Student).WithMany(p => p.StudentiPredmeti).HasForeignKey(d => d.StudentId);
                entity.HasOne(d => d.Predmet).WithMany(p => p.StudentiPredmeti).HasForeignKey(d => d.PredmetId);
            });
            modelBuilder.Entity<StudentiPorukeIB230046>(entity =>
            {
                entity.HasOne(d => d.Student).WithMany(p => p.StudentiPoruke).HasForeignKey(d => d.StudentId);
                entity.HasOne(d => d.Predmet).WithMany(p => p.studentiPoruke).HasForeignKey(d => d.PredmetId);
            });

        }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<PredmetIB230046> Predmeti { get; set; }

        public DbSet<StudentiPredmetiIB230046> StudentiPredmeti { get; set; }
        public DbSet<StudentiPorukeIB230046> studentiPorukeIB230046 { get; set; }
        
    }
}
