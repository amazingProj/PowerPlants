using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    class GetFromCsv : IGetFromCsvInterface
    {
        private BE.DataReader CsvReader;

        public GetFromCsv()
        {
            CsvReader = new BE.CsvReader();
        }

        public List<dynamic> FilterByCapacityMaxWieght(string capacity_mw)
        {
            throw new System.NotImplementedException();
        }

        public List<dynamic> FilterByCountry(string countryName)
        {
            return CsvReader.GetAllRecords().Where((x) => x[0].equals(countryName) || x[1].equals(countryName)).ToList();
        }

        public List<dynamic> FilterByNumberDifferentFuel(int number)
        {
            throw new System.NotImplementedException();
        }

        public List<dynamic> FilterByPrimaryFuel(string primaryFuel)
        {
            throw new System.NotImplementedException();
        }
    }
}
