using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using GrpcService;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ProductGrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // wait for grpc server is running
            Console.WriteLine("Waiting for server is running");
            Thread.Sleep(2000);

            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new EmployeeCRUD.EmployeeCRUDClient(channel);

            GrpcService.Empty response1 = client.Insert(new Employee()
            {
                FirstName = "Tom",
                LastName = "Jerry"
            });

            Employee employee = client.SelectById(
                new EmployeeFilter() { EmployeeId = 1041 });

            employee.FirstName = "Tom123";
            employee.LastName = "Jerry123";

            GrpcService.Empty response2 = client.Update(employee);

            GrpcService.Empty response3 = client.Delete(new EmployeeFilter()
            {
                EmployeeId = 1062
            });

            Employees employees = client.SelectAll(new GrpcService.Empty());



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

}