using AutoMapper;
using FileExploler.Aplication.FileStorage.Models.Filtering;
using FileExploler.Aplication.FileStorage.Services;
using Microsoft.AspNetCore.Mvc;

namespace FileExplorer.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DirectoriesController : ControllerBase
{
    private readonly IDirectoryProcessingService _directoryProcessingService;
    private readonly IMapper _mapper;

    public DirectoriesController(IDirectoryService directoryService, IDirectoryProcessingService directoryProcessingService, IMapper mapper)
    {
        _directoryProcessingService = directoryProcessingService;
        _mapper = mapper;
    }

    [HttpGet("root/entries")]
    public async ValueTask<IActionResult> GetRootEntriesAsync(
        [FromQuery] StorageDirectoryEntryFilterModel filterModel,
        [FromServices] IWebHostEnvironment environment
    )
    {
        var data = await _directoryProcessingService.GetEntriesAsync(environment.WebRootPath, filterModel);
        return data.Any() ? Ok(data) : NoContent();
    }

    [HttpGet("{directoryPath}/entries")]
    public async ValueTask<IActionResult> GetDirectoryEntriesByPathAsync(
        [FromRoute] string directoryPath,
        [FromQuery] StorageDirectoryEntryFilterModel filterModel
    )
    {
        var data = await _directoryProcessingService.GetEntriesAsync(directoryPath, filterModel);
        return data.Any() ? Ok(data) : NoContent();
    }
}