using ExpensesManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExpensesManager.Core
{
    public static class DataAccess
    {

        public static readonly string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+"\\expensemanager-data.json";
        public static readonly ExpenseManagerData InitData = new ()
        {
            DayOfMonth = 15,
            Expenses = new List<Expense>(),
            ExpenseTypes = new List<ExpenseType>(),
            MonthlyLimit = 10000
        };
        public static async Task CheckFileExists()
        {
            if (!File.Exists(FilePath))
            {
                await File.WriteAllTextAsync(FilePath, JsonSerializer.Serialize(InitData, new JsonSerializerOptions() { WriteIndented = true }));
            }
        }
        public static async Task<ExpenseManagerData> GetData()
        {
            var data = await File.ReadAllTextAsync(FilePath);
            return JsonSerializer.Deserialize<ExpenseManagerData>(data)!;
        }
        public static async Task SetData(ExpenseManagerData data)
        {
            await File.WriteAllTextAsync(FilePath, JsonSerializer.Serialize(data, new JsonSerializerOptions() { WriteIndented = true }));
        }
        public static async Task ExportAsExcelFile(ExpenseManagerData data)
        {
            string content = "";
            foreach (var expense in data.Expenses)
            {
                content += $"{expense.Description},{expense.ExpenseType},{expense.ExpendedOn:hh:mm:ss tt dd-MM-yyyy},{expense.Amount}\n";
            }
            await File.WriteAllTextAsync(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{DateTime.Now:hh_mm_ss_tt_dd_MM_yyyy} Expenses.csv"), content);

        }
        public static (decimal budget,int daysRemaining) GetBudgetAndRemainingDays(ExpenseManagerData data)
        {
            var dtn = DateTime.Now;
            var totalExpenses = data.Expenses.Select(e => e.Amount).Sum();
            var dayOfEndNowMonth = new DateTime(dtn.Year, dtn.Month, data.DayOfMonth);
            var daydiff = dayOfEndNowMonth.Day - dtn.Day;
            var daysRemaining = daydiff > 0 ? daydiff : ((new DateTime(dtn.Year, dtn.Month, data.DayOfMonth)).AddMonths(1) - dtn).Days;
            var budget = data.MonthlyLimit - totalExpenses;

            return (budget, daysRemaining);
        }
    }
}
