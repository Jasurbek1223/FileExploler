using FileExploler.Aplication.FileStorage.Models.Filtering;
using FileExploler.Aplication.FileStorage.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace FileExplorer.Api.Controller;

[ApiController]
[Route("api/[controller]")]
public class FilesController : ControllerBase
{
    private readonly IWebHostEnvironment _hostEnvironment;
    private readonly IFileProcessingService _fileProcessingService;

    public FilesController(IWebHostEnvironment hostEnvironment, IFileProcessingService fileProcessingService)
    {
        _hostEnvironment = hostEnvironment;
        _fileProcessingService = fileProcessingService;
    }

    [HttpGet("root/files/filter")]
    public async ValueTask<IActionResult> GetFilesSummary()
    {
        var result = await _fileProcessingService.GetFilterDataModelAsync(_hostEnvironment.WebRootPath);
        return Ok(result);
    }

    [HttpGet("root/files/by-filter")]
    public async ValueTask<IActionResult> GetFilesByFilter([FromQuery] StorageFileFilterModel filterModel)
    {
        filterModel.DirectoryPath = _hostEnvironment.WebRootPath;
        var files = await _fileProcessingService.GetByFilterAsync(filterModel);
        return files.Any() ? Ok(files) : NotFound(files);
    }
}