namespace szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Button b = new Button();
                    b.Text = (i*j).ToString();
                    b.Left = 100 * i;
                    b.Top = 100 * j;

                    Controls.Add(b);
                }
            }
           
        }
    }
}