using Microsoft.EntityFrameworkCore;
using Thunders.TechTest.AppHost.Application.Interfaces;
using Thunders.TechTest.AppHost.Domain.Entities;
using Thunders.TechTest.Infrastructure.Persistence.Context;

namespace Thunders.TechTest.Infrastructure.Persistence.Repositories;

public class TollRepository : ITollRepository
{
    private readonly AppDbContext _context;

    public TollRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Toll?> GetByIdAsync(Guid id)
    {
        return await _context.Tolls.FindAsync(id);
    }

    public async Task<Toll?> GetByNameAsync(string name)
    {
        return await _context.Tolls
            .FirstOrDefaultAsync(t => t.Name == name);
    }

    public async Task<List<Toll>> GetAllAsync()
    {
        return await _context.Tolls.ToListAsync();
    }

    public async Task AddAsync(Toll toll)
    {
        _context.Tolls.Add(toll);
        await _context.SaveChangesAsync();
    }
}
