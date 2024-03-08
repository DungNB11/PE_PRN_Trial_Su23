using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q3.Models;

namespace Q3.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            List<Employee> list = new List<Employee>();
            using (var context = new PE_Fall21B5Context())
            {
                list = context.Employees.ToList();
            }
            return View(list);
        }
        public IActionResult Delete(int Id)
        {
            string sql = $"delete from Employee where Id = {Id}"+
                $"delete from Employee where Id = {Id}";

            using (var context = new PE_Fall21B5Context())
            {
                context.Database.ExecuteSqlRaw(sql);
            }
            return Redirect("/Employee/List");
        }
    }
}
