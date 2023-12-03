namespace FileExploler.Aplication.FileStorage.Models.Settings;

public class FileFilterSettings
{
    public ICollection<FileExtensionSettings> FileExtensions { get; set; } = default!;
}