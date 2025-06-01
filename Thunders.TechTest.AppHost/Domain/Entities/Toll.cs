namespace Thunders.TechTest.AppHost.Domain.Entities;

public class Toll
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }

    // Construtor para criação
    public Toll(string name, string city, string state)
    {
        Id = Guid.NewGuid();
        Name = name;
        City = city;
        State = state;
    }    
}
