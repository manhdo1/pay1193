﻿using Pay1193.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Pay1193.Services
{
    public interface IPayService
    {
        Task CreateAsync(PaymentRecord paymentRecord);
        PaymentRecord GetById(int id);
        TaxYear GetTaxYearById(int id);
        IEnumerable<PaymentRecord> GetAll();
        IEnumerable<SelectListItem> GetAllTaxYear();

        decimal OverTimeHours(decimal hoursWorked, decimal contractualHours);
        decimal ContractualEarning(decimal contractualHours, decimal hoursWorked, decimal hourlyRate);
        decimal OvertimeRate(decimal hourlyRate);
<<<<<<< HEAD
        
        decimal OvertimeEarnings(decimal overtimeEarnings, decimal contractualEarnings);
        decimal TotalEarnings(decimal overtimeEarnings, decimal contractualEarnings);

=======
        //update 22/11
        decimal OvertimeEarnings(decimal overtimeRate, decimal overtimeHours);
>>>>>>> 5fafbe68d1f7664e0f961639473795d8c068ed13
        decimal TotalDeduction(decimal tax, decimal nic, decimal studentLoanRepayment, decimal unionFees);
        decimal NetPay(decimal totalEarnings, decimal totalDeduction);
    }
}
