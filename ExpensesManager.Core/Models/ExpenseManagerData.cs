using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesManager.Core.Models
{
    public class ExpenseManagerData
    {
        public List<ExpenseType> ExpenseTypes { get; set; }
        public List<Expense> Expenses { get; set; }
        public int DayOfMonth { get; set; }
        public decimal MonthlyLimit { get; set; }
    }
}
