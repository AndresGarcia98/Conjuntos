namespace Conjunto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbConjuntoA = new System.Windows.Forms.Label();
            this.lbConjuntoB = new System.Windows.Forms.Label();
            this.lbConjuntoC = new System.Windows.Forms.Label();
            this.txtConjuntoA = new System.Windows.Forms.TextBox();
            this.txtConjuntoB = new System.Windows.Forms.TextBox();
            this.txtConjuntoC = new System.Windows.Forms.TextBox();
            this.bttGuardarA = new System.Windows.Forms.Button();
            this.bttGuardarB = new System.Windows.Forms.Button();
            this.bttGuardarC = new System.Windows.Forms.Button();
            this.grbxConjuntos = new System.Windows.Forms.GroupBox();
            this.bttReiniciar = new System.Windows.Forms.Button();
            this.btt4Operacion = new System.Windows.Forms.Button();
            this.btt2Operacion = new System.Windows.Forms.Button();
            this.btt3Operacion = new System.Windows.Forms.Button();
            this.lbMensajeVacio = new System.Windows.Forms.Label();
            this.bttTerminarConjuntos = new System.Windows.Forms.Button();
            this.btt1Operacion = new System.Windows.Forms.Button();
            this.txtOperaciones = new System.Windows.Forms.TextBox();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.txtAgregarAU = new System.Windows.Forms.TextBox();
            this.txtConjuntoU = new System.Windows.Forms.TextBox();
            this.lbConjuntoU = new System.Windows.Forms.Label();
            this.txtMostrarC = new System.Windows.Forms.TextBox();
            this.txtMostrarB = new System.Windows.Forms.TextBox();
            this.txtMostrarA = new System.Windows.Forms.TextBox();
            this.lbCjC = new System.Windows.Forms.Label();
            this.lbCjB = new System.Windows.Forms.Label();
            this.lbCjA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtElementosA = new System.Windows.Forms.TextBox();
            this.txtElementosAB = new System.Windows.Forms.TextBox();
            this.txtElementosAC = new System.Windows.Forms.TextBox();
            this.txtElementosABC = new System.Windows.Forms.TextBox();
            this.txtElementosB = new System.Windows.Forms.TextBox();
            this.txtElementosC = new System.Windows.Forms.TextBox();
            this.txtElementosBC = new System.Windows.Forms.TextBox();
            this.txtElementosU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbxConjuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbConjuntoA
            // 
            this.lbConjuntoA.AutoSize = true;
            this.lbConjuntoA.Location = new System.Drawing.Point(6, 16);
            this.lbConjuntoA.Name = "lbConjuntoA";
            this.lbConjuntoA.Size = new System.Drawing.Size(252, 13);
            this.lbConjuntoA.TabIndex = 0;
            this.lbConjuntoA.Text = "Ingresar el elemento que desea añadir al conjunto A";
            // 
            // lbConjuntoB
            // 
            this.lbConjuntoB.AutoSize = true;
            this.lbConjuntoB.Location = new System.Drawing.Point(6, 117);
            this.lbConjuntoB.Name = "lbConjuntoB";
            this.lbConjuntoB.Size = new System.Drawing.Size(252, 13);
            this.lbConjuntoB.TabIndex = 1;
            this.lbConjuntoB.Text = "Ingresar el elemento que desea añadir al conjunto B";
            // 
            // lbConjuntoC
            // 
            this.lbConjuntoC.AutoSize = true;
            this.lbConjuntoC.Location = new System.Drawing.Point(6, 219);
            this.lbConjuntoC.Name = "lbConjuntoC";
            this.lbConjuntoC.Size = new System.Drawing.Size(252, 13);
            this.lbConjuntoC.TabIndex = 2;
            this.lbConjuntoC.Text = "Ingresar el elemento que desea añadir al conjunto C";
            // 
            // txtConjuntoA
            // 
            this.txtConjuntoA.Location = new System.Drawing.Point(62, 32);
            this.txtConjuntoA.Name = "txtConjuntoA";
            this.txtConjuntoA.Size = new System.Drawing.Size(45, 20);
            this.txtConjuntoA.TabIndex = 3;
            // 
            // txtConjuntoB
            // 
            this.txtConjuntoB.Location = new System.Drawing.Point(62, 133);
            this.txtConjuntoB.Name = "txtConjuntoB";
            this.txtConjuntoB.Size = new System.Drawing.Size(45, 20);
            this.txtConjuntoB.TabIndex = 4;
            // 
            // txtConjuntoC
            // 
            this.txtConjuntoC.Location = new System.Drawing.Point(62, 235);
            this.txtConjuntoC.Name = "txtConjuntoC";
            this.txtConjuntoC.Size = new System.Drawing.Size(45, 20);
            this.txtConjuntoC.TabIndex = 5;
            // 
            // bttGuardarA
            // 
            this.bttGuardarA.Location = new System.Drawing.Point(51, 58);
            this.bttGuardarA.Name = "bttGuardarA";
            this.bttGuardarA.Size = new System.Drawing.Size(69, 20);
            this.bttGuardarA.TabIndex = 6;
            this.bttGuardarA.Text = "Guardar";
            this.bttGuardarA.UseVisualStyleBackColor = true;
            this.bttGuardarA.Click += new System.EventHandler(this.bttGuardarA_Click);
            // 
            // bttGuardarB
            // 
            this.bttGuardarB.Location = new System.Drawing.Point(51, 159);
            this.bttGuardarB.Name = "bttGuardarB";
            this.bttGuardarB.Size = new System.Drawing.Size(69, 20);
            this.bttGuardarB.TabIndex = 7;
            this.bttGuardarB.Text = "Guardar";
            this.bttGuardarB.UseVisualStyleBackColor = true;
            this.bttGuardarB.Click += new System.EventHandler(this.bttGuardarB_Click);
            // 
            // bttGuardarC
            // 
            this.bttGuardarC.Location = new System.Drawing.Point(51, 261);
            this.bttGuardarC.Name = "bttGuardarC";
            this.bttGuardarC.Size = new System.Drawing.Size(69, 20);
            this.bttGuardarC.TabIndex = 8;
            this.bttGuardarC.Text = "Guardar";
            this.bttGuardarC.UseVisualStyleBackColor = true;
            this.bttGuardarC.Click += new System.EventHandler(this.bttGuardarC_Click);
            // 
            // grbxConjuntos
            // 
            this.grbxConjuntos.Controls.Add(this.bttReiniciar);
            this.grbxConjuntos.Controls.Add(this.btt4Operacion);
            this.grbxConjuntos.Controls.Add(this.btt2Operacion);
            this.grbxConjuntos.Controls.Add(this.btt3Operacion);
            this.grbxConjuntos.Controls.Add(this.lbMensajeVacio);
            this.grbxConjuntos.Controls.Add(this.bttTerminarConjuntos);
            this.grbxConjuntos.Controls.Add(this.btt1Operacion);
            this.grbxConjuntos.Controls.Add(this.txtOperaciones);
            this.grbxConjuntos.Controls.Add(this.bttAgregar);
            this.grbxConjuntos.Controls.Add(this.txtAgregarAU);
            this.grbxConjuntos.Controls.Add(this.txtConjuntoU);
            this.grbxConjuntos.Controls.Add(this.lbConjuntoU);
            this.grbxConjuntos.Controls.Add(this.txtMostrarC);
            this.grbxConjuntos.Controls.Add(this.txtMostrarB);
            this.grbxConjuntos.Controls.Add(this.txtMostrarA);
            this.grbxConjuntos.Controls.Add(this.lbCjC);
            this.grbxConjuntos.Controls.Add(this.lbCjB);
            this.grbxConjuntos.Controls.Add(this.lbCjA);
            this.grbxConjuntos.Controls.Add(this.txtConjuntoB);
            this.grbxConjuntos.Controls.Add(this.bttGuardarB);
            this.grbxConjuntos.Controls.Add(this.bttGuardarC);
            this.grbxConjuntos.Controls.Add(this.lbConjuntoA);
            this.grbxConjuntos.Controls.Add(this.bttGuardarA);
            this.grbxConjuntos.Controls.Add(this.txtConjuntoC);
            this.grbxConjuntos.Controls.Add(this.lbConjuntoB);
            this.grbxConjuntos.Controls.Add(this.txtConjuntoA);
            this.grbxConjuntos.Controls.Add(this.lbConjuntoC);
            this.grbxConjuntos.Location = new System.Drawing.Point(12, 12);
            this.grbxConjuntos.Name = "grbxConjuntos";
            this.grbxConjuntos.Size = new System.Drawing.Size(473, 544);
            this.grbxConjuntos.TabIndex = 21;
            this.grbxConjuntos.TabStop = false;
            // 
            // bttReiniciar
            // 
            this.bttReiniciar.Location = new System.Drawing.Point(309, 360);
            this.bttReiniciar.Name = "bttReiniciar";
            this.bttReiniciar.Size = new System.Drawing.Size(75, 23);
            this.bttReiniciar.TabIndex = 39;
            this.bttReiniciar.Text = "Reiniciar";
            this.bttReiniciar.UseVisualStyleBackColor = true;
            this.bttReiniciar.Click += new System.EventHandler(this.bttReiniciar_Click);
            // 
            // btt4Operacion
            // 
            this.btt4Operacion.Location = new System.Drawing.Point(142, 485);
            this.btt4Operacion.Name = "btt4Operacion";
            this.btt4Operacion.Size = new System.Drawing.Size(130, 20);
            this.btt4Operacion.TabIndex = 38;
            this.btt4Operacion.Text = "(B - A)\' intr C\'";
            this.btt4Operacion.UseVisualStyleBackColor = true;
            this.btt4Operacion.Click += new System.EventHandler(this.btt_Click);
            // 
            // btt2Operacion
            // 
            this.btt2Operacion.Location = new System.Drawing.Point(6, 485);
            this.btt2Operacion.Name = "btt2Operacion";
            this.btt2Operacion.Size = new System.Drawing.Size(130, 20);
            this.btt2Operacion.TabIndex = 37;
            this.btt2Operacion.Text = "(B dfs C) dfs A\'";
            this.btt2Operacion.UseVisualStyleBackColor = true;
            this.btt2Operacion.Click += new System.EventHandler(this.btt2Operacion_Click);
            // 
            // btt3Operacion
            // 
            this.btt3Operacion.Location = new System.Drawing.Point(142, 459);
            this.btt3Operacion.Name = "btt3Operacion";
            this.btt3Operacion.Size = new System.Drawing.Size(130, 20);
            this.btt3Operacion.TabIndex = 36;
            this.btt3Operacion.Text = "(B - A)\' dfs C";
            this.btt3Operacion.UseVisualStyleBackColor = true;
            this.btt3Operacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMensajeVacio
            // 
            this.lbMensajeVacio.AutoSize = true;
            this.lbMensajeVacio.ForeColor = System.Drawing.Color.Red;
            this.lbMensajeVacio.Location = new System.Drawing.Point(245, 35);
            this.lbMensajeVacio.Name = "lbMensajeVacio";
            this.lbMensajeVacio.Size = new System.Drawing.Size(201, 13);
            this.lbMensajeVacio.TabIndex = 35;
            this.lbMensajeVacio.Text = " \"vacio\" si el desea algun conjunto vacio";
            // 
            // bttTerminarConjuntos
            // 
            this.bttTerminarConjuntos.Location = new System.Drawing.Point(84, 390);
            this.bttTerminarConjuntos.Name = "bttTerminarConjuntos";
            this.bttTerminarConjuntos.Size = new System.Drawing.Size(70, 47);
            this.bttTerminarConjuntos.TabIndex = 34;
            this.bttTerminarConjuntos.Text = "Termine de llenar los Conjuntos";
            this.bttTerminarConjuntos.UseVisualStyleBackColor = true;
            this.bttTerminarConjuntos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btt1Operacion
            // 
            this.btt1Operacion.Location = new System.Drawing.Point(6, 459);
            this.btt1Operacion.Name = "btt1Operacion";
            this.btt1Operacion.Size = new System.Drawing.Size(130, 20);
            this.btt1Operacion.TabIndex = 33;
            this.btt1Operacion.Text = "(A dfs B)\'- C";
            this.btt1Operacion.UseVisualStyleBackColor = true;
            this.btt1Operacion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtOperaciones
            // 
            this.txtOperaciones.Location = new System.Drawing.Point(71, 511);
            this.txtOperaciones.Name = "txtOperaciones";
            this.txtOperaciones.ReadOnly = true;
            this.txtOperaciones.Size = new System.Drawing.Size(159, 20);
            this.txtOperaciones.TabIndex = 32;
            // 
            // bttAgregar
            // 
            this.bttAgregar.Location = new System.Drawing.Point(123, 364);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(94, 20);
            this.bttAgregar.TabIndex = 31;
            this.bttAgregar.Text = "Agregar a U";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // txtAgregarAU
            // 
            this.txtAgregarAU.Location = new System.Drawing.Point(71, 364);
            this.txtAgregarAU.Name = "txtAgregarAU";
            this.txtAgregarAU.Size = new System.Drawing.Size(49, 20);
            this.txtAgregarAU.TabIndex = 30;
            // 
            // txtConjuntoU
            // 
            this.txtConjuntoU.Location = new System.Drawing.Point(71, 338);
            this.txtConjuntoU.Name = "txtConjuntoU";
            this.txtConjuntoU.ReadOnly = true;
            this.txtConjuntoU.Size = new System.Drawing.Size(146, 20);
            this.txtConjuntoU.TabIndex = 29;
            // 
            // lbConjuntoU
            // 
            this.lbConjuntoU.AutoSize = true;
            this.lbConjuntoU.Location = new System.Drawing.Point(0, 338);
            this.lbConjuntoU.Name = "lbConjuntoU";
            this.lbConjuntoU.Size = new System.Drawing.Size(66, 13);
            this.lbConjuntoU.TabIndex = 28;
            this.lbConjuntoU.Text = "Conjunto U: ";
            // 
            // txtMostrarC
            // 
            this.txtMostrarC.Location = new System.Drawing.Point(71, 295);
            this.txtMostrarC.Name = "txtMostrarC";
            this.txtMostrarC.ReadOnly = true;
            this.txtMostrarC.Size = new System.Drawing.Size(146, 20);
            this.txtMostrarC.TabIndex = 27;
            // 
            // txtMostrarB
            // 
            this.txtMostrarB.Location = new System.Drawing.Point(71, 196);
            this.txtMostrarB.Name = "txtMostrarB";
            this.txtMostrarB.ReadOnly = true;
            this.txtMostrarB.Size = new System.Drawing.Size(146, 20);
            this.txtMostrarB.TabIndex = 26;
            // 
            // txtMostrarA
            // 
            this.txtMostrarA.Location = new System.Drawing.Point(71, 94);
            this.txtMostrarA.Name = "txtMostrarA";
            this.txtMostrarA.ReadOnly = true;
            this.txtMostrarA.Size = new System.Drawing.Size(146, 20);
            this.txtMostrarA.TabIndex = 25;
            // 
            // lbCjC
            // 
            this.lbCjC.AutoSize = true;
            this.lbCjC.Location = new System.Drawing.Point(0, 295);
            this.lbCjC.Name = "lbCjC";
            this.lbCjC.Size = new System.Drawing.Size(65, 13);
            this.lbCjC.TabIndex = 24;
            this.lbCjC.Text = "Conjunto C: ";
            // 
            // lbCjB
            // 
            this.lbCjB.AutoSize = true;
            this.lbCjB.Location = new System.Drawing.Point(0, 196);
            this.lbCjB.Name = "lbCjB";
            this.lbCjB.Size = new System.Drawing.Size(65, 13);
            this.lbCjB.TabIndex = 23;
            this.lbCjB.Text = "Conjunto B: ";
            // 
            // lbCjA
            // 
            this.lbCjA.AutoSize = true;
            this.lbCjA.Location = new System.Drawing.Point(0, 94);
            this.lbCjA.Name = "lbCjA";
            this.lbCjA.Size = new System.Drawing.Size(65, 13);
            this.lbCjA.TabIndex = 22;
            this.lbCjA.Text = "Conjunto A: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(862, 635);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtElementosA
            // 
            this.txtElementosA.BackColor = System.Drawing.SystemColors.Control;
            this.txtElementosA.Location = new System.Drawing.Point(642, 228);
            this.txtElementosA.Name = "txtElementosA";
            this.txtElementosA.ReadOnly = true;
            this.txtElementosA.Size = new System.Drawing.Size(145, 20);
            this.txtElementosA.TabIndex = 24;
            // 
            // txtElementosAB
            // 
            this.txtElementosAB.Location = new System.Drawing.Point(825, 171);
            this.txtElementosAB.Name = "txtElementosAB";
            this.txtElementosAB.ReadOnly = true;
            this.txtElementosAB.Size = new System.Drawing.Size(179, 20);
            this.txtElementosAB.TabIndex = 25;
            // 
            // txtElementosAC
            // 
            this.txtElementosAC.Location = new System.Drawing.Point(727, 376);
            this.txtElementosAC.Name = "txtElementosAC";
            this.txtElementosAC.ReadOnly = true;
            this.txtElementosAC.Size = new System.Drawing.Size(127, 20);
            this.txtElementosAC.TabIndex = 26;
            // 
            // txtElementosABC
            // 
            this.txtElementosABC.Location = new System.Drawing.Point(832, 284);
            this.txtElementosABC.Name = "txtElementosABC";
            this.txtElementosABC.ReadOnly = true;
            this.txtElementosABC.Size = new System.Drawing.Size(172, 20);
            this.txtElementosABC.TabIndex = 27;
            // 
            // txtElementosB
            // 
            this.txtElementosB.Location = new System.Drawing.Point(1032, 208);
            this.txtElementosB.Name = "txtElementosB";
            this.txtElementosB.ReadOnly = true;
            this.txtElementosB.Size = new System.Drawing.Size(154, 20);
            this.txtElementosB.TabIndex = 28;
            // 
            // txtElementosC
            // 
            this.txtElementosC.Location = new System.Drawing.Point(778, 508);
            this.txtElementosC.Name = "txtElementosC";
            this.txtElementosC.ReadOnly = true;
            this.txtElementosC.Size = new System.Drawing.Size(284, 20);
            this.txtElementosC.TabIndex = 29;
            // 
            // txtElementosBC
            // 
            this.txtElementosBC.Location = new System.Drawing.Point(985, 366);
            this.txtElementosBC.Name = "txtElementosBC";
            this.txtElementosBC.ReadOnly = true;
            this.txtElementosBC.Size = new System.Drawing.Size(131, 20);
            this.txtElementosBC.TabIndex = 30;
            // 
            // txtElementosU
            // 
            this.txtElementosU.Location = new System.Drawing.Point(1054, 609);
            this.txtElementosU.Name = "txtElementosU";
            this.txtElementosU.ReadOnly = true;
            this.txtElementosU.Size = new System.Drawing.Size(261, 20);
            this.txtElementosU.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(740, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1096, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1298, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "U";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 670);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElementosU);
            this.Controls.Add(this.txtElementosBC);
            this.Controls.Add(this.txtElementosC);
            this.Controls.Add(this.txtElementosB);
            this.Controls.Add(this.txtElementosABC);
            this.Controls.Add(this.txtElementosAC);
            this.Controls.Add(this.txtElementosAB);
            this.Controls.Add(this.txtElementosA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbxConjuntos);
            this.Name = "Form1";
            this.Text = "Conjuntos";
            this.grbxConjuntos.ResumeLayout(false);
            this.grbxConjuntos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConjuntoA;
        private System.Windows.Forms.Label lbConjuntoB;
        private System.Windows.Forms.Label lbConjuntoC;
        private System.Windows.Forms.TextBox txtConjuntoA;
        private System.Windows.Forms.TextBox txtConjuntoB;
        private System.Windows.Forms.TextBox txtConjuntoC;
        private System.Windows.Forms.Button bttGuardarA;
        private System.Windows.Forms.Button bttGuardarB;
        private System.Windows.Forms.Button bttGuardarC;
        private System.Windows.Forms.GroupBox grbxConjuntos;
        private System.Windows.Forms.TextBox txtMostrarC;
        private System.Windows.Forms.TextBox txtMostrarB;
        private System.Windows.Forms.TextBox txtMostrarA;
        private System.Windows.Forms.Label lbCjC;
        private System.Windows.Forms.Label lbCjB;
        private System.Windows.Forms.Label lbCjA;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.TextBox txtAgregarAU;
        private System.Windows.Forms.TextBox txtConjuntoU;
        private System.Windows.Forms.Label lbConjuntoU;
        private System.Windows.Forms.TextBox txtOperaciones;
        private System.Windows.Forms.Button btt1Operacion;
        private System.Windows.Forms.Button bttTerminarConjuntos;
        private System.Windows.Forms.Label lbMensajeVacio;
        private System.Windows.Forms.Button btt2Operacion;
        private System.Windows.Forms.Button btt3Operacion;
        private System.Windows.Forms.Button btt4Operacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtElementosA;
        private System.Windows.Forms.TextBox txtElementosAB;
        private System.Windows.Forms.TextBox txtElementosAC;
        private System.Windows.Forms.TextBox txtElementosABC;
        private System.Windows.Forms.TextBox txtElementosB;
        private System.Windows.Forms.TextBox txtElementosC;
        private System.Windows.Forms.TextBox txtElementosBC;
        private System.Windows.Forms.TextBox txtElementosU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttReiniciar;
    }
}

