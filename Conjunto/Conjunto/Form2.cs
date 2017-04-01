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
    enum Conjunto { A = 1, B, C }
    public partial class Form2 : Form
    {
        private int n;
        public int Elementos
        {
            get { return n; }
            set { n = value; }
        }
        private int conjunto;
        public int Conjuntos
        {
            get { return conjunto; }
            set { conjunto = value; }
        }

        private int count = 1;
        public int counter
        {
            get { return count; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int nElementos, int nConjunto)
        {
            InitializeComponent();
            n = nElementos;
            switch (nConjunto)
            {
                case 1:
                    lbMensaje.Text = "Ingrese el 1 elemento de A";
                    break;

                case 2:
                    lbMensaje.Text = "Ingrese el 1 elemento de B";
                    break;

                case 3:
                    lbMensaje.Text = "Ingrese el 1 elemento de C";
                    break;
            }
            conjunto = nConjunto;
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            lbMensaje.Text = "";
            Form1 fm1 = new Form1();
            if (txtConjunto.Text != "")
            {
                count++;
                lbMensaje.Text = "Ingrese el " + count + " del Conjunto" + (Conjunto)conjunto;
                int elemento = Convert.ToInt32(txtConjunto.Text);
                switch (conjunto)
                {
                    case 1:
                        fm1.ingresarElementos(1, elemento);
                        break;

                    case 2:
                        fm1.ingresarElementos(2, elemento);
                        break;

                    case 3:
                        fm1.ingresarElementos(3, elemento);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe Ingresar un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbMensaje.Text = "Ingrese el " + count + " del Conjunto" + (Conjunto)conjunto;

            }
            txtConjunto.Text = "";
            if (count - 1 == n)
            {
                this.Hide();
            }
        }
    }
}
