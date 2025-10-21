namespace Proyecto_IS
{
    partial class InicioMedicos
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
            this.dgv_HistorialMedico = new System.Windows.Forms.DataGridView();
            this.btnCerrar_Sesion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HistorialMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HistorialMedico
            // 
            this.dgv_HistorialMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HistorialMedico.Location = new System.Drawing.Point(290, 12);
            this.dgv_HistorialMedico.Name = "dgv_HistorialMedico";
            this.dgv_HistorialMedico.RowHeadersWidth = 51;
            this.dgv_HistorialMedico.RowTemplate.Height = 24;
            this.dgv_HistorialMedico.Size = new System.Drawing.Size(868, 628);
            this.dgv_HistorialMedico.TabIndex = 0;
            // 
            // btnCerrar_Sesion
            // 
            this.btnCerrar_Sesion.Location = new System.Drawing.Point(12, 617);
            this.btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            this.btnCerrar_Sesion.Size = new System.Drawing.Size(101, 23);
            this.btnCerrar_Sesion.TabIndex = 1;
            this.btnCerrar_Sesion.Text = "Cerrar Sesion";
            this.btnCerrar_Sesion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nueva consulta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Modificar Consulta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Buscar Paciente";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(58, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Registrar Paciente";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // InicioMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 652);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar_Sesion);
            this.Controls.Add(this.dgv_HistorialMedico);
            this.Name = "InicioMedicos";
            this.Text = "InicioMedicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HistorialMedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HistorialMedico;
        private System.Windows.Forms.Button btnCerrar_Sesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}