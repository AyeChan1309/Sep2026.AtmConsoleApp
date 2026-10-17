using Sep2026.AtmConsoleApp;

Console.WriteLine("____________Welcome to the ATM Console Application!____________");

Start:

Console.WriteLine("1. Create Account");
Console.WriteLine("2. Login");
Console.WriteLine("3. Exit");
Console.Write("Please select an option: ");
string option = Console.ReadLine();
AtmService atmService = new AtmService();
switch (option)
{
	case "1":
        // Create Account logic
        Console.Write("Please enter your account number: ");
        string AccountNumber = Console.ReadLine();

        Console.Write("Please enter your account holder name: ");
        string AccountHolderName = Console.ReadLine();

        Console.Write("Please enter your PIN: ");
        string Pin = Console.ReadLine();

        Console.Write("Please enter your initial balance: ");
        decimal InitialBalance = decimal.Parse(Console.ReadLine());

        
        atmService.CreateAccount(AccountNumber, AccountHolderName, InitialBalance, Pin);

        atmService.ShowAllAccounts();
        break;
	case "2":
        // Login logic
        Console.Write("Please enter your account number: ");
                string AcctNo = Console.ReadLine();

        Console.Write("Please enter your PIN: ");
        string PinNo = Console.ReadLine();

        atmService.Login(AcctNo, PinNo);
        break;
	case "3":
		// Exit logic
        goto End;
        break;
	default:
		Console.WriteLine("Invalid option. Please try again.");
		break;
}

goto Start;
Console.ReadLine();
End:
Console.WriteLine("Thank you for using the ATM Console Application!");

