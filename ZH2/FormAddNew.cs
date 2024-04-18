using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2
{
    public partial class FormAddNew : Form
    {
        public autok newAuto = new autok();
        public FormAddNew()
        {
            InitializeComponent();
            autokBindingSource.DataSource = newAuto;
        }

        private void FormAddNew_Load(object sender, EventArgs e)
        {

        }
    }
}
