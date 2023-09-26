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
    public class Context:IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=KEREM\\SQLEXPRESS;database=BenimProjem;integrated security=true; TrustServerCertificate=True");
        }
        public DbSet<User> User { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Headline> Headline { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comment>()
            .HasOne(comment => comment.User)
            .WithMany(g => g.Comments)
            .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<Comment>()
           .HasOne(comment => comment.Headline)
           .WithMany(g => g.Comments)
           .HasForeignKey(s => s.HeadlineId);


            modelBuilder.Entity<User>()
            .HasOne(comment => comment.Headlines)
            .WithMany(g => g.h)
            .HasForeignKey(s => s.UserId);

        }
    }
   
}
