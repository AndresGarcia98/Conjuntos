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
            this.lbConjuntoA = new System.Windows.Forms.Label();
            this.lbConjuntoB = new System.Windows.Forms.Label();
            this.lbConjuntoC = new System.Windows.Forms.Label();
            this.txtConjuntoA = new System.Windows.Forms.TextBox();
            this.txtConjuntoB = new System.Windows.Forms.TextBox();
            this.txtConjuntoC = new System.Windows.Forms.TextBox();
            this.bttGuardarA = new System.Windows.Forms.Button();
            this.bttGuardarB = new System.Windows.Forms.Button();
            this.bttGuardarC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConjuntoA
            // 
            this.lbConjuntoA.AutoSize = true;
            this.lbConjuntoA.Location = new System.Drawing.Point(12, 15);
            this.lbConjuntoA.Name = "lbConjuntoA";
            this.lbConjuntoA.Size = new System.Drawing.Size(187, 13);
            this.lbConjuntoA.TabIndex = 0;
            this.lbConjuntoA.Text = "Cantidad de elementos del Conjunto A";
            // 
            // lbConjuntoB
            // 
            this.lbConjuntoB.AutoSize = true;
            this.lbConjuntoB.Location = new System.Drawing.Point(255, 15);
            this.lbConjuntoB.Name = "lbConjuntoB";
            this.lbConjuntoB.Size = new System.Drawing.Size(187, 13);
            this.lbConjuntoB.TabIndex = 1;
            this.lbConjuntoB.Text = "Cantidad de elementos del Conjunto B";
            // 
            // lbConjuntoC
            // 
            this.lbConjuntoC.AutoSize = true;
            this.lbConjuntoC.Location = new System.Drawing.Point(484, 15);
            this.lbConjuntoC.Name = "lbConjuntoC";
            this.lbConjuntoC.Size = new System.Drawing.Size(187, 13);
            this.lbConjuntoC.TabIndex = 2;
            this.lbConjuntoC.Text = "Cantidad de elementos del Conjunto C";
            // 
            // txtConjuntoA
            // 
            this.txtConjuntoA.Location = new System.Drawing.Point(68, 31);
            this.txtConjuntoA.Name = "txtConjuntoA";
            this.txtConjuntoA.Size = new System.Drawing.Size(45, 20);
            this.txtConjuntoA.TabIndex = 3;
            // 
            // txtConjuntoB
            // 
            this.txtConjuntoB.Location = new System.Drawing.Point(312, 31);
            this.txtConjuntoB.Name = "txtConjuntoB";
            this.txtConjuntoB.Size = new System.Drawing.Size(45, 20);
            this.txtConjuntoB.TabIndex = 4;
            // 
            // txtConjuntoC
            // 
            this.txtConjuntoC.Location = new System.Drawing.Point(549, 31);
            this.txtConjuntoC.Name = "txtConjuntoC";
            this.txtConjuntoC.Size = new System.Drawing.Size(45, 20);
            this.txtConjuntoC.TabIndex = 5;
            // 
            // bttGuardarA
            // 
            this.bttGuardarA.Location = new System.Drawing.Point(56, 57);
            this.bttGuardarA.Name = "bttGuardarA";
            this.bttGuardarA.Size = new System.Drawing.Size(69, 20);
            this.bttGuardarA.TabIndex = 6;
            this.bttGuardarA.Text = "Guardar";
            this.bttGuardarA.UseVisualStyleBackColor = true;
            this.bttGuardarA.Click += new System.EventHandler(this.bttGuardarA_Click);
            // 
            // bttGuardarB
            // 
            this.bttGuardarB.Location = new System.Drawing.Point(299, 57);
            this.bttGuardarB.Name = "bttGuardarB";
            this.bttGuardarB.Size = new System.Drawing.Size(69, 20);
            this.bttGuardarB.TabIndex = 7;
            this.bttGuardarB.Text = "Guardar";
            this.bttGuardarB.UseVisualStyleBackColor = true;
            this.bttGuardarB.Click += new System.EventHandler(this.bttGuardarB_Click);
            // 
            // bttGuardarC
            // 
            this.bttGuardarC.Location = new System.Drawing.Point(539, 57);
            this.bttGuardarC.Name = "bttGuardarC";
            this.bttGuardarC.Size = new System.Drawing.Size(69, 20);
            this.bttGuardarC.TabIndex = 8;
            this.bttGuardarC.Text = "Guardar";
            this.bttGuardarC.UseVisualStyleBackColor = true;
            this.bttGuardarC.Click += new System.EventHandler(this.bttGuardarC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 461);
            this.Controls.Add(this.bttGuardarC);
            this.Controls.Add(this.bttGuardarB);
            this.Controls.Add(this.bttGuardarA);
            this.Controls.Add(this.txtConjuntoC);
            this.Controls.Add(this.txtConjuntoB);
            this.Controls.Add(this.txtConjuntoA);
            this.Controls.Add(this.lbConjuntoC);
            this.Controls.Add(this.lbConjuntoB);
            this.Controls.Add(this.lbConjuntoA);
            this.Name = "Form1";
            this.Text = "Conjuntos";
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
    }
}

