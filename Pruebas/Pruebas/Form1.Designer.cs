namespace Pruebas
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextTitle = new Label();
            BTNInicio = new Button();
            SuspendLayout();
            // 
            // TextTitle
            // 
            TextTitle.AutoEllipsis = true;
            TextTitle.AutoSize = true;
            TextTitle.Font = new Font("Rockwell Extra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextTitle.ForeColor = SystemColors.ButtonShadow;
            TextTitle.Location = new Point(12, 9);
            TextTitle.MaximumSize = new Size(1000, 100);
            TextTitle.Name = "TextTitle";
            TextTitle.Size = new Size(330, 28);
            TextTitle.TabIndex = 0;
            TextTitle.Text = "METODOS NUMERICOS";
            TextTitle.TextAlign = ContentAlignment.MiddleCenter;
            TextTitle.Click += label1_Click;
            // 
            // BTNInicio
            // 
            BTNInicio.Location = new Point(123, 109);
            BTNInicio.Name = "BTNInicio";
            BTNInicio.Size = new Size(104, 28);
            BTNInicio.TabIndex = 1;
            BTNInicio.Text = "Iniciar";
            BTNInicio.UseVisualStyleBackColor = true;
            BTNInicio.Click += BTNInicio_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(352, 186);
            Controls.Add(BTNInicio);
            Controls.Add(TextTitle);
            Font = new Font("Yu Gothic UI", 9F);
            Name = "FormInicio";
            Text = "Metódos Númericos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextTitle;
        private Button BTNInicio;
    }
}
