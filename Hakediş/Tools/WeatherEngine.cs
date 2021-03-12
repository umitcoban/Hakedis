using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net;
using Newtonsoft.Json;
namespace Hakediş
{
  public  class WeatherEngine
    {
        public static string DailyWeatherGet(string apiKey, string cityID)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}&units=metric&lang=tr&charset=UTF-8", cityID,apiKey);
                var json = web.DownloadString(url);
                return json;
            }
        }
    }
}
