namespace Exersise2
{
    internal class Account
    {
        int balance { get; set; }
        public Account(int balance)
        {
            this.balance = balance;
        }

        public void AddBalance(int amount)
        {
            balance += amount;
        }

        public bool MinusBalance(int amount)
        {
            if (amount >= balance)
            {
                return false;
            }
            else if (balance < 100)
            {
                return false;
            }
            else 
            {
                balance -= amount;
                return true;
            }               
        }

        public int ShowBalance()
        {
            return balance;
        }
    }
}
