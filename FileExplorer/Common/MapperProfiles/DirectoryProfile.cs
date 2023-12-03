using AutoMapper;
using FileExploler.Aplication.FileStorage.Models.Storage;
using FileExplorer.Api.Models.Dtos;

namespace FileExplorer.Api.Common.MapperProfiles;

public class DirectoryProfile : Profile
{
    public DirectoryProfile()
    {
        CreateMap<StorageDirectory, StorageDirectoryDto>();
        CreateMap<StorageDirectoryDto, StorageDirectory>();
    }
}