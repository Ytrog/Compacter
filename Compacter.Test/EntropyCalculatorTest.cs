using Compacter;

namespace Compacter.Test
{
    [TestClass]
    public class EntropyCalculatorTest
    {
        /// <summary>
        /// Calculate the entropy of a file with all the bytes one value (should be *very* low)
        /// </summary>
        [TestMethod]
        public void CalculateEntropyAllSame()
        {
            long length = 100;
            uint[] count = new uint[0xFF];
            count[42] = 100;

            double expected = 0;

            double actual = EntropyCalculator.CalculateEntropy(length, count);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateEntropyAllDifferent()
        {
            uint[] count = new uint[0xFF];
            
            for (int i = 0; i < count.Length; i++) 
            {
                count[i] = 1;
            }

            double expected = 8;

            double actual = EntropyCalculator.CalculateEntropy(count.Length, count);

            Assert.AreEqual((byte)expected, actual);
        }

        /// <summary>
        /// Generate a file for comparison
        /// </summary>
        [TestMethod]
        [Ignore]
        public void GenerateFile()
        {
            byte[] buffer = new byte[0xFF];

            for(int i = 0;i < buffer.Length; i++)
            {
                buffer[i] = (byte)i;
            }

            File.WriteAllBytes(@"C:\test\entropytest.dat", buffer);
        }
    }
}