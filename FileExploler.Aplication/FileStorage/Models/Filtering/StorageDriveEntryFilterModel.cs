using FileExploler.Aplication.Common.Models.Filtering;

namespace FileExploler.Aplication.FileStorage.Models.Filtering;

public class StorageDriveEntryFilterModel : FilterPagination
{
    public bool IncludeDirectories { get; set; }

    public bool IncludeFiles { get; set; }
}