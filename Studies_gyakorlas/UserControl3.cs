using CsvHelper;
using Studies_gyakorlas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studies_gyakorlas
{
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl3()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from i in context.Instructors
                                   where i.Name.StartsWith(textBox1.Text)
                                   select i).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Instructor instructor = (Instructor)listBox1.SelectedItem;

            var data = (from i in context.Instructors
                        where instructor.InstructorSk == i.InstructorSk
                        select new
                        {
                            Statusz = i.StatusFkNavigation.Name,
                            Munka = i.EmployementFkNavigation.Name,
                            Nevelo = i.Salutation
                        }).ToList();
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = (from i in context.Instructors
                        select i).ToList();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                csv.WriteRecords(data);
                streamWriter.Close();
            }
        }
    }
}
