using FileRenamer.Application.Commands;

namespace FileRenamer.Application.Interfaces
{
    public interface IPreviewRenameHandler
    {
        public void Handle(PreviewRenameCommand command);
    }
}
