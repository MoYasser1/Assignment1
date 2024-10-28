class SimpleCalculator
{
    static void Main()
    {
        //Assignment 1


        string name = "Mohamed Yasser Calculator";

        Console.WriteLine("**************************************");
        Console.WriteLine("*                                    *");
        Console.WriteLine("*       " + name + "                 *");
        Console.WriteLine("*                                    *");
        Console.WriteLine("**************************************");


        int num1, num2, choice;
        bool exitProgram = false;
        Console.Write("Mohamed Yasser ");


        Console.Write("Enter the first Integer: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second Integer: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        while (!exitProgram)
        {
            Console.WriteLine("\nHere are the options:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit");
            Console.Write("Input your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"The Addition of {num1} and {num2} is: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"The Subtraction of {num1} and {num2} is: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"The Multiplication of {num1} and {num2} is: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine($"The Division of {num1} and {num2} is: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                case 5:
                    exitProgram = true;
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice ==> Please try again.");
                    break;
            }
        }
    }
}
