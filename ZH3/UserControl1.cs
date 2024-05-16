using ZH3B_XEZH7P.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;

namespace ZH3B_XEZH7P
{


    public partial class UserControl1 : UserControl
    {

        se_cocktailsContext context;
        public UserControl1()
        {
            InitializeComponent();
            context = new se_cocktailsContext();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => FillDataSource();

        private void FillDataSource()
        {
            listBox1.DataSource = (from i in context.Materials
                                   where i.Name.Contains(textBox1.Text)
                                   select i).ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null) return;
            Material material = (Material)listBox1.SelectedItem;

            var materials = from l in context.Materials
                            where l.Name == material.Name
                            select new
                            {
                                Tipus = l.TypeFkNavigation.Name,
                                Mennyiseg = l.UnitFkNavigation.Name,
                                Ar = l.Price
                            };
            dataGridView1.DataSource = materials.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = (from l in context.Materials
                        select l).ToList();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                csv.WriteRecords(data);
                streamWriter.Close();
            }
        }
    }
}
