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
//services.AddSingleton<IRenameService, RenameService>();

var provider = services.BuildServiceProvider();

// Resolve your top-level handler
var handler = provider.GetRequiredService<IPreviewRenameHandler>();
var previewService = provider.GetRequiredService<IPreviewService>();
var command = new PreviewRenameCommand();

try
{
    Console.WriteLine("Hello, User Please input the directory where the file should be renamed");
    var directory = Console.ReadLine();
    command.FolderPath = directory;

    Console.WriteLine("what name would you like to rename it to");
    var pattern = Console.ReadLine();
    command.Pattern = pattern;

    handler.Handle(command, previewService);

    Console.WriteLine("Would you like to go ahead and rename files?");
    var executeRenameYesorNo = Console.ReadLine();

}
catch (Exception e)
{
    Console.WriteLine(e);
}

