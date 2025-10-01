namespace FileRenamer.Domain.Interfaces
{
    public interface IRenameService
    {
        public void Rename(string folderPath, string pattern);
    }
}
