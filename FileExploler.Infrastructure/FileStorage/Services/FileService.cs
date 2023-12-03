using FileExploler.Aplication.Common.Models.Filtering;
using FileExploler.Aplication.FileStorage.Brokers;
using FileExploler.Aplication.FileStorage.Models.Filtering;
using FileExploler.Aplication.FileStorage.Models.Settings;
using FileExploler.Aplication.FileStorage.Models.Storage;
using FileExploler.Aplication.FileStorage.Services;
using Microsoft.Extensions.Options;

namespace FileExploler.Infrastructure.FileStorage.Services;

public class FileService : IFileService
{
    private readonly FileFilterSettings _fileFilterSettings;
    private readonly FileStorageSettings _fileStorageSettings;
    private readonly IFileBroker _fileBroker;

    public FileService(IOptions<FileStorageSettings> fileStorageSettings, IOptions<FileFilterSettings> fileFilterSettings, IFileBroker fileBroker)
    {
        _fileStorageSettings = fileStorageSettings.Value;
        _fileFilterSettings = fileFilterSettings.Value;
        _fileBroker = fileBroker;
    }

    public async ValueTask<IList<StorageFile>> GetFilesByPathAsync(IEnumerable<string> filesPath)
    {
        var files = await Task.Run(() => { return filesPath.Select(filePath => _fileBroker.GetByPath(filePath)).ToList(); });

        return files;
    }

    public ValueTask<StorageFile> GetFileByPathAsync(string filePath) =>
        !string.IsNullOrWhiteSpace(filePath)
            ? new ValueTask<StorageFile>(_fileBroker.GetByPath(filePath))
            : throw new ArgumentNullException(nameof(filePath));

    public IEnumerable<StorageFilesSummary> GetFilesSummary(IEnumerable<StorageFile> files)
    {
        var filesType = files.Select(file => (File: file, Type: GetFileType(file.Path)));
        return filesType
            .GroupBy(file => file.Type)
            .Select(filesGroup => new StorageFilesSummary
            {
                FileType = filesGroup.Key,
                DisplayName = _fileFilterSettings.FileExtensions.FirstOrDefault(extension => extension.FileType == filesGroup.Key)?.DisplayName ??
                              "Other files",
                Count = filesGroup.Count(),
                Size = filesGroup.Sum(file => file.File.Size),
                ImageUrl = _fileFilterSettings.FileExtensions.FirstOrDefault(extension => extension.FileType == filesGroup.Key)?.ImageUrl ??
                           _fileStorageSettings.FileImageUrl
            });
    }

    public StorageFileType GetFileType(string filePath)
    {
        var fileExtension = Path.GetExtension(filePath).TrimStart('.');
        var matchedFileType = _fileFilterSettings.FileExtensions.FirstOrDefault(extension => extension.Extensions.Contains(fileExtension));
        return matchedFileType?.FileType ?? StorageFileType.Other;
    }
}