using EntityFramework_ModelFirstExample_App.DB;
using EntityFramework_ModelFirstExample_App.Model;

using (ApplicationDbContext db = new ApplicationDbContext())
{
    IUserService userService = new RdbUserService(db);
    //
    Console.WriteLine(userService.Auth("admin", "123456"));
    Console.WriteLine(userService.Auth("user", "qwerty"));
}
