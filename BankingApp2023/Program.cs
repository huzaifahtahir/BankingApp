using BankingApp2023;

Dictionary<int, Accounts> dictAcc = new Dictionary<int, Accounts>();

string firstName = "";
string lastName = "";
double balance = 0;
int accNum = Accounts.ACCOUNT_NUM;
string choice;

Console.WriteLine("Welcome to the Huzaifah Bank.");
Console.WriteLine();
do
{
    Console.WriteLine();
    DisplayChoices();
    Console.Write("Select a choice below: ");
    choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter your starting balance: ");
            balance = Convert.ToDouble(Console.ReadLine());
            Accounts acc = new Accounts(firstName, lastName, balance);
            dictAcc.Add(accNum++, acc);
            break;

        case "3":
            int tempAccNum = 0;
            double tempBalance = 0;
            Console.WriteLine("Enter Account Number: ");
            tempAccNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount: ");
            tempBalance = Convert.ToDouble(Console.ReadLine());
            dictAcc[tempAccNum].Deposit(tempBalance);
            break;


        case "5":
            tempAccNum = 0;
            Console.WriteLine("Enter Account Number: ");
            tempAccNum = Convert.ToInt32(Console.ReadLine());
            dictAcc.Remove(tempAccNum);
            break;
            
        case "6":
            foreach(KeyValuePair<int, Accounts> entry in dictAcc)
            {
                Console.WriteLine();
                Console.WriteLine(entry.Value.ToString());
            }    
            break;
        case "7":
            Console.WriteLine("The account numbers are: {0}", Accounts.ACCOUNT_NUM);
            break;
    }
    



} while (choice != "9");


void DisplayChoices()
{
    Console.WriteLine("1 - Open an Account");
    Console.WriteLine("2 - Balance Inquiry");
    Console.WriteLine("3 - Deposit");
    Console.WriteLine("4 - Withdrawal");
    Console.WriteLine("5 - Close an account");
    Console.WriteLine("6 - Show all accounts");
    Console.WriteLine("9 - Quit");
}
