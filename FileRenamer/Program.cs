// See https://aka.ms/new-console-template for more information
using FileRenamer.Application.Commands;
using FileRenamer.Application.Handlers;
using FileRenamer.Application.Interfaces;
using FileRenamer.Domain.Infrastructure;
using FileRenamer.Domain.Interfaces;
using FileRenamer.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// Register your services
services.AddSingleton<IFileSystem, LocalFileSystem>();
services.AddSingleton<IPreviewRenameHandler, PreviewRenameHandler>();
services.AddSingleton<IFileRenameHandler, FileRenameHandler>();
services.AddSingleton<IPreviewService, PreviewService>();
services.AddSingleton<IRenameService, RenameService>();

var provider = services.BuildServiceProvider();

// Resolve your top-level handler
var previewHandler = provider.GetRequiredService<IPreviewRenameHandler>();
var fileRenameHandler = provider.GetRequiredService<IFileRenameHandler>();
var previewService = provider.GetRequiredService<IPreviewService>();
var fileRenameService = provider.GetRequiredService<IRenameService>();
var previewCommand = new PreviewRenameCommand();
var fileRenameCommand = new FileRenameCommand();

try
{
    Console.WriteLine("Hello, User Please input the directory where the file should be renamed");
    var directory = Console.ReadLine();
    previewCommand.FolderPath = directory;
    fileRenameCommand.FolderPath = directory;

    Console.WriteLine("what name would you like to rename it to");
    var pattern = Console.ReadLine();
    previewCommand.Pattern = pattern;
    fileRenameCommand.Pattern = pattern;

    previewHandler.Handle(previewCommand, previewService);

    Console.WriteLine("Would you like to go ahead and rename files? Answer with YES or NO");
    var executeRenameYesorNo = Console.ReadLine();

    if (executeRenameYesorNo == "YES")
    {
        fileRenameHandler.Handle(fileRenameCommand, fileRenameService);
    }

    Console.WriteLine("Finished Program");

}
catch (Exception e)
{
    Console.WriteLine(e);
}

