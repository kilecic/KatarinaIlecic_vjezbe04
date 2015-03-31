using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTO_aplikacija
{
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float polumjer = 0;
            float povrsina = 0;
            float opseg = 0;
            float.TryParse(txtPolumjer.Text, out polumjer);
            if (polumjer < 0) polumjer = 0;

            povrsina = polumjer * polumjer * (float)Math.PI;
            opseg = 2 * polumjer * (float)Math.PI;

            txtPolumjer.Text = polumjer.ToString();
            txtpovrsina.Text = Math.Round(povrsina, 2).ToString();
            txtOpseg.Text = Math.Round(opseg, 2).ToString();

            if (chkSpremi.Checked == true) {
                IstRezultati.Items.Add(polumjer);
            }
            
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtPolumjer.Text = "0,00";
            txtpovrsina.Text = "0,00";
            txtOpseg.Text = "0,00";
            IstRezultati.Items.Clear();
        }

        private void IstRezultati_DoubleClick(object sender, EventArgs e)
        {
            float polumjer = 0;
            float.TryParse(IstRezultati.SelectedItem.ToString(), out polumjer);
            txtPolumjer.Text = polumjer.ToString();
            btnIzracunaj_Click(null, null);
        }
    }
}
