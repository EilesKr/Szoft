using ZH3B_XEZH7P;

namespace ZH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 userControl1 = new();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 userControl2 = new();
            panel1.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
        }
    }
}