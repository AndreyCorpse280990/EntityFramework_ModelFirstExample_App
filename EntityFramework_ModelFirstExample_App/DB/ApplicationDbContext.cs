using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ModelFirstExample_App.DB
{
    // ApplicationDbContext - класс-менеджер для работы с EF
    internal class ApplicationDbContext : DbContext 
    {
        // коллекция пользователей
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"
                Data Source=LAPTOP-SCD1CHJF\SQLEXPRESS;
                Initial Catalog=user_db_pv324;
                Integrated Security=SSPI;
                Timeout=5;
                TrustServerCertificate=Yes;
            ";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
