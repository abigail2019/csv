using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;
using System.IO;
using System.Diagnostics;
using System.Linq;
using Csv;

namespace Csv
{
   public class Writecsv
    {
        public static IList<string> ReadCsvFile<T, M>(string absolutePath, CsvHelper.TypeConversion.ITypeConverter DoubleTypeConversion)
        {
            Type mapType = typeof(M);
            
            using var reader = new StreamReader(absolutePath);
            IList<string> results = new List<string>();
            using (var csv = new CsvReader(reader))
            {
                //IList<string> results = new List<string>();
                csv.Configuration.HasHeaderRecord = true;
                csv.Configuration.TypeConverterCache.AddConverter(typeof(double), DoubleTypeConversion);
                csv.Configuration.RegisterClassMap(mapType);

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    results.Add(line);
                }
            }
            return results;
        }
    }
}
