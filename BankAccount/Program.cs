namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput input = new UserInput();
            UserInterface userInterface = new UserInterface();
            userInterface.AddMenuCategory(1, "Create Account");
            userInterface.AddMenuCategory(2, "Make a deposit");
            userInterface.AddMenuCategory(3, "Make a withdrawal");
            userInterface.AddMenuCategory(4, "View transaction History");
            userInterface.AddMenuCategory(5, "Account Balance");
            
            string userInput = "Y";

            while (userInput == "Y" || userInput == "y")
            {
                
                userInterface.DisplayMenu();
                Console.WriteLine("Please enter a selection from the menu above: ");
                int selection = Convert.ToInt32(Console.ReadLine());
                input.UserSelections(selection);
                Console.WriteLine("Would you like to do something else? Type Y/y: ");
                userInput = Console.ReadLine();
                Console.Clear();
            }
            
            
            

             

            

            //var account = new BankAccount("Kendra", 10000);
            //Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}");
            //account.MakeWithdrawel(500, DateTime.Now, "Rent payment");
            //account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            //account.GetAccountHistory();
        }
    }
}
