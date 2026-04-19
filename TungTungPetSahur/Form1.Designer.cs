namespace TungTungPetSahur
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            pgrDiversion = new ProgressBar();
            pgrComida = new ProgressBar();
            pgrEnergia = new ProgressBar();
            btnComer = new Button();
            btnJugar = new Button();
            btnDormir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pgrDiversion
            // 
            pgrDiversion.ForeColor = Color.FromArgb(255, 128, 0);
            pgrDiversion.Location = new Point(345, 74);
            pgrDiversion.Name = "pgrDiversion";
            pgrDiversion.Size = new Size(188, 23);
            pgrDiversion.TabIndex = 1;
            // 
            // pgrComida
            // 
            pgrComida.ForeColor = Color.Cyan;
            pgrComida.Location = new Point(345, 121);
            pgrComida.Name = "pgrComida";
            pgrComida.Size = new Size(188, 23);
            pgrComida.TabIndex = 2;
            // 
            // pgrEnergia
            // 
            pgrEnergia.ForeColor = Color.Lime;
            pgrEnergia.Location = new Point(345, 171);
            pgrEnergia.Name = "pgrEnergia";
            pgrEnergia.Size = new Size(188, 23);
            pgrEnergia.TabIndex = 3;
            // 
            // btnComer
            // 
            btnComer.Location = new Point(250, 339);
            btnComer.Name = "btnComer";
            btnComer.Size = new Size(123, 42);
            btnComer.TabIndex = 4;
            btnComer.Text = "Comer";
            btnComer.UseVisualStyleBackColor = true;
            btnComer.Click += button1_Click;
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(79, 339);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(123, 42);
            btnJugar.TabIndex = 4;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += button2_Click;
            // 
            // btnDormir
            // 
            btnDormir.Location = new Point(423, 339);
            btnDormir.Name = "btnDormir";
            btnDormir.Size = new Size(123, 42);
            btnDormir.TabIndex = 4;
            btnDormir.Text = "Dormir";
            btnDormir.UseVisualStyleBackColor = true;
            btnDormir.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(btnDormir);
            Controls.Add(btnJugar);
            Controls.Add(btnComer);
            Controls.Add(pgrEnergia);
            Controls.Add(pgrComida);
            Controls.Add(pgrDiversion);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TungTungPetSahur";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar pgrDiversion;
        private ProgressBar pgrComida;
        private ProgressBar pgrEnergia;
        private Button btnComer;
        private Button btnJugar;
        private Button btnDormir;
    }
}
