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
| Requirement Type     | Description                                                | Notes / Example                                      | Accomplished | 
|----------------------|------------------------------------------------------------|------------------------------------------------------|--------------|
| Functional           | User inputs a folder path                             		  | Only files in the selected folder, no subfolders     |     N/A      |
| Functional           | Rename all files with a sequential number             		  | e.g., File_1.txt, File_2.txt                         |     N/A      |
| Functional           | Optional prefix for filenames                         		  | User can enter a prefix like Report                  |     N/A      |
| Functional           | Preview filenames before renaming                     		  | Show old vs new filenames in console                 |     N/A      |
| Functional           | Execute renaming after confirmation                   		  | Ask user Y/N before renaming                         |     N/A      |
| Non-Functional       | Handle invalid folder paths                           		  | Show an error message if folder doesn’t exist        |     N/A      |
| Non-Functional       | Prevent overwriting files                             		  | Skip renaming if a new name already exists           |     N/A      |
| Functional           | Preview proposed renaming                             		  | Show current vs new filenames before applying        |     N/A      |
| Functional           | User confirmation before renaming                     		  | Yes/No prompt                                        |     N/A      |
| Functional           | Undo last renaming operation                          		  | Optional batch undo                                  |     N/A      |
| Functional           | Save a log file of operations                         		  | Include original & new filenames, timestamp          |     N/A      |
| Non-Functional       | Handle directories with large number of files efficiently	| Performance consideration                            |     N/A      |
| Non-Functional       | Avoid filename conflicts                                 	| Detect and prevent overwriting                       |     N/A      |
| Non-Functional       | Clear console instructions and prompts                   	| Usability requirement                                |     N/A      |
| Non-Functional       | Handle invalid directory paths                           	| Error handling                                       |     N/A      |
| Non-Functional       | Handle file access issues                          		    | e.g., file in use                                    |     N/A      |
| Non-Functional       | Cross-platform support                             		    | Optional, requires .NET Core/.NET 7+                 |     N/A      |
| Optional Feature     | Regex-based renaming                               		    | Advanced feature                                     |     N/A      |
| Optional Feature     | Metadata-based renaming                            		    | e.g., image EXIF date                                |     N/A      |
| Optional Feature     | Batch undo                                         		    | Undo multiple past renaming operations               |     N/A      |
| Optional Feature     | Save renaming rules                                		    | Configuration file for repeated use                  |     N/A      |


```text
Example output or screenshot:
