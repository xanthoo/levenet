using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    public class Deposits
    {
        private int accountNr;
        private decimal moneyAmount;
        private string bankAccount;
        public string date;


        public Deposits(int accountNr, decimal moneyAmount, string bankNr)
        {
            this.accountNr = accountNr;
            this.moneyAmount = moneyAmount;
            this.bankAccount = bankNr;

            date = DateTime.Now.ToString("MM/dd/yyyy H:mm");
        }


        public int AccountNr
        {
            
            get { return accountNr; }
        }
        
        public string GetInfo()
        {
            return accountNr.ToString() + "  " + moneyAmount.ToString();
        }
  
        public string GetBankAccount()
        {
            return bankAccount; 
        }

        public decimal GetMoney()
        {
            return moneyAmount;
        }
        public string GetDate()
        {
            return date;
        }
   
    }
}
