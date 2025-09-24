namespace FileRenamer.Application.Commands
{
    public class FileRenameCommand
    {
        public string FolderPath { get; set; }
        public string Pattern { get; set; }
        public string Name { get; set; }
    }
}
