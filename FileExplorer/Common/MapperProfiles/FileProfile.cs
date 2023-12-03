using AutoMapper;
using FileExploler.Aplication.FileStorage.Models.Storage;
using FileExplorer.Api.Models.Dtos;

namespace FileExplorer.Api.Common.MapperProfiles;

public class FileProfile : Profile
{
    public FileProfile()
    {
        CreateMap<StorageFile, StorageFileDto>();
        CreateMap<StorageFileDto, StorageFile>();
    }
}