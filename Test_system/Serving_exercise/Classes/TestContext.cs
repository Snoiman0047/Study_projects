using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Serving_exercise.Classes
{
    class Test_Exercises : DbContext
    {
        public DbSet<Test> Test { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<American_exercise> American_exercise { get; set; }

        public Test_Exercises() : base("data source=.;initial catalog=TestExercises_db;integrated security=True") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Test_Exercises>(new DropCreateDatabaseIfModelChanges<Test_Exercises>());
            base.OnModelCreating(modelBuilder);
        }

    }
}
