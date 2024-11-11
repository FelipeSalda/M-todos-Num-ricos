namespace Pruebas
{
    partial class FormTemas
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
            BTNTema1 = new Button();
            BTNTema2 = new Button();
            lblInterpolacion = new Label();
            BTNTema3 = new Button();
            SuspendLayout();
            // 
            // BTNTema1
            // 
            BTNTema1.Location = new Point(12, 36);
            BTNTema1.Name = "BTNTema1";
            BTNTema1.Size = new Size(75, 23);
            BTNTema1.TabIndex = 0;
            BTNTema1.Text = "Tema 1\r\n";
            BTNTema1.UseVisualStyleBackColor = true;
            BTNTema1.Click += BTNTema1_Click;
            // 
            // BTNTema2
            // 
            BTNTema2.Location = new Point(14, 65);
            BTNTema2.Name = "BTNTema2";
            BTNTema2.Size = new Size(75, 23);
            BTNTema2.TabIndex = 1;
            BTNTema2.Text = "Tema 2";
            BTNTema2.UseVisualStyleBackColor = true;
            // 
            // lblInterpolacion
            // 
            lblInterpolacion.AutoSize = true;
            lblInterpolacion.Location = new Point(12, 9);
            lblInterpolacion.Name = "lblInterpolacion";
            lblInterpolacion.Size = new Size(77, 15);
            lblInterpolacion.TabIndex = 2;
            lblInterpolacion.Text = "Interpolación";
            // 
            // BTNTema3
            // 
            BTNTema3.Location = new Point(14, 94);
            BTNTema3.Name = "BTNTema3";
            BTNTema3.Size = new Size(75, 23);
            BTNTema3.TabIndex = 3;
            BTNTema3.Text = "Tema 3";
            BTNTema3.UseVisualStyleBackColor = true;
            // 
            // FormTemas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 349);
            Controls.Add(BTNTema3);
            Controls.Add(lblInterpolacion);
            Controls.Add(BTNTema2);
            Controls.Add(BTNTema1);
            Name = "FormTemas";
            Text = "Temas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNTema1;
        private Button BTNTema2;
        private Label lblInterpolacion;
        private Button BTNTema3;
    }
}