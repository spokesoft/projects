using Microsoft.AspNetCore.Mvc;
using Projects.Data.Models;
using Projects.Web.Models;

namespace Tix.Web.Controllers;

/// <summary>
/// Projects Controller
/// </summary>
public class ProjectsController : AppController
{
    /// <summary>
    /// Projects index page
    /// </summary>
    [HttpGet("/projects")]
    public IActionResult Index()
    {
        var testproj1 = new Project() {
            Id = 1,
            Name = "Project 1",
            Description = "Project 1 Description"
        };
        var testproj2 = new Project() {
            Id = 2,
            Name = "Project 2",
            Description = "Project 2 Description"
        };
        var testproj3 = new Project() {
            Id = 3,
            Name = "Project 3",
            Description = "Project 3 Description"
        };
        var vm = new ProjectsIndexViewModel();
        vm.Projects = vm.Projects.Append(testproj1);
        vm.Projects = vm.Projects.Append(testproj2);
        vm.Projects = vm.Projects.Append(testproj3);
        return View(vm);
    }

    /// <summary>
    /// Projects read page
    /// </summary>
    /// <param name="id"></param>
    [HttpGet("/projects/{id}")]
    public IActionResult Read(long id)
    {
        var vm = new ProjectsReadViewModel
        {
            Project = new Project()
            {
                Id = id,
                Name = $"Project {id}",
                Description = $"Project {id} Description"
            }
        };
        return View(vm);
    }
}