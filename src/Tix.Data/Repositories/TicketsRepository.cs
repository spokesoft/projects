using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tix.Data.Contexts;
using Tix.Data.Models;

namespace Tix.Data.Repositories;

public abstract class TicketsRepository(
    TixContext context, 
    ILogger<TicketsRepository> logger) 
    : BaseRepository<Ticket>(context, logger)
{
}