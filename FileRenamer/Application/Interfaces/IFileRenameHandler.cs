using FileRenamer.Application.Commands;
using FileRenamer.Domain.Interfaces;

namespace FileRenamer.Application.Interfaces
{
    public interface IFileRenameHandler
    {
        public void Handle(FileRenameCommand command, IRenameService renameService);
    }
}
