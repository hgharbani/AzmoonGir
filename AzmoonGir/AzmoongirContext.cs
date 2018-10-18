using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.CodeFirst;

namespace AzmoonGir
{
   public class AzmoongirContext:DbContext
   {
       public AzmoongirContext() : base("TestSqllite") { }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           var sqlConnection = new MyDbContextInistializ(modelBuilder);
           Database.SetInitializer(sqlConnection);
       }

       public class MyDbContextInistializ : SqliteDropCreateDatabaseWhenModelChanges<AzmoongirContext>
       {
            public MyDbContextInistializ(DbModelBuilder modelBuilder):base(modelBuilder) { }

           protected override void Seed(AzmoongirContext azmoongirContext)
           {

           }

        }
   }
}
