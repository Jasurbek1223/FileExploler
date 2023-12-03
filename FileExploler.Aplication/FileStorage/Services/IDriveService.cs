using FileExploler.Aplication.FileStorage.Models.Storage;

namespace FileExploler.Aplication.FileStorage.Services;

public interface IDriveService
{
    ValueTask<IList<StorageDrive>> GetAsync();
}