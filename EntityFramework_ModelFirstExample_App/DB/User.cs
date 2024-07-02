using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ModelFirstExample_App.DB
{
    // User - класс, описывающий БД-сущность
    internal class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public DateTime? LastAuthTime { get; set; }

        public User() { }

        public override string ToString()
        {
            return $"{Id} - {Login}";
        }
    }
}
