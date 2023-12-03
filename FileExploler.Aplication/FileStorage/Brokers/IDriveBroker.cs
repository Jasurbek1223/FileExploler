using FileExploler.Aplication.FileStorage.Models.Storage;

namespace FileExploler.Aplication.FileStorage.Brokers;

public interface IDriveBroker
{
    IEnumerable<StorageDrive> Get();
}