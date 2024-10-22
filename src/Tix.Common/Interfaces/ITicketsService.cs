using Tix.Common.Models;
using Tix.Data.Interfaces;
using Tix.Data.Models;

namespace Tix.Common.Interfaces;

public interface ITicketsService
{
    int GetDefaultLimit(); // Get the default limit for tickets
    int GetTicketCount(); // Get the total count of tickets

    // -------------
    // Create new tickets
    // -------------
    
    /// <summary>
    /// Create a new ticket from the provided form.
    /// </summary>
    /// <param name="form"></param>
    /// <returns>The created ticket</returns>
    Ticket Create(ITicket form);
    
    /// <summary>
    /// Create a new ticket from the provided form asynchronously.
    /// </summary>
    /// <param name="form"></param>
    /// <returns>The created ticket</returns>
    Task<Ticket> CreateAsync(ITicket form);
    
    /// <summary>
    /// Create a range of tickets from the provided forms.
    /// </summary>
    /// <param name="forms"></param>
    /// <returns>The created tickets</returns>
    IEnumerable<Ticket> CreateRange(IEnumerable<ITicket> forms);
    
    /// <summary>
    /// Create a range of tickets from the provided forms.
    /// </summary>
    /// <param name="forms"></param>
    /// <returns>The created tickets</returns>
    Task<IEnumerable<Ticket>> CreateRangeAsync(IEnumerable<ITicket> forms);

    // -------------
    // Read tickets
    // -------------

    /// <summary>
    /// Search for tickets based on the provided query.
    /// </summary>
    /// <param name="query"></param>
    /// <returns>Paged result of tickets</returns>
    PagedResult<Ticket> Search(TixQuery<Ticket> query);

    /// <summary>
    /// Search for tickets based on the provided query asynchronously.
    /// </summary>
    /// <param name="query"></param>
    /// <returns>Paged result of tickets</returns>
    Task<PagedResult<Ticket>> SearchAsync(TixQuery<Ticket> query);
    
    /// <summary>
    /// Get a single ticket by id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Matching ticket</returns>
    Ticket Get(long id);
    
    /// <summary>
    /// Get a single ticket by query.
    /// </summary>
    /// <param name="query"></param>
    /// <returns>Matching ticket</returns>
    Ticket Get(TixQuery<Ticket> query);
    
    /// <summary>
    /// Get a single ticket by id asynchronously.
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Matching ticket</returns>
    Task<Ticket> GetAsync(long id);
    
    /// <summary>
    /// Get a single ticket by query asynchronously.
    /// </summary>
    /// <param name="query"></param>
    /// <returns>Matching ticket</returns>
    Task<Ticket> GetAsync(TixQuery<Ticket> query);

    /// <summary>
    /// Get all accessable tickets.
    /// </summary>
    /// <returns>Collection of tickets</returns>
    IEnumerable<Ticket> GetAll();

    /// <summary>
    /// Get all accessable tickets asynchronously.
    /// </summary>
    /// <returns>Collection of tickets</returns>
    Task<IEnumerable<Ticket>> GetAllAsync();
    
    /// <summary>
    /// Get a range of tickets by ids.
    /// </summary>
    /// <param name="ids"></param>
    /// <returns></returns>
    IEnumerable<Ticket> GetRange(IEnumerable<long> ids);

    /// <summary>
    /// Get a range of tickets by ids asynchronously.
    /// </summary>
    /// <param name="ids"></param>
    /// <returns></returns>
    Task<IEnumerable<Ticket>> GetRangeAsync(IEnumerable<long> ids);
    
    // -------------
    // Update existing tickets
    // -------------
    
    /// <summary>
    /// Update an existing ticket from the provided form.
    /// </summary>
    /// <param name="form"></param>
    /// <returns></returns>
    Ticket Update(ITicket form);
    
    /// <summary>
    /// Update an existing ticket from the provided form asynchronously.
    /// </summary>
    /// <param name="form"></param>
    /// <returns></returns>
    Task<Ticket> UpdateAsync(ITicket form);
    
    
    /// <summary>
    /// Update a range of tickets from the provided forms.
    /// </summary>
    /// <param name="forms"></param>
    /// <returns></returns>
    IEnumerable<Ticket> UpdateRange(IEnumerable<ITicket> forms);
    
    /// <summary>
    /// Update a range of tickets from the provided forms asynchronously.
    /// </summary>
    /// <param name="forms"></param>
    /// <returns></returns>
    Task<IEnumerable<Ticket>> UpdateRangeAsync(IEnumerable<ITicket> forms);
    
    // TODO: Move to abstraction layer
    Ticket Update(long id, ITicket form); // Update an existing ticket by id
    Ticket Update(TixQuery<Ticket> query, ITicket form); // Update an existing ticket by query
    Task<Ticket> UpdateAsync(long id, ITicket form); // Update an existing ticket by id
    Task<Ticket> UpdateAsync(TixQuery<Ticket> query, ITicket form); // Update an existing ticket by query
    
    // -------------
    // Delete existing tickets
    // -------------

    /// <summary>
    /// Delete an existing ticket by id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Ticket Delete(long id);

    /// <summary>
    /// Delete an existing ticket by id asynchronously.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Ticket> DeleteAsync(long id);

    /// <summary>
    /// Delete an existing ticket from the provided model.
    /// </summary>
    /// <param name="form"></param>
    /// <returns></returns>
    Ticket Delete(ITicket model); // Delete a ticket
    
    /// <summary>
    /// Delete an existing ticket from the provided model asynchronously.
    /// </summary>
    /// <param name="form"></param>
    /// <returns></returns>
    Task<Ticket> DeleteAsync(ITicket model);
    
    /// <summary>
    /// Delete an existing ticket from the provided query.
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    Ticket Delete(TixQuery<Ticket> query);
    
    /// <summary>
    /// Delete an existing ticket from the provided query asynchronously.
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    Task<Ticket> DeleteAsync(TixQuery<Ticket> query);

    /// <summary>
    /// Delete a range of tickets resulting from the provided query.
    /// </summary>
    /// <param name="ids"></param>
    /// <returns></returns>
    IEnumerable<Ticket> DeleteRange(TixQuery<Ticket> query);

    /// <summary>
    /// Delete a range of tickets resulting from the provided query asynchronously.
    /// </summary>
    /// <param name="forms"></param>
    /// <returns></returns>
    Task<IEnumerable<Ticket>> DeleteRangeAsync(TixQuery<Ticket> query);

    /// <summary>
    /// Delete a range of tickets by ids.
    /// </summary>
    /// <param name="ids"></param>
    /// <returns></returns>
    IEnumerable<Ticket> DeleteRange(IEnumerable<long> ids);

    /// <summary>
    /// Delete a range of tickets by ids asynchronously.
    /// </summary>
    /// <param name="forms"></param>
    /// <returns></returns>
    Task<IEnumerable<Ticket>> DeleteRangeAsync(IEnumerable<ITicket> forms);
}
