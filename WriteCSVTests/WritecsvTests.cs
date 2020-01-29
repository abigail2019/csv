using Microsoft.VisualStudio.TestTools.UnitTesting;
using WriteCSV;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Xunit.Sdk;

namespace WriteCSV.Tests
{
    [TestClass()]
    public class WritecsvTests
    {
        [TestMethod()]
        public void CsvWriteTest()
        {
            var path = "c://csvfiles//worldcities.csv";
            string WPath = Writecsv.CsvWrite(path);
            Assert.IsTrue(File.Exists(WPath));
        }
    }
}

namespace WriteCSVTests
{
    class WritecsvTests
    {
    }
}
