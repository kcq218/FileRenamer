namespace FileRenamer.Domain.Interfaces
{
    public interface IFileSystem
    {
        List<FileInfo> GetFiles(string folderPath);
        void Rename(FileInfo file, string newName);
    }
}
