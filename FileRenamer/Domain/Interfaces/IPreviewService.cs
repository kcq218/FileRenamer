namespace FileRenamer.Domain.Interfaces
{
    public interface IPreviewService
    {
        public void Preview(string folderPath, string pattern);
    }
}
