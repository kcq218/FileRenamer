using FileRenamer.Domain.Interfaces;

namespace FileRenamer.Domain.Services
{
    public class RenameService : IRenameService
    {

        IFileSystem _fileSystem;
        public RenameService(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public void Rename(string folderPath, string pattern)
        {
            var fileInfoList = _fileSystem.GetFiles(folderPath);
            var results = new List<string>();
            var current = 0;
            Console.WriteLine("Renaming Files");

            while (current < fileInfoList.Count)
            {
                var currentFolderPath = $"{folderPath}/{fileInfoList[current].Name}";
                var name = pattern;
                var fullFolderPath = $"{folderPath}/{name}.txt";

                if (current > 0)
                {
                    name += $"_{current + 1}";
                    fullFolderPath = $"{folderPath}/{name}.txt";
                }

                if (!File.Exists(fullFolderPath))
                {
                    File.Move(currentFolderPath, fullFolderPath);

                }
                else
                {
                    Console.WriteLine($"rename failed {fullFolderPath} already exists");
                }

                Console.WriteLine($"Old Path: {currentFolderPath} new Path:{fullFolderPath}");

                ++current;
            }

            Console.WriteLine("Finish renaming files Press any button to exit");

            Console.ReadLine();
        }
    }
}
