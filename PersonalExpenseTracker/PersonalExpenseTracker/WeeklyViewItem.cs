using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class WeeklyViewItem : UserControl
    {
        private readonly List<UserTransactionDataForWeeklyView> _transactions;

        public WeeklyViewItem(List<UserTransactionDataForWeeklyView> transactions)
        {
            InitializeComponent();
            _transactions = transactions;
            SetUpViewData();
        }

        public void RefreshControls()
        {
            SetUpViewData();
        }


        private void SetUpViewData()
        {
            decimal expenseAmount = 0;
            decimal incomeAmount = 0;
            int ySpacer = 3;
            foreach (var item in _transactions)
            {
                WeeklyViewItemComponent dayItem = new WeeklyViewItemComponent(item);
                dayItem.Location = new Point(3, ySpacer);
                panelItems.Controls.Add(dayItem);
                ySpacer += dayItem.Height + 3;

                if (item.transactionType == "Expense")
                {
                    expenseAmount += decimal.Parse(item.transactionAmount);
                } else
                {
                    incomeAmount += decimal.Parse(item.transactionAmount);
                }
                
            }

            lblTotalExpenses.Text = "Total Expenses: Rs."+ expenseAmount.ToString();
            lblTotalIncomes.Text = "Total Incomes: Rs." + incomeAmount.ToString();
        }
    }
}
