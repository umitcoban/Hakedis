using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakediş
{
    class WeatherInfo
    {
        public class weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
        }
        public class main
        {
            public double temp { get; set; }
        }
        public class Root
        {
            public main main { get; set; }
            public List<weather> weather { get; set; }
        }
    }
}
