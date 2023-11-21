using System.Collections;

namespace Lab5;

abstract class Lab5
{
    static void Main()
    {
        List<Participant> participants = new List<Participant>
        {
            new Participant { Country = "Russia", TeamName = "Reds", FullName = "John Doe", PlayerNumber = 1, 
                Age = 16, Height = 180, Weight = 75 },
            
            new Participant { Country = "USA", TeamName = "Niggers", FullName = "Barrack Obama", 
                PlayerNumber = 2, Age = 32, Height = 175, Weight = 70 },
        };
        
        Participant youngest = participants.OrderBy(p => p.Age).First();
        Participant tallest = participants.OrderBy(p => p.Height).Last();
        Participant lightest = participants.OrderBy(p => p.Weight).First();
        
        Console.WriteLine("Age min:");
        PrintParticipantInfo(youngest);

        Console.WriteLine("\nHeight max:");
        PrintParticipantInfo(tallest);

        Console.WriteLine("\nWeight min:");
        PrintParticipantInfo(lightest);
    }
    
    static void PrintParticipantInfo(Participant participant)
    {
        Console.WriteLine($"{participant.Country} - {participant.TeamName} - {participant.FullName} " +
                          $"- {participant.Age} years old - {participant.Height} cm tall");
    }
}

public class Participant
{
    public string Country { get; set; }
    public string TeamName { get; set; }
    public string FullName { get; set; }
    public int PlayerNumber { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
}

public class ParticipantsCollection : IEnumerable<Participant>
{
    private List<Participant> participants;

    public ParticipantsCollection(List<Participant> participants)
    {
        this.participants = participants;
    }

    public IEnumerator<Participant> GetEnumerator()
    {
        return participants.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}