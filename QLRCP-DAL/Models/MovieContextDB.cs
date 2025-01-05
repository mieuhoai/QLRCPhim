using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLRCP_DAL.Models
{
    public partial class MovieContextDB : DbContext
    {
        public MovieContextDB()
            : base("name=MovieContextDB")
        {
        }

        public virtual DbSet<buy_tickets> buy_tickets { get; set; }
        public virtual DbSet<movies> movies { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<buy_tickets>()
                .Property(e => e.movie_id)
                .IsUnicode(false);

            modelBuilder.Entity<movies>()
                .Property(e => e.movie_id)
                .IsUnicode(false);

            modelBuilder.Entity<movies>()
                .Property(e => e.price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<movies>()
                .Property(e => e.movie_image)
                .IsUnicode(false);

            modelBuilder.Entity<movies>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.status)
                .IsUnicode(false);
        }
    }
}