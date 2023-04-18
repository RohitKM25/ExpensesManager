using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesManager.Core.Models
{
    public class Expense
    {

        public string ExpenseType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpendedOn { get; set; }
    }
}
