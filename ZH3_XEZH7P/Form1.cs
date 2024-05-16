namespace ZH3_XEZH7P
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
    }
}