using FileRenamer.Domain.Interfaces;

namespace FileRenamer.Domain.Services
{
    public class PreviewService : IPreviewService
    {

        IFileSystem _fileSystem;
        public PreviewService(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public void Preview(string folderPath, string pattern)
        {
            var fileInfoList = _fileSystem.GetFiles(folderPath);
            var results = new List<string>();

            var current = 0;

            while (current < fileInfoList.Count)
            {
                var name = pattern;

                if (current > 0)
                {
                    name += $"_{current + 1}";
                    Console.WriteLine(name);
                }

            }

            Console.ReadLine();
        }
    }
}
