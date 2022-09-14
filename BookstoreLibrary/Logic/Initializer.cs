using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using BookstoreLibrary.Entities;
using System.Drawing;

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

        public void initCities(ComboBox CitiesComboBox, string postalCode)
        {
            CitiesComboBox.Items.Clear();
            string url = "http://kodpocztowy.intami.pl/api/" + postalCode;
            var request = WebRequest.Create(url);
            request.Method = "GET";
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            var JsonObject = JsonConvert.DeserializeObject<dynamic>(data);
            List<string> cities = new List<string>();
            foreach(var city in JsonObject)
            {
                if (!cities.Contains(city["miejscowosc"].ToString()))
                {
                    cities.Add(city["miejscowosc"].ToString());
                }
                
            }
            foreach(var city in cities)
            {
                CitiesComboBox.Items.Add(city);
            }
        }

        public void initRolesIfDbIsEmpty()
        {
            using (var db = new BookstoreLibContext())
            {
                if (db.Roles.Count() == 0)
                {
                    Role admin = new Role { Name = "Admin", IsAdmin = true, IsUser = false, IsSeller = false };
                    Role user = new Role { Name = "User", IsAdmin = false, IsUser = true, IsSeller = false };
                    Role seller = new Role { Name = "Seller", IsAdmin = false, IsUser = false, IsSeller = true };
                    db.Roles.Add(admin);
                    db.Roles.Add(user);
                    db.Roles.Add(seller);
                    db.SaveChanges();
                }
                
            }
                
        }

        public void initInfoLabel(Label label, string username)
        {
            label.Text = "You are currently logged as " + username;
        }

        public void initBooksPanel(DataGridView booksTable, Label label)
        {
            using (var db = new BookstoreLibContext())
            {
                var books = db.Books.ToList();
                booksTable.DataSource = books;
                label.Text = "All books:";
            }
        }

        public void initUsersTable(DataGridView usersTable, Label label)
        {
            using (var db = new BookstoreLibContext())
            {
                usersTable.DataSource = db.Users.Select(u => new
                {
                    Id = u.Id,
                    Name = u.Name,
                    Surname = u.Surname,
                    Username = u.Username,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                    JoinDate = u.JoinDate,
                    AccountBalance = u.AccountBalance,
                    Role = u.Role.Name
                }).ToList();
            }
            label.Text = "All users:";
        }

        public void initAddressInfo(TextBox StreetBox, TextBox NumberBox, TextBox CityBox, TextBox PostalCodeBox, User user)
        {
            StreetBox.Text = user.Address.Street;
            NumberBox.Text = user.Address.Number;
            CityBox.Text = user.Address.City;
            PostalCodeBox.Text = user.Address.PostalCode;
        }

        public void initAddingBookComboBoxes(ComboBox AuthorBox, ComboBox TypeBox, ComboBox PublisherBox, ComboBox PublishYearBox, ComboBox CurrencyBox, PictureBox CurrencyFlagPictureBox)
        {
            using (var db = new BookstoreLibContext())
            {
                var authors = db.Books.Select(b => new { Author = b.Author }).ToList();
                foreach (var author in authors)
                {
                    if (!AuthorBox.Items.Contains(author.Author))
                    {
                        AuthorBox.Items.Add(author.Author);
                    }
                }
                var types = db.Books.Select(b => new {Type = b.Type}).ToList();
                foreach (var type in types)
                {
                    if (!TypeBox.Items.Contains(type.Type))
                    {
                        TypeBox.Items.Add(type.Type);
                    }
                }
                var publishers = db.Books.Select(b => new { Publisher = b.Publisher }).ToList();
                foreach(var publisher in publishers)
                {
                    if (!PublisherBox.Items.Contains(publisher.Publisher))
                    {
                        PublisherBox.Items.Add(publisher.Publisher);
                    }
                }
                string[] currencies = { "PLN", "EUR", "USD", "CHF", "GBP", "UAH"};
                foreach (var currency in currencies)
                {
                    CurrencyBox.Items.Add(currency);
                }
                CurrencyBox.Text = "PLN";
                DateTime now = DateTime.Now;
                int currentYear = now.Year;
                for (int i=1900; i<=currentYear; i++)
                {
                    PublishYearBox.Items.Add(i.ToString());
                }
            }
            //Initialize currency flag pictureBox
            try
            {
                string startupPath = Environment.CurrentDirectory;
                startupPath = startupPath.Replace(@"\bin\Debug", "");
                string path = Path.Combine(startupPath, @"Images\Icons\Flags\pl.png");
                CurrencyFlagPictureBox.Image = Image.FromFile(path);
                CurrencyFlagPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            } catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void initHistoryTable(DataGridView historyTable, string username, Label label)
        {
            using (var db = new BookstoreLibContext())
            {
                User user = db.Users.FirstOrDefault(x => x.Username == username);
                if (user != null)
                {
                    var history = user.History.Select(h => new {Id = h.Id, Book = h.Book.Title, BookId = h.Book.Id, Action = h.Action, ActionDate = h.ActionDate }).ToList();
                    historyTable.DataSource = history;
                    label.Text = username + " history:";
                }
            }
        }

        public void initHoursComboBox(ComboBox hoursComboBox)
        {
            for(int i=1; i<25; i++)
            {
                if (i < 10) { hoursComboBox.Items.Add("0" + i.ToString()); } else { hoursComboBox.Items.Add(i.ToString()); }
            }
            
        }

        public void initMinutesComboBox(ComboBox minutesComboBox)
        {
            for(int i=0; i<61; i++)
            {
                if (i < 10) { minutesComboBox.Items.Add("0" + i.ToString()); } else { minutesComboBox.Items.Add(i.ToString()); }
            }
        }

        public void initDaysCheckedListBox(CheckedListBox days)
        {
            string[] daysArr = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            foreach(string day in daysArr)
            {
                days.Items.Add(day);
            }
        }
    }
}
