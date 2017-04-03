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
            if(txtConjuntoA.Text != "")
            {
                countConjuntos++;
                int nElementosA = Convert.ToInt32(txtConjuntoA.Text);
                llenarConjuntoU(countConjuntos);
                Form2 fm = new Form2(nElementosA, 1);
                fm.Show();
            }
        }

        private void bttGuardarB_Click(object sender, EventArgs e)
        {
            if(txtConjuntoB.Text != "")
            {
                countConjuntos++;
                int nElementosB = Convert.ToInt32(txtConjuntoB.Text);
                llenarConjuntoU(countConjuntos);
                Form2 fm = new Form2(nElementosB, 2);
                fm.Show();
            }
        }

        private void bttGuardarC_Click(object sender, EventArgs e)
        {
            if(txtConjuntoC.Text != "")
            {
                countConjuntos++;
                int nElementosC = Convert.ToInt32(txtConjuntoC.Text);
                llenarConjuntoU(countConjuntos);
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
        public void llenarConjuntoU(int count)
        {
            if(count == 3)
            {
                conjuntoU = conjuntoA;
                for(int i = 0; i < 2; i++)
                {
                    switch(i + 1)
                    {
                        case 1:
                            for(int j = 0; j < conjuntoU.Count(); j++)
                            {
                                for(int h = 0; h < conjuntoB.Count(); h++)
                                {
                                    if(conjuntoU[j] != conjuntoB[h])
                                    {
                                        conjuntoU.Add(conjuntoB[h]);
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                        break;

                        case 2:
                            for (int j = 0; j < conjuntoU.Count(); j++)
                            {
                                for (int h = 0; h < conjuntoC.Count(); h++)
                                {
                                    if (conjuntoU[j] != conjuntoC[h])
                                    {
                                        conjuntoU.Add(conjuntoC[h]);
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                        break;
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
        private void bttCalcular_Click(object sender, EventArgs e)
        {
            if(txtOperaciones.Text != "")
            {
                calcularOperaciones(txtOperaciones.Text);
            }
            else
            {
                MessageBox.Show("No puede estar vacio si desea ralizar alguna operación", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Aqui termina.

        public void calcularOperaciones(string operacion)
        {
            for(int i = 0; i < operacion.Length; i++)
            {
                if(operacion.Equals("("))
                {
                    aux++;
                    continue;
                }
                else if(aux == count)
                {
                    //Importaante
                }
                else
                {
                    continue;
                }
            }
        }

        private void bttMostarA_Click(object sender, EventArgs e)
        {
            foreach(int i in conjuntoA)
            {
                txtMostrarA.Text = txtMostrarA.Text +"," +  Convert.ToString(conjuntoA[i]);
            }
        }
    }
}
