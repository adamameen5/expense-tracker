using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker
{
    public partial class FormWeeklyView : Form
    {
        private ExpenseModel helper = new ExpenseModel();
        public DateTime selectedDate = new DateTime();
        private GroupBox[] _groupBoxes;

        public FormWeeklyView()
        {
            InitializeComponent();
            
        }

        private void DatePicked(object sender, DateRangeEventArgs e)
        {
            dateToShowCalendar.MaxSelectionCount = 1;
            selectedDate = dateToShowCalendar.SelectionRange.Start;
            foreach (var grp in Controls.OfType<GroupBox>().ToList())
            {
                Controls.Remove(grp);
            }
            LoadWeeklyViewData();
        }


        public void LoadWeeklyViewData()
        {
            int xStartPoint = 16;
            int yStartPoint = 230;
            _groupBoxes = new GroupBox[7];

            for (int i = 0; i < 7; i++)
            {
                xStartPoint += 5;
                GroupBox groupBox = new GroupBox();
                groupBox.Size = new Size(150, 375);
                groupBox.Location = new Point(xStartPoint, yStartPoint);
                this.Controls.Add(groupBox);
                xStartPoint += groupBox.Width;
                _groupBoxes[i] = groupBox;
            }

            switch (selectedDate.DayOfWeek.ToString())
            {
                case "Monday":
                    fillFutureView(0);
                    break;
                case "Tuesday":
                    selectedDate = selectedDate.AddDays(-1);
                    fillPastView(1);
                    fillFutureView(1);                    
                    break;
                case "Wednesday":
                    selectedDate = selectedDate.AddDays(-2);
                    fillPastView(2);
                    fillFutureView(2);
                    break;
                case "Thursday":
                    selectedDate = selectedDate.AddDays(-3);
                    fillPastView(3);
                    fillFutureView(3);
                    break;
                case "Friday":
                    selectedDate = selectedDate.AddDays(-4);
                    fillPastView(4);
                    fillFutureView(4);
                    break;
                case "Saturday":
                    selectedDate = selectedDate.AddDays(-5);
                    fillPastView(5);
                    fillFutureView(5);
                    break;
                case "Sunday":
                    selectedDate = selectedDate.AddDays(-6);
                    fillPastView(6);
                    fillFutureView(6);
                    break;
            }


        }


        public List<UserTransactionDataForWeeklyView> GetExpensesOn(DateTime date)
        {
            return helper.GetListOfTransactions(date);
        }

        public void fillFutureView(int c)
        {
            for (int i = c; i <= 6; i++)
            {
                _groupBoxes[i].Text = selectedDate.ToString("d");

                Console.WriteLine(selectedDate.DayOfWeek);
                WeeklyViewItem item = new WeeklyViewItem(GetExpensesOn(selectedDate));
                item.RefreshControls();
                item.Location = new Point(0, 19);

                selectedDate = selectedDate.AddDays(+1);
                _groupBoxes[i].Controls.Add(item);
            }
            
        }

        public void fillPastView(int c)
        {
            for (int i = 0; i < c; i++)
            {
                _groupBoxes[i].Text = selectedDate.ToString("d");

                Console.WriteLine(selectedDate.DayOfWeek);
                WeeklyViewItem item = new WeeklyViewItem(GetExpensesOn(selectedDate));
                item.RefreshControls();
                item.Location = new Point(0, 19);

                selectedDate = selectedDate.AddDays(+1);
                _groupBoxes[i].Controls.Add(item);
            }

        }
    }
}
