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
        //Hashsets donde seguardanm los elementos de los conjuntos.
        HashSet<string> conjuntoA = new HashSet<string>();
        HashSet<string> conjuntoB = new HashSet<string>();
        HashSet<string> conjuntoC = new HashSet<string>();
        HashSet<string> conjuntoU = new HashSet<string>();


        //Contadores que me ayudan a saber cuantos elementos se han ingresado a cuantos conjuntos
        private int countA = 2, countB = 2, countC = 2,
            countNoAgregarMas, aux, counter;

        public Form1()
        {
            InitializeComponent();
        }

        private void bttGuardarA_Click(object sender, EventArgs e)
        {
            if (!txtConjuntoA.Text.Equals("") && !txtConjuntoA.Text.Trim().Equals("{}"))
            {
                string A = txtConjuntoA.Text.ToLower(); ;
                if (!conjuntoA.Contains(A))
                {
                    countA++;
                    if (A == "vacio" && countA == 3)
                    {
                        A = "{  }";
                        countA = 1;
                        txtConjuntoA.ReadOnly = true;
                        txtMostrarA.Text = txtMostrarA.Text + A;
                        conjuntoA.Add(A);
                        A = "";
                        llenarConjuntoU(A, aux);
                    }
                    else if (countA == 3)
                    {
                        conjuntoA.Add(A);
                        aux++;
                        txtMostrarA.Text = txtMostrarA.Text + A;
                        llenarConjuntoU(A, aux);
                    }
                    else
                    {
                        conjuntoA.Add(A);
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
            if (!txtConjuntoB.Text.Equals("") && !txtConjuntoB.Text.Trim().Equals("{}"))
            {
                string B = txtConjuntoB.Text.ToLower();
                if (!conjuntoB.Contains(B))
                {
                    countB++;
                    if (B == "vacio" && countB == 3)
                    {
                        B = "{ }";
                        countB = 1;
                        txtConjuntoB.ReadOnly = true;
                        txtMostrarB.Text = txtMostrarB.Text + B;
                        conjuntoB.Add(B);
                        B = "";
                        llenarConjuntoU(B, aux);
                    }
                    else if (countB == 3)
                    {
                        conjuntoB.Add(B);
                        aux++;
                        txtMostrarB.Text = txtMostrarB.Text + B;
                        llenarConjuntoU(B, aux);
                    }
                    else
                    {
                        conjuntoB.Add(B);
                        aux++;
                        txtMostrarB.Text = txtMostrarB.Text + " , " + B;
                        llenarConjuntoU(B, aux);
                    }
                }
                txtConjuntoB.Text = "";
            }
        }

        /// <summary>
        /// Método para agregar elementos al conjuntoC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttGuardarC_Click(object sender, EventArgs e)
        {
            //Verifica si el usuario ingresa algo.
            if (!txtConjuntoC.Text.Equals("") && !txtConjuntoC.Text.Trim().Equals("{}"))
            {
                //Asisno el valor inresago a una variable(todo lo cambio a minusculas)
                string C = txtConjuntoC.Text.ToLower();
                if (!conjuntoC.Contains(C))
                {
                    //Este contador me ayuda a identificar si es el primer elemento ha ingresar.
                    countC++;
                    //Si es el primer y equivale a vacio.
                    if (C == "vacio" && countC == 3)
                    {
                        //Redefino el valor de la variable y Guardo en el conjunto lo que se identifica como vacio
                        C = "{ }";
                        //El contador indica que el conjunto es vacio.
                        countC = 1;
                        //Impido que el usuario ingre mas elementos
                        txtConjuntoC.ReadOnly = true;
                        //Le muestro al usuario que es el conjunto es vacio, como el ha indicado
                        txtMostrarC.Text = txtMostrarC.Text + C;
                        conjuntoC.Add(C);
                        //Redifino la variable a vacio Y se la envio a llenarConjuntos() con sus respectivo parametros
                        C = "";
                        llenarConjuntoU(C, aux);
                    }
                    else if (countC == 3)
                    {
                        conjuntoC.Add(C);
                        aux++;
                        txtMostrarC.Text = txtMostrarC.Text + C;
                        llenarConjuntoU(C, aux);
                    }
                    else
                    {
                        conjuntoC.Add(C);
                        aux++;
                        txtMostrarC.Text = txtMostrarC.Text + " , " + C;
                        llenarConjuntoU(C, aux);
                    }
                    //Despues de todos los procedimientos se limpia para el ingreso un proximo elemento.
                    txtConjuntoC.Text = "";
                }
            }
        }
        /// <summary>
        /// Método para ingesar Elementos al conjunto Universal(CojuntoU).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttAgregar_Click(object sender, EventArgs e)
        {
            /*
             * Verifica si el usuario indica que el conjunto universal es vacio y no se ha ingresado elementos a los conjuntos.
             * De ser así, indica que todo es vacio.
             * Sino si el ususario ingreso algo y ya se ingreso algo en algun conjunto, ejecunta el método llenarConjuntoU()c con sus parametros.
             */
            if (txtAgregarAU.Text.Equals("vacio") && !txtAgregarAU.Text.Trim().Equals("{}") && countA == 2 && countB == 2 && countC == 2 )
            {
                txtMostrarA.Text = "{ }";
                txtConjuntoA.ReadOnly = true;

                txtMostrarB.Text = "{ }";
                txtConjuntoB.ReadOnly = true;

                txtMostrarC.Text = "{ }";
                txtConjuntoC.ReadOnly = true;

                txtConjuntoU.Text = "{ }";
                txtAgregarAU.ReadOnly = true;
            }
            else if (!txtAgregarAU.Text.Equals("") && !txtAgregarAU.Text.Trim().Equals("{}") && countA>= 3 || countB >= 3 || countC >= 3)
            {
                aux++;
                string u = txtAgregarAU.Text;
                llenarConjuntoU(u, aux);
            }
            //Despues de todos los procedimientos se limpia para el ingreso un proximo elemento.
            txtAgregarAU.Text = "";
        }

        /// <summary>
        /// Método que es encarga de llenar el conjuntoU con todos los elementos del los conjuntos y los que están
        /// por fuera.
        /// </summary>
        /// <param name="e">Este para metro es el elemento que se va agregar al conjuntoU.
        /// Ya sea de los elementos de los conjuntos o aquellos qeu estan por fuera.</param>
        /// 
        /// <param name="i">Este parametro me indica en que conjunto se ingreso el primer valor que se añade al conjuntoU.
        ///  Se usa para forma estetica que aparece en pantalla</param>
        public void llenarConjuntoU(string e, int i)
        {
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

        /// <summary>
        /// Método que que seencarga de hallar las intersecciones de los conjuntos.
        /// </summary>
        public void hallarIntersepciones(int j, string e)
        {
            //Se realizan la operacción de interseccion dee los conjuntos
            HashSet<string> intrAB = new HashSet<string>(conjuntoA);
            intrAB.IntersectWith(conjuntoB);

            HashSet<string> intrAC = new HashSet<string>(conjuntoA);
            intrAC.IntersectWith(conjuntoC);

            HashSet<string> intrBC = new HashSet<string>(conjuntoB);
            intrBC.IntersectWith(conjuntoC);

            HashSet<string> intrABC = new HashSet<string>(intrAB);
            intrABC.IntersectWith(conjuntoC);
            if (j == 0)
            {
                //Método para graficar los conjuntos
                graficarConjuntos(1, intrAB, intrAC);
                graficarConjuntos(2, intrAB, intrBC);
                graficarConjuntos(3, intrBC, intrAC);
                //Métodoo para Graficar las interssecciones
                graficarIntersecciones(1, intrAB, intrABC);
                graficarIntersecciones(2, intrAC, intrABC);
                graficarIntersecciones(3, intrBC, intrABC);

                //Recorre al interseccion de los tres conjuntos y va imprimiendo sus elementos
                foreach (string i in intrABC)
                {
                    txtElementosABC.Text = txtElementosABC.Text + " " + i;
                }

                //Recorre al connuntoU para saber cuales son los elementos que estar en el Universal
                foreach (string i in conjuntoU)
                {
                    if (!intrAB.Contains(i) && !intrAC.Contains(i) && !intrBC.Contains(i) &&
                        !conjuntoA.Contains(i) && !conjuntoB.Contains(i) && !conjuntoC.Contains(i))
                    {
                        txtElementosU.Text = txtElementosU.Text + " " + i;
                    }
                }
            }
            else
            {
                if (intrABC.Contains(e) || intrAB.Contains(e) || intrAC.Contains(e) || intrBC.Contains(e))
                {
                    if (intrABC.Contains(e))
                    {
                        txtElementosABC.BackColor = Color.Orange;
                    }
                    if (intrAB.Contains(e))
                    {
                        txtElementosAB.BackColor = Color.Orange;
                    }
                    if (intrAC.Contains(e))
                    {
                        txtElementosAC.BackColor = Color.Orange;
                    }
                    if (intrBC.Contains(e))
                    {
                        txtElementosBC.BackColor = Color.Orange;
                    }
                }
                else if(conjuntoA.Contains(e) || conjuntoB.Contains(e) || conjuntoC.Contains(e) || conjuntoU.Contains(e))
                {
                    if(conjuntoA.Contains(e))
                    {
                        txtElementosA.BackColor = Color.Orange;
                    }
                    if (conjuntoB.Contains(e))
                    {
                        txtElementosB.BackColor = Color.Orange;
                    }
                    if (conjuntoC.Contains(e))
                    {
                        txtElementosC.BackColor = Color.Orange;
                    }
                    if (conjuntoU.Contains(e) && conjuntoA.Contains(e) && conjuntoB.Contains(e) && conjuntoC.Contains(e))
                    {
                        txtElementosU.BackColor = Color.Orange;
                    }
                }
            }
        }

        public void colorNormal()
        {
            txtElementosA.BackColor = Color.WhiteSmoke;
            txtElementosB.BackColor = Color.WhiteSmoke;
            txtElementosC.BackColor = Color.WhiteSmoke;
            txtElementosU.BackColor = Color.WhiteSmoke;

            txtElementosAB.BackColor = Color.WhiteSmoke;
            txtElementosAC.BackColor = Color.WhiteSmoke;
            txtElementosBC.BackColor = Color.WhiteSmoke;
            txtElementosABC.BackColor = Color.WhiteSmoke;
        }
        /// <summary>
        /// Método que se encarga de graficar los elmentos de los conjuntos que no se encuentran en las intersecciones. 
        /// </summary>
        /// <param name="j">Parametro que me indica el caso(Conjunto) para realixar las comparaciones y determinar donde 
        /// se deben imprimir en la pantalla los elementos</param>
        /// <param name="inter1">Es una de las intersseciones posibles de los conjuntos</param>
        /// <param name="inter2">Es una de las intersseciones posibles de los conjuntos</param>
        public void graficarConjuntos(int j, HashSet<string> inter1, HashSet<string> inter2)
        {
            //Se usa para imprimir los resultados segun los casos(cada caso se refiere a un conjunto)
            switch(j)
            {
                case 1:
                    foreach(string i in conjuntoA)
                    {
                        if (!inter1.Contains(i) && !inter2.Contains(i))
                        {
                            txtElementosA.Text = txtElementosA.Text  + " " + i;
                        }
                        else
                        {
                            continue;
                        }
                    }
                break;

                case 2:
                    foreach (string i in conjuntoB)
                    {
                        if (!inter1.Contains(i) && !inter2.Contains(i))
                        {
                            txtElementosB.Text = txtElementosB.Text + " " + i;
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
                        if (!inter1.Contains(i) && !inter2.Contains(i))
                        {
                            txtElementosC.Text = txtElementosC.Text + " " + i;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
            }
        }

        public void graficarIntersecciones(int j, HashSet<string> inter, HashSet<string> interABC)
        {
            switch (j)
            {
                case 1:
                    foreach (string i in inter)
                    {
                        if (!interABC.Contains(i))
                        {
                            txtElementosAB.Text = txtElementosAB.Text + " " + i;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;

                case 2:
                    foreach (string i in inter)
                    {
                        if (!interABC.Contains(i))
                        {
                            txtElementosAC.Text = txtElementosAC.Text + " " + i;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;

                case 3:
                    foreach (string i in inter)
                    {
                        if (!interABC.Contains(i))
                        {
                            txtElementosBC.Text = txtElementosBC.Text + " " + i;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
            }
        }
        /// <summary>
        /// Método que se encarga de mostrar los resulttados de lass operaciones que se indican en el problema.
        /// </summary>
        /// <param name="p">Este parametro indica el resultado final de cada operación ya definida</param>
        public void imprimirResultados(HashSet<string> p)
        {
            //Realiza la interación al resultado final 
            foreach( string i in p)
            {
                //Me indica en que elemento voy, ya que no se recorre sino que se realiza una interacción.
                counter++;
                //Para saber como se muestran los resultados en la pantalla.
                if(counter == 1)
                {
                    txtOperaciones.Text = txtOperaciones.Text + i;
                    hallarIntersepciones(1, i);
                }
                else
                {
                    txtOperaciones.Text = txtOperaciones.Text + "," + i;
                    hallarIntersepciones(1, i);
                }
            }
        }

        /*
         * Metodos de las operaciones requeridas.
         */
            //Primera Operación.
         private void button1_Click_1(object sender, EventArgs e)
        {
            //Me indica si ya se indico que ya ingresaron tods elementos y sino se muestra un mensaje indicando que es necesario.
            if (countNoAgregarMas >= 1)
            {
                colorNormal();
                //Se limpia el espacio donde se muestra el resulatdo de las operaciones. 
                txtOperaciones.Text = "";
                HashSet<string> dfSimetrica = new HashSet<string>(conjuntoA);
                dfSimetrica.SymmetricExceptWith(conjuntoB);
                HashSet<string> comple = new HashSet<string>(conjuntoU);
                comple.ExceptWith(dfSimetrica);
                HashSet<string> dfC = new HashSet<string>(comple);
                dfC.ExceptWith(conjuntoC);
                imprimirResultados(dfC);
                counter = 0;

                //Si no hay ningun elemento se muestra que es vacio.
                if(txtOperaciones.Text.Equals(""))
                {
                    txtOperaciones.Text = "{ }";
                }
            }
            else
            {
                MessageBox.Show("Señor Usuario Primero debe Terminar de llenar los conjuntos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Segunda operación.
        private void btt2Operacion_Click(object sender, EventArgs e)
        {
            if (countNoAgregarMas >= 1)
            {
                colorNormal();
                txtOperaciones.Text = "";
                HashSet<string> dfSimeBC = new HashSet<string>(conjuntoB);
                dfSimeBC.SymmetricExceptWith(conjuntoC);
                HashSet<string> compleA = new HashSet<string>(conjuntoU);
                compleA.ExceptWith(conjuntoA);
                HashSet<string> df1Y2 = new HashSet<string>(dfSimeBC);
                df1Y2.ExceptWith(compleA);
                imprimirResultados(df1Y2);
                counter = 0;
                if (txtOperaciones.Text.Equals(""))
                {
                    txtOperaciones.Text = "{ }";
                }
            }
            else
            {
                MessageBox.Show("Señor Usuario Primero debe Terminar de llenar los conjuntos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Tercera operación
        private void button1_Click(object sender, EventArgs e)
        {
            if (countNoAgregarMas >= 1)
            {
                colorNormal();
                txtOperaciones.Text = "";
                HashSet<string> dfAB = new HashSet<string>(conjuntoA);
                dfAB.ExceptWith(conjuntoB);
                HashSet<string> comple = new HashSet<string>(conjuntoU);
                comple.ExceptWith(dfAB);
                HashSet<string> dfSime = new HashSet<string>(comple);
                dfSime.SymmetricExceptWith(conjuntoC);
                imprimirResultados(dfSime);
                counter = 0;
                if (txtOperaciones.Text.Equals(""))
                {
                    txtOperaciones.Text = "{ }";
                }
            }
            else
            {
                MessageBox.Show("Señor Usuario Primero debe Terminar de llenar los conjuntos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Cuarta operación.
        private void btt_Click(object sender, EventArgs e)
        {
            if (countNoAgregarMas >= 1)
            {
                colorNormal();
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
                if (txtOperaciones.Text.Equals(""))
                {
                    txtOperaciones.Text = "{ }";
                }
            }
            else
            {
                MessageBox.Show("Señor Usuario Primero debe Terminar de llenar los conjuntos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Método para cuando el usuario indica que ya ha ingresado todo los elementos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            /*
             * Verifica si se ha ingresado por lo menos un elemento a cada conjunto  y se impide que se ingresen mas elementos
             * a los conjuntos o al universal y de no ser así se le indica al usuario que debe llenar los conjuntos 
             */
            if (!txtMostrarA.Text.Equals("") && !txtMostrarB.Text.Equals("") && !txtMostrarC.Text.Equals(""))
            {
                hallarIntersepciones(0, "a");
                txtConjuntoA.ReadOnly = true;
                txtConjuntoB.ReadOnly = true;
                txtConjuntoC.ReadOnly = true;
                txtAgregarAU.ReadOnly = true;
                countNoAgregarMas++;
            }
            else
            {
                MessageBox.Show("Debe llenar todos los conjuntos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


    



