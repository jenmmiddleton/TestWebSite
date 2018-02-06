using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestWebSite.DAL
{
    public class Playground_DB_Context : DbContext
    {
        public Playground_DB_Context() : base("name=Playground")
        {

        }

        public DbSet<TestWebSite.Models.Playground_DB.Account> Account { get; set; }
        public DbSet<TestWebSite.Models.Playground_DB.Subscriber> Subscriber { get; set; }
    }
}