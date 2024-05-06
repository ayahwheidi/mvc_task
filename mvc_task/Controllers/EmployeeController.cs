using Microsoft.AspNetCore.Mvc;
using mvc_task.context;
using mvc_task.data;
using System.Xml.Linq;

namespace mvc_task.Controllers
{
    public class EmployeeController : Controller
    {

        DbApliicationContext context = new DbApliicationContext();
        public IActionResult Index()
        {
            //var name = "wheidi";
            //return View("Create",name);
            var employee = context.Employees.ToList(); ;
            return View("Create", employee);


        }
    }
}
