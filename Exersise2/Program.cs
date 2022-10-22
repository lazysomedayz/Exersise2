namespace Exersise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(500);
            ATM atm = new ATM(account);

            atm.Start();
        }
    }
}