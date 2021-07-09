using System.ComponentModel.DataAnnotations.Schema;

namespace GrpcService.DataAccess
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}    

    }
}