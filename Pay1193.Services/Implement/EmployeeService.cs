﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pay1193.Entity;
using Pay1193.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pay1193.Services.Implement
{
    public class EmployeeService : IEmployee
    {
        private readonly ApplicationDbContext _context;
<<<<<<< HEAD
        private decimal studentLoanAmount;

=======
        //update 22/11
        private decimal studentLoanAmount;
>>>>>>> 5fafbe68d1f7664e0f961639473795d8c068ed13
        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

        public Employee GetById(int employeeId)
        {
            return _context.Employees.Where(e => e.Id == employeeId).FirstOrDefault();

        }

        public async Task Delete(int employeeId)
        {
            var employee = GetById(employeeId);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.AsNoTracking().OrderBy(emp => emp.FullName);

        }
        public async Task UpdateAsync(Employee employee)
        {
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id)
        {
            var employee = GetById(id);
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }



        public decimal StudentLoanRepaymentAmount(int id, decimal totalAmount)
        {
            var employee = GetById(id);
            if (employee.StudentLoan == StudentLoan.Yes && totalAmount > 1750 && totalAmount < 2000)
            {
                studentLoanAmount = 15m;
            }
            else if (employee.StudentLoan == StudentLoan.Yes && totalAmount >= 2000 && totalAmount < 2250)
            {
                studentLoanAmount = 38m;
            }
            else if (employee.StudentLoan == StudentLoan.Yes && totalAmount >= 2250 && totalAmount < 2500)
            {
                studentLoanAmount = 60m;
            }
            else if (employee.StudentLoan == StudentLoan.Yes && totalAmount >= 2500)
            {
                studentLoanAmount = 83m;
            }
            else
            {
                studentLoanAmount = 0m;
            }
            return studentLoanAmount;
        }

        public decimal UnionFees(int id)
        {
            var employee = GetById(id);
            var fee = employee.UnionMember == UnionMember.Yes ? 10m : 0m;
            return fee;
        }


        public IEnumerable<SelectListItem> GetAllEmployeesForPayroll()
        {
            return GetAll().Select(emp => new SelectListItem()
            {
                Text = emp.FullName,
                Value = emp.Id.ToString()
            });
        }

       
<<<<<<< HEAD


=======
        //update 22/11
        public decimal StudentLoanRepaymentAmount(int id, decimal totalAmount)
        {
            var employee = GetById(id);
            if (employee.StudentLoan == StudentLoan.Yes && totalAmount > 1750 && totalAmount < 2000)
            {
                studentLoanAmount = 15m;
            }
            else if (employee.StudentLoan == StudentLoan.Yes && totalAmount >= 2000 && totalAmount < 2250)
            {
                studentLoanAmount = 38m;
            }
            else if (employee.StudentLoan == StudentLoan.Yes && totalAmount >= 2250 && totalAmount < 2500)
            {
                studentLoanAmount = 60m;
            }
            else if (employee.StudentLoan == StudentLoan.Yes && totalAmount >= 2500)
            {
                studentLoanAmount = 83m;
            }
            else
            {
                studentLoanAmount = 0m;
            }
            return studentLoanAmount;
        }
        //update 22/11
        public decimal UnionFee(int id)
        {
            var employee = GetById(id);
            var fee = employee.UnionMember == UnionMember.Yes ? 10m : 0m;
            return fee;
        }

        public IEnumerable<SelectListItem> GetAllEmployeesForPayroll()
        {
            return GetAll().Select(emp => new SelectListItem()
            {
                Text = emp.FullName,
                Value = emp.Id.ToString()
            });
        }
>>>>>>> 5fafbe68d1f7664e0f961639473795d8c068ed13

        
    }
}
