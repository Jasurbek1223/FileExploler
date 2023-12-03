using FileExploler.Aplication.FileStorage.Models.Storage;

namespace FileExplorer.Api.Models.Dtos;

public class StorageFileDto
{
    public string Name { get; set; } = string.Empty;

    public string Path { get; set; } = string.Empty;

    public string DirectoryPath { get; set; } = string.Empty;

    public long Size { get; set; }

    public string Extension { get; set; } = string.Empty;

    public StorageEntryType EntryType { get; set; }
}