using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalExpenseTracker
{
    public class PredictorModel
    {
        int userId = FormLogin.globalLoggedInUserID;


        public List<decimal> PredictStatus(DateTime dateSelected, DateTime previousSixtyDays)
        {
            decimal totalFutureIncomes = 0;
            decimal totalFutureExpenses = 0;
            decimal totalPreviousIncomes = 0;
            decimal totalPreviousExpenses = 0;
            decimal moneyInAccountLastSixtyDays = 0;
            decimal moneyInAccountUntilSpecifiedDate = 0;
            decimal totalMoneyInAccountOnSelectedDate = 0;

            List<decimal> tempList = new List<decimal>();

            using (var context = new ExpenseGuideDBContainer())
            {
                //Collecting the data for Calculation 1
                var x = context.Transactions.Where(t => t.TransactionDate.Value > DateTime.Today && t.TransactionDate.Value <= dateSelected).ToList();
                
                foreach (var item in x)
                {
                    if(item.TransactionType == "Expense")
                    {
                        totalFutureExpenses += decimal.Parse(item.TransactionAmount);
                    } else
                    {
                        totalFutureIncomes += decimal.Parse(item.TransactionAmount);
                    }
                    
                }

                moneyInAccountUntilSpecifiedDate = this.CalculateMoneyInAccountUntilSpecifiedDate(totalFutureIncomes, totalFutureExpenses);



                //Collecting the data for Calculation 2
                var y = context.Transactions.Where(t => t.TransactionDate.Value <= DateTime.Today && t.TransactionDate.Value >= previousSixtyDays).ToList();
                
                foreach (var item in y)
                {
                    if (item.TransactionType == "Expense")
                    {
                        totalPreviousExpenses += decimal.Parse(item.TransactionAmount);
                    }
                    else
                    {
                        totalPreviousIncomes += decimal.Parse(item.TransactionAmount);
                    }

                }

                moneyInAccountLastSixtyDays = this.CalculateMoneyInAccountLastSixtyDays(totalPreviousIncomes, totalPreviousExpenses);


                totalMoneyInAccountOnSelectedDate = this.CalculateTotalMoneyInAccountOnSelectedDate(moneyInAccountLastSixtyDays, moneyInAccountUntilSpecifiedDate);

                tempList.Add(totalFutureIncomes);
                tempList.Add(totalFutureExpenses);
                tempList.Add(totalPreviousIncomes);
                tempList.Add(totalPreviousExpenses);
                tempList.Add(totalMoneyInAccountOnSelectedDate);

                return tempList;
            }
        }


        private decimal CalculateMoneyInAccountUntilSpecifiedDate(decimal TotalFutureIncomes, decimal TotalFutureExpenses)
        {
            decimal moneyInAccountUntilSpecifiedDate = 0;
            moneyInAccountUntilSpecifiedDate = TotalFutureIncomes - TotalFutureExpenses;
            return moneyInAccountUntilSpecifiedDate;
        }


        private decimal CalculateMoneyInAccountLastSixtyDays(decimal TotalPreviousIncomes, decimal TotalPreviousExpenses)
        {
            decimal moneyInAccountLastSixtyDays = 0;
            moneyInAccountLastSixtyDays = TotalPreviousIncomes - TotalPreviousExpenses;
            return moneyInAccountLastSixtyDays;
        }


        private decimal CalculateTotalMoneyInAccountOnSelectedDate(decimal MoneyInAccountLastSixtyDays, decimal MoneyInAccountUntilSpecifiedDate)
        {
            decimal totalMoneyInAccountOnSelectedDate = 0;
            totalMoneyInAccountOnSelectedDate = MoneyInAccountLastSixtyDays + MoneyInAccountUntilSpecifiedDate;
            return totalMoneyInAccountOnSelectedDate;
        }
    }
}
