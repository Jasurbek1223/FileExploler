using FileExploler.Aplication.FileStorage.Models.Filtering;
using FileExploler.Aplication.FileStorage.Models.Storage;

namespace FileExploler.Aplication.FileStorage.Services;

public interface IDirectoryProcessingService
{
    ValueTask<List<IStorageEntry>> GetEntriesAsync(string directoryPath, StorageDirectoryEntryFilterModel filterModel);
}