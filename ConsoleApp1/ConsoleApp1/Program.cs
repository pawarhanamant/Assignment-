using System;

class CoffeeShop
{
    static void Main()
    {
        char repeat = 'y';
        double totalAmount = 0;

        while (repeat == 'y')
        {
            Console.WriteLine("\nPlease choose coffee size:");
            Console.WriteLine("1 - Small ($1.50)");
            Console.WriteLine("2 - Medium ($2.50)");
            Console.WriteLine("3 - Large ($3.50)");

            int choice = Convert.ToInt32(Console.ReadLine());
            double pricePerCup = 0;
            string sizeName = "";

            switch (choice)
            {
                case 1:
                    pricePerCup = 1.50;
                    sizeName = "Small";
                    break;
                case 2:
                    pricePerCup = 2.50;
                    sizeName = "Medium";
                    break;
                case 3:
                    pricePerCup = 3.50;
                    sizeName = "Large";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
            }

            Console.Write($"How many cups of {sizeName} coffee do you want? ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double currentBill = pricePerCup * quantity;
            totalAmount += currentBill;

            Console.WriteLine($"Added {quantity} {sizeName} coffee(s): ${currentBill:F2}");
            Console.Write("Do you want to order again? (y/n): ");
            repeat = Convert.ToChar(Console.ReadLine().ToLower());
        }

        Console.WriteLine("\n=====================================");
        Console.WriteLine("Total bill amount: $" + totalAmount.ToString("F2"));
        Console.WriteLine("Thank you for visiting the coffee shop!");
    }
}
