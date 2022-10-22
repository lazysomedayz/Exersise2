namespace Exersise2
{
    internal class ATM
    {
        Account account;

        public ATM(Account account)
        {
            this.account = account;
        }

        void deposit()
        {
            Console.Write("\nEnter money to deposit: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            account.AddBalance(amount);
            checkBalance();
        }
        void withdraw()
        {
            checkBalance();
            Console.Write("\nEnter money to withdraw: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (account.MinusBalance(amount))
            {
                checkBalance();
            }
            else
            {
                Console.WriteLine("Cannot withdraw because money that you enter is more than your balance or your balance less than 100!!");
            }
            
        }
        void checkBalance()
        {
            Console.WriteLine("\nAccount Balance is: {0}", account.ShowBalance());  
        }

        void menu()
        {
        input:
            Console.Clear();
            Console.WriteLine("Account");
            Console.WriteLine("============================");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("0. Exit\n");
            Console.Write("Select number: ");
  
            int selected;
            string input = Console.ReadLine();
            try
            {
                selected = Convert.ToInt32(input);
            }
            catch (Exception)
            {
                goto input;
            }

            switch (selected)
            {
                case 0:
                    System.Environment.Exit(1);
                    goto input;
                case 1:
                    deposit();
                    PressAnyKey();
                    goto input;
                case 2:
                    withdraw();
                    PressAnyKey();
                    goto input;
                case 3:
                    checkBalance();
                    PressAnyKey();
                    goto input;
                default:
                    goto input;
            }
        }

        void PressAnyKey()
        {
            Console.Write("Press Any Key...");
            Console.ReadLine();
        }

        public void Start()
        {
            menu();
        }
    }
}
