using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3_XEZH7P
{
    public partial class UserControl1 : UserControl
    {
        CocktailContext context;
        public UserControl1()
        {
            InitializeComponent();
            context = new CocktailContext();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }
    }
}
