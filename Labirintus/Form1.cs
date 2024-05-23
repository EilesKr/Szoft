using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Labirintus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox player = new PictureBox();
        PictureBox finish = new PictureBox();
        List<PictureBox> brickes = new List<PictureBox>();
        int size = 20;
        int time = 0;
        int step = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    int y = 0;
                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        for (int x = 0; x < sor.Length; x++)
                        {
                            if (sor[x] == '#')
                            {
                                PictureBox pb = new PictureBox();
                                pb.Location = new Point(x * size, 100 + y * size);
                                pb.Size = new Size(size, size);
                                pb.BackColor = Color.Black;
                                this.Controls.Add(pb);
                                brickes.Add(pb);
                            }

                            if (sor[x] == 'S')
                            {
                                player.Location = new Point(x * size, 100 + y * size);
                                player.Size = new Size(size, size);
                                player.BackColor = Color.Fuchsia;
                                Controls.Add(player);
                            }

                            if (sor[x] == 'F')
                            {
                                finish.Location = new Point(x * size, 100 + y * size);
                                finish.Size = new Size(size, size);
                                finish.BackColor = Color.Cyan;
                                Controls.Add(finish);
                            }
                        }
                        y++;
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            timer1.Enabled = true;
            int x = player.Location.X;
            int y = player.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                x += size;
                StepChange();
            }

            if (e.KeyCode == Keys.Left && player.Location.X != 0)
            {
                x -= size;
                StepChange();
            }

            if (e.KeyCode == Keys.Up && player.Location.Y > 100)
            {
                y -= size;
                StepChange();
            }

            if (e.KeyCode == Keys.Down)
            {
                y += size;
                StepChange();
            }

            var wall = brickes.FirstOrDefault(w => w.Location.X == x && w.Location.Y == y);
            if (wall == null)
            {
                player.Location = new Point(x, y);
            }

            if (e.KeyCode == Keys.R)
            {
                player.Location = new Point(0, 100);
                time = 0;
                step = 0;
                labelStep.Text = $"Lépések száma: {step}";
                labelTime.Text = $"Eltelt idõ: {time} mp";

            }

            if (player.Location == finish.Location)
            {
                timer1.Enabled = false;
                MessageBox.Show($"Gratulálunk, kijutottál a labirintusból!\nIdõ: {time} mp\nLépések: {step}");
            }
        }

        private void StepChange()
        {
            step++;
            labelStep.Text = $"Lépések száma: {step}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            labelTime.Text = $"Eltelt idõ: {time} mp";
        }

    }
}