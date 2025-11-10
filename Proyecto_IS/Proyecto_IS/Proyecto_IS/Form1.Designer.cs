namespace Proyecto_IS
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
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnFarmaceutico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedico
            // 
            this.btnMedico.Location = new System.Drawing.Point(58, 22);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(130, 80);
            this.btnMedico.TabIndex = 0;
            this.btnMedico.Text = "Medico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(58, 189);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(130, 80);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnFarmaceutico
            // 
            this.btnFarmaceutico.Location = new System.Drawing.Point(58, 333);
            this.btnFarmaceutico.Name = "btnFarmaceutico";
            this.btnFarmaceutico.Size = new System.Drawing.Size(130, 80);
            this.btnFarmaceutico.TabIndex = 2;
            this.btnFarmaceutico.Text = "Farmaceutico";
            this.btnFarmaceutico.UseVisualStyleBackColor = true;
            this.btnFarmaceutico.Click += new System.EventHandler(this.btnFarmaceutico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 450);
            this.Controls.Add(this.btnFarmaceutico);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnMedico);
            this.Name = "Form1";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnFarmaceutico;
    }
}

