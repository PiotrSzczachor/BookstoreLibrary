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
        public AddingStoreForm(User user)
        {
            InitializeComponent();
            currentlyLoggedUser = user;
            Initializer initializer = new Initializer();
            initializer.initHoursComboBox(HourComboBox1);
            initializer.initHoursComboBox(HourComboBox2);
            initializer.initMinutesComboBox(MinuteComboBox1);
            initializer.initMinutesComboBox(MinuteComboBox2);
            initializer.initDaysCheckedListBox(DaysCheckBoxList);
            HourComboBox1.Text = "08";
            MinuteComboBox1.Text = "00";
            HourComboBox2.Text = "20";
            MinuteComboBox2.Text = "00";
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StoresMapForm(currentlyLoggedUser).ShowDialog();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
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
    }
}
