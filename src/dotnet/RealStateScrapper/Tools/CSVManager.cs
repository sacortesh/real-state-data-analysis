using CsvHelper;
using RealStateScrapper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateScrapper.Tools
{
    class CSVManager
    {
        public static void WritePropertiesCSV(List<Property> properties)
        {
            //TODO set a default output folder
            string filepath = "C:\\RealState\\properties.csv";


            using (TextWriter writer = new StreamWriter(filepath, false, System.Text.Encoding.UTF8))
            {
                var csv = new CsvWriter(writer);
                csv.WriteRecords(properties); // where values implements IEnumerable
            }

        }

    }
}
