using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szinhaz
{
    public partial class Stat : Form
    {
        private Szinhaz szinhaz;
        public Stat(Szinhaz szinhaz)
        {
            InitializeComponent();
            this.szinhaz = szinhaz;
        }

        //véletlen
        private void Stat_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Osszes_Click(object sender, EventArgs e)
        {
            osszesfoglalas.Text = szinhaz.stat[0]+"";
        }

        private void UresSor_Click(object sender, EventArgs e)
        {
            vaneures.Text = szinhaz.stat[1] == 0 ? "Nincs benne": "Van benne";
        }

        private void Tiznel_Click(object sender, EventArgs e)
        {
            tizes.Text = szinhaz.stat[2] == -1 ? "Nincs ilyen" : $"{szinhaz.stat[2]}.sorban";
        }
    }
}
