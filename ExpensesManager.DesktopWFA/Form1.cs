using ExpensesManager.Core;
using ExpensesManager.Core.Models;
using System.Windows.Forms;

namespace ExpensesManager.DesktopWFA
{
    public partial class Form1 : Form
    {
        private ExpenseManagerData _data;
        private readonly BindingSource _expensesDataGridSource;
        private readonly BindingSource _expenseTypesDataGridSource;
        private readonly BindingSource _expenseTypesInputSource;
        public Form1(ExpenseManagerData data)
        {
            InitializeComponent();
            _data = data;
            _expensesDataGridSource = new()
            {
                DataSource = _data.Expenses
            };
            _expenseTypesInputSource = new()
            {
                DataSource = _data.ExpenseTypes
            };
            _expenseTypesDataGridSource = new()
            {
                DataSource = _data.ExpenseTypes
            };
            LoadSources();
        }
        private async Task ResetSourceBindings()
        {
            _expensesDataGridSource.ResetBindings(false);
            _expenseTypesInputSource.ResetBindings(false);
            _expenseTypesDataGridSource.ResetBindings(false);
            await DataAccess.SetData(_data);
            UpdateStatus();
        }
        public void LoadSources()
        {
            newExpenseTypeInput.DataSource = _expenseTypesInputSource;
            expensesDataGrid.DataSource = _expensesDataGridSource;
            expenseTypesDataGrid.DataSource = _expenseTypesDataGridSource;
            generalDayOfMonthInput.Value = _data.DayOfMonth;
            generalMonthlyLimitInput.Value = _data.MonthlyLimit;
            UpdateStatus();
        }

        private void newExpenseClearBtn_Click(object sender, EventArgs e)
        {
            ClearNewExpenseGroupInputs();
        }

        private void newExpenseTypeClearBtn_Click(object sender, EventArgs e)
        {
            ClearNewExpenseTypeGroupInputs();
        }

        private void generalResetBtn_Click(object sender, EventArgs e)
        {
            ResetGeneralGroupInputs();
        }

        private async void newExpenseAddBtn_Click(object sender, EventArgs e)
        {
            _data.Expenses.Add(new Expense()
            {
                Description = newExpenseDescInput.Text,
                Amount = newExpenseAmountInput.Value,
                ExpendedOn = DateTime.Now,
                ExpenseType = newExpenseTypeInput.Text,
            });
            await ResetSourceBindings();
            ClearNewExpenseGroupInputs();
            UpdateStatus();
        }

        private async void newExpenseTypeAddBtn_Click(object sender, EventArgs e)
        {
            _data.ExpenseTypes.Add(new ExpenseType()
            {
                Name = newExpenseTypeNameInput.Text,
                Abbreviation = ""
            }); await ResetSourceBindings();
            ClearNewExpenseTypeGroupInputs();
            UpdateStatus();
        }

        private void generalUpdateBtn_Click(object sender, EventArgs e)
        {
            _data.DayOfMonth = ((int)generalDayOfMonthInput.Value);
            _data.MonthlyLimit = generalMonthlyLimitInput.Value;
            ResetGeneralGroupInputs();
            UpdateStatus();
        }

        private void ClearNewExpenseGroupInputs()
        {

            newExpenseTypeInput.Text = "";
            newExpenseDescInput.Text = "";
            newExpenseAmountInput.Value = 0;
        }
        private void ClearNewExpenseTypeGroupInputs()
        {

            newExpenseTypeNameInput.Text = "";
        }
        private void ResetGeneralGroupInputs()
        {
            generalDayOfMonthInput.Value = _data.DayOfMonth;
            generalMonthlyLimitInput.Value = _data.MonthlyLimit;
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            await DataAccess.SetData(_data);
        }
        private void UpdateStatus()
        {
            var (budget, daysRemaining) = DataAccess.GetBudgetAndRemainingDays(_data);
            budgetLabel.Text = $"₹{budget}";
            remainingDaysLabel.Text = $"{daysRemaining} days remain.";
            //if (daysRemaining >= 7) return;
            if (budget < _data.MonthlyLimit * 10 / 100)
            {
                limitlabel.Text = "Oops! your budget is below 10%.";
                limitlabel.ForeColor = Color.Red;
            }
            else if (budget < _data.MonthlyLimit * 30 / 100)
            {
                limitlabel.Text = "Your budget is below 30%.";
                limitlabel.ForeColor = Color.DarkOrange;
            }
            else
            {
                limitlabel.Text = "";
                limitlabel.ForeColor = Color.Black;
            }
        }

        private async void exportAsCSVBtn_Click(object sender, EventArgs e)
        {
            await DataAccess.ExportAsExcelFile(_data);
        }

        private async void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            await ResetSourceBindings();
        }

        private async void dataGrid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            await ResetSourceBindings();
        }
    }
}