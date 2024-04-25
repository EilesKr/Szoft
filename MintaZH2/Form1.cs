using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace MintaZH2
{
    public partial class Form1 : Form
    {
        BindingList<FutoVersenyzok> Futo = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<FutoVersenyzok>();

                foreach (var item in t�mb)
                {
                    Futo.Add(item);
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
            FutoBindingSource.DataSource = Futo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(Futo);
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
            if (FutoBindingSource.Current == null)
            {
                MessageBox.Show("Nem lehet sort t�r�lni.");
                return;
            };

            if (MessageBox.Show("Biztosan t�rli a sort?", "T�rl�s", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FutoBindingSource.RemoveCurrent();
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();
            if (formAddNew.ShowDialog() == DialogResult.OK)
            {
                FutoBindingSource.Add(formAddNew.newFuto);
            }
        }

        private void buttonErdekesseg_Click(object sender, EventArgs e)
        {
            double �sszeg = 0;
            int darab = 0;

            foreach (var item in Futo)
            {
                if (item.Nemzetiseg == "USA")
                {
                    �sszeg += item.EredmenyPerc;
                    darab++;
                }

            }

            //double �tlag = �sszeg / fut�k.Count();
            double �tlag = �sszeg / darab;

            MessageBox.Show(�tlag.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double minimum = double.PositiveInfinity;
            string leggyorsabb = string.Empty;

            foreach (var item in Futo)
            {
                if (item.EredmenyPerc < minimum)
                {
                    minimum = item.EredmenyPerc;
                    leggyorsabb = item.Nev;
                }
            }
            MessageBox.Show($"A leggyorsabb fut� {leggyorsabb}, aki {minimum} alatt futotta le a t�vot.");
        }
    }
}
