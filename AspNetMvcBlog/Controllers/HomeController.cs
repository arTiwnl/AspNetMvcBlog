using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcBlog.Controllers;

public class HomeController : Controller
{
 
    public ActionResult Index()
    {
        return Content("Home Page");
    }

    
}