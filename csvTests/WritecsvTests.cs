using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csv;
using Cities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Csv.Tests
{
    [TestClass()]
    public class WritecsvTests
    {
        [TestMethod()]
        public void ReadCsvFileTest()
        {
            var path = "c://csvfiles//worldcities.csv";
            var doubleTypeConversion = new DoubleConversion();
            IList<CityModelImport> myList = ReadCsv.ReadCsvFile<CityModelImport, CityMap>(path, doubleTypeConversion);

            Assert.AreEqual(15493, myList.Count());
        }
    }
}