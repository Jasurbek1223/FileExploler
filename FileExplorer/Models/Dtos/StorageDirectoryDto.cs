using FileExploler.Aplication.FileStorage.Models.Storage;

namespace FileExplorer.Api.Models.Dtos;

public class StorageDirectoryDto
{
    public string Name { get; set; } = string.Empty;

    public string Path { get; set; } = string.Empty;

    public long ItemsCount { get; set; }

    public StorageEntryType EntryType { get; set; }
}