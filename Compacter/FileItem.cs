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
        public bool Compressed { get; private set; }
        public int SizeOnDisk { get; private set; }
        public double Entropy { get; private set; }

        public void Analyze() 
        {
            // TODO size on disk
            // TODO is compressed?
            // TODO entropy
        }
    }
}
