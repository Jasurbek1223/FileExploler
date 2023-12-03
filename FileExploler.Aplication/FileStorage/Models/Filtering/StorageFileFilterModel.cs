using FileExploler.Aplication.Common.Models.Filtering;

namespace FileExploler.Aplication.FileStorage.Models.Filtering;

public class StorageFileFilterModel : FilterPagination
{
    public string DirectoryPath { get; set; } = string.Empty;

    public ICollection<StorageFileType> FileTypes { get; set; } = default!;
}