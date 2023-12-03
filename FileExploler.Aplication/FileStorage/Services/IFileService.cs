using FileExploler.Aplication.Common.Models.Filtering;
using FileExploler.Aplication.FileStorage.Models.Filtering;
using FileExploler.Aplication.FileStorage.Models.Storage;

namespace FileExploler.Aplication.FileStorage.Services;

public interface IFileService
{
    ValueTask<IList<StorageFile>> GetFilesByPathAsync(IEnumerable<string> filesPath);

    ValueTask<StorageFile> GetFileByPathAsync(string filePath);

    IEnumerable<StorageFilesSummary> GetFilesSummary(IEnumerable<StorageFile> files);

    StorageFileType GetFileType(string filePath);
}