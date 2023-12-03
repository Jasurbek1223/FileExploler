using AutoMapper;
using FileExploler.Aplication.FileStorage.Models.Storage;
using FileExplorer.Api.Models.Dtos;

namespace FileExplorer.Api.Common.MapperProfiles;

public class DriveProfile : Profile
{
    public DriveProfile()
    {
        CreateMap<StorageDriveDto, StorageDrive>();
        CreateMap<StorageDrive, StorageDriveDto>();
    }
}