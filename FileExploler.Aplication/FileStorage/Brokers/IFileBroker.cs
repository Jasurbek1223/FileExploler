using FileExploler.Aplication.FileStorage.Models.Storage;

namespace FileExploler.Aplication.FileStorage.Brokers;

public interface IFileBroker
{
    StorageFile GetByPath(string filePath);
}