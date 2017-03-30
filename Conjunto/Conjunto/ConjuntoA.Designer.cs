namespace Conjunto
{
    partial class ConjuntoA
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
            this.txtConjuntoA = new System.Windows.Forms.TextBox();
            this.bttGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConjuntoA
            // 
            this.lbConjuntoA.AutoSize = true;
            this.lbConjuntoA.Location = new System.Drawing.Point(12, 40);
            this.lbConjuntoA.Name = "lbConjuntoA";
            this.lbConjuntoA.Size = new System.Drawing.Size(179, 13);
            this.lbConjuntoA.TabIndex = 0;
            this.lbConjuntoA.Text = "Ingrese el 1 elemento del conjunto A";
            // 
            // txtConjuntoA
            // 
            this.txtConjuntoA.Location = new System.Drawing.Point(81, 56);
            this.txtConjuntoA.Name = "txtConjuntoA";
            this.txtConjuntoA.Size = new System.Drawing.Size(66, 20);
            this.txtConjuntoA.TabIndex = 1;
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(81, 82);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(66, 23);
            this.bttGuardar.TabIndex = 2;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // ConjuntoA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 127);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.txtConjuntoA);
            this.Controls.Add(this.lbConjuntoA);
            this.Name = "ConjuntoA";
            this.Text = "Conjunto A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConjuntoA;
        private System.Windows.Forms.TextBox txtConjuntoA;
        private System.Windows.Forms.Button bttGuardar;
    }
}