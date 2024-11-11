namespace Pruebas
{
    partial class FormPTema2
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
            lblProblemas = new Label();
            label1 = new Label();
            txtRespuesta = new TextBox();
            lblRespuesta = new Label();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // lblProblemas
            // 
            lblProblemas.AutoSize = true;
            lblProblemas.Location = new Point(44, 9);
            lblProblemas.Name = "lblProblemas";
            lblProblemas.Size = new Size(63, 15);
            lblProblemas.TabIndex = 0;
            lblProblemas.Text = "Problemas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 43);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "x = 3.75";
            label1.Click += label1_Click;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(311, 215);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(100, 23);
            txtRespuesta.TabIndex = 2;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Location = new Point(192, 223);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(113, 15);
            lblRespuesta.TabIndex = 3;
            lblRespuesta.Text = "Ingrese su respuesta";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(417, 214);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // FormPTema2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificar);
            Controls.Add(lblRespuesta);
            Controls.Add(txtRespuesta);
            Controls.Add(label1);
            Controls.Add(lblProblemas);
            Name = "FormPTema2";
            Text = "Problemas Tema 2";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProblemas;
        private Label label1;
        private TextBox txtRespuesta;
        private Label lblRespuesta;
        private Button btnVerificar;
    }
}