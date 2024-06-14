using Microsoft.AspNetCore.Mvc;
using ReportAdminStaff.Data;
using ReportAdminStaff.Models;

namespace ReportAdminStaff.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogIn(User user)
        {
            UsersDAO usersDAO = new UsersDAO();
            User FoundUser = usersDAO.FindUserByNameAndPassword(user);

            if (FoundUser == null)
            {
                return View("LoginFailure", user);
            }
            else
            {
                if (FoundUser.UserType == "admin")
                {
                    return View("AdminHome", FoundUser);
                }
                else
                    return View("SalestaffHome", FoundUser);
            }
            
        }
    }
}
