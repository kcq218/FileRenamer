# FileRenamer
FileRenamer project 1 out of 100 microprojects in C#

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

---

## Demo
*Optional*: Add screenshots, GIFs, or a link to a live demo if available.

#features
| Requirement Type     | Description                                                | Notes / Example |                                    | Accomplished | 
|----------------------|------------------------------------------------------------|------------------------------------------------------|--------------|
| Functional           | User inputs a folder path                             		  | Only files in the selected folder, no subfolders     |              |
| Functional           | Rename all files with a sequential number             		  | e.g., File_1.txt, File_2.txt                         |              |
| Functional           | Optional prefix for filenames                         		  | User can enter a prefix like Report_                 |              |
| Functional           | Preview filenames before renaming                     		  | Show old vs new filenames in console                 |              |
| Functional           | Execute renaming after confirmation                   		  | Ask user Y/N before renaming                         |              |
| Non-Functional       | Handle invalid folder paths                           		  | Show an error message if folder doesn’t exist        |              |
| Non-Functional       | Prevent overwriting files                             		  | Skip renaming if a new name already exists           |              |
| Functional           | Preview proposed renaming                             		  | Show current vs new filenames before applying        |              |
| Functional           | User confirmation before renaming                     		  | Yes/No prompt                                        |              |
| Functional           | Undo last renaming operation                          		  | Optional batch undo                                  |              |
| Functional           | Save a log file of operations                         		  | Include original & new filenames, timestamp          |              |
| Non-Functional       | Handle directories with large number of files efficiently	| Performance consideration                            |              |
| Non-Functional       | Avoid filename conflicts                                 	| Detect and prevent overwriting                       |              |
| Non-Functional       | Clear console instructions and prompts                   	| Usability requirement                                |              |
| Non-Functional       | Handle invalid directory paths                           	| Error handling                                       |              |
| Non-Functional       | Handle file access issues                          		    | e.g., file in use                                    |              |
| Non-Functional       | Cross-platform support                             		    | Optional, requires .NET Core/.NET 7+                 |              |
| Optional Feature     | Regex-based renaming                               		    | Advanced feature                                     |              |
| Optional Feature     | Metadata-based renaming                            		    | e.g., image EXIF date                                |              |
| Optional Feature     | Batch undo                                         		    | Undo multiple past renaming operations               |              |
| Optional Feature     | Save renaming rules                                		    | Configuration file for repeated use                  |              |


```text
Example output or screenshot:
