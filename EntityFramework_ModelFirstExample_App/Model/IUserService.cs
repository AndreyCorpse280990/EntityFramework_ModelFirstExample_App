using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_ModelFirstExample_App.Model
{
    // IUserService - контракт операций с пользователем
    internal interface IUserService
    {
        // Register - регистрация пользователя
        // вход: логин и пароль
        // выход: true в случае успешной регистрации, иначе false
        bool Register(string login, string password);

        // Auth - аутентификация пользователя (проверка логина и пароля)
        // вход: логин и пароль
        // выход: true в случае успешной аутентификации, иначе false
        bool Auth(string login, string password);
    }
}
