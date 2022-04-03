using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system
{
    class Balance
    {
        public int Amountwithdrawn { get; set; }
        public int AccountBalance { get; set; }

        public Balance()
        {
          AccountBalance = 5000;
            
        }

        public void  CalculateBalanceWithdraw(int Amountwithdrawn, int AccountBalance)
        {
            if (Amountwithdrawn < AccountBalance)
            {
                int AmountLeft = AccountBalance - Amountwithdrawn;
                Console.WriteLine("Succesful withdrawal");
                AccountBalance = AmountLeft;
                
                Console.WriteLine(AccountBalance);
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }
    }
}
