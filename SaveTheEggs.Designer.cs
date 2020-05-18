namespace SaveTheEggs
{
    partial class SaveTheEggs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveTheEggs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chicken = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Start = new System.Windows.Forms.ToolStripMenuItem();
            this.Start_De = new System.Windows.Forms.ToolStripMenuItem();
            this.Start_TrungBinh = new System.Windows.Forms.ToolStripMenuItem();
            this.Start_Kho = new System.Windows.Forms.ToolStripMenuItem();
            this.HuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.Thoat = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mạng: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaveTheEggs.Properties.Resources.egg;
            this.pictureBox1.Location = new System.Drawing.Point(48, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Eggs";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SaveTheEggs.Properties.Resources.egg;
            this.pictureBox2.Location = new System.Drawing.Point(234, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Eggs";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SaveTheEggs.Properties.Resources.egg;
            this.pictureBox3.Location = new System.Drawing.Point(448, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Eggs";
            // 
            // chicken
            // 
            this.chicken.Image = global::SaveTheEggs.Properties.Resources.chicken_normal2;
            this.chicken.Location = new System.Drawing.Point(223, 607);
            this.chicken.Name = "chicken";
            this.chicken.Size = new System.Drawing.Size(93, 83);
            this.chicken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chicken.TabIndex = 5;
            this.chicken.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start,
            this.HuongDan,
            this.ThongTin,
            this.Thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Start
            // 
            this.Start.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start_De,
            this.Start_TrungBinh,
            this.Start_Kho});
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(59, 20);
            this.Start.Text = "Bắt đầu";
            // 
            // Start_De
            // 
            this.Start_De.Name = "Start_De";
            this.Start_De.Size = new System.Drawing.Size(132, 22);
            this.Start_De.Text = "Dễ";
            this.Start_De.Click += new System.EventHandler(this.Start_De_Click);
            // 
            // Start_TrungBinh
            // 
            this.Start_TrungBinh.Name = "Start_TrungBinh";
            this.Start_TrungBinh.Size = new System.Drawing.Size(132, 22);
            this.Start_TrungBinh.Text = "Trung bình";
            this.Start_TrungBinh.Click += new System.EventHandler(this.Start_TrungBinh_Click);
            // 
            // Start_Kho
            // 
            this.Start_Kho.Name = "Start_Kho";
            this.Start_Kho.Size = new System.Drawing.Size(132, 22);
            this.Start_Kho.Text = "Khó";
            this.Start_Kho.Click += new System.EventHandler(this.Start_Kho_Click);
            // 
            // HuongDan
            // 
            this.HuongDan.Name = "HuongDan";
            this.HuongDan.Size = new System.Drawing.Size(79, 20);
            this.HuongDan.Text = "Hướng dẫn";
            this.HuongDan.Click += new System.EventHandler(this.HuongDan_Click);
            // 
            // ThongTin
            // 
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Size = new System.Drawing.Size(74, 20);
            this.ThongTin.Text = "Thông Tin";
            this.ThongTin.Click += new System.EventHandler(this.ThongTin_Click);
            // 
            // Thoat
            // 
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(50, 20);
            this.Thoat.Text = "Thoát";
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // SaveTheEggs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(612, 699);
            this.Controls.Add(this.chicken);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SaveTheEggs";
            this.Text = "Save The Eggs";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaveTheEggs_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SaveTheEggs_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox chicken;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Start;
        private System.Windows.Forms.ToolStripMenuItem ThongTin;
        private System.Windows.Forms.ToolStripMenuItem HuongDan;
        private System.Windows.Forms.ToolStripMenuItem Start_De;
        private System.Windows.Forms.ToolStripMenuItem Start_TrungBinh;
        private System.Windows.Forms.ToolStripMenuItem Start_Kho;
        private System.Windows.Forms.ToolStripMenuItem Thoat;
    }
}