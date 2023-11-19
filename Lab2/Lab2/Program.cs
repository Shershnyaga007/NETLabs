namespace Lab2;

abstract class Program
{
    public static void Main()
    {
        //Task 1
        Console.WriteLine("Task 1");

        List<double> list = new List<double>();

        Random random = new Random();
        for (int i=0; i < 10; i++) 
            list.Add(random.NextDouble());
        foreach (var d in list)
            Console.Write(d + " ");
        
        //Task 2
        Console.WriteLine("Task 2");
        
        List<int> A = new List<int>();
        List<int> B = new List<int>();
        List<int> C = new List<int>();
        
        for (int i = 0; i < 10; i++)
        {
            A.Add(random.Next(100));
            B.Add(random.Next(100));
        }
        
        for (int i = 0; i < 10; i++)
            C.Add(A[i] - B[i]);
        
        foreach (int num in C)
            Console.WriteLine(num);
        
        // Task 3
        Console.WriteLine("Task 3");
        
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        
        List<double> array = new List<double>();
        for (int i = 0; i < N; i++)
        {
            array.Add(random.NextDouble() * 100);
        }
        
        double min = array[0];
        foreach (double num in array)
        {
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine("min: " + min);
        
        double max = array[0];
        int maxIndex = 0;
        for (int i = 1; i < array.Count; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        
        double sum = 0;
        for (int i = maxIndex + 1; i < array.Count; i++)
        {
            sum += array[i];
        }
        Console.WriteLine("Sum: " + sum);
        
        List<double> transformed = new List<double>();
        foreach (double num in array)
        {
            if (num == 0)
                transformed.Insert(0, num);
            else
                transformed.Add(num);
        }
        
        Console.Write("Transformed array: ");
        foreach (var d in transformed)
        {
            Console.Write(d + " ");
        }
    }
}
