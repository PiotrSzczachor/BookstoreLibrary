using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using BookstoreLibrary.Data;

namespace BookstoreLibrary.Logic
{
    public class Initializer
    {
        public void initPhoneCodesComboBox(ComboBox PhoneCodesComboBox)
        {
            var url = "http://country.io/phone.json";
            var request = WebRequest.Create(url);
            request.Method = "GET";
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            var CountriesPhoneCodesDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
            List<string> phoneCodes = new List<string>();
            foreach(var phoneCode in CountriesPhoneCodesDict.Values)
            {
                if(!phoneCode.Contains('+') && !phoneCode.Contains(' ') && !string.IsNullOrEmpty(phoneCode))
                {
                    phoneCodes.Add(phoneCode);
                }
            }
            phoneCodes = phoneCodes.Distinct().ToList();
            foreach(var phoneCode in phoneCodes)
            {
                PhoneCodesComboBox.Items.Add('+' + phoneCode);
            }
            PhoneCodesComboBox.Text = "+48";
        }

        public void initPostalCodes(ComboBox PostalCodesComboBox)
        {
            using (var reader = new StreamReader(@"C:\Users\piotr\source\repos\BookstoreLibrary\BookstoreLibrary\Data\PostalCodes.csv"))
            {
                List<string> postalCodes = new List<string>();
                bool header = true;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if(!header)
                    {
                        PostalCodesComboBox.Items.Add(values[0]);
                    }
                    header = false;
                }
            }
        }

        public void initCities(ComboBox CitiesComboBox)
        {
            string url = "http://kodpocztowy.intami.pl/api/" + "37-700";
            var request = WebRequest.Create(url);
            request.Method = "GET";
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            var Cities = JsonConvert.DeserializeObject<dynamic>(data);
            foreach(var city in Cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
