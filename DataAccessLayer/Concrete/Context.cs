using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ZANBAK; database=CoreBlogDb; integrated security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Takim> Takims { get; set; }
        public DbSet<Mac> Macs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Mac>()
                .HasOne(x => x.EvTakim)
                .WithMany(y => y.EvMac)
                .HasForeignKey(z => z.EvTakimId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Mac>()
                .HasOne(x => x.KonukTakim)
                .WithMany(y => y.KonukMac)
                .HasForeignKey(z => z.KonukTakimId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}