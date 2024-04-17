using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaZH21
{
    public partial class FormEdit : Form
    {
        public VizsgaKerdes újVizsgakérdés = new();
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            vizsgaKérdésBindingSource.DataSource = újVizsgakérdés;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
