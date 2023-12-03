using AutoMapper;
using FileExploler.Aplication.FileStorage.Brokers;
using FileExploler.Aplication.FileStorage.Models.Storage;

namespace FileExploler.Infrastructure.FileStorage.Brokers;

public class DriveBroker : IDriveBroker
{
    private readonly IMapper _mapper;

    public DriveBroker(IMapper mapper)
    {
        _mapper = mapper;
    }

    public IEnumerable<StorageDrive> Get()
    {
        return DriveInfo
            .GetDrives()
            .Select(drive => _mapper.Map<StorageDrive>(drive))
            .AsQueryable();
    }
}