using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<User,UserRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=KEREM\\SQLEXPRESS;database=BenimProjem;integrated security=true; TrustServerCertificate=True");
        }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Headline> Headline { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comment>()
            .HasOne(m => m.User)
            .WithMany(p => p.Comments)
            .HasForeignKey(m => m.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull);
            

            modelBuilder.Entity<Headline>()
            .HasOne(m => m.User)
            .WithMany(p => p.Headlines)
            .HasForeignKey(m => m.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Comment>()
            .HasOne(m => m.Headline)
            .WithMany(p => p.Comments)
            .HasForeignKey(m => m.HeadlineId)
            .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
