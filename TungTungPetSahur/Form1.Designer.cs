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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pgrDiversion = new ProgressBar();
            pgrComida = new ProgressBar();
            pgrEnergia = new ProgressBar();
            btnComer = new Button();
            btnJugar = new Button();
            btnDormir = new Button();
            lblDiversion = new Label();
            lblComida = new Label();
            lblEnergia = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            btnComer.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnJugar.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            btnDormir.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDormir.Location = new Point(423, 339);
            btnDormir.Name = "btnDormir";
            btnDormir.Size = new Size(123, 42);
            btnDormir.TabIndex = 4;
            btnDormir.Text = "Dormir";
            btnDormir.UseVisualStyleBackColor = true;
            btnDormir.Click += button3_Click;
            // 
            // lblDiversion
            // 
            lblDiversion.AutoSize = true;
            lblDiversion.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiversion.Location = new Point(545, 82);
            lblDiversion.Name = "lblDiversion";
            lblDiversion.Size = new Size(39, 17);
            lblDiversion.TabIndex = 5;
            lblDiversion.Text = "label1";
            // 
            // lblComida
            // 
            lblComida.AutoSize = true;
            lblComida.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComida.Location = new Point(545, 129);
            lblComida.Name = "lblComida";
            lblComida.Size = new Size(39, 17);
            lblComida.TabIndex = 6;
            lblComida.Text = "label1";
            // 
            // lblEnergia
            // 
            lblEnergia.AutoSize = true;
            lblEnergia.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnergia.Location = new Point(545, 179);
            lblEnergia.Name = "lblEnergia";
            lblEnergia.Size = new Size(39, 17);
            lblEnergia.TabIndex = 7;
            lblEnergia.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(300, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(300, 78);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 21);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(300, 175);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(624, 441);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(lblEnergia);
            Controls.Add(lblComida);
            Controls.Add(lblDiversion);
            Controls.Add(btnDormir);
            Controls.Add(btnJugar);
            Controls.Add(btnComer);
            Controls.Add(pgrEnergia);
            Controls.Add(pgrComida);
            Controls.Add(pgrDiversion);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TungTungPetSahur";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar pgrDiversion;
        private ProgressBar pgrComida;
        private ProgressBar pgrEnergia;
        private Button btnComer;
        private Button btnJugar;
        private Button btnDormir;
        private Label lblDiversion;
        private Label lblComida;
        private Label lblEnergia;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
