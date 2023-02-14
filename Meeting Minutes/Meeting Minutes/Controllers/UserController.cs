using Meeting_Minutes.Data;
using Meeting_Minutes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Meeting_Minutes.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        //GET : USERS
        public IActionResult Index()
        {
            List<User> user = new List<User>();
            DataAccess dataAccess = new DataAccess();

            user = dataAccess.FetchAllUser();

            return View("Index", user);
        }

        public IActionResult DeleteUser(int id)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.Delete(id);

            List<User> user =  dataAccess.FetchAllUser();

            return View("Index", user);
        }

        //Store : User
        public IActionResult Create()
        {
            return View("CreateForm");
        }
        //Edit
        public IActionResult EditUser(int id)
        {
            DataAccess dataAccess = new DataAccess();
            User user = dataAccess.FetchOneUser(id);
            return View("Edit", user);
        }


        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.CreateOrUpdate(user);
            Index();
            return View("Index");
        }
    }
}
