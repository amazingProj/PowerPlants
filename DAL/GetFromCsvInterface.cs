using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IGetFromCsvInterface
    {
        List<dynamic> FilterByCountry(string countryName);
        List<dynamic> FilterByCapacityMaxWieght(string capacity_mw);
        List<dynamic> FilterByPrimaryFuel(string primaryFuel);
        List<dynamic> FilterByNumberDifferentFuel(int number);
    }
}
