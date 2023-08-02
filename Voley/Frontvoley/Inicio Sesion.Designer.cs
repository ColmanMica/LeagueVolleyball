namespace Frontvoley
{
    partial class Inicio_Sesion
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
            this.INICIAR = new System.Windows.Forms.Button();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // INICIAR
            // 
            this.INICIAR.BackColor = System.Drawing.Color.LightSeaGreen;
            this.INICIAR.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INICIAR.ForeColor = System.Drawing.SystemColors.Control;
            this.INICIAR.Location = new System.Drawing.Point(603, 310);
            this.INICIAR.Name = "INICIAR";
            this.INICIAR.Size = new System.Drawing.Size(128, 66);
            this.INICIAR.TabIndex = 9;
            this.INICIAR.Text = "INICIAR";
            this.INICIAR.UseVisualStyleBackColor = false;
            this.INICIAR.Click += new System.EventHandler(this.INICIAR_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(168, 206);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(125, 26);
            this.Contraseña.TabIndex = 8;
            this.Contraseña.Text = "Contraseña";
            this.Contraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.Location = new System.Drawing.Point(168, 115);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(80, 26);
            this.Correo.TabIndex = 7;
            this.Correo.Text = "Correo";
            this.Correo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContraseña.Location = new System.Drawing.Point(340, 206);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtContraseña.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCorreo.Location = new System.Drawing.Point(340, 115);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 22);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(26, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(705, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Iniciar sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.INICIAR);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Name = "Inicio_Sesion";
            this.Text = "Inicio_Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button INICIAR;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button button1;
    }
}