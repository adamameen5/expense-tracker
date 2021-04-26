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
    public partial class FormPredictor : Form
    {
        public FormPredictor()
        {
            InitializeComponent();
            lblCurrentTime.Text = DateTime.Now.ToString("f");
            lblUserName.Text = FormLogin.globalLoggedInUserName;
            panelStatus.Visible = false;
            groupBoxFutureIncomeExpense.Visible = false;
            groupBoxLastTwoMonths.Visible = false;
        }

        private void ValidateDate(object sender, EventArgs e)
        {
            
            if ( datePickerSelectedDate.Value < (DateTime.Today.AddDays(+1)))
            {
                MessageBox.Show("Select a date greater than todays date");
            }

            this.PerformCalculation(datePickerSelectedDate.Value);
        }


        public void PerformCalculation(DateTime selectedDate)
        {
            List<decimal> finalValues = new List<decimal>();
            String financialStatus = "";
            DateTime previousSixtyDays = DateTime.Today.AddDays(-60);

            PredictorModel helper = new PredictorModel();
            finalValues = helper.PredictStatus(selectedDate, previousSixtyDays);
            panelStatus.Visible = true;

            if (finalValues[4] < 0)
            {
                financialStatus = "Loss";
                lblStatus.Text = financialStatus;
                lblStatus.ForeColor = Color.OrangeRed;
            } else
            {
                financialStatus = "Gain";
                lblStatus.Text = financialStatus;
                lblStatus.ForeColor = Color.Green;
            }

            groupBoxFutureIncomeExpense.Visible = true;
            groupBoxLastTwoMonths.Visible = true;

            lblFutureIncome.Text = "Rs. "+finalValues[0].ToString();
            lblFutureExpenses.Text = "Rs. " + finalValues[1].ToString();
            lblIncomeLastTwoMonths.Text = "Rs. " + finalValues[2].ToString();
            lblExpenseLastTwoMonths.Text = "Rs. " + finalValues[3].ToString();
        }
    }
}
