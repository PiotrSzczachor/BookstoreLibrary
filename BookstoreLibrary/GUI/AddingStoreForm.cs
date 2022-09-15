using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookstoreLibrary.Logic;
using BookstoreLibrary.Entities;

namespace BookstoreLibrary.GUI
{
    public partial class AddingStoreForm : Form
    {
        User currentlyLoggedUser;
        bool isEdit;
        int storeId;
        string initName;
        string initOpenHour;
        string initOpenMinute;
        string initCloseHour;
        string initCloseMinute;
        string initDays;
        string initStreet;
        string initNumber;
        string initCity;
        string initPostalCode;

        public AddingStoreForm(User user, bool edit = false, int id = -1)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            isEdit = edit;
            Initializer initializer = new Initializer();
            if (!isEdit)
            {
                initializer.initHoursComboBox(HourComboBox1);
                initializer.initHoursComboBox(HourComboBox2);
                initializer.initMinutesComboBox(MinuteComboBox1);
                initializer.initMinutesComboBox(MinuteComboBox2);
                initializer.initDaysCheckedListBox(DaysCheckBoxList);
                HourComboBox1.Text = "08";
                MinuteComboBox1.Text = "00";
                HourComboBox2.Text = "20";
                MinuteComboBox2.Text = "00";
            } else
            {
                SaveButton.Enabled = false;
                storeId = id;
                StoresManager storesManager = new StoresManager();
                storesManager.getStoreInfo(storeId, NameBox, HourComboBox1, MinuteComboBox1, HourComboBox2,
                                           MinuteComboBox2, DaysCheckBoxList, StreetBox, NumberTextBox, CityBox,
                                           PostalCodeBox);
                initName = NameBox.Text;
                initOpenHour = HourComboBox1.Text;
                initOpenMinute = MinuteComboBox1.Text;
                initCloseHour = HourComboBox2.Text;
                initCloseMinute = MinuteComboBox2.Text;
                initDays = "";
                foreach (string day in DaysCheckBoxList.CheckedItems)
                {
                    initDays += day + ",";
                }
                if (initDays.Length < 0) { initDays = initDays.Remove(initDays.Length - 1, 1); }
                initStreet = StreetBox.Text;
                initNumber = NumberTextBox.Text;
                initCity = CityBox.Text;
                initPostalCode = PostalCodeBox.Text;
                CheckChangesTimer.Enabled = true;
                CheckChangesTimer.Start();
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StoresMapForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                List<string> days = new List<string>();
                foreach (string day in DaysCheckBoxList.CheckedItems)
                {
                    days.Add(day);
                }
                StoresManager manager = new StoresManager();
                manager.addStore(NameBox.Text, HourComboBox1.Text, MinuteComboBox1.Text, HourComboBox2.Text, MinuteComboBox2.Text,
                                 days, StreetBox.Text, NumberTextBox.Text, CityBox.Text, PostalCodeBox.Text);
            }
            else
            {
                StoresManager manager = new StoresManager();
                manager.editStore(storeId, NameBox.Text, HourComboBox1.Text, MinuteComboBox1.Text, HourComboBox2.Text, MinuteComboBox2.Text,
                                 DaysCheckBoxList, StreetBox.Text, NumberTextBox.Text, CityBox.Text, PostalCodeBox.Text);
            }
            
        }

        private void CheckChangesTimer_Tick(object sender, EventArgs e)
        {
            string days = "";
            foreach (string day in DaysCheckBoxList.CheckedItems)
            {
                days += day + ",";
            }
            if (days.Length > 0) { days = days.Remove(days.Length - 1, 1); }
            List<string> values = new List<string>{ NameBox.Text, HourComboBox1.Text, MinuteComboBox1.Text, HourComboBox2.Text, MinuteComboBox2.Text,
                                             days, StreetBox.Text, NumberTextBox.Text, CityBox.Text, PostalCodeBox.Text };
            List<string> initValues = new List<string> { initName, initOpenHour, initOpenMinute, initCloseHour, initCloseMinute, initDays,
                                                         initStreet, initNumber, initCity, initPostalCode};
            bool emptyValues = false;
            bool valuesChanged = false;
            for (int i = 0; i < values.Count; i++)
            {
                if (string.IsNullOrEmpty(values[i]))
                {
                    emptyValues = true;
                }
                if (values[i] != initValues[i])
                {
                    valuesChanged = true;
                }
            }
            if (!emptyValues && valuesChanged)
            {
                SaveButton.Enabled = true;
            } else
            {
                SaveButton.Enabled = false;
            }
        }
    }
}
