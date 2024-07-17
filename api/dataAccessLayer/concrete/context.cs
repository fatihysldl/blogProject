using entityLayer.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.concrete
{
    public class context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MuhammedFatih\\SQLEXPRESS; initial catalog=FoodDatas; integrated security=true; TrustServerCertificate=True;");
        }
        public DbSet<authorTable> authorTables { get; set; }
        public DbSet<postTable> postTables { get; set; }
    }
}
