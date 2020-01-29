    using System;
using Csv;
using Cities;
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
namespace WriteCSV
{
    public class Writecsv
    {
        public static string CsvWrite(string path)
        {
            var doubleTypeConversion = new DoubleConversion();
            IList<CityModelImport> myList = ReadCsv.ReadCsvFile<CityModelImport, CityMap>(path, doubleTypeConversion);
            var countryCapitalQueryprimary = (from s in myList
                                       where s.Capital.Equals("primary")
                                       orderby s.Country ascending
                                       select s);
            /*
            foreach (CityModelImport city in countryCapitalQuery)
            {
                Debug.Write(city.Country + ": " + city.City_name + Environment.NewLine);
            }*/
            var queryName = nameof(countryCapitalQueryprimary);
            var writePath = "c://csvfiles//" + queryName + ".csv";
            using (var writer = new StreamWriter(writePath))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(countryCapitalQueryprimary);
            }
            return writePath;
        }
    }
}
