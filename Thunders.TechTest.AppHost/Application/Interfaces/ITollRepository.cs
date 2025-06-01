using Thunders.TechTest.AppHost.Domain.Entities;

namespace Thunders.TechTest.AppHost.Application.Interfaces;

public interface ITollRepository
{
    Task<Toll?> GetByIdAsync(Guid id);
    Task<Toll?> GetByNameAsync(string name);
    Task<List<Toll>> GetAllAsync();
    Task AddAsync(Toll toll);
}
