using Adatbazis2.CsillagokModels;

namespace Csillagkep2
{
    public partial class Form1 : Form
    {
        hajosContext context = new();
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.DarkBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush b = new SolidBrush(Color.Gold);

            var stars = (from x in context.StarData
                         select new { x.Hip, x.X, x.Y, x.Magnitude }).ToList();

            double nagyitas = 501;

            g.Clear(Color.DarkBlue);

            Color c = Color.Gold;

            Pen toll = new(c, 1);

            Brush brush = new SolidBrush(c);

            float cx = ClientRectangle.Width / 2;
            float cy = ClientRectangle.Height / 2;


            foreach (var s in stars)
            {
                if (Math.Sqrt(Math.Pow(s.X, 2) + Math.Pow(s.Y, 2)) > 1) continue;

                float x1 = (float)(nagyitas * s.X);
                float y1 = (float)(nagyitas * s.Y);

                double size = 20 * Math.Pow(10, (s.Magnitude) / -2.5);

                if (size < 1) size = 1;
                g.FillEllipse(b, x1 + cx, y1 + cy, (float)size, (float)size);
            }

            var lines = context.ConstellationLines.ToList();

            foreach (var line in lines) 
            {
                var star1 = (from s in stars where s.Hip == line.Star1 select s).FirstOrDefault();
                var star2 = (from s in stars where s.Hip == line.Star2 select s).FirstOrDefault();

                if (star1 == null || star2 == null) continue;

                float x1 = (float)(nagyitas * star1.X);
                float y1 = (float)(nagyitas * star1.Y);
                float x2 = (float)(nagyitas * star2.X);
                float y2 = (float)(nagyitas * star2.Y);

                g.DrawLine(toll, x1 + cx, y1 + cy, x2 + cx, y2 + cy);
            }



            MessageBox.Show(lines.Count.ToString());
        }
    }
}