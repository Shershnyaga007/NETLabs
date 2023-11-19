namespace Lab1;

abstract class Lab1
{
    public static void Main()
    {
        // Task 1
        Console.WriteLine("Task 1");
        string? n1Str, n2Str;
        Console.WriteLine("Read first number");
        Console.Write("> ");
        n1Str = Console.ReadLine();
        
        Console.WriteLine("Read second number");
        Console.Write("> ");
        n2Str = Console.ReadLine();

        float n1 = float.Parse(n1Str);
        float n2 = float.Parse(n2Str);
        
        Console.WriteLine(n1 - n2);
        
        // Task 2
        Console.WriteLine("Task 2");
        Console.WriteLine("Read first number");
        Console.Write("> ");
        n1Str = Console.ReadLine();
        
        Console.WriteLine("Read second number");
        Console.Write("> ");
        n2Str = Console.ReadLine();

        int i1 = int.Parse(n1Str);
        int i2 = int.Parse(n2Str);

        int sum = 0;
        for (int i = i1; i <= i2; i++)
            sum += i;
        
        Console.WriteLine(sum);
        
        // Task 3
        Console.WriteLine("Task 3");
        for (int number = 10; number < 100; number++)
        {
            int d1 = number / 10;
            int d2 = number % 10;
            int sumOfSquares = (d1 * d1) + (d2 * d2);

            if (sumOfSquares % 17 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}

