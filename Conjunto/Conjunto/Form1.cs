using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conjunto
{
    public partial class Form1 : Form
    {
        string mensaje = "El conjunto es vacio";
        public Form1()
        {
            InitializeComponent();
        }

        private void bttGuardarA_Click(object sender, EventArgs e)
        {
            if(txtConjuntoA.Text != "")
            {
                int nElementosA = Convert.ToInt32(txtConjuntoA.Text);
            }
        }

        private void bttGuardarB_Click(object sender, EventArgs e)
        {
            if(txtConjuntoB.Text != "")
            {
                int nElementosB = Convert.ToInt32(txtConjuntoB.Text);
            }
        }

        private void bttGuardarC_Click(object sender, EventArgs e)
        {
            if(txtConjuntoC.Text != "")
            {
                int nElementosC = Convert.ToInt32(txtConjuntoC.Text);
            }
        }
    }
}
