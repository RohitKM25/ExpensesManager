using ExpensesManager.Core;
using ExpensesManager.Core.Models;

namespace ExpensesManager.DesktopWFA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            ExpenseManagerData data;
            
            ApplicationConfiguration.Initialize();
            await DataAccess.CheckFileExists();
            data = await DataAccess.GetData();
            Application.Run(new Form1(data));
        }
    }
}