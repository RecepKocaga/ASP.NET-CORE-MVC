using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1(){
            string message = $"HELLO WORLD. {DateTime.Now.ToString()}";
            return View("Index1",message);
        }

        public ViewResult Index2()  //ViewResult: görünüm sonucu
        {
            var names = new String[]
            {
              "Recep",
              "Turgay",
              "Merve"
            };
           return View("Index2",names); //view altındaki employee klasörü altındaki Index çalıştır
        }

        public IActionResult Index3(){
            var list = new List<Employee>()
            {
               new Employee(){Id=1, FirstName="Recep", LastName="koçağa", Age=29},
               new Employee(){Id=2, FirstName="turgay", LastName="türker", Age=25},
               new Employee(){Id=3, FirstName="deniz", LastName="sever", Age=21},

            };
            return View("Index3",list);
        }
    }
    
}