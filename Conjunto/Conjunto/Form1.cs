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
        List<int> conjuntoA = new List<int>();
        List<int> conjuntoB = new List<int>();
        List<int> conjuntoC = new List<int>();
        List<int> conjuntoU = new List<int>();
        private string mensaje = "El conjunto es vacio";
        public Form1()
        {
            InitializeComponent();
        }

        private void bttGuardarA_Click(object sender, EventArgs e)
        {
            if(txtConjuntoA.Text != "")
            {
                int nElementosA = Convert.ToInt32(txtConjuntoA.Text);
                Form2 fm = new Form2(nElementosA, 1);
                fm.Show();
            }
        }

        private void bttGuardarB_Click(object sender, EventArgs e)
        {
            if(txtConjuntoB.Text != "")
            {
                int nElementosB = Convert.ToInt32(txtConjuntoB.Text);
                Form2 fm = new Form2(nElementosB, 2);
                fm.Show();
            }
        }

        private void bttGuardarC_Click(object sender, EventArgs e)
        {
            if(txtConjuntoC.Text != "")
            {
                int nElementosC = Convert.ToInt32(txtConjuntoC.Text);
                Form2 fm = new Form2(nElementosC, 3);
                fm.Show();
            }
        }
        public void ingresarElementos(int n, int e)
        {
            switch(n)
            {
                case 1:
                    conjuntoA.Add(e);
                break;

                case 2:
                    conjuntoB.Add(e);
                break;

                case 3:
                    conjuntoC.Add(e);
                break;
            }
        }
    }
}
