namespace Kigyos_jatek
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;

        int irány_x = 1;
        int irány_y = 0;

        int hossz = 5;

        int lépésszám;

        List<KígyóElem> kígyó = new List<KígyóElem>();

        public Form1()
        {
            InitializeComponent();
        }

        class KígyóElem : PictureBox
        {
            public static int Méret = 20;

            public KígyóElem()
            {
                Width = KígyóElem.Méret;
                Height = KígyóElem.Méret;
                BackColor = Color.Fuchsia;

                
            }


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lépésszám++;

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            if (lépésszám % 2 == 0) ke.BackColor = Color.Yellow;
            kígyó.Add(ke);
            Controls.Add(ke);

            if (kígyó.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            if (lépésszám % 10 == 0)
            {
                Random rnd = new Random();
                Kaja kaja = new Kaja();
                kaja.Top = rnd.Next(ClientRectangle.Height / 20) * 20;
                kaja.Left = rnd.Next(ClientRectangle.Width / 20) * 20;
                Controls.Add(kaja);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }
        }
    }
}