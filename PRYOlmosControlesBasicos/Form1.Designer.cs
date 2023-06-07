namespace PRYOlmosControlesBasicos
{
    partial class frmEjemplo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjemplo));
            this.lblEjeY = new System.Windows.Forms.Label();
            this.lblEjeX = new System.Windows.Forms.Label();
            this.chkRojo = new System.Windows.Forms.CheckBox();
            this.chkAzul = new System.Windows.Forms.CheckBox();
            this.chkAmarillo = new System.Windows.Forms.CheckBox();
            this.lblEjemplo = new System.Windows.Forms.Label();
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
            // chkRojo
            // 
            this.chkRojo.AutoSize = true;
            this.chkRojo.Location = new System.Drawing.Point(36, 77);
            this.chkRojo.Name = "chkRojo";
            this.chkRojo.Size = new System.Drawing.Size(48, 17);
            this.chkRojo.TabIndex = 2;
            this.chkRojo.Text = "Rojo";
            this.chkRojo.UseVisualStyleBackColor = true;
            this.chkRojo.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // chkAzul
            // 
            this.chkAzul.AutoSize = true;
            this.chkAzul.Location = new System.Drawing.Point(36, 101);
            this.chkAzul.Name = "chkAzul";
            this.chkAzul.Size = new System.Drawing.Size(46, 17);
            this.chkAzul.TabIndex = 3;
            this.chkAzul.Text = "Azul";
            this.chkAzul.UseVisualStyleBackColor = true;
            this.chkAzul.CheckedChanged += new System.EventHandler(this.chkAzul_CheckedChanged);
            // 
            // chkAmarillo
            // 
            this.chkAmarillo.AutoSize = true;
            this.chkAmarillo.Location = new System.Drawing.Point(36, 125);
            this.chkAmarillo.Name = "chkAmarillo";
            this.chkAmarillo.Size = new System.Drawing.Size(62, 17);
            this.chkAmarillo.TabIndex = 4;
            this.chkAmarillo.Text = "Amarillo";
            this.chkAmarillo.UseVisualStyleBackColor = true;
            this.chkAmarillo.CheckedChanged += new System.EventHandler(this.chkAmarillo_CheckedChanged);
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEjemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplo.Location = new System.Drawing.Point(36, 174);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(181, 27);
            this.lblEjemplo.TabIndex = 5;
            this.lblEjemplo.Text = "Texto de Ejemplo";
            // 
            // frmEjemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.chkAmarillo);
            this.Controls.Add(this.chkAzul);
            this.Controls.Add(this.chkRojo);
            this.Controls.Add(this.lblEjeX);
            this.Controls.Add(this.lblEjeY);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEjemplo";
            this.Text = "Prueva de Controles Comunes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEjeY;
        private System.Windows.Forms.Label lblEjeX;
        private System.Windows.Forms.CheckBox chkRojo;
        private System.Windows.Forms.CheckBox chkAzul;
        private System.Windows.Forms.CheckBox chkAmarillo;
        private System.Windows.Forms.Label lblEjemplo;
    }
}

