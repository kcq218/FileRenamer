using FileRenamer.Application.Commands;

namespace FileRenamer.Application.Interfaces
{
    public interface IFileRenameHandler
    {
        public void Handle(FileRenameCommand command);
    }
}
