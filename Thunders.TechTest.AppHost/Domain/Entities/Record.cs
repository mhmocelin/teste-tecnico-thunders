using Thunders.TechTest.AppHost.Domain.Enums;

namespace Thunders.TechTest.AppHost.Domain.Entities;

public class Record
{
    public Guid Id { get; private set; }
    public DateTime Date { get; private set; }
    public Guid TollId { get; private set; }
    public Toll Toll { get; private set; } // EF Core navigation
    public decimal Value { get; private set; }
    public VehicleType VehicleType { get; private set; }

    public Record(DateTime date, Toll toll, decimal value, VehicleType vehicleType)
    {
        Id = Guid.NewGuid();
        Date = date;
        Toll = toll;
        TollId = toll.Id;
        Value = value;
        VehicleType = vehicleType;
    }
}
