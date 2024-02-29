namespace Gyakorlo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    SzamoloGomb uj = new SzamoloGomb();
                    uj.Width = 100;
                    uj.Height = 50;

                    uj.Left = i * 110;
                    uj.Top = j * 55;

                    uj.Text = (1).ToString();

                    Controls.Add(uj);
                }
            }
            }

            
    }
}