namespace Gyakorlo1
{
    internal class SzamoloGomb : Button
    {
        int szam = 0;
        public SzamoloGomb()
        {
            Width = 20;
            Height = 20;

            Click += SzamoloGomb_Click;
        }

        private void SzamoloGomb_Click(object? sender, EventArgs e)
        {
            szam += 1;
            Text = szam.ToString();

        }
    }
}
