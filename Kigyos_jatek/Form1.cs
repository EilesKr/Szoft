namespace Kigyos_jatek
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;

        int ir�ny_x = 1;
        int ir�ny_y = 0;

        int hossz = 5;

        int l�p�ssz�m;

        List<K�gy�Elem> k�gy� = new List<K�gy�Elem>();

        public Form1()
        {
            InitializeComponent();
        }

        class K�gy�Elem : PictureBox
        {
            public static int M�ret = 20;

            public K�gy�Elem()
            {
                Width = K�gy�Elem.M�ret;
                Height = K�gy�Elem.M�ret;
                BackColor = Color.Fuchsia;

                
            }


        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            l�p�ssz�m++;

            //Fejn�veszt�s
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;

            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }

            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Yellow;
            k�gy�.Add(ke);
            Controls.Add(ke);

            if (k�gy�.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }

            if (l�p�ssz�m % 10 == 0)
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
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (object item in Controls)
            {
                if (item is K�gy�Elem)
                {
                    K�gy�Elem k = (K�gy�Elem)item;

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