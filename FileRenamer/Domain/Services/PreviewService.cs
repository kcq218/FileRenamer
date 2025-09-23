using FileRenamer.Domain.Interfaces;

namespace FileRenamer.Domain.Services
{
    public class PreviewService: IPreviewService
    {
        IFileSystem _fileSystem { get; set; }
        public PreviewService(IFileSystem fileSystem) 
        {
            _fileSystem = fileSystem;
        }
     
        public void Preview(string folderPath, string pattern)
        {

        }
    }
}
