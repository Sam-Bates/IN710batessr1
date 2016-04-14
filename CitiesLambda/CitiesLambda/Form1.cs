using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitiesLambda
{
    public partial class Form1 : Form
    {
        public List<City> CityList;
        public Form1()
        {
            InitializeComponent();
            CityList = new List<City>();

            City c1 = new City("Dunedin", "New Zealand", 127500);
            City c2 = new City("Wellington", "New Zealand", 204000);
            City c3 = new City("Paris", "France", 2244000);

            CityList.Add(c1);
            CityList.Add(c2);
            CityList.Add(c3);
        }
        public class City
        {
            public string CityName { get; set; }
            public string CountryName { get; set; }
            public int Population { get; set; }

            public City(string cityName, string countryName, int population)
            {
                CityName = cityName;
                CountryName = countryName;
                Population = population;
            }
            public override string ToString()
            {
                return "Name: " + CityName +  "\t | " + " Population: " + Population;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            //strings are input, bool is the return type.
            Func<string, string, bool> searchCities = (c1, c2) => c1.Equals(c2);

            listBox1.Items.Clear();
            foreach (City currCity in CityList)
            {   //call the lambda func and compare input to name
                if (searchCities(input, currCity.CountryName))
                {
                    listBox1.Items.Add(currCity.ToString());
                }
            }
        }
    }
}
