using FileRenamer.Application.Commands;
using FileRenamer.Application.Interfaces;
using FileRenamer.Domain.Interfaces;

namespace FileRenamer.Application.Handlers
{
    public class PreviewRenameHandler : IPreviewRenameHandler
    {
        public void Handle(PreviewRenameCommand command, IPreviewService previewService)
        {
            previewService.Preview(command.FolderPath, command.Pattern);
        }
    }
}
