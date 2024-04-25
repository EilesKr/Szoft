namespace Adatkotes
{
    public partial class Form2 : Form
    {
        public CountryData CountryData;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
