using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compacter
{
    internal class FileItem
    {
        public required string Path { get; init; }

        public void Analyze() 
        {
            // TODO size on disk
            // TODO is compressed?
            // TODO entropy
        }
    }
}
