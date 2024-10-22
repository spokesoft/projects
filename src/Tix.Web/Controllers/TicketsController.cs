using Microsoft.AspNetCore.Mvc;
using Tix.Data.Models;
using Projects.Web.Models;

namespace Tix.Web.Controllers;

/// <summary>
/// Projects Controller
/// </summary>
public class TicketsController : AppController
{
    /// <summary>
    /// Tickets index page
    /// </summary>
    [HttpGet("/tickets")]
    public IActionResult Index() 
    {
        return View();
    }

    /// <summary>
    /// Tickets index page
    /// </summary>
    [HttpGet("/tickets/create")]
    public IActionResult Create() 
    {
        return View();
    }

    public class TicketForm
    {
        public string? Title { get; set; }
    }

    /// <summary>
    /// Tickets index page
    /// </summary>
    [HttpPost("/tickets")]
    public IActionResult Create(TicketForm form, string? returnUrl = null)
    {
        return View();
    }

    /// <summary>
    /// Tickets index page
    /// </summary>
    [HttpGet("/tickets/{id}")]
    public IActionResult Read(long id) 
    {
        return View();
    }
}