using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tix.Data.Contexts;
using Tix.Data.Models;

namespace Tix.Data.Repositories;

public abstract class ProjectsRepository(
    TixContext context, 
    ILogger<ProjectsRepository> logger) 
    : BaseRepository<Project>(context, logger)
{
}