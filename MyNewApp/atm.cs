using System;

class Program122
{
    static void Main(string[] args)
    {
        const string correctPin = "1234"; // Example PIN
        double balance = 1000.00; // Initial balance
        string pin;

        Console.Write("Enter your PIN: ");
        pin = Console.ReadLine();

        if (pin != correctPin)
        {
            Console.WriteLine("Incorrect PIN. Access denied.");
            return;
        }

        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display Balance");
            Console.WriteLine("2. Cash Deposit");
            Console.WriteLine("3. Cash Withdrawal");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your current balance is: ${balance}");
                    break;

                case 2:
                    Console.Write("Enter the amount to deposit: ");
                    double deposit = double.Parse(Console.ReadLine());
                    if (deposit > 0)
                    {
                        balance += deposit;
                        Console.WriteLine($"Successfully deposited ${deposit}. New balance is: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Deposit must be greater than 0.");
                    }
                    break;

                case 3:
                    Console.Write("Enter the amount to withdraw: ");
                    double withdrawal = double.Parse(Console.ReadLine());
                    if (withdrawal > 0 && withdrawal <= balance)
                    {
                        balance -= withdrawal;
                        Console.WriteLine($"Successfully withdrew ${withdrawal}. New balance is: ${balance}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Withdrawal must be greater than 0 and less than or equal to the current balance.");
                    }
                    break;

                case 4:
                    quit = true;
                    Console.WriteLine("Thank you for using our service. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
