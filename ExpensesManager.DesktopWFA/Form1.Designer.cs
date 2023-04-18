namespace ExpensesManager.DesktopWFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox1 = new GroupBox();
            newExpenseClearBtn = new Button();
            newExpenseAddBtn = new Button();
            label3 = new Label();
            newExpenseTypeInput = new ComboBox();
            expenseTypesBindingSource = new BindingSource(components);
            expenseManagerDataBindingSource = new BindingSource(components);
            newExpenseAmountInput = new NumericUpDown();
            newExpenseDescInput = new TextBox();
            label2 = new Label();
            expenseTypeBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            newExpenseTypeClearBtn = new Button();
            newExpenseTypeAddBtn = new Button();
            newExpenseTypeNameInput = new TextBox();
            label5 = new Label();
            expensesDataGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            expensesBindingSource = new BindingSource(components);
            groupBox4 = new GroupBox();
            generalMonthlyLimitInput = new NumericUpDown();
            label6 = new Label();
            generalDayOfMonthInput = new NumericUpDown();
            generalResetBtn = new Button();
            generalUpdateBtn = new Button();
            label4 = new Label();
            statusStrip1 = new StatusStrip();
            budgetLabel = new ToolStripStatusLabel();
            remainingDaysLabel = new ToolStripStatusLabel();
            limitlabel = new ToolStripStatusLabel();
            exportAsCSVBtn = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            expenseTypesDataGrid = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expenseTypesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseManagerDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newExpenseAmountInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseTypeBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expensesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expensesBindingSource).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)generalMonthlyLimitInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)generalDayOfMonthInput).BeginInit();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expenseTypesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(newExpenseClearBtn);
            groupBox1.Controls.Add(newExpenseAddBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(newExpenseTypeInput);
            groupBox1.Controls.Add(newExpenseAmountInput);
            groupBox1.Controls.Add(newExpenseDescInput);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 152);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Expense";
            // 
            // newExpenseClearBtn
            // 
            newExpenseClearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newExpenseClearBtn.Location = new Point(154, 123);
            newExpenseClearBtn.Name = "newExpenseClearBtn";
            newExpenseClearBtn.Size = new Size(93, 23);
            newExpenseClearBtn.TabIndex = 10;
            newExpenseClearBtn.Text = "Clear";
            newExpenseClearBtn.UseVisualStyleBackColor = true;
            newExpenseClearBtn.Click += newExpenseClearBtn_Click;
            // 
            // newExpenseAddBtn
            // 
            newExpenseAddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newExpenseAddBtn.Location = new Point(253, 123);
            newExpenseAddBtn.Name = "newExpenseAddBtn";
            newExpenseAddBtn.Size = new Size(93, 23);
            newExpenseAddBtn.TabIndex = 9;
            newExpenseAddBtn.Text = "Add";
            newExpenseAddBtn.UseVisualStyleBackColor = true;
            newExpenseAddBtn.Click += newExpenseAddBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 81);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Amount";
            // 
            // newExpenseTypeInput
            // 
            newExpenseTypeInput.DataSource = expenseTypesBindingSource;
            newExpenseTypeInput.DisplayMember = "Name";
            newExpenseTypeInput.FormattingEnabled = true;
            newExpenseTypeInput.Location = new Point(89, 21);
            newExpenseTypeInput.Name = "newExpenseTypeInput";
            newExpenseTypeInput.Size = new Size(257, 23);
            newExpenseTypeInput.TabIndex = 7;
            newExpenseTypeInput.ValueMember = "Name";
            // 
            // expenseTypesBindingSource
            // 
            expenseTypesBindingSource.DataMember = "ExpenseTypes";
            expenseTypesBindingSource.DataSource = expenseManagerDataBindingSource;
            // 
            // expenseManagerDataBindingSource
            // 
            expenseManagerDataBindingSource.DataSource = typeof(Core.Models.ExpenseManagerData);
            // 
            // newExpenseAmountInput
            // 
            newExpenseAmountInput.Location = new Point(89, 79);
            newExpenseAmountInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            newExpenseAmountInput.Name = "newExpenseAmountInput";
            newExpenseAmountInput.Size = new Size(257, 23);
            newExpenseAmountInput.TabIndex = 5;
            // 
            // newExpenseDescInput
            // 
            newExpenseDescInput.Location = new Point(89, 50);
            newExpenseDescInput.Name = "newExpenseDescInput";
            newExpenseDescInput.Size = new Size(257, 23);
            newExpenseDescInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // expenseTypeBindingSource
            // 
            expenseTypeBindingSource.DataSource = typeof(Core.Models.ExpenseType);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(newExpenseTypeClearBtn);
            groupBox2.Controls.Add(newExpenseTypeAddBtn);
            groupBox2.Controls.Add(newExpenseTypeNameInput);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(352, 110);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "New Expense Type";
            // 
            // newExpenseTypeClearBtn
            // 
            newExpenseTypeClearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newExpenseTypeClearBtn.Location = new Point(154, 79);
            newExpenseTypeClearBtn.Name = "newExpenseTypeClearBtn";
            newExpenseTypeClearBtn.Size = new Size(93, 23);
            newExpenseTypeClearBtn.TabIndex = 10;
            newExpenseTypeClearBtn.Text = "Clear";
            newExpenseTypeClearBtn.UseVisualStyleBackColor = true;
            newExpenseTypeClearBtn.Click += newExpenseTypeClearBtn_Click;
            // 
            // newExpenseTypeAddBtn
            // 
            newExpenseTypeAddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newExpenseTypeAddBtn.Location = new Point(253, 79);
            newExpenseTypeAddBtn.Name = "newExpenseTypeAddBtn";
            newExpenseTypeAddBtn.Size = new Size(93, 23);
            newExpenseTypeAddBtn.TabIndex = 9;
            newExpenseTypeAddBtn.Text = "Add";
            newExpenseTypeAddBtn.UseVisualStyleBackColor = true;
            newExpenseTypeAddBtn.Click += newExpenseTypeAddBtn_Click;
            // 
            // newExpenseTypeNameInput
            // 
            newExpenseTypeNameInput.Location = new Point(89, 22);
            newExpenseTypeNameInput.Name = "newExpenseTypeNameInput";
            newExpenseTypeNameInput.Size = new Size(257, 23);
            newExpenseTypeNameInput.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 2;
            label5.Text = "Name";
            // 
            // expensesDataGrid
            // 
            expensesDataGrid.AllowUserToAddRows = false;
            expensesDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            expensesDataGrid.AutoGenerateColumns = false;
            expensesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            expensesDataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            expensesDataGrid.DataSource = expensesBindingSource;
            expensesDataGrid.Location = new Point(6, 6);
            expensesDataGrid.Name = "expensesDataGrid";
            expensesDataGrid.RowTemplate.Height = 25;
            expensesDataGrid.Size = new Size(440, 386);
            expensesDataGrid.TabIndex = 0;
            expensesDataGrid.CellEndEdit += dataGrid_CellEndEdit;
            expensesDataGrid.UserDeletedRow += dataGrid_UserDeletedRow;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ExpenseType";
            dataGridViewTextBoxColumn1.HeaderText = "ExpenseType";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            dataGridViewTextBoxColumn2.HeaderText = "Description";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            dataGridViewTextBoxColumn3.HeaderText = "Amount";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "ExpendedOn";
            dataGridViewTextBoxColumn4.HeaderText = "ExpendedOn";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // expensesBindingSource
            // 
            expensesBindingSource.DataMember = "Expenses";
            expensesBindingSource.DataSource = expenseManagerDataBindingSource;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(generalMonthlyLimitInput);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(generalDayOfMonthInput);
            groupBox4.Controls.Add(generalResetBtn);
            groupBox4.Controls.Add(generalUpdateBtn);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(12, 286);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(352, 129);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "General";
            // 
            // generalMonthlyLimitInput
            // 
            generalMonthlyLimitInput.Location = new Point(109, 51);
            generalMonthlyLimitInput.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            generalMonthlyLimitInput.Name = "generalMonthlyLimitInput";
            generalMonthlyLimitInput.Size = new Size(237, 23);
            generalMonthlyLimitInput.TabIndex = 13;
            generalMonthlyLimitInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 53);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 12;
            label6.Text = "Monthly Limit";
            // 
            // generalDayOfMonthInput
            // 
            generalDayOfMonthInput.Location = new Point(109, 22);
            generalDayOfMonthInput.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            generalDayOfMonthInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            generalDayOfMonthInput.Name = "generalDayOfMonthInput";
            generalDayOfMonthInput.Size = new Size(237, 23);
            generalDayOfMonthInput.TabIndex = 11;
            generalDayOfMonthInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // generalResetBtn
            // 
            generalResetBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            generalResetBtn.Location = new Point(154, 100);
            generalResetBtn.Name = "generalResetBtn";
            generalResetBtn.Size = new Size(93, 23);
            generalResetBtn.TabIndex = 10;
            generalResetBtn.Text = "Reset";
            generalResetBtn.UseVisualStyleBackColor = true;
            generalResetBtn.Click += generalResetBtn_Click;
            // 
            // generalUpdateBtn
            // 
            generalUpdateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            generalUpdateBtn.Location = new Point(253, 100);
            generalUpdateBtn.Name = "generalUpdateBtn";
            generalUpdateBtn.Size = new Size(93, 23);
            generalUpdateBtn.TabIndex = 9;
            generalUpdateBtn.Text = "Update";
            generalUpdateBtn.UseVisualStyleBackColor = true;
            generalUpdateBtn.Click += generalUpdateBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 24);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 2;
            label4.Text = "Day Of Month";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { budgetLabel, remainingDaysLabel, limitlabel });
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            statusStrip1.Location = new Point(0, 441);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(842, 20);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // budgetLabel
            // 
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(13, 15);
            budgetLabel.Text = "1";
            // 
            // remainingDaysLabel
            // 
            remainingDaysLabel.Name = "remainingDaysLabel";
            remainingDaysLabel.Size = new Size(13, 15);
            remainingDaysLabel.Text = "1";
            // 
            // limitlabel
            // 
            limitlabel.Name = "limitlabel";
            limitlabel.Size = new Size(0, 0);
            // 
            // exportAsCSVBtn
            // 
            exportAsCSVBtn.Location = new Point(12, 416);
            exportAsCSVBtn.Name = "exportAsCSVBtn";
            exportAsCSVBtn.Size = new Size(352, 23);
            exportAsCSVBtn.TabIndex = 14;
            exportAsCSVBtn.Text = "Export As CSV";
            exportAsCSVBtn.UseVisualStyleBackColor = true;
            exportAsCSVBtn.Click += exportAsCSVBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(370, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(460, 426);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(expensesDataGrid);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(452, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Expenses";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(expenseTypesDataGrid);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(452, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Types";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // expenseTypesDataGrid
            // 
            expenseTypesDataGrid.AllowUserToAddRows = false;
            expenseTypesDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            expenseTypesDataGrid.AutoGenerateColumns = false;
            expenseTypesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            expenseTypesDataGrid.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn });
            expenseTypesDataGrid.DataSource = expenseTypesBindingSource;
            expenseTypesDataGrid.Location = new Point(6, 6);
            expenseTypesDataGrid.Name = "expenseTypesDataGrid";
            expenseTypesDataGrid.RowTemplate.Height = 25;
            expenseTypesDataGrid.Size = new Size(440, 386);
            expenseTypesDataGrid.TabIndex = 0;
            expenseTypesDataGrid.CellEndEdit += dataGrid_CellEndEdit;
            expenseTypesDataGrid.UserDeletedRow += dataGrid_UserDeletedRow;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 461);
            Controls.Add(tabControl1);
            Controls.Add(exportAsCSVBtn);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expenseTypesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseManagerDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)newExpenseAmountInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseTypeBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expensesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)expensesBindingSource).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)generalMonthlyLimitInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)generalDayOfMonthInput).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)expenseTypesDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox newExpenseDescInput;
        private Label label2;
        private NumericUpDown newExpenseAmountInput;
        private ComboBox newExpenseTypeInput;
        private BindingSource expenseTypeBindingSource;
        private Button newExpenseClearBtn;
        private Button newExpenseAddBtn;
        private Label label3;
        private GroupBox groupBox2;
        private Button newExpenseTypeClearBtn;
        private Button newExpenseTypeAddBtn;
        private TextBox newExpenseTypeNameInput;
        private Label label5;
        private DataGridView expensesDataGrid;
        private DataGridViewTextBoxColumn expenseTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expendedOnDataGridViewTextBoxColumn;
        private BindingSource expensesBindingSource;
        private BindingSource expenseManagerDataBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BindingSource expenseTypesBindingSource;
        private GroupBox groupBox4;
        private Button generalResetBtn;
        private Button generalUpdateBtn;
        private Label label4;
        private NumericUpDown generalDayOfMonthInput;
        private NumericUpDown generalMonthlyLimitInput;
        private Label label6;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel budgetLabel;
        private ToolStripStatusLabel remainingDaysLabel;
        private ToolStripStatusLabel limitlabel;
        private Button exportAsCSVBtn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView expenseTypesDataGrid;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}