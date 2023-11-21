namespace Lab3;

abstract class Lab3
{
    public static void Main()
    {
        StreamReader reader = new StreamReader("./Inlet.txt");

        List<string?> strings = new List<string?>();
        while (reader.EndOfStream)
        {
            strings.Add(reader.ReadLine());
        }
        
        reader.Close();
        
        List<string> words = new List<string>();
        int max = -1;
        
        foreach (var s in strings)
        {
            if (s != null)
            {
                string[] w = s.Split(' ');
                words.AddRange(w);
            }
        }

        for (int i = 0; i < words.Count; i++)
        {
            if (words[i].Length > max)
                max = i + 1;
        }

        Console.WriteLine(max);
    }
}

