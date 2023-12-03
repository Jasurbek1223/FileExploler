using AutoMapper;
using FileExploler.Aplication.FileStorage.Brokers;
using FileExploler.Aplication.FileStorage.Models.Storage;

namespace FileExploler.Infrastructure.FileStorage.Brokers;

public class FileBroker : IFileBroker
{
    private readonly IMapper _mapper;

    public FileBroker(IMapper mapper)
    {
        _mapper = mapper;
    }

    public StorageFile GetByPath(string filePath)
    {
        return _mapper.Map<StorageFile>(new FileInfo(filePath));
    }
}