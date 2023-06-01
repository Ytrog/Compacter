using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compacter.Test
{
    [TestClass]
    public class CompressorTest
    {
        /// <summary>
        /// Explore what GetExtension does
        /// </summary>
        [TestMethod]
        [Ignore]
        public void CompressorCorrectlySeesExecutables()
        {
            string actual = Path.GetExtension(@"C:\Users\ABCdeCirkel\.vscode\extensions\rust-lang.rust-analyzer-0.3.1506-win32-x64\server\rust-analyzer.exe");

            string expected = "exe";

            Assert.AreEqual(expected, actual);
        }
    }
}
