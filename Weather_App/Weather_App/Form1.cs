using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace Weather_App
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            Search_btn.Click += Search_btn_Click;
        }
        string api_key = "7503e2cfbc263cb887554f04cef977fa";
        private void Search_btn_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient wc = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", UI_City_txt.Text,api_key);
                var json = wc.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                UI_Icon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";


            }
        }
    }
}
