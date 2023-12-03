namespace FileExploler.Aplication.FileStorage.Models.Storage;

public class StorageDirectory : IStorageEntry
{
    public string Name { get; set; } = string.Empty;

    public string Path { get; set; } = string.Empty;

    public long ItemsCount { get; set; }

    public StorageEntryType EntryType { get; set; } = StorageEntryType.Directory;
}