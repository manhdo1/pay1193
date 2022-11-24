using Microsoft.AspNetCore.Mvc.Rendering;
using Pay1193.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pay1193.Services
{
    public interface IEmployee
    {
        Task CreateAsync(Employee newEmployee);
        Employee GetById(int employeeId);
        Task UpdateAsync(Employee employee);
        Task UpdateAsync(int id);
        Task Delete(int employeeId);
        decimal UnionFees(int id);
        decimal StudentLoanRepaymentAmount(int id, decimal totalAmount);
<<<<<<< HEAD
        IEnumerable<SelectListItem> GetAllEmployeesForPayroll();
        IEnumerable<Employee> GetAll();
=======
        //update 22/11
        IEnumerable<SelectListItem> GetAllEmployeesForPayroll();
>>>>>>> 5fafbe68d1f7664e0f961639473795d8c068ed13
    }
}
