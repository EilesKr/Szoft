namespace Csillagkep
{
    public partial class Form1 : Form

        
    {
        hajosContext context = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush b = new SolidBrush(Color.Fuchsia);

            Pen pen = new Pen(Color.Gold);

            g.FillEllipse(b, ClientRectangle.Width/2 - 50, ClientRectangle.Height/2 - 50, 100, 100);

            var stars = from x in context.StarData
                        select new { x.Hip, x.X, x.Y,  }

        }
    }
}