using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace APItest
{


    class Program
    {
        static void Main(string[] args)
        {
            String url = "https://app.rakuten.co.jp/services/api/Travel/SimpleHotelSearch/20170426?format=json&applicationId=1079385179510929202" + "&largeClassCode=japan&middleClassCode=nagasaki&smallClassCode=nagasaki";
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
            string text = streamReader.ReadToEnd();
            streamReader.Close();
            stream.Close();
            Console.WriteLine(text);

            //Stream response_stream = request.GetResponse().GetResponseStream();
            //StreamReader reader = new StreamReader(response_stream);
            //var obj_from_json = JObject.Parse(reader.ReadToEnd());

            //var forecast_sum = obj_from_json["weather"][0]["main"];
            //var forecast_des = obj_from_json["weather"][0]["description"];
            //var forecast_max_temp = obj_from_json["main"]["temp_max"];
            //var forecast_min_temp = obj_from_json["main"]["temp_min"];
            //var forecast_hum = obj_from_json["main"]["humidity"];
            //var forecast_wind = obj_from_json["wind"]["speed"];

            //string forecast_output = "Tokyo is " + forecast_sum + " now. Description is " + forecast_des + ". Max tempreture is " + forecast_max_temp
            //    + "℃. Min tempreture is " + forecast_min_temp + "℃. Humidity is " + forecast_hum + "%. Wind is " + forecast_wind + "m/s. Have a good day!";
            //Console.WriteLine(forecast_output);

        }
    }
}