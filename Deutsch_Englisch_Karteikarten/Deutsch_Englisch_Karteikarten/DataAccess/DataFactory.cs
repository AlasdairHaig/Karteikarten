using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deutsch_Englisch_Karteikarten.DataAccess
{
    public class DataFactory
    {
        private DataProvider _dp = new DataProvider();

        public static readonly DataFactory dpf = new DataFactory();

        public DataProvider DP
        {
            get { return _dp; }
        }
    }
}
