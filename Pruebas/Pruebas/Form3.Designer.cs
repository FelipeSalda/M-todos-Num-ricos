namespace Pruebas
{
    partial class FormTema1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTema1));
            BTNTerminarT1 = new Button();
            lblProgreso = new Label();
            BTNProblemasT1 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BTNTerminarT1
            // 
            BTNTerminarT1.Location = new Point(117, 261);
            BTNTerminarT1.Name = "BTNTerminarT1";
            BTNTerminarT1.Size = new Size(75, 23);
            BTNTerminarT1.TabIndex = 0;
            BTNTerminarT1.Text = "Terminar";
            BTNTerminarT1.UseVisualStyleBackColor = true;
            BTNTerminarT1.Click += BTNTerminarT1_Click;
            // 
            // lblProgreso
            // 
            lblProgreso.AutoSize = true;
            lblProgreso.Location = new Point(160, 20);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(32, 15);
            lblProgreso.TabIndex = 1;
            lblProgreso.Text = "label";
            lblProgreso.Click += lblProgreso_Click;
            // 
            // BTNProblemasT1
            // 
            BTNProblemasT1.Location = new Point(117, 303);
            BTNProblemasT1.Name = "BTNProblemasT1";
            BTNProblemasT1.Size = new Size(75, 23);
            BTNProblemasT1.TabIndex = 2;
            BTNProblemasT1.Text = "Problemas";
            BTNProblemasT1.UseVisualStyleBackColor = true;
            BTNProblemasT1.Click += BTNProblemasT1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Lagrange";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 92);
            label2.Name = "label2";
            label2.Size = new Size(270, 15);
            label2.TabIndex = 4;
            label2.Text = "Se aplica que intervalos uniformes y no uniformes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 120);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormTema1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 330);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BTNProblemasT1);
            Controls.Add(lblProgreso);
            Controls.Add(BTNTerminarT1);
            Name = "FormTema1";
            Text = "Tema 1";
            Load += FormTema1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNTerminarT1;
        private Label lblProgreso;
        private Button BTNProblemasT1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}