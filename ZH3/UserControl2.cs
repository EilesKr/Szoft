using ZH3B_XEZH7P.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3B_XEZH7P
{
    public partial class UserControl2 : UserControl
    {
        se_cocktailsContext context;
        public UserControl2()
        {
            InitializeComponent();
            context = new se_cocktailsContext();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => FillDataSource();

        private void FillDataSource()
        {
            listBox1.DataSource = (from i in context.Cocktails
                                   where i.Name.Contains(textBox1.Text)
                                   select i).ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null) return;
            Recipe recepie = (Recipe)listBox1.SelectedItem;

            var recepies = from l in context.Recipes
                            where l.RecipeSk == recepie.RecipeSk
                            select new
                            {
                                Koktel = l.CocktailFkNavigation.Name,
                                Anyag = l.MaterialFkNavigation.Name,
                                Mennyiseg = l.Quantity
                            };

            dataGridView1.DataSource = recepies.ToList();
        }
    }
}
