using System;

namespace BL
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchEngine engine = new SearchEngine();
            engine.ParseString("All the power plants in ISR");
            int x = 1;
        }
    }
}
