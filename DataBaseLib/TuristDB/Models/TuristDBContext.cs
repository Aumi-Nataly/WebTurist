using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataBaseLib.TuristDB.Models
{
    public partial class TuristDBContext : DbContext
    {
        public TuristDBContext()
        {
        }

        public TuristDBContext(DbContextOptions<TuristDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAttractionInterestPoint> TblAttractionInterestPoints { get; set; } = null!;
        public virtual DbSet<TblAttractionType> TblAttractionTypes { get; set; } = null!;
        public virtual DbSet<TblCity> TblCities { get; set; } = null!;
        public virtual DbSet<TblCountry> TblCountries { get; set; } = null!;
        public virtual DbSet<TblInterestPointCity> TblInterestPointCities { get; set; } = null!;

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Data Source=DESKTOP-DVSENK7\\SQLEXPRESS;Initial Catalog=TuristDB;Integrated Security=True");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAttractionInterestPoint>(entity =>
            {
                entity.HasKey(e => e.Atip)
                    .HasName("PK__tblAttra__5B37D0FD24620146");

                entity.ToTable("tblAttraction_InterestPoint");

                entity.Property(e => e.Atip).HasColumnName("atip");

                entity.Property(e => e.Atid).HasColumnName("atid");

                entity.Property(e => e.Pointid).HasColumnName("pointid");

                entity.HasOne(d => d.At)
                    .WithMany(p => p.TblAttractionInterestPoints)
                    .HasForeignKey(d => d.Atid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_atid");

                entity.HasOne(d => d.Point)
                    .WithMany(p => p.TblAttractionInterestPoints)
                    .HasForeignKey(d => d.Pointid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_pointid");
            });

            modelBuilder.Entity<TblAttractionType>(entity =>
            {
                entity.HasKey(e => e.AtId)
                    .HasName("PK__tblAttra__5B38D4C1981A42F5");

                entity.ToTable("tblAttractionType");

                entity.Property(e => e.AtId).HasColumnName("atId");

                entity.Property(e => e.AtName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("atName");
            });

            modelBuilder.Entity<TblCity>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK__tblCity__F2D21B760659BEF2");

                entity.ToTable("tblCity");

                entity.Property(e => e.CityName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cityName");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TblCities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CountryId");
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__tblCount__D32076BC50A5655D");

                entity.ToTable("tblCountry");

                entity.Property(e => e.CountryId).HasColumnName("countryId");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("countryName");

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("currencyName");

                entity.Property(e => e.LanguageMain)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("languageMain");

                entity.Property(e => e.SummaryInfo).IsUnicode(false);

                entity.Property(e => e.Visa).HasColumnName("visa");
            });

            modelBuilder.Entity<TblInterestPointCity>(entity =>
            {
                entity.HasKey(e => e.PointId)
                    .HasName("PK__tblInter__4CB435AE6CB268C7");

                entity.ToTable("tblInterestPointCity");

                entity.Property(e => e.PointId).HasColumnName("pointId");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.PointName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pointName");

                entity.Property(e => e.SummaryInfo).IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblInterestPointCities)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cityId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
