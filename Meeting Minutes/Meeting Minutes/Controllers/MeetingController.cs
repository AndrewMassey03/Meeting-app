using Meeting_Minutes.Data;
using Meeting_Minutes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace Meeting_Minutes.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        //GET : MEETS
        public IActionResult Index()
        {
           List<Meeting> meet = new List<Meeting>();
           DataAccess dataAccess = new DataAccess();
           meet = dataAccess.FetchAllMeets();

           return View("Index", meet);
        }

    }

  
}
