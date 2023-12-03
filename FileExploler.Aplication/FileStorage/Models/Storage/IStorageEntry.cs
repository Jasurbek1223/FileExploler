namespace FileExploler.Aplication.FileStorage.Models.Storage;

public interface IStorageEntry
{
    string Path { get; set; }

    StorageEntryType EntryType { get; set; }
}