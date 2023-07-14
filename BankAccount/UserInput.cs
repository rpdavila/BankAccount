namespace BankAccount
{
    public class UserInput
    {
        private static BankAccount? Account;

        public void UserSelections(int selection)
        {
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Please enter your name: ");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Please enter the initial deposit: ");
                    decimal initialDeposit = Convert.ToDecimal(Console.ReadLine());
                    BankAccount account = new BankAccount(name, initialDeposit);
                    Account = account;
                    Console.WriteLine($"Bank Account created with account number: {Account.Number}");
                    Console.WriteLine($"Your initial balance is: {Account.Balance}");
                    break;
                case 2:
                    Console.WriteLine("How much would you like to deposit? ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Would you like to write a note about the deposit? ");
                    string? depositNote = Console.ReadLine();
                    Account?.MakeDeposit(depositAmount, DateTime.Now, depositNote);
                    break;
                case 3:
                    Console.WriteLine("How much would you like to Withdraw? ");
                    decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Would you like to write a note about the deposit? ");
                    string? withdrawelNote = Console.ReadLine();
                    Account?.MakeWithdrawel(withdrawalAmount, DateTime.Now, withdrawelNote);
                    break;
                case 4:
                    Account?.GetAccountHistory();
                    break;
                case 5:
                    Console.WriteLine($"Your account balance:");
                    Account?.GetAccountBalance();
                    break;
            }               
        }
    }
}
