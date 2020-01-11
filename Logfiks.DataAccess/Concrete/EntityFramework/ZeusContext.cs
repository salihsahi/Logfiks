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
        public DbSet<YapisalOzellik> YapisalOzellik { get; set; }
        public DbSet<Ulke> Ulke { get; set; }
        //public DbSet<Sehir> Sehir { get; set; }
        public DbSet<Ilce> Ilce { get; set; }
        public DbSet<KombinePaketTuru> KombinePaketTuru { get; set; }
        public DbSet<TekliPaketTuru> TekliPaketTuru { get; set; }
        public DbSet<SevkiyatTipi> SevkiyatTipi { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TasitTipi>().ToTable("tasit_tipleri", "public");
            modelBuilder.Entity<ApiKullanicilari>().ToTable("apikullanicilari", "public");
            modelBuilder.Entity<YapisalOzellik>().ToTable("arac_yapisal_ozellik", "public");
            modelBuilder.Entity<Ulke>().ToTable("ulkeler", "public");


            //modelBuilder.Entity<Sehir>().ToTable("ilceler", "public");
            
            modelBuilder.Entity<KombinePaketTuru>().ToTable("kombine_paket_turleri", "public");
            modelBuilder.Entity<TekliPaketTuru>().ToTable("tekli_paket_turleri", "public");
            modelBuilder.Entity<SevkiyatTipi>().ToTable("sevkiyat_tipleri", "public");
            modelBuilder.Entity<Ilce>().ToTable("ilceler", "public");


        }
    }
}
