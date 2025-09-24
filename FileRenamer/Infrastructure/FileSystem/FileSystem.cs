using FileRenamer.Domain.Interfaces;

namespace FileRenamer.Domain.Infrastructure
{
    public class LocalFileSystem : IFileSystem
    {
        public List<FileInfo> GetFiles(string folderPath)
        {
            var filePaths = Directory.GetFiles(folderPath);
            return filePaths.Select(path => new FileInfo(path)).ToList();
        }

        public void Rename(FileInfo file, string newName)
        {
            var originalPath = Path.Combine(file.DirectoryName, file.Name);
            var newPath = Path.Combine(file.DirectoryName, newName);
            File.Move(originalPath, newPath);
        }
    }
}
