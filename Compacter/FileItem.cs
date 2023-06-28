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

        const double PACKED_THRESHOLD = 6.5; // From Detect-It-Easy XBinary class

        #region Properties
        public required string Path { get; init; }
        public bool Compressed { get; private set; }
        public long SizeOnDisk { get; private set; }
        public double Entropy { get; private set; }

        public bool Packed { get; private set; }
        public bool Analyzed { get; private set; }

        public bool ErrorOccurred { get; private set; }

        public string ErrorMessage { get; private set; } = string.Empty;

        #endregion
        public void Analyze() 
        {
            ErrorOccurred = false; // reset

            try
            {
                FileInfo fileInfo = new FileInfo(Path);

                SizeOnDisk = GetSizeOnDisk(fileInfo);

                Compressed = fileInfo.Attributes.HasFlag(FileAttributes.Compressed);

                Entropy = CalculateEntropy(fileInfo);

                Packed = Entropy >= PACKED_THRESHOLD;

                Analyzed = true;
            }
            catch (Exception e)
            {
                ErrorOccurred = true;
                Analyzed = false;
                ErrorMessage = e.Message;
            }

        }

        private double CalculateEntropy(FileInfo fileInfo)
        {
            return EntropyCalculator.Calculate(fileInfo);
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
