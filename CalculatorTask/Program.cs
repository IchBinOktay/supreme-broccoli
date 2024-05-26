public class Calculator
{
    private decimal num1;
    private decimal num2;

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Enter first number");
            Console.WriteLine("2. Enter second number");
            Console.WriteLine("3. Add");
            Console.WriteLine("4. Subtract");
            Console.WriteLine("5. Multiply");
            Console.WriteLine("6. Divide");
            Console.WriteLine("7. Exit");

            int choice = GetIntInput("Enter your choice: ");

            switch (choice)
            {
                case 1:
                    num1 = GetNumericInput<decimal>("Enter first number: ");
                    break;
                case 2:
                    num2 = GetNumericInput<decimal>("Enter second number: ");
                    break;
                case 3:
                    if (IsReadyForOperation())
                    {
                        decimal result = PerformOperation(choice);
                        Console.WriteLine($"Result: {result}");
                    }
                    break;
                case 4:
                    if (IsReadyForOperation())
                    {
                        decimal result = PerformOperation(choice);
                        Console.WriteLine($"Result: {result}");
                    }
                    break;
                case 5:
                    if (IsReadyForOperation())
                    {
                        decimal result = PerformOperation(choice);
                        Console.WriteLine($"Result: {result}");
                    }
                    break;
                case 6:
                    if (IsReadyForOperation())
                    {
                        decimal result = PerformOperation(choice);
                        Console.WriteLine($"Result: {result}");
                    }
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    private bool IsReadyForOperation()
    {
        if (num1 == 0m && num2 == 0m)
        {
            Console.WriteLine("Please enter both numbers before performing operations.");
            return false;
        }
        return true;
    }

    private decimal PerformOperation(int choice)
    {
        switch (choice)
        {
            case 3:
                return Add(num1, num2);
            case 4:
                return Subtract(num1, num2);
            case 5:
                return Multiply(num1, num2);
            case 6:
                return Divide(num1, num2);
            default:
                throw new ArgumentOutOfRangeException(nameof(choice));
        }
    }

    private decimal GetNumericInput<T>(string prompt)
    {
        while (true)
        {
            try
            {
                Console.Write(prompt);
                return (decimal)Convert.ChangeType(Console.ReadLine(), typeof(decimal));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }

    private int GetIntInput(string prompt)
    {
        while (true)
        {
            try
            {
                Console.Write(prompt);
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter an integer value.");
            }
        }
    }
    private decimal Add(decimal a, decimal b)
    {
        return a + b;
    }

    private decimal Subtract(decimal a, decimal b)
    {
        return a - b;
    }

    private decimal Multiply(decimal a, decimal b)
    {
        return a * b;
    }

    private decimal Divide(decimal a, decimal b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return 0;
        }
        return a / b;
    }
}