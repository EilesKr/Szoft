using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaZH2
{
    public partial class FormAddNew : Form
    {
        public FutoVersenyzok newFuto = new FutoVersenyzok();
        public FormAddNew()
        {
            InitializeComponent();
            FutoBindingSource.DataSource = newFuto;

        }

        private void FormAddNew_Load(object sender, EventArgs e)
        {
        }
    }
}
