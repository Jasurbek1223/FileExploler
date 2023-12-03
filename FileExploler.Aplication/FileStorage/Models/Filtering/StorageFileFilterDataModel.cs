using FileExploler.Aplication.Common.Models.Filtering;

namespace FileExploler.Aplication.FileStorage.Models.Filtering;

public class StorageFileFilterDataModel
{
    public List<StorageFilesSummary> FilterData { get; set; } = new();
}