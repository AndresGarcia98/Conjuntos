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
        public static List<string> conjuntoA = new List<string>();
        public static List<string> conjuntoB = new List<string>();
        public static List<string> conjuntoC = new List<string>();
        List<string> conjuntoU = new List<string>();

        public static List<string> interseccionABC = new List<string>();

        public static List<string> unionABC = new List<string>();
        public static List<string> unionAB = new List<string>();
        public static List<string> unionBC = new List<string>();
        public static List<string> unionAC = new List<string>();


        private int countConjuntos;
        public int CountConjuntos
        {
            get { return countConjuntos; }
        }

        private int count;

        public int Count
        {
            get { return count; }
        }

        private int aux;
        public int Aux
        {
            get { return aux; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void bttGuardarA_Click(object sender, EventArgs e)
        {
            if (!txtConjuntoA.Text.Equals(""))
            {
                string A = txtConjuntoA.Text;
                if (!conjuntoA.Contains(A))
                {
                    conjuntoA.Add(A);
                    txtMostrarA.Text = txtMostrarA.Text + A + ",";
                }
                llenarConjuntoU(A);
                txtConjuntoA.Text = "";
            }
        }

        private void bttGuardarB_Click(object sender, EventArgs e)
        {
            if (!txtConjuntoB.Text.Equals(""))
            {
                string B = txtConjuntoB.Text;
                if (!conjuntoB.Contains(B))
                {
                    conjuntoA.Add(B);
                    txtMostrarB.Text = txtMostrarB.Text + B + ",";
                }
                llenarConjuntoU(B);
                txtConjuntoB.Text = "";
            }
        }

        private void bttGuardarC_Click(object sender, EventArgs e)
        {
            if (!txtConjuntoC.Text.Equals(""))
            {
                string C = txtConjuntoC.Text;
                if (!conjuntoC.Contains(C))
                {
                    conjuntoA.Add(C);
                    txtMostrarC.Text = txtMostrarC.Text + C + ",";
                }
                llenarConjuntoU(C);

                txtConjuntoC.Text = "";
            }
        }

      public void llenarConjuntoU(string e)
        {
            if (!conjuntoU.Contains(e))
            {
                conjuntoU.Add(e);
                txtConjuntoU.Text = txtConjuntoU.Text + e + ",";
            }
        }

        public void llenarInterseccion()
        {
            for (int i = 0; i < conjuntoA.Count; i++)
            {
                for (int j = 0; j < conjuntoB.Count; j++)
                {
                    for (int k = 0; k < conjuntoC.Count; k++)
                    {
                        if (conjuntoA[i] == conjuntoB[j] && conjuntoB[j] == conjuntoC[k])
                        {
                            interseccionABC.Add(conjuntoA[i]);
                        }
                    }
                }
            }
        }

        public void llenarUnion()
        {
            unionAB = conjuntoA;
            unionAC = conjuntoA;
            unionBC = conjuntoB;

            for (int i = 0; i < conjuntoA.Count; i++)
            {
                for (int j = 0; j < conjuntoB.Count; j++)
                {
                    if (!unionAB.Contains(conjuntoB[j]))
                    {
                        unionAB.Add(conjuntoB[j]);
                    }

                    for (int k = 0; k < conjuntoC.Count; k++)
                    {
                        if (!unionAC.Contains(conjuntoC[k]))
                        {
                            unionAC.Add(conjuntoC[k]);
                        }

                        if (!unionBC.Contains(conjuntoC[k]))
                        {
                            unionBC.Add(conjuntoC[k]);
                        }
                    }
                }
            }
        }

        //codigo que hace que aparezca en el txtOperaciones segun lo que el usaurio presiono en los botones
        private void bttA_Click(object sender, EventArgs e)
        {
            string cjA = "A";
            txtOperaciones.Text = txtOperaciones.Text + cjA;
        }

        private void bttB_Click(object sender, EventArgs e)
        {
            string cjB = "B";
            txtOperaciones.Text = txtOperaciones.Text + cjB;
        }

        private void bttC_Click(object sender, EventArgs e)
        {
            string cjC = "C";
            txtOperaciones.Text = txtOperaciones.Text + cjC;
        }

        private void bttUnion_Click(object sender, EventArgs e)
        {
            string union = "U";
            txtOperaciones.Text = txtOperaciones.Text + union;
        }

        private void bttIntersepcion_Click(object sender, EventArgs e)
        {
            string interseccion = "";
            txtOperaciones.Text = txtOperaciones.Text + interseccion;
        }

        private void bttDirecenciaSimetrica_Click(object sender, EventArgs e)
        {
            string dfSimetrica = "A";
            txtOperaciones.Text = txtOperaciones.Text + dfSimetrica;
        }

        private void bttDiferencia_Click(object sender, EventArgs e)
        {
            string diferencia = "-";
            txtOperaciones.Text = txtOperaciones.Text + diferencia;
        }

        private void txtComplemento_Click(object sender, EventArgs e)
        {
            string complemento = "'";
            txtOperaciones.Text = txtOperaciones.Text + complemento;
        }

        private void txtParentisisAbrir_Click(object sender, EventArgs e)
        {
            string parentesis = "(";
            txtOperaciones.Text = txtOperaciones.Text + parentesis;
            count++;
        }

        private void bttParentesisCerrar_Click(object sender, EventArgs e)
        {
            string parentesis = ")";
            txtOperaciones.Text = txtOperaciones.Text + parentesis;
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            if (!txtAgregarAU.Text.Equals(""))
            {
                string u = txtAgregarAU.Text;
                llenarConjuntoU(u);
            }
        }*/
    }
}
