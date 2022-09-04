using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreLibrary.Logic
{
    public class AddingBookLogic
    {
        public void changeFlagPicture(string currency, PictureBox flag)
        {
            string startupPath = Environment.CurrentDirectory;
            startupPath = startupPath.Replace(@"\bin\Debug", "");
            string path = Path.Combine(startupPath, @"Images\Icons\Flags\");
            if (currency == "PLN")
            {
                path += "pl.png";
            }
            if (currency == "EUR")
            {
                path += "europeanunion.png";
            }
            if (currency == "USD")
            {
                path += "us.png";
            }
            if (currency == "CHF")
            {
                path += "ch.png";
            }
            if (currency == "GBP")
            {
                path += "gb.png";
            } 
            if (currency == "UAH")
            {
                path += "ua.png";
            }
            try
            {
                flag.Image = Image.FromFile(path);
                flag.SizeMode = PictureBoxSizeMode.StretchImage;
            } catch (FileNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
