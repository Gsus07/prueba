namespace BancoGUI
{
    partial class FrmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregar));
            this.btnCuentaAhorro = new System.Windows.Forms.Button();
            this.btnCuentaCorriente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCuentaAhorro
            // 
            this.btnCuentaAhorro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCuentaAhorro.FlatAppearance.BorderSize = 0;
            this.btnCuentaAhorro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.btnCuentaAhorro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentaAhorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentaAhorro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCuentaAhorro.Location = new System.Drawing.Point(276, 248);
            this.btnCuentaAhorro.Name = "btnCuentaAhorro";
            this.btnCuentaAhorro.Size = new System.Drawing.Size(229, 114);
            this.btnCuentaAhorro.TabIndex = 5;
            this.btnCuentaAhorro.Text = "Vuenta de ahorros";
            this.btnCuentaAhorro.UseVisualStyleBackColor = false;
            this.btnCuentaAhorro.Click += new System.EventHandler(this.BtnCuentaAhorro_Click);
            // 
            // btnCuentaCorriente
            // 
            this.btnCuentaCorriente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCuentaCorriente.FlatAppearance.BorderSize = 0;
            this.btnCuentaCorriente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.btnCuentaCorriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentaCorriente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentaCorriente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCuentaCorriente.Location = new System.Drawing.Point(276, 105);
            this.btnCuentaCorriente.Name = "btnCuentaCorriente";
            this.btnCuentaCorriente.Size = new System.Drawing.Size(229, 114);
            this.btnCuentaCorriente.TabIndex = 4;
            this.btnCuentaCorriente.Text = "Cuenta corriente";
            this.btnCuentaCorriente.UseVisualStyleBackColor = false;
            this.btnCuentaCorriente.Click += new System.EventHandler(this.BtnCuentaCorriente_Click);
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCuentaAhorro);
            this.Controls.Add(this.btnCuentaCorriente);
            this.Name = "FrmAgregar";
            this.Text = "FrmAgregar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCuentaAhorro;
        private System.Windows.Forms.Button btnCuentaCorriente;
    }
}