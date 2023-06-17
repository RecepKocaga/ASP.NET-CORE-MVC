using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public String Index(){
            return "hello";
        }

        public ViewResult Index2()  //ViewResult: görünüm sonucu
        {
           return View("Index"); //view altındaki employee klasörü altındaki Index çalıştır
        }

        public IActionResult Index3(){
            return Content("Employee");
        }
    }
    
}