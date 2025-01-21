using Microsoft.EntityFrameworkCore;
using NovaPoshta.Constants;
using NovaPoshta.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<AreaEntity> Areas { get; set; }
        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlite(AppDataBase.ConnectionString);
        }
    }

}
