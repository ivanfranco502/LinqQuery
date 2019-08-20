using System;
using LinqQuery.DataSets;

namespace LinqQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.ProcessBusinessLineLinq(DataSetBusinessLine.Get(), Process.GetMapper());
        }
    }
}
