using System;
using System.Collections.Generic;
using System.Text;
using LawFirmDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace LawFirmDatabaseImplement
{
    public class LawFirmDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-K0NHGEFP\SQLEXPRESS01;Initial Catalog=LawFirmDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().Property(m => m.ImplementerId).IsRequired(false);
            modelBuilder.Entity<MessageInfo>().Property(m => m.ClientId).IsRequired(false);
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }
        public virtual DbSet<Document> Documents { set; get; }
        public virtual DbSet<DocumentComponent> DocumentComponents { set; get; }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
        public virtual DbSet<Implementer> Implementers { get; set; }
        public virtual DbSet<MessageInfo> MessagesInfo { set; get; }
    }
}
