using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3B_XEZH7P.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZH3B_XEZH7P
{
    public partial class UserControl3 : UserControl
    {
        se_cocktailsContext context;

        public UserControl3()
        {
            InitializeComponent();
            context = new se_cocktailsContext();
            FillDataSource();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e) => FillDataSource();

        private void FillDataSource()
        {
            var materialType = from l in context.MaterialTypes
                               select new
                               {
                                   Tipus = l.MaterialTypeId,
                                   Name = l.Name
                               };
            dataGridView1.DataSource = materialType.ToList();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            var label = new Label { Text = "Material neve", Location = new Point(10, 10) };
            var TextBox = new System.Windows.Forms.TextBox { Location = new Point(10, 40) };
            var okButton = new System.Windows.Forms.Button { Text = "OK", Location = new Point(10, 70) };
            var cancelButton = new System.Windows.Forms.Button { Text = "Cancel", Location = new Point(10, 70) };

            okButton.Click += (sender, e) =>
            {
                var material = new MaterialType { Name = TextBox.Text };
                context.MaterialTypes.Add(material);
                context.SaveChanges();
                FillDataSource();
                Form.Close();
            };

            cancelButton.Click += (sender, e) => Form.Close();

            Form.Controls.Add(label);
            Form.Controls.Add(TextBox);
            Form.Controls.Add(okButton);
            Form.Controls.Add(cancelButton);

            Form.ShowDialog();
        }*/
    }
}
