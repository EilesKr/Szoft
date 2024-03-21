using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hajos_teszt
{
     public class ValaszGomb : TextBox
    {
        public ValaszGomb()
        {
            BackColor = Color.LightGray;
            Multiline = true;
            ReadOnly = true;

            MouseEnter += ValaszGomb_MouseEnter;
            MouseLeave += ValaszGomb_MouseLeave;
            MouseClick += ValaszGomb_MouseClick;

            BorderStyle = BorderStyle.None;
            Cursor = Cursors.Hand;
        }

        private void ValaszGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (true)
            {
                BackColor = Color.Green;
            }
            else
            {
                BackColor = Color.Red;
            }
        }

        private void ValaszGomb_MouseLeave(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }

        private void ValaszGomb_MouseEnter(object? sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
