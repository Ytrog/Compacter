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
    }
}