namespace Conjunto
{
    partial class Form2
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
            this.bttGuardar = new System.Windows.Forms.Button();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.txtConjunto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttGuardar
            // 
            this.bttGuardar.Location = new System.Drawing.Point(95, 63);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(75, 23);
            this.bttGuardar.TabIndex = 0;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = true;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(13, 13);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(0, 13);
            this.lbMensaje.TabIndex = 1;
            // 
            // txtConjunto
            // 
            this.txtConjunto.Location = new System.Drawing.Point(109, 37);
            this.txtConjunto.Name = "txtConjunto";
            this.txtConjunto.Size = new System.Drawing.Size(47, 20);
            this.txtConjunto.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 120);
            this.Controls.Add(this.txtConjunto);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.bttGuardar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttGuardar;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.TextBox txtConjunto;
    }
}