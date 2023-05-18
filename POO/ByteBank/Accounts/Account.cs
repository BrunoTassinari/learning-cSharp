

using ByteBank.Users;

namespace ByteBank.Accounts
{
    public class Account
    {
        public static int TotalAccountsCreated { get; private set; }
        private int Agency { get; set; }
        private string NumberAccount { get; set; }

        private double _balance = 0.0;
        public double Balance
        {
            get => this._balance;
            set
            {
                if (value >= 0)
                {
                    this._balance = value;
                }
                else
                {
                    throw new Exception("Invalid value for balance");
                }
                
            }
            
        }
        private Client Holder { get; set; }
        
        public Account(int agency, string numberAccount, Client holder, double balance = 0.0)
        {
            this.Agency = agency;
            this.NumberAccount = numberAccount;
            this.Holder = holder;
            this.Balance = balance;
            TotalAccountsCreated++;
            
        }
        
        public void Transfer(double value, Account destiny)
        {
            this.Balance -= value;
            destiny.Balance += value;
        }

        public void ShowDataAccount()
        {
            this.Holder.showClientInfo();
            Console.WriteLine($"Account number: {this.NumberAccount}");
            Console.WriteLine($"Agency: {this.Agency}");
            Console.WriteLine($"Balance $ {this.Balance:0.00}");
        }

        
    }
}