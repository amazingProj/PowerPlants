using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public interface DataReader
    {
        List<dynamic> GetAllRecords();
    }
}
