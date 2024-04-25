using Adatbazis2.Models;

namespace Adatbazis2
{
    public partial class Form1 : Form
    {
        private readonly Models.StudentContext studentContext = new Models.StudentContext();
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = studentContext.Students.ToList();

            studentBindingSource.DataSource = studentContext.Students.ToList();

            dataGridView1.DataSource = studentBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception kivetel)
            {

                MessageBox.Show(kivetel.InnerException.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text = textBox1.Text;

            var eredmeny = from student in students
                           where student.Name.Contains(text)
                           select student;
            var eredmeny2 = students.Where(student=> student.Name.Contains(text));

            eredmeny2 = eredmeny2.OrderBy(student=> student.Name); //abc

            List<Student> eredmeny3 = new List<Student>();

            foreach (var item in students)
            {
                if (item.Name.Contains(text))
                {
                    eredmeny3.Add(item);
                }
            }

            studentBindingSource.DataSource = eredmeny2.ToList();
        }
    }
}