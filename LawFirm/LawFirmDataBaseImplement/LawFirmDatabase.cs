﻿using System;
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
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-3ONQPAF5\SQLEXPRESS01;Initial Catalog=LawFirmDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Component> Components { set; get; }
        public virtual DbSet<Document> Documents { set; get; }
        public virtual DbSet<DocumentComponent> DocumentComponents { set; get; }
        public virtual DbSet<Client> Clients { set; get; }
        public virtual DbSet<Order> Orders { set; get; }
    }
}
