namespace TungTungPetSahur
{
    partial class MenuSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSeleccion));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnTungTung = new Button();
            btnBallerina = new Button();
            btnTralalero = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(240, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.tralalerosinfondo;
            pictureBox2.Location = new Point(467, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.ballerinacapuccinasinfondo;
            pictureBox3.Location = new Point(12, 174);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(145, 143);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // btnTungTung
            // 
            btnTungTung.BackColor = Color.FromArgb(255, 128, 0);
            btnTungTung.FlatStyle = FlatStyle.Flat;
            btnTungTung.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTungTung.Location = new Point(263, 337);
            btnTungTung.Name = "btnTungTung";
            btnTungTung.Size = new Size(106, 35);
            btnTungTung.TabIndex = 1;
            btnTungTung.Text = "TungTung";
            btnTungTung.UseVisualStyleBackColor = false;
            btnTungTung.Click += btnTungTung_Click;
            // 
            // btnBallerina
            // 
            btnBallerina.BackColor = Color.FromArgb(255, 192, 255);
            btnBallerina.FlatAppearance.BorderSize = 0;
            btnBallerina.FlatStyle = FlatStyle.Flat;
            btnBallerina.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBallerina.Location = new Point(31, 337);
            btnBallerina.Name = "btnBallerina";
            btnBallerina.Size = new Size(106, 35);
            btnBallerina.TabIndex = 1;
            btnBallerina.Text = "Ballerina";
            btnBallerina.UseVisualStyleBackColor = false;
            btnBallerina.Click += btnBallerina_Click;
            // 
            // btnTralalero
            // 
            btnTralalero.BackColor = Color.FromArgb(0, 192, 192);
            btnTralalero.FlatStyle = FlatStyle.Flat;
            btnTralalero.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTralalero.Location = new Point(486, 337);
            btnTralalero.Name = "btnTralalero";
            btnTralalero.Size = new Size(106, 35);
            btnTralalero.TabIndex = 1;
            btnTralalero.Text = "Tralalero";
            btnTralalero.UseVisualStyleBackColor = false;
            btnTralalero.Click += btnTralalero_Click;
            // 
            // MenuSeleccion
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(624, 441);
            Controls.Add(btnTralalero);
            Controls.Add(btnBallerina);
            Controls.Add(btnTungTung);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "MenuSeleccion";
            Text = "MenuSeleccion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnTungTung;
        private Button btnBallerina;
        private Button btnTralalero;
    }
}