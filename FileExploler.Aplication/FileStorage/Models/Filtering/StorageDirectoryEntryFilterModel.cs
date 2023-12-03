using FileExploler.Aplication.Common.Models.Filtering;

namespace FileExploler.Aplication.FileStorage.Models.Filtering;

public class StorageDirectoryEntryFilterModel : FilterPagination
{
    public bool IncludeDirectories { get; set; }

    public bool IncludeFiles { get; set; }
}