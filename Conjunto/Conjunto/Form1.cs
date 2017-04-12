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
        HashSet<string> conjuntoA = new HashSet<string>();
        HashSet<string> conjuntoB = new HashSet<string>();
        HashSet<string> conjuntoC = new HashSet<string>();
        HashSet<string> conjuntoU = new HashSet<string>();

        List<string> operacion = new List<string>();

        List<string> interseccionAB = new List<string>();
        List<string> interseccionAC = new List<string>();
        List<string> interseccionBC = new List<string>();
        List<string> interseccionABC = new List<string>();

        private int countA = 2, countB = 2, countC = 2, countNoAgregarMas;

        public Form1()
        {
            InitializeComponent();
        }

        private void bttGuardarA_Click(object sender, EventArgs e)
        {
            if (!txtConjuntoA.Text.Equals("") && !txtAgregarAU.Equals("vacio"))
            {
                string A = txtConjuntoA.Text;
                if (!conjuntoA.Contains(A))
                {
                    countA++;
                    conjuntoA.Add(A);

                    if (A == "vacio" && countA == 3)
                    {
                        countA = 1;
                        txtConjuntoA.ReadOnly = true;
                        txtMostrarA.Text = txtMostrarA.Text + A;
                        A = "";
                        llenarConjuntoU(A);
                    }
                    else if (countA == 3)
                    {
                        txtMostrarA.Text = txtMostrarA.Text + A;
                        llenarConjuntoU(A);
                    }
                    else
                    {
                        txtMostrarA.Text = txtMostrarA.Text + " , " + A;
                        llenarConjuntoU(A);
                    }
                }
                txtConjuntoA.Text = "";
            }
        }

        private void bttGuardarB_Click(object sender, EventArgs e)
        {
            if (!txtConjuntoB.Text.Equals("") && !txtAgregarAU.Equals("vacio"))
            {
                string B = txtConjuntoB.Text;
                if (!conjuntoB.Contains(B))
                {
                    countB++;
                    conjuntoA.Add(B);
                    if (B == "vacio" && countB == 3)
                    {
                        countB = 1;
                        txtConjuntoB.ReadOnly = true;
                        txtMostrarB.Text = txtMostrarB.Text + B;
                        B = "";
                        llenarConjuntoU(B);
                    }
                    else if (countB == 3)
                    {
                        txtMostrarB.Text = txtMostrarB.Text + B;
                        llenarConjuntoU(B);
                    }
                    else
                    {
                        txtMostrarB.Text = txtMostrarB.Text + " , " + B;
                        llenarConjuntoU(B);
                    }
                }
                txtConjuntoB.Text = "";
            }
        }

        private void bttGuardarC_Click(object sender, EventArgs e)
        {
            if (!txtConjuntoC.Text.Equals("") && !txtAgregarAU.Equals("vacio"))
            {
                string C = txtConjuntoC.Text;
                if (!conjuntoC.Contains(C))
                {
                    countC++;
                    conjuntoA.Add(C);
                    if (C == "vacio" && countC == 3)
                    {
                        countC = 1;
                        txtConjuntoC.ReadOnly = true;
                        txtMostrarC.Text = txtMostrarC.Text + C;
                        C = "";
                        llenarConjuntoU(C);
                    }
                    else if (countC == 3)
                    {
                        txtMostrarC.Text = txtMostrarC.Text + C;
                        llenarConjuntoU(C);
                    }
                    else
                    {
                        txtMostrarC.Text = txtMostrarC.Text + " , " + C;
                        llenarConjuntoU(C);
                    }
                    txtConjuntoC.Text = "";
                }
            }
        }
        private void bttAgregar_Click(object sender, EventArgs e)
        {
            if (txtAgregarAU.Text.Equals("vacio") && countA == 2 && countB == 2 && countC == 2 )
            {
                txtMostrarA.Text = "vacio";
                txtConjuntoA.ReadOnly = true;

                txtMostrarB.Text = "vacio";
                txtConjuntoB.ReadOnly = true;

                txtMostrarC.Text = "vacio";
                txtConjuntoC.ReadOnly = true;

                txtConjuntoU.Text = "vacio";
                txtAgregarAU.ReadOnly = true;
            }
            else if (!txtAgregarAU.Text.Equals("") && countA>= 3 || countB >= 3 || countC >= 3)
            {
                string u = txtAgregarAU.Text;
                llenarConjuntoU(u);
            }
            txtAgregarAU.Text = "";
        }

        public void hallarIntersepciones()
        {
            HashSet<string> intrAB = new HashSet<string>(conjuntoA);
            intrAB.IntersectWith(conjuntoB);
            interseccionAB = intrAB.ToList<string>();

            HashSet<string> intrAC= new HashSet<string>(conjuntoA);
            intrAB.IntersectWith(conjuntoC);
            interseccionAC = intrAC.ToList<string>();

            HashSet<string> intrBC = new HashSet<string>(conjuntoB);
            intrAB.IntersectWith(conjuntoC);
            interseccionBC = intrBC.ToList<string>();

            HashSet<string> intrABC = new HashSet<string>(interseccionAB);
            intrABC.IntersectWith(conjuntoC);
            interseccionABC = intrABC.ToList<string>();

        }
        public void imprimirResultados(List<string> p)
        {
            for (int i = 0; i < p.Count; i++)
            {
                if(i + 1 == 1)
                {
                    txtOperaciones.Text = txtOperaciones.Text + p[i];
                }
                else
                {
                    txtOperaciones.Text = txtOperaciones.Text + "," + p[i];
                }

                if( i + 1 == p.Count)
                {
                    operacion.Clear();
                }
            }
        }

         private void button1_Click_1(object sender, EventArgs e)
        {
            if (countNoAgregarMas >= 1)
            {
                txtOperaciones.Text = "";
                HashSet<string> dfSimetrica = new HashSet<string>(conjuntoA);
                dfSimetrica.SymmetricExceptWith(conjuntoB);
                HashSet<string> comple = new HashSet<string>(conjuntoU);
                comple.ExceptWith(dfSimetrica);
                HashSet<string> dfC = new HashSet<string>(comple);
                dfC.ExceptWith(conjuntoC);
                operacion = dfC.ToList<string>();
                imprimirResultados(operacion);
            }
            else
            {
                MessageBox.Show("Señor Usuario debe Primero debe Terminar de llenar los conjuntos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (countNoAgregarMas >= 1)
            {
                txtOperaciones.Text = "";
                HashSet<string> dfAB = new HashSet<string>(conjuntoA);
                dfAB.ExceptWith(conjuntoB);
                HashSet<string> comple = new HashSet<string>(conjuntoU);
                comple.ExceptWith(dfAB);
                HashSet<string> dfSime = new HashSet<string>(comple);
                dfSime.SymmetricExceptWith(conjuntoC);
                operacion = dfSime.ToList<string>();
                imprimirResultados(operacion);
            }
            else
            {
                MessageBox.Show("Señor Usuario debe Primero debe Terminar de llenar los conjuntos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btt2Operacion_Click(object sender, EventArgs e)
        {
            if (countNoAgregarMas >= 1)
            {
                txtOperaciones.Text = "";
                HashSet<string> dfSimeBC = new HashSet<string>(conjuntoB);
                dfSimeBC.SymmetricExceptWith(conjuntoC);
                HashSet<string> compleA = new HashSet<string>(conjuntoU);
                compleA.ExceptWith(conjuntoA);
                HashSet<string> df1Y2 = new HashSet<string>(dfSimeBC);
                df1Y2.ExceptWith(compleA);
                operacion = df1Y2.ToList<string>();
                imprimirResultados(operacion);
            }
            else
            {
                MessageBox.Show("Señor Usuario debe Primero debe Terminar de llenar los conjuntos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btt_Click(object sender, EventArgs e)
        {
            if (countNoAgregarMas >= 1)
            {
                txtOperaciones.Text = "";
                HashSet<string> dfAB = new HashSet<string>(conjuntoA);
                dfAB.ExceptWith(conjuntoB);
                HashSet<string> comple = new HashSet<string>(conjuntoU);
                comple.ExceptWith(dfAB);
                HashSet<string> compleC = new HashSet<string>(conjuntoU);
                compleC.ExceptWith(conjuntoU);
                HashSet<string> union1Y2 = new HashSet<string>(comple);
                union1Y2.UnionWith(compleC);
                operacion = union1Y2.ToList<string>();
                imprimirResultados(operacion);

            }
            else
            {
                MessageBox.Show("Señor Usuario debe Primero debe Terminar de llenar los conjuntos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void llenarConjuntoU(string e)
        {
            if (countA == 1 && countB == 1 && countC == 1)
            {
                conjuntoU.Add("vacio");
                txtConjuntoU.Text = "vacio";
                txtAgregarAU.ReadOnly = true;

            }

            if (!conjuntoU.Contains(e))
            {
                if (countA > 3 || countB > 3 || countC > 3)
                {
                    conjuntoU.Add(e);
                    txtConjuntoU.Text = txtConjuntoU.Text + " , " + e;
                }
                else
                {
                    conjuntoU.Add(e);
                    txtConjuntoU.Text = txtConjuntoU.Text + e;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!txtMostrarA.Text.Equals("") && !txtMostrarB.Text.Equals("") && !txtMostrarC.Text.Equals(""))
            {
                txtConjuntoA.ReadOnly = true;
                txtConjuntoB.ReadOnly = true;
                txtConjuntoC.ReadOnly = true;
                txtAgregarAU.ReadOnly = true;
                countNoAgregarMas++;
                hallarIntersepciones();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los conjuntos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


    



