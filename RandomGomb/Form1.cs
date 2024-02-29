namespace RandomGomb
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                int width = rng.Next(20, 51);
                int height = rng.Next(20, 51);

                int left = rng.Next(this.ClientSize.Width - width);
                int top = rng.Next(this.ClientSize.Height - height);

                int r = rng.Next(256);
                int g = rng.Next(256);
                int b = rng.Next(256);

                Button gomb = new Button();
                gomb.Width = width;
                gomb.Height = height;
                gomb.Left = left;
                gomb.Top = top;
                gomb.BackColor = Color.FromArgb(r, g, b);
                this.Controls.Add(gomb);
            }
        }
    }
}