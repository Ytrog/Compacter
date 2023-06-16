using Compacter;
using System.Diagnostics;

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
            uint[] count = new uint[256];
            count[42] = 100;

            double expected = 0;

            double actual = EntropyCalculator.CalculateEntropy(length, count);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateEntropyAllDifferent()
        {
            uint[] count = new uint[256];
            
            for (int i = 0; i < count.Length; i++) 
            {
                count[i] = 1;
            }

            double expected = 8;

            double actual = EntropyCalculator.CalculateEntropy(count.Length, count);

            Assert.AreEqual(expected, actual, 0.01);
        }
        [TestMethod]
        [TestCategory("Performance")]
        public void PerformanceCalculateEntropySequential()
        {
#if DEBUG
            Assert.Inconclusive("Do not benchmark in Debug mode");
#endif

            const int runs = 1_000_000;
            uint[] count = new uint[256];

            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 1;
            }

            // JIT warmup
            EntropyCalculator.CalculateEntropy(count.Length, count);

            // actual test
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < runs; i++)
            {
                EntropyCalculator.CalculateEntropy(count.Length, count);
            }
            sw.Stop();

            Trace.WriteLine("Elapsed: " + sw.Elapsed.ToString());
        }

        [TestMethod]
        [TestCategory("Performance")]
        public void PerformanceCalculateEntropyParallel()
        {
#if DEBUG
            Assert.Inconclusive("Do not benchmark in Debug mode");
#endif
            const int runs = 1_000_000;
            uint[] count = new uint[256];

            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 1;
            }

            // JIT warmup
            EntropyCalculator.CalculateEntropy(count.Length, count);

            // actual test
            Stopwatch sw = Stopwatch.StartNew();

            Parallel.For(0, runs, i => EntropyCalculator.CalculateEntropy(count.Length, count));

            sw.Stop();

            Trace.WriteLine("Elapsed: " + sw.Elapsed.ToString());

        }

        /// <summary>
        /// Generate a file for comparison
        /// </summary>
        [TestMethod]
        [Ignore]
        public void GenerateFile()
        {
            byte[] buffer = new byte[256];

            for(int i = 0;i < buffer.Length; i++)
            {
                buffer[i] = (byte)i;
            }

            File.WriteAllBytes(@"C:\test\entropytest.dat", buffer);
        }
    }
}