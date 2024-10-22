using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tix.Common.Interfaces;
using Tix.Common.Models;
using Tix.Data.Interfaces;
using Tix.Data.Models;

namespace Tix.Rest.Controllers;

/// <summary>
/// Tickets rest controller.
/// </summary>
/// <param name="tickets"></param>
/// <param name="logger"></param>

[ApiController]
[Route("/tickets")]
[Authorize]
public class TicketsController(
    ITicketsService tickets,
    ILogger<TicketsController> logger) : RestController
{
    private readonly ITicketsService _tickets = tickets;
    private readonly ILogger<TicketsController> _logger = logger;

    [HttpPost]
    public async Task<ActionResult<Ticket>> Create(ITicket ticket)
    {
        var created = await _tickets.CreateAsync(ticket);
    }

    /// <summary>
    /// Search for tickets based on the provided query.
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ticket>>> Search(TixQuery<Ticket> query)
    {
        var tickets = await _tickets.SearchAsync(query);
        return Ok(tickets);
    }

    /// <summary>
    /// Get a ticket by its Id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>

    [HttpGet("{id}")]
    public async Task<ActionResult<Ticket>> Get(long id)
    {
        var ticket = await _tickets.GetAsync(id);
        if (ticket == null)
        {
            return NotFound(id);
        }
        return Ok(ticket);
    }
}