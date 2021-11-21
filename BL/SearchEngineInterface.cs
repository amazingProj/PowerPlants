using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public interface ISearchEngineInterface
    {
        public List<dynamic> ParseString(string SearchString);

        public List<dynamic> ClusteringString(string[] SearchString);


    }
}
