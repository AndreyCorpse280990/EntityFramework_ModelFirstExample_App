using EntityFramework_ModelFirstExample_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ModelFirstExample_App.DB
{
    internal class RdbUserService : IUserService
    {
        private readonly ApplicationDbContext _db;

        public RdbUserService(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Register(string login, string password)
        {
            if (_db.Users.FirstOrDefault(u => u.Login == login) != null)
            {
                return false;   // есть такой пользователь
            }
            // иначе нет, добавить пользователя
            User user = new User()
            {
                Login = login,
                Password = password,
                LastAuthTime = null  
            };
            _db.Users.Add(user);
            _db.SaveChanges();
            return true;
        }


        public bool Auth(string login, string password)
        {
            User? user = _db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user != null)
            {
                user.LastAuthTime = DateTime.UtcNow;
                _db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
