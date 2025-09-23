using FileRenamer.Application.Commands;
using FileRenamer.Domain.Interfaces;

namespace FileRenamer.Application.Interfaces
{
    public interface IPreviewRenameHandler
    {
        public void Handle(PreviewRenameCommand command, IPreviewService previewService);
    }
}
