using FileExploler.Aplication.FileStorage.Models.Filtering;
using FileExploler.Aplication.FileStorage.Models.Storage;

namespace FileExploler.Aplication.FileStorage.Services;

public interface IFileProcessingService
{
    ValueTask<StorageFileFilterDataModel> GetFilterDataModelAsync(string directoryPath);

    ValueTask<IList<StorageFile>> GetByFilterAsync(StorageFileFilterModel filterModel);
}