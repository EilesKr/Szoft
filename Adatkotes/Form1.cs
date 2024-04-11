using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Adatkotes
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new();
        public Form1()
        {

            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tomb = csv.GetRecords<CountryData>();
            foreach (var item in tomb)
            {
                countryList.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fce = new Form2();
            fce.CountryData = countryDataBindingSource.Current as CountryData;
            fce.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }
    }
}