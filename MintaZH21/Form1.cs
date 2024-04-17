using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace MintaZH21
{
    public partial class Form1 : Form
    {
        BindingList<VizsgaKerdes> kerdesek = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_coma.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<VizsgaKerdes>();

                foreach (var item in tömb)
                {
                    kerdesek.Add(item);
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
            vizsgaKérdésBindingSource.DataSource = kerdesek;
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
                    csv.WriteRecords(kerdesek);
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
            if (vizsgaKérdésBindingSource.Current == null) return;

            if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                vizsgaKérdésBindingSource.RemoveCurrent();
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            if (vizsgaKérdésBindingSource.Current is VizsgaKerdes) 
            { 
                FormEdit formEdit = new FormEdit();
                formEdit.újVizsgakérdés = vizsgaKérdésBindingSource.Current as VizsgaKerdes;
                formEdit.Show();
            }
        }
    }
}
