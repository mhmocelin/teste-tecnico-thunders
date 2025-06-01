using Thunders.TechTest.AppHost.Domain.Entities;

namespace Thunders.TechTest.AppHost.Application.Interfaces;

public interface IRecordRepository
{
    Task<Record?> GetByIdAsync(Guid id);
    Task<List<Record>> GetByTollAsync(Guid tollId);
    Task<List<Record>> GetAllAsync();
    Task AddAsync(Record record);
}
