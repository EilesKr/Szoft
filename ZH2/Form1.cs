using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace ZH2
{
    public partial class Form1 : Form
    {
        BindingList<autok> auto = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("autok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tomb = csv.GetRecords<autok>();

                foreach (var item in tomb)
                {
                    auto.Add(item);
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autokBindingSource.DataSource = auto;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(auto);

                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (autokBindingSource.Current == null)
            {
                MessageBox.Show("Nincs kijelölve sor.");
                return;
            }

            if (MessageBox.Show("Sor törlése", "Biztosan ki szeretnéd törölni a sort?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                autokBindingSource.RemoveCurrent();
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();

            if (formAddNew.ShowDialog() == DialogResult.OK)
            {
                autokBindingSource.Add(formAddNew.newAuto);
            }
        }

        private void buttonErdekesseg_Click(object sender, EventArgs e)
        {
            double minimum = double.NegativeInfinity;
            string legerosebb = string.Empty;

            foreach (var item in auto)
            {
                if(item.TeljesitmenyHP > minimum)
                {
                    minimum = item.TeljesitmenyHP;
                    legerosebb = item.Gyarto;
                }
            }

            double osszeg = 0;
            int darab = 0;

            foreach (var item in auto)
            {
                if (item.Gyarto == "BMW")
                {
                    osszeg += item.TeljesitmenyHP;
                    darab++;
                }
            }

            double atlag = osszeg/ darab;

            MessageBox.Show($"A legerõsebb autó {minimum} lóerõs, és a {legerosebb} gyártmánya. {darab} BMW gyártmányú autó található a fileban, és az átlagos lóerejük {atlag}");
        }
    }
}