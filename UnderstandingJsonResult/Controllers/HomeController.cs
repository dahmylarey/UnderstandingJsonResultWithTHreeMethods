using Microsoft.AspNetCore.Mvc;
using UnderstandingJsonResult.Models;

namespace UnderstandingJsonResult.Controllers
{
    public class HomeController : Controller
    {
        //First JsonResult method
        //[Route("/Employee/John")]
        //public JsonResult Index()
        //{
        //    Employee emp = new Employee() { Id = 101, Name = "John", Age = 29, Salary = 10000 };
        //    return new JsonResult(emp);
        //}

        //Second JsonResult method
        [Route("/Employee/John")]
        public JsonResult Index()
        {
            Employee emp = new Employee() { Id = 101, Name = "John", Age = 29, Salary = 10000 };
            return Json(emp);
        }


        //Third JsonResult method
        //[Route("/Employee/John")]
        //public ContentResult Index()
        //{
        //    Employee employee = new Employee() { Id = 101, Name = "John", Salary = 10000, Age = 20 };


        //    //add jsonKey in d Parenthesis follow by the value wrap in double qoutes""then add content type  specify the content type ("application/json")
        //    return Content("{\"name\": \"john\"}", "application/json");
        //}
    }
}
