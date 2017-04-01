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
        private int countConjuntos;
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
    }
}
