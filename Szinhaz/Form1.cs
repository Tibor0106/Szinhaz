using System.Runtime.InteropServices;

namespace Szinhaz
{
    public partial class Form1 : Form
    {
        private Szinhaz Szinhaz { get; set; }
        public Form1()
        {
            InitializeComponent();
            Szinhaz = new Szinhaz("szinhaz.txt");

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Foglaltsag_Click(object sender, EventArgs e)
        {
            FoglalasiTerkep a = new FoglalasiTerkep(Szinhaz.adatok);
            a.Show();

        }


        private void Foglal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(sor.Text, out int _sor) && int.TryParse(oszlop.Text, out int _oszlop))
            {
                try
                {
                    char ertek = Szinhaz.adatok[_sor - 1].sor[_oszlop - 1];
                    if (ertek == 'x')
                    {
                        MessageBox.Show("Ez a hely m�r foglalt.");
                    }
                    else
                    {
                        Szinhaz.Foglal(_sor, _oszlop);
                        Szinhaz = new Szinhaz("szinhaz.txt");
                        MessageBox.Show("Sikeres foglal�s !");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nem tal�lhat� a megadott sz�k");
                }
            }
            else
            {
                MessageBox.Show("A megadott �rt�k/�rt�kek nem sz�m/sz�mok");
            }
        }

        private void Stat_Click(object sender, EventArgs e)
        {
            Stat s = new Stat(Szinhaz);
            s.Show();
        }
    }
}
