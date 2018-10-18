using AzmoonGir.Model;
using SQLite.CodeFirst;
using System.Data.Entity;
using History = AzmoonGir.Model.History;

namespace AzmoonGir
{
    public class AzmoongirContext : DbContext
    {
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<History> Histories { get; set; }

        public AzmoongirContext() : base("TestSqllite")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqlConnection = new MyDbContextInistializ(modelBuilder);
            Database.SetInitializer(sqlConnection);
        }

        public class MyDbContextInistializ : SqliteDropCreateDatabaseWhenModelChanges<AzmoongirContext>
        {
            public MyDbContextInistializ(DbModelBuilder modelBuilder) : base(modelBuilder)
            {
            }

            protected override void Seed(AzmoongirContext azmoongirContext)
            {
            }
        }
    }
}