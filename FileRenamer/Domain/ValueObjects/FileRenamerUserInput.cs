using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamer.Domain.ValueObjects
{
    public class FileRenamerUserInput
    {
        public int SingleOrMultipleFiles { get; set; }

        public string FolderPath { get; set; }

        public string Prefix {  get; set; }

        public string OriginalFileName { get; set; }
        public string ModifiedFileName { get; set; }
    }
}
