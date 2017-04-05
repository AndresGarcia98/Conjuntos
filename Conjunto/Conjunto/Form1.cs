﻿using System;
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
        List<string> conjuntoA = new List<string>();
        List<string> conjuntoB = new List<string>();
        List<string> conjuntoC = new List<string>();
        List<string> conjuntoU = new List<string>();

        List<string> interseccionAB = new List<string>();
        List<string> interseccionAC = new List<string>();
        List<string> interseccionBC = new List<string>();
        List<string> interseccionABC = new List<string>();

        List<string> unionABC = new List<string>();
        List<string> unionAB = new List<string>();
        List<string> unionBC = new List<string>();
        List<string> unionAC = new List<string>();

        List<string> diferencaAB = new List<string>();
        List<string> diferencaAC = new List<string>();
        List<string> diferencaBA = new List<string>();
        List<string> diferencaBC = new List<string>();
        List<string> diferencaCA = new List<string>();
        List<string> diferencaCB = new List<string>();
        List<string> diferencaABC = new List<string>();


        List<string> complemento = new List<string>();
        List<string> operacion = new List<string>();


        private int countA, countB, countC;

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
                    conjuntoA.Add(A);
                    txtMostrarA.Text = txtMostrarA.Text + A + ",";
                    countA++;
                    if (A == "vacio" && countA == 1)
                    {
                        txtConjuntoA.ReadOnly = true;
                    }
                }
                llenarConjuntoU(A);
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
                    conjuntoA.Add(B);
                    txtMostrarB.Text = txtMostrarB.Text + B + ",";
                    countB++;
                    if(B == "vacio" && countB == 1)
                    {
                        txtConjuntoB.ReadOnly = true;
                    }
                }
                llenarConjuntoU(B);
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
                    conjuntoA.Add(C);
                    txtMostrarC.Text = txtMostrarC.Text + C + ",";
                    countC++;
                    if (C == "vacio" && countC == 1)
                    {
                        txtConjuntoC.ReadOnly = true;
                    }
                }
                llenarConjuntoU(C);
                txtConjuntoC.Text = "";
            }
        }
        private void bttAgregar_Click(object sender, EventArgs e)
        {
            if(txtAgregarAU.Text.Equals("vacio"))
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
            else if (!txtAgregarAU.Text.Equals("") && conjuntoA.Count != 0 && conjuntoB.Count != 0 && conjuntoC.Count != 0)
            {
                string u = txtAgregarAU.Text;
                llenarConjuntoU(u);
            }
            txtAgregarAU.Text = "";
        }
        public void llenarConjuntoU(string e)
        {
            if (!conjuntoU.Contains(e))
            {
                if( e != "vacio" && countA != 0 || countB != 0 || countC != 0)
                {
                    conjuntoU.Add(e);
                    txtConjuntoU.Text = txtConjuntoU.Text + "," + e;
                }
                else
                {
                    conjuntoU.Add(e);
                    txtConjuntoU.Text = txtConjuntoU.Text + e;
                }
            }
            if(countA ==1 && countB == 1 && countC == 1)
            {
                conjuntoU.Add(e);
                txtConjuntoU.Text = txtConjuntoU.Text + e ;
                txtAgregarAU.ReadOnly = true;

            }
        }

        public void realizarOperaciones()
        {
            if (conjuntoA.Count != 0 && conjuntoB.Count != 0 && conjuntoC.Count != 0)
            {
                llenarUnion();
                llenarInterseccion();
                llenarDiferencia();
            }
        }

        public void llenarInterseccion()
        {
            for (int i = 0; i < conjuntoA.Count; i++)
            {
                for (int j = 0; j < conjuntoB.Count; j++)
                {
                    if (conjuntoA.Contains(conjuntoB[j]))
                    {
                        interseccionAB.Add(conjuntoB[j]);
                    }
                    else if (j + 1 == conjuntoB.Count)
                    {
                        for (int k = 0; k < conjuntoC.Count; k++)
                        {
                            if (interseccionAB.Contains(conjuntoC[k]))
                            {
                                interseccionABC.Add(conjuntoC[k]);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    continue;
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

                        if (!unionAB.Contains(conjuntoC[k]))
                        {
                            unionABC.Add(conjuntoC[k]);
                        }
                    }
                }
        }
    }


        public void llenarDiferencia()
        {
            diferencaAB = conjuntoA;
            diferencaAC = conjuntoA;
            diferencaBA = conjuntoB;
            diferencaBC = conjuntoB;
            diferencaCA = conjuntoC;
            diferencaCB = conjuntoC;
            for (int i = 0; i < conjuntoA.Count; i++)
            {
                string a = conjuntoA[i];
                if (diferencaBA.Contains(a))
                {
                    diferencaAB.Remove(a);
                }
                if (diferencaCA.Contains(a))
                {
                    diferencaCB.Remove(a);
                }
                for (int j = 0; j < conjuntoB.Count; j++)
                {
                    string b = conjuntoB[j];
                    if (diferencaAB.Contains(b))
                    {
                        diferencaAB.Remove(b);
                    }
                    if (diferencaCB.Contains(b))
                    {
                        diferencaCB.Remove(b);
                    }
                    for (int k = 0; k < conjuntoC.Count; k++)
                    {
                        string c = conjuntoC[k];
                        if (diferencaBC.Contains(c))
                        {
                            diferencaAB.Remove(c);
                        }
                        if (diferencaAC.Contains(c))
                        {
                            diferencaCB.Remove(c);
                        }
                    }
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            for(int i = 0; i < conjuntoU.Count; i ++)
            {
                if (!diferencaAB.Contains(conjuntoU[i]))
                {
                    complemento.Add(conjuntoU[i]);
                    if (i + 1 == conjuntoU.Count)
                    {
                        for (int j = 0; j < conjuntoC.Count; j++)
                        {
                            if(!complemento.Contains(conjuntoC[j]))
                            {
                                operacion.Add(conjuntoC[i]);
                                txt1Operacion.Text = txt1Operacion.Text + conjuntoC[i];
                            }
                            else
                            {
                                MessageBox.Show("Si esta");
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            realizarOperaciones();
        }
    }
}



