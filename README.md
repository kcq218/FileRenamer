# FileRenamer
FileRenamer project 1 of microprojects in C#

---

## Table of Contents
- [Demo](#demo)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Configuration](#configuration)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)
- [Lessons](#lessons)

---

## Demo
*Optional*: Add screenshots, GIFs, or a link to a live demo if available.

## Features
| Requirement Type     | Description                                                | Notes / Example                                      | Accomplished | 
|----------------------|------------------------------------------------------------|------------------------------------------------------|--------------|
| Functional           | User inputs a folder path                             		  | Only files in the selected folder, no subfolders     |     YES      |
| Functional           | Rename all files with a sequential number             		  | e.g., File_1.txt, File_2.txt                         |     YES      |
| Functional           | Optional prefix for filenames                         		  | User can enter a prefix like Report                  |     N/A      |
| Functional           | Preview filenames before renaming                     		  | Show old vs new filenames in console                 |     YES      |
| Functional           | Execute renaming after confirmation                   		  | Ask user Y/N before renaming                         |     YES      |
| Non-Functional       | Handle invalid folder paths                           		  | Show an error message if folder doesn’t exist        |     YES      |
| Non-Functional       | Prevent overwriting files                             		  | Skip renaming if a new name already exists           |     YES      |
| Functional           | Undo last renaming operation                          		  | Optional batch undo                                  |     N/A      |
| Functional           | Save a log file of operations                         		  | Include original & new filenames, timestamp          |     N/A      |
| Non-Functional       | Handle directories with large number of files efficiently	| Performance consideration                            |     YES      |
| Non-Functional       | Clear console instructions and prompts                   	| Usability requirement                                |     YES      |
| Non-Functional       | Handle invalid directory paths                           	| Error handling                                       |     YES      |
| Non-Functional       | Handle file access issues                          		    | e.g., file in use                                    |     N/A      |
| Non-Functional       | Cross-platform support                             		    | Optional, requires .NET Core/.NET 7+                 |     YES      |
| Optional Feature     | Regex-based renaming                               		    | Advanced feature                                     |     N/A      |
| Optional Feature     | Metadata-based renaming                            		    | e.g., image EXIF date                                |     N/A      |
| Optional Feature     | Save renaming rules                                		    | Configuration file for repeated use                  |     N/A      |

## Lessons
-Domain should not reference any other layer
-Application can have it's own interface folder to avoid using Domain's
-Value object represents a concept, like a file naming patter, a file extension...etc
- No identity (no ID or unique reference)
- Immutable (once created, never changes)
- Equality by value (not by reference)
- Self-validating (can enforce rules in constructor)
-Commands should only hold data no logic
-A Command is a representation of an intent
-you can use provider.GetRequiredService to inject constructor at top level

09/23/25 - project hours: 5 hours
- always use interface, and register them with <interface,implementation>
- if you need to use them at the top level use provider.GetRequiredServices<interface> instead of new

09/30/25 - project hours: 8 hours
- use docker command build with period at end like ex: docker build -t file-renamer .
- with run remember to use -it to have it interactive in command line: docker run -it file-renamer
- finished MVP need to write test
```text
Example output or screenshot:





