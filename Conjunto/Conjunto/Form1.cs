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

        HashSet<string> interseccionAB = new HashSet<string>();
        HashSet<string> interseccionAC = new HashSet<string>();
        HashSet<string> interseccionBC = new HashSet<string>();
        HashSet<string> interseccionABC = new HashSet<string>();

        private int countA = 2, countB = 2, countC = 2, countNoAgregarMas, aux, counter;

        public Form1()
        {
            InitializeComponent();
        }

        private void bttGuardarA_Click(object sender, EventArgs e)
        {
            if (!txtConjuntoA.Text.Equals("") && !txtAgregarAU.Equals("vacio"))
            {
                string A = txtConjuntoA.Text.ToLower(); ;
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
                        llenarConjuntoU(A, aux);
                    }
                    else if (countA == 3)
                    {
                        aux++;
                        txtMostrarA.Text = txtMostrarA.Text + A;
                        llenarConjuntoU(A, aux);
                    }
                    else
                    {
                        aux++;
                        txtMostrarA.Text = txtMostrarA.Text + " , " + A;
                        llenarConjuntoU(A, aux);
                    }
                }
                txtConjuntoA.Text = "";
            }
        }

        private void bttGuardarB_Click(object sender, EventArgs e)
        {
            if (!txtConjuntoB.Text.Equals("") && !txtAgregarAU.Equals("vacio"))
            {
                string B = txtConjuntoB.Text.ToLower();
                if (!conjuntoB.Contains(B))
                {
                    countB++;
                    conjuntoB.Add(B);
                    if (B == "vacio" && countB == 3)
                    {
                        countB = 1;
                        txtConjuntoB.ReadOnly = true;
                        txtMostrarB.Text = txtMostrarB.Text + B;
                        B = "";
                        llenarConjuntoU(B, aux);
                    }
                    else if (countB == 3)
                    {
                        aux++;
                        txtMostrarB.Text = txtMostrarB.Text + B;
                        llenarConjuntoU(B, aux);
                    }
                    else
                    {
                        aux++;
                        txtMostrarB.Text = txtMostrarB.Text + " , " + B;
                        llenarConjuntoU(B, aux);
                    }
                }
                txtConjuntoB.Text = "";
            }
        }

        private void bttGuardarC_Click(object sender, EventArgs e)
        {
            if (!txtConjuntoC.Text.Equals("") && !txtAgregarAU.Equals("vacio"))
            {
                string C = txtConjuntoC.Text.ToLower();
                if (!conjuntoC.Contains(C))
                {
                    countC++;
                    conjuntoC.Add(C);
                    if (C == "vacio" && countC == 3)
                    {
                        countC = 1;
                        txtConjuntoC.ReadOnly = true;
                        txtMostrarC.Text = txtMostrarC.Text + C;
                        C = "";
                        llenarConjuntoU(C, aux);
                    }
                    else if (countC == 3)
                    {
                        aux++;
                        txtMostrarC.Text = txtMostrarC.Text + C;
                        llenarConjuntoU(C, aux);
                    }
                    else
                    {
                        aux++;
                        txtMostrarC.Text = txtMostrarC.Text + " , " + C;
                        llenarConjuntoU(C, aux);
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
                aux++;
                string u = txtAgregarAU.Text;
                llenarConjuntoU(u, aux);
            }
            txtAgregarAU.Text = "";
        }

        public void llenarConjuntoU(string e, int i)
        {
            if (countA == 1 && countB == 1 && countC == 1)
            {
                conjuntoU.Add("vacio");
                txtConjuntoU.Text = "vacio";
                txtAgregarAU.ReadOnly = true;

            }

            if (!conjuntoU.Contains(e) && !e.Equals(""))
            {
                if (i == 1)
                {
                    conjuntoU.Add(e);
                    txtConjuntoU.Text = txtConjuntoU.Text + e;
                }
                else
                {
                    conjuntoU.Add(e);
                    txtConjuntoU.Text = txtConjuntoU.Text + " , " + e;
                }
            }
        }

        public void hallarIntersepciones()
        {
            HashSet<string> intrAB = new HashSet<string>(conjuntoA);
            intrAB.IntersectWith(conjuntoB);

            HashSet<string> intrAC= new HashSet<string>(conjuntoA);
            intrAB.IntersectWith(conjuntoC);

            HashSet<string> intrBC = new HashSet<string>(conjuntoB);
            intrAB.IntersectWith(conjuntoC);

            HashSet<string> intrABC = new HashSet<string>(interseccionAB);
            intrABC.IntersectWith(conjuntoC);

        }

        public void graficarEnVenn(int j, HashSet<string> inter, HashSet<string> interABC)
        {
            switch(j)
            {
                case 1:
                    foreach(string i in inter)
                    {
                        if(!interABC.Contains(i))
                        {
                            lbInterAB.Text = lbInterAB.Text + i;
                        }

                        if(!conjuntoA.Contains(i))
                        {
                            lbElementosA.Text = lbElementosA.Text + i;
                        }
                        else
                        {
                            continue;
                        }
                    }
               break;

                case 2:
                    foreach(string i  in inter)
                    {
                        if (!interABC.Contains(i))
                        {
                            lbInterAC.Text = lbInterAC.Text + i;
                        }

                        if (!inter.Contains(i))
                        {
                            lbElementosB.Text = lbElementosB.Text + i;
                        }
                        else
                        {
                            continue;
                        }
                    }
                break;

                case 3:
                    foreach (string i in conjuntoC)
                    {
                        if (!inter.Contains(i))
                        {
                            lbElementosC.Text = lbElementosC.Text + i;
                        }
                        else
                        {
                            continue;
                        }
                    }
               break;

            }
        }
        public void imprimirResultados(HashSet<string> p)
        {
            foreach( string i in p)
            {
                counter++;
                if(counter == 1)
                {
                    txtOperaciones.Text = txtOperaciones.Text + i;
                }
                else
                {
                    txtOperaciones.Text = txtOperaciones.Text + "," + i;
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
                imprimirResultados(dfC);
                counter = 0;
            }
            else
            {
                MessageBox.Show("Señor Usuario Primero debe Terminar de llenar los conjuntos", "Error",
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
                imprimirResultados(dfSime);
                counter = 0;
            }
            else
            {
                MessageBox.Show("Señor Usuario Primero debe Terminar de llenar los conjuntos", "Error",
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
                imprimirResultados(df1Y2);
                counter = 0;
            }
            else
            {
                MessageBox.Show("Señor Usuario Primero debe Terminar de llenar los conjuntos", "Error",
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
                imprimirResultados(union1Y2);
                counter = 0;
            }
            else
            {
                MessageBox.Show("Señor Usuario Primero debe Terminar de llenar los conjuntos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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


    



