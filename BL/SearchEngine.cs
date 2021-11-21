using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public class SearchEngine : ISearchEngineInterface
    {
        private DAL.IGetFromCsvInterface GetFromCsvInterface;
        public SearchEngine()
        {
            GetFromCsvInterface = new DAL.GetFromCsv();
        }
        public List<dynamic> ClusteringString(string[] SearchString)
        {
            if (SearchString.Equals(null))
            {
                return null;
            }
            List<dynamic> interstingWords = SearchString.Where(x => x.All(char.IsUpper)).ToList<dynamic>();
            return GetFromCsvInterface.FilterByCountry(interstingWords[0]);
        }
        
        public List<dynamic> ParseString(string SearchString)
        {
            if (SearchString.Equals(null))
            {
                return null;
            }

            string[] words = SearchString.Split(' ');

            return ClusteringString(words);
        }
    }
}
