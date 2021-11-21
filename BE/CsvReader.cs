using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class CsvReader : DataReader
    {
        private string PathDir;
        private string File;

        private List<dynamic> records;
        public CsvReader()
        {

            PathDir = Directory.GetCurrentDirectory();

            StringBuilder relativePath = new StringBuilder();
            
            for (int i = 0; i < 4; ++i)
            {
                PathDir = System.IO.Directory.GetParent(PathDir).FullName;
            }

            File = PathDir + @"\global_power_plant_database.csv";

            using (var streamReader = new StreamReader(File))
            {
                using (var csvReader = new CsvHelper.CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    records = csvReader.GetRecords<dynamic>().ToList();
                }
            }
        }

        public List<dynamic> Records { get => records; set => records = value; }
        public string PathDirectory { get => PathDir; set => PathDir = value; }
        public string FileCsv { get => File; set => File = value; }

        public List<dynamic> GetAllRecords()
        {
            return records;
        }
    }
}
