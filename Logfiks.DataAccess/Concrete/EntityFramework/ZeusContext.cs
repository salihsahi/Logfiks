using LogFiks.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logfiks.DataAccess.Concrete.EntityFramework
{
    public class ZeusContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=185.120.6.139;Database=zeus;Username=zeus_logfiks;Password=Mr98521010*-_");



        public DbSet<TasitTipi> TasitTipi { get; set; }
        public DbSet<ApiKullanicilari> ApiKullanicilari { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TasitTipi>().ToTable("tasit_tipleri", "public");
            modelBuilder.Entity<ApiKullanicilari>().ToTable("apikullanicilari", "public");
        }
    }
}
