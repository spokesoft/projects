using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tix.Data.Contexts;
using Tix.Data.Models;

namespace Tix.Data.Repositories;

/// <summary>
/// Base repository for Tix entities.
/// </summary>
/// <typeparam name="T"></typeparam>
/// <param name="context"></param>
/// <param name="logger"></param>

public abstract class BaseRepository<T>(
    TixContext context,
    ILogger<BaseRepository<T>> logger)
    : IRepository<T> 
    where T : TixEntity
{
    private readonly TixContext _context = context;
    private readonly DbSet<T> _set = context.Set<T>();
    private readonly ILogger<BaseRepository<T>> _logger = logger;
    
    /// <inheritdoc/>
    public T Add(T entity)
    {
        _set.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    /// <inheritdoc/>
    public async Task<T> AddAsync(T entity)
    {
        await _set.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    /// <inheritdoc/>
    public IEnumerable<T> AddRange(IEnumerable<T> entities)
    {
        _set.AddRange(entities);
        _context.SaveChanges();
        return entities;
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
    {
        await _set.AddRangeAsync(entities);
        await _context.SaveChangesAsync();
        return entities;
    }

    /// <inheritdoc/>
    public T Delete(T entity)
    {
        _set.Remove(entity);
        _context.SaveChanges();
        return entity;
    }

    /// <inheritdoc/>
    public async Task<T> DeleteAsync(T entity)
    {
        _set.Remove(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    /// <inheritdoc/>
    public IEnumerable<T> DeleteRange(IEnumerable<T> entities)
    {
        _set.RemoveRange(entities);
        _context.SaveChanges();
        return entities;
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> entities)
    {
        _set.RemoveRange(entities);
        await _context.SaveChangesAsync();
        return entities;
    }

    /// <inheritdoc/>
    public T Update(T entity)
    {
        _set.Update(entity);
        _context.SaveChanges();
        return entity;
    }

    /// <inheritdoc/>
    public async Task<T> UpdateAsync(T entity)
    {
        _set.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    /// <inheritdoc/>
    public IEnumerable<T> UpdateRange(IEnumerable<T> entities)
    {
        _set.UpdateRange(entities);
        _context.SaveChanges();
        return entities;
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities)
    {
        _set.UpdateRange(entities);
        await _context.SaveChangesAsync();
        return entities;
    }
}