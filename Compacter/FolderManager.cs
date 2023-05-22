using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compacter
{
    internal class FolderManager
    {
        public required string Path { get; init; }

        public FolderManager(string path)
        {
            Path = path;
        }
    }
}
