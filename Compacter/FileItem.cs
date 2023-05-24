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

            SizeOnDisk = GetSizeOnDisk(fileInfo);

            Compressed = fileInfo.Attributes.HasFlag(FileAttributes.Compressed);
            // TODO entropy

            Entropy = CalculateEntropy(fileInfo);

        }

        private double CalculateEntropy(FileInfo fileInfo)
        {
            return default; // TODO implement
        }

        /// <summary>
        /// Get the "size on disk" metric as seen on Windows Explorer in bytes
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        private long GetSizeOnDisk(FileInfo fileInfo)
        {
            return Alphaleonis.Win32.Filesystem.File.GetCompressedSize(fileInfo.FullName);
        }
    }
}
