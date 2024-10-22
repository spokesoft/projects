using Tix.Common.Interfaces;
using Tix.Common.Models;
using Tix.Data.Interfaces;
using Tix.Data.Models;

namespace Projects.Common.Services;

public class TicketsService : ITicketsService
{
    public Ticket Create(ITicket ticket)
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> CreateAsync(ITicket ticket)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Ticket> CreateRange(IEnumerable<ITicket> tickets)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ticket>> CreateRangeAsync(IEnumerable<ITicket> tickets)
    {
        throw new NotImplementedException();
    }

    public Ticket Delete(ITicket ticket)
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> DeleteAsync(ITicket ticket)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Ticket> DeleteRange(IEnumerable<ITicket> tickets)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ticket>> DeleteRangeAsync(IEnumerable<ITicket> tickets)
    {
        throw new NotImplementedException();
    }

    public Ticket Get(long id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Ticket> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ticket>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> GetAsync(long id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Ticket> Search(TicketQuery query)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ticket>> SearchAsync(TicketQuery query)
    {
        throw new NotImplementedException();
    }

    public Ticket Update(ITicket ticket)
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> UpdateAsync(ITicket ticket)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Ticket> UpdateRange(IEnumerable<ITicket> tickets)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Ticket>> UpdateRangeAsync(IEnumerable<ITicket> tickets)
    {
        throw new NotImplementedException();
    }
}