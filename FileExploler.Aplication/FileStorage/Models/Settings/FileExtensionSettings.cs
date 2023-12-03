using FileExploler.Aplication.FileStorage.Models.Filtering;

namespace FileExploler.Aplication.FileStorage.Models.Settings;

public class FileExtensionSettings
{
    public StorageFileType FileType { get; set; }

    public string DisplayName { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public ICollection<string> Extensions { get; set; } = default!;
}