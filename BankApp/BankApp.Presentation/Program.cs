class Program
{
    //application execution
    static void Main()
    {
        //display app title
        System.Console.WriteLine("***************MyBank*****************");
        System.Console.WriteLine("::Login Page::");

        //variables username and password
        string userName = null, password = null;

        //read username
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();

        if (userName != "")
        {
            //read password
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        //check username and password
        if(userName == "system" && password == "manager")
        {
            //variable for user menu choice
            //default value -1 means user has not yet made any choices
            int mainMenuChoice = -1;

            do
            {
                //display menu
                System.Console.WriteLine("\n:::Main Menu:::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Fund Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statements");
                System.Console.WriteLine("0. Exit");

                System.Console.Write("Enter choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                //switch-case to check user choice
                switch (mainMenuChoice)
                {
                    case 1:CustomerMenu();
                        break;
                    case 2:AccountsMenu();
                        break;
                    case 3://to do: displaye fund transfer menu
                        break;
                    case 4://to do: displaye fund transfer statement menu
                        break;
                    case 5://to do: displaye accounts statements menu
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Ooops! Something went wrong. Please check username and password.");
        }

        System.Console.WriteLine("Thank you. Please visit again.");
        System.Console.ReadKey();
    }

    static void CustomerMenu()
    {
        //variable that store customers menu selection
        int customerMenuChoice = -1;

        do
        {
            //dispay account menu
            System.Console.WriteLine("\n::::Customer Menu:::");
            System.Console.WriteLine("1.Add Account");
            System.Console.WriteLine("2.Delete Account");
            System.Console.WriteLine("3.Update Account");
            System.Console.WriteLine("4.View Account");
            System.Console.WriteLine("0.Back to Main Menu");

            //accept account selection
            System.Console.Write("Enter choice: ");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        //variable that store accounts menu selection
        int accountsChoice = -1;

        do
        {
            //dispay customer menu
            System.Console.WriteLine("\n::::Customer Menu:::");
            System.Console.WriteLine("1.Add Customer");
            System.Console.WriteLine("2.Delete Customer");
            System.Console.WriteLine("3.Update Customer");
            System.Console.WriteLine("4.View Customer");
            System.Console.WriteLine("0.Back to Main Menu");

            //accept customer selection
            System.Console.Write("Enter choice: ");
            accountsChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (accountsChoice != 0);
    }
}
