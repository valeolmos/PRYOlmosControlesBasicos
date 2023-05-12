namespace PRYOlmosControlesBasicos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEjeY = new System.Windows.Forms.Label();
            this.lblEjeX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEjeY
            // 
            this.lblEjeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeY.AutoSize = true;
            this.lblEjeY.Location = new System.Drawing.Point(393, 10);
            this.lblEjeY.Name = "lblEjeY";
            this.lblEjeY.Size = new System.Drawing.Size(14, 13);
            this.lblEjeY.TabIndex = 0;
            this.lblEjeY.Text = "Y";
            this.lblEjeY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // lblEjeX
            // 
            this.lblEjeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjeX.AutoSize = true;
            this.lblEjeX.Location = new System.Drawing.Point(393, 36);
            this.lblEjeX.Name = "lblEjeX";
            this.lblEjeX.Size = new System.Drawing.Size(14, 13);
            this.lblEjeX.TabIndex = 1;
            this.lblEjeX.Text = "X";
            this.lblEjeX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.lblEjeX);
            this.Controls.Add(this.lblEjeY);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Titulo de la ventana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjeY;
        private System.Windows.Forms.Label lblEjeX;
    }
}

