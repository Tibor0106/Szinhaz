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
    public partial class FoglalasiTerkep : Form
    {
        public FoglalasiTerkep(List<Szinhaz.S_Szinhaz> adat)
        {
            InitializeComponent();
            

            for (int i = 1; i <= Szinhaz.S_Szinhaz.maxSzekPerSor; i++)
            {
                dataGridView1.Columns.Add(i.ToString(), i.ToString());
                dataGridView1.Columns[i - 1].DefaultCellStyle.BackColor = SystemColors.Info;
                dataGridView1.Columns[i - 1].Width = 28;
           
            }

            for (int i = 1; i <= Szinhaz.S_Szinhaz.sorokSzama; i++)
            {
                dataGridView1.Rows.Add(i);
                dataGridView1.Rows[i-1].HeaderCell.Value = i.ToString();          
            }
   
            for(int i = 0; i < adat.Count; i++)
            {
               for(int j = 0; j < adat[i].sor.Count; j++) 
                {
                    dataGridView1.Rows[i].Cells[j].Value = adat[i].sor[j] == 'x' ? "" : j+1;
                }
            }       
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
