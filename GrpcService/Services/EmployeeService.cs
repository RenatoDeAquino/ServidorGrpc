using DataAccess = GrpcService.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Threading.Tasks;
using GrpcService.DataAccess;
using System.Linq;

using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcService
{

     public class EmployeeService : EmployeeCRUD.EmployeeCRUDBase
    {
        private DataAccess.EmployeeContext db = null;

        public EmployeeService(DataAccess.EmployeeContext db)
        {
            this.db = db;
        }

        public override Task<Employees> SelectAll(Empty requestData, ServerCallContext context)
        {
            Employees responseData = new Employees();

            var query = from emp in db.Employees
                        select new Employee()
                        {
                            EmployeeId = emp.EmployeeID,
                            FirstName = emp.FirstName,
                            LastName = emp.LastName
                        };

            responseData.Items.AddRange(query.ToArray());
            return Task.FromResult(responseData);
        }

        public override Task<Employee> SelectById(EmployeeFilter requestData, ServerCallContext context)
        {
            var data = db.Employees.Find(requestData.EmployeeId);

            Employee emp = new Employee
            {
                EmployeeId = data.EmployeeID,
                FirstName = data.FirstName,
                LastName = data.LastName
            };

            return Task.FromResult(emp);
        }

        public override Task<Empty> Insert(Employee requestData, ServerCallContext context)
        {
            db.Employees.Add(new DataAccess.Employee()
            {
                EmployeeID = requestData.EmployeeId,
                FirstName = requestData.FirstName,
                LastName = requestData.LastName
            });

            db.SaveChanges();

            return Task.FromResult(new Empty());
        }

        public override Task<Empty> Update(Employee requestData, ServerCallContext context)
        {
            db.Employees.Update(new DataAccess.Employee()
            {
                EmployeeID = requestData.EmployeeId,
                FirstName = requestData.FirstName,
                LastName = requestData.LastName
            });

            db.SaveChanges();

            return Task.FromResult(new Empty());
        }

        public override Task<Empty> Delete(EmployeeFilter requestData, ServerCallContext context)
        {
            var data = db.Employees.Find(requestData.EmployeeId);

            db.Employees.Remove(new DataAccess.Employee()
            {
                EmployeeID = data.EmployeeID,
                FirstName = data.FirstName,
                LastName = data.LastName
            });

            db.SaveChanges();

            return Task.FromResult(new Empty());
        }



    }
}
