using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawFirmDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;


namespace LawFirmDatabaseImplement
{
    public class LawFirmDatabase : DbContext
    {
        public static void Main()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             if (optionsBuilder.IsConfigured == false)
             {
<<<<<<< Updated upstream
             optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-B2TPTK14\SQLEXPRESS01;Initial Catalog=LawFirmDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
             }
             base.OnConfiguring(optionsBuilder);
         }
         public virtual DbSet<Component> Components { set; get; }
=======
             optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-K0NHGEFP\SQLEXPRESS;Initial Catalog=LawFirmDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
             }
             base.OnConfiguring(optionsBuilder);
         }

        internal object Include(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<Component> Components { set; get; }
>>>>>>> Stashed changes
         public virtual DbSet<Document> Documents { set; get; }
         public virtual DbSet<DocumentComponent> DocumentComponents { set; get; }
         public virtual DbSet<Order> Orders { set; get; }

    }
}
