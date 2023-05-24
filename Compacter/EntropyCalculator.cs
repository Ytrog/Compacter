using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compacter
{
    /// <summary>
    /// Calculate entropy. Inspired by: https://github.com/merces/entropy/blob/master/entropy.cpp
    /// </summary>
    internal static class EntropyCalculator
    {
        public static double Calculate(FileInfo fileInfo)
        {

            uint[] count = CountBytes(fileInfo);

            double entropy = CalculateEntropy(fileInfo, count);

            return entropy;
        }

        private static double CalculateEntropy(FileInfo fileInfo, uint[] count)
        {
            double entropy = 0;
            double temp;

            for (int i = 0; i < 0xFF; i++)
            {
                temp = count[i] / fileInfo.Length;

                if (temp > 0)
                {
                    entropy += temp * Math.Abs(Math.Log2(temp));
                }
            }

            return entropy;
        }

        private static uint[] CountBytes(FileInfo fileInfo)
        {
            uint[] byteCount = new uint[0xFF]; // create an array with the count for each byte value (from 0x00 to 0xFF)

            // TODO count the bytes

            return byteCount;
        }
    }
}
