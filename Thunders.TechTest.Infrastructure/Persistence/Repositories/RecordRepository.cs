using Microsoft.EntityFrameworkCore;
using Thunders.TechTest.AppHost.Application.Interfaces;
using Thunders.TechTest.AppHost.Domain.Entities;
using Thunders.TechTest.Infrastructure.Persistence.Context;

namespace Thunders.TechTest.Infrastructure.Persistence.Repositories;

public class RecordRepository : IRecordRepository
{
    private readonly AppDbContext _context;

    public RecordRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Record?> GetByIdAsync(Guid id)
    {
        return await _context.Records.FindAsync(id);
    }

    public async Task<List<Record>> GetByTollAsync(Guid tollId)
    {
        return await _context.Records
            .Where(r => r.TollId == tollId)
            .ToListAsync();
    }

    public async Task<List<Record>> GetAllAsync()
    {
        return await _context.Records.ToListAsync();
    }

    public async Task AddAsync(Record record)
    {
        _context.Records.Add(record);
        await _context.SaveChangesAsync();
    }
}
