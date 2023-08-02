namespace Frontvoley
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
            this.button1 = new System.Windows.Forms.Button();
            this.Fixture = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(65, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(648, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "League Volleyball";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Fixture
            // 
            this.Fixture.BackColor = System.Drawing.Color.OliveDrab;
            this.Fixture.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fixture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fixture.Location = new System.Drawing.Point(567, 204);
            this.Fixture.Name = "Fixture";
            this.Fixture.Size = new System.Drawing.Size(146, 65);
            this.Fixture.TabIndex = 1;
            this.Fixture.Text = "Fixture";
            this.Fixture.UseVisualStyleBackColor = false;
            this.Fixture.Click += new System.EventHandler(this.Fixture_Click);
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.Color.OliveDrab;
            this.Registrar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Registrar.Location = new System.Drawing.Point(28, 202);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(147, 65);
            this.Registrar.TabIndex = 2;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OliveDrab;
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(291, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 67);
            this.button3.TabIndex = 4;
            this.button3.Text = "INICIAR SESIÓN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.Fixture);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Fixture;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button button3;
    }
}

