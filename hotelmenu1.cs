//hotel menu
using System;

class Program
{
    static void Main()
    {
        int choice, quantity;
        int price = 0;
        int finalBill = 0;
        string ch = "yes";

        // Item-wise quantity
        int pizzaQty = 0;
        int pastaQty = 0;
        int burgerQty = 0;
        int momozQty = 0;

        do
        {
            Console.WriteLine("\n---- Hotel Menu ----");
            Console.WriteLine("1. Pizza     - Rs.100");
            Console.WriteLine("2. pasta     - Rs.130");
            Console.WriteLine("3. Burger    - Rs.150");
            Console.WriteLine("4. momoz  - Rs.60");
            Console.Write("Select item: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    price = 100;
                    Console.Write("Enter quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    pizzaQty += quantity;
                    finalBill += price * quantity;
                    break;

                case 2:
                    price = 130;
                    Console.Write("Enter quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    pastaQty += quantity;
                    finalBill += price * quantity;
                    break;

                case 3:
                    price = 150;
                    Console.Write("Enter quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    burgerQty += quantity;
                    finalBill += price * quantity;
                    break;

                case 4:
                    price = 60;
                    Console.Write("Enter quantity: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    momozQty += quantity;
                    finalBill += price * quantity;
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    continue;
            }

            Console.Write("Do you want to continue (yes/no): ");
            ch = Console.ReadLine().ToLower();

        } while (ch == "yes");

        Console.WriteLine("\n------ Item Details ------");

        if (pizzaQty > 0)
            Console.WriteLine("Pizza: " + pizzaQty + " = Rs." + (pizzaQty * 100));

        if (pastaQty > 0)
            Console.WriteLine("pasta: " + pastaQty + " = Rs." + (pastaQty * 130));

        if (burgerQty > 0)
            Console.WriteLine("Burger: " + burgerQty + " = Rs." + (burgerQty * 150));

        if (momozQty > 0)
            Console.WriteLine(" momoz: " +  momozQty + " = Rs." + ( momozQty * 60));

        Console.WriteLine("=============================");
        Console.WriteLine("Final Bill = Rs." + finalBill);
		Console.WriteLine("=============================");
        Console.WriteLine("Thank you!");
    }
}