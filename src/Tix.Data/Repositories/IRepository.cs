using Tix.Data.Models;

namespace Tix.Data.Repositories;

/// <summary>
/// Interface for repository pattern
/// </summary>
/// <typeparam name="T"></typeparam>

public interface IRepository<T> where T : TixEntity
{
    /// <summary>
    /// Add a new entity to the repository
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    T Add(T entity);
    
    /// <summary>
    /// Add a new entity to the repository asynchronously
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<T> AddAsync(T entity);
    
    /// <summary>
    /// Add multiple entities to the repository
    /// </summary>
    /// <param name="entities"></param>
    /// <returns></returns>
    IEnumerable<T> AddRange(IEnumerable<T> entities);
    
    /// <summary>
    /// Add multiple entities to the repository asynchronously
    /// </summary>
    /// <param name="entities"></param>
    /// <returns></returns>
    Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
    
    /// <summary>
    /// Update an existing entity in the repository
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    T Update(T entity);
    
    /// <summary>
    /// Update an existing entity in the repository asynchronously
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<T> UpdateAsync(T entity);
    
    /// <summary>
    /// Update multiple entities in the repository
    /// </summary>
    /// <param name="entities"></param>
    /// <returns></returns>
    IEnumerable<T> UpdateRange(IEnumerable<T> entities);
    
    /// <summary>
    /// Update multiple entities in the repository asynchronously
    /// </summary>
    /// <param name="entities"></param>
    /// <returns></returns>
    Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities);
    
    /// <summary>
    /// Remove an existing entity from the repository
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    T Delete(T entity);
    
    /// <summary>
    /// Remove an existing entity from the repository asynchronously
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<T> DeleteAsync(T entity);
    
    /// <summary>
    /// Remove multiple entities from the repository
    /// </summary>
    /// <param name="entities"></param>
    /// <returns></returns>
    IEnumerable<T> DeleteRange(IEnumerable<T> entities);
    
    /// <summary>
    /// Delete multiple entities from the repository asynchronously
    /// </summary>
    /// <param name="entities"></param>
    /// <returns></returns>
    Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> entities);
}