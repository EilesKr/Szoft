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
    public partial class UserControl4 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl4()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from c in context.Courses
                                   where c.Name.Contains(textBox1.Text)
                                   select c).ToList();
            label1.Text = (from i in context.Courses
                           where i.Name.StartsWith(textBox1.Text)
                           select i).Count().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Course course = listBox1.SelectedItem as Course;

            dataGridView1.DataSource = (from l in context.Lessons
                                        where l.CourseFk == course.CourseSk
                                        select new
                                        {
                                            Nap = l.DayFkNavigation.Name,
                                            Sav = l.TimeFkNavigation.Name,
                                            Oktato = l.InstructorFkNavigation.Name,
                                        }
                                        ).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new Form())
            {

                var label = new Label { Text = "Kurzus neve:", Location = new Point(10, 10) };
                var textBox = new TextBox { Location = new Point(10, 40) };
                var okButton = new Button { Text = "Ok", Location = new Point(10, 70) };
                var cancelButton = new Button { Text = "Mégse", Location = new Point(100, 70) };

                okButton.Click += (sender, e) =>
                {
                    var course = new Course { Name = textBox.Text };
                    context.Courses.Add(course);
                    context.SaveChanges();
                    FillDataSource();
                    form.Close();
                };

                cancelButton.Click += (sender, e) => form.Close();

                form.Controls.Add(label);
                form.Controls.Add(textBox);
                form.Controls.Add(okButton);
                form.Controls.Add(cancelButton);

                form.ShowDialog();
            }
        }
    }
}
