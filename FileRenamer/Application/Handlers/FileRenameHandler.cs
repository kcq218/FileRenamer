using FileRenamer.Application.Commands;
using FileRenamer.Application.Interfaces;
using FileRenamer.Domain.Interfaces;

namespace FileRenamer.Application.Handlers
{
    public class FileRenameHandler : IFileRenameHandler
    {
        public void Handle(FileRenameCommand command, IRenameService renameService)
        {
            renameService.Rename(command.FolderPath, command.Pattern);
        }
    }
}
