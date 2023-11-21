namespace Lab4;

abstract class Lab4
{
    public static void Main()
    {
        List<Participant> participants = new List<Participant>
        {
            new Participant { Country = "Russia", TeamName = "Reds", FullName = "John Doe", PlayerNumber = 1, 
                Age = 16, Height = 180, Weight = 75 },
            
            new Participant { Country = "USA", TeamName = "Niggers", FullName = "Barrack Obama", 
                PlayerNumber = 2, Age = 32, Height = 175, Weight = 70 },
        };

        Console.WriteLine("Sort by max:");
        participants.Sort();
        PrintParticipants(participants);

        Console.WriteLine("\nSort by min (age and height):");
        participants.Sort(new ParticipantComparer());
        PrintParticipants(participants);
    }
    
    private static void PrintParticipants(List<Participant> participants)
    {
        foreach (var participant in participants)
        {
            Console.WriteLine($"{participant.Country} - {participant.TeamName} - {participant.FullName} - {participant.Age} years old - {participant.Height} cm tall");
        }
    }
}

public class Participant : IComparable<Participant>
{
    public string Country { get; set; }
    public string TeamName { get; set; }
    public string FullName { get; set; }
    public int PlayerNumber { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    
    public int CompareTo(Participant other)
    {
        if (Age != other.Age)
            return Age.CompareTo(other.Age);
        
        return PlayerNumber.CompareTo(other.PlayerNumber);
    }
}

public class ParticipantComparer : IComparer<Participant>
{
    public int Compare(Participant x, Participant y)
    {
        int result = y.Age.CompareTo(x.Age);
        
        if (result == 0)
            result = y.Height.CompareTo(x.Height);

        return result;
    }
}