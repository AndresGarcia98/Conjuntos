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
    public partial class ConjuntoA : Form
    {
        int[] conjuntoA;
        int nElementos, count = 1;
        public ConjuntoA(int n)
        {
            InitializeComponent();
             this.nElementos = n;
             conjuntoA = new int[nElementos];
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (txtConjuntoA.Text != "")
            {
                count += 1;
                lbConjuntoA.Text = "Ingrese el " + count + " Elemento del conjunto A";
                int a = Convert.ToInt32(txtConjuntoA.Text);
                conjuntoA[count] = a;
                txtConjuntoA.Text = "";
            }
            else
            {
                MessageBox.Show("Debe ingresar un elemento");
            }
        }
    }
}
