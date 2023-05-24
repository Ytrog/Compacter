using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compacter
{
    internal class FileItem
    {
        public required string Path { get; init; }
        public bool Compressed { get; private set; }
        public long SizeOnDisk { get; private set; }
        public double Entropy { get; private set; }

        public void Analyze() 
        {
            FileInfo fileInfo = new FileInfo(Path);


            // TODO size on disk
            SizeOnDisk = GetSizeOnDisk(fileInfo);

            Compressed = fileInfo.Attributes.HasFlag(FileAttributes.Compressed);
            // TODO entropy
        }

        private long GetSizeOnDisk(FileInfo fileInfo)
        {
            return Alphaleonis.Win32.Filesystem.File.GetCompressedSize(fileInfo.FullName);
        }
    }
}
