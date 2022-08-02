using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

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


    }
}
