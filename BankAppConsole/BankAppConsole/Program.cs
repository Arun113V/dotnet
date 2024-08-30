namespace BankAppConsole
{
    class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Welcome to Self Bank");
            System.Console.WriteLine("=======Login Page=======");

            string username = null; string password = null;

            System.Console.WriteLine("Etner the username");
            username = Console.ReadLine();
            System.Console.WriteLine("Enter the password");
            password = Console.ReadLine();

            if (username == "system" || password == "manager")
            {
                int mainchoicemenu = -1;

                do
                {
                    System.Console.WriteLine("::::Main Menu::::");
                    System.Console.WriteLine("1.Customers");
                    System.Console.WriteLine("2.Accounts");
                    System.Console.WriteLine("3.Fund Transfer");
                    System.Console.WriteLine("4.Fund Transfer Statement");
                    System.Console.WriteLine("5.Account Statement");
                    System.Console.WriteLine("0.Exit");

                    System.Console.WriteLine("Enter Choice");
                    mainchoicemenu = int.Parse(Console.ReadLine());

                    switch (mainchoicemenu)
                    {
                        case 1: CustomersMenu();
                            break;
                        case 2: //To Do Accounts
                            break;
                        case 3: // To Do Fund Transfer
                            break;
                        case 4: // To Do Fund Transfer Statement
                            break;
                        case 5: // To Do Account Statement
                            break;

                    }

                } while (mainchoicemenu != 0);
            }
            else
            {
                System.Console.WriteLine("Invalid Login");
            }
        }
        public static void CustomersMenu()
        {
            int customermainmenu = -1;
            do
            {
                System.Console.WriteLine(":::Customer Menu:::");
                System.Console.WriteLine("1.Add Account");
                System.Console.WriteLine("2.Edit Account");
                System.Console.WriteLine("3.Delete Account");
                System.Console.WriteLine("4.View Customer");
                System.Console.WriteLine("0.Exit to main menu");

                System.Console.WriteLine("Enter Choice");
                customermainmenu = int.Parse(System.Console.ReadLine());

            } while (customermainmenu != 0);


        }
    }
}