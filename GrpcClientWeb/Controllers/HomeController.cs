using GrpcClientWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GrpcService;
using Grpc.Net.Client;

namespace GrpcClientWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new EmployeeCRUD.EmployeeCRUDClient(channel);

            Empty response1 = client.Insert(new Employee()
            {
                FirstName = "Tom",
                LastName = "Jerry"
            });

            Employee employee = client.SelectById( new EmployeeFilter() { EmployeeId = 1041 });

            employee.FirstName = "Tom123";
            employee.LastName = "Jerry123";

            Empty response2 = client.Update(employee);

            Empty response3 = client.Delete(new EmployeeFilter()
            {
                EmployeeId = 1062
            });
            Employees employees = client.SelectAll
            (new Empty());
            return View(employees);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
