using AutoMapper;
using FileExploler.Aplication.FileStorage.Models.Storage;
using FileExplorer.Api.Models.Dtos;

namespace FileExplorer.Api.Common.MapperProfiles;

public class StorageItemProfile : Profile
{
    public StorageItemProfile()
    {
        CreateMap<IStorageEntry, IStorageItemDto>();
        CreateMap<IStorageItemDto, IStorageEntry>();
    }
}