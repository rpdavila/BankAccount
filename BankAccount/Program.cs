using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}");
            account.MakeWithdrawel(500, DateTime.Now, "Rent payment");
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            account.GetAccountHistory();
        }
    }
}
