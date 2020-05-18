using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 - Họ và tên: Nguyễn Công Thành
 - MSSV: 1654050102
 - Môn: LTGD - Lớp: TH71
*/

namespace SaveTheEggs
{
    public partial class SaveTheEggs : Form
    {
        bool goleft; //Kiem trai nguoi choi co di chuyen dung qua ben trai khong
        bool goright; //Kiem trai nguoi choi co di chuyen dung qua ben phai khong
        int speed = 0; // Toc do tha trung mac dinh
        int score = 0; //Gia tri diem mac dinh
        int missed = 0; //Gia tri vo trung mac dinh
        Random rndY = new Random(); //Tao vi tri ngau nhin Y
        Random rndX = new Random(); //Tao vi tri ngau nhin X
        PictureBox splash = new PictureBox();

        public SaveTheEggs()
        {
            InitializeComponent();
           
        }

        //Thiet lap muc do: De, Trung Binh, Kho
        private void Start_De_Click(object sender, EventArgs e)
        {
            speed = 2;
        }

        private void Start_TrungBinh_Click(object sender, EventArgs e)
        {
            speed = 5; 
        }

        private void Start_Kho_Click(object sender, EventArgs e)
        {
            speed = 8; 
        }

        //Huong dan
        private void HuongDan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
                                HƯỚNG DẪN 
                     - Di chuyển bàn phím qua trái hoặc qua
                       phải để hứng trứng rơi 
                     - Hứng mỗi quả sẽ được 10 điểm 
                     - Để rơi 5 quả trứng sẽ thua cuộc", "Hướng Dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Thong Tin
        private void ThongTin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nguyễn Công Thành - MSSV: 1654050102", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        //Thoat
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h == DialogResult.OK)
                Application.Exit(); 
        }
       
        //Kiem tra nguoi choi nhan phim Trai hay phim Phai
        private void SaveTheEggs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

        }

        private void SaveTheEggs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = "Điểm: " + score;
            label2.Text = "Trứng vỡ: " + missed;

            //Neu nhan phim trai "Ga" di chuyen sang ben trai
            if (goleft == true && chicken.Left > 0)
            {
                chicken.Left -= 12;
                chicken.Image = Properties.Resources.chicken_normal2;
            }

            //Neu nhan phim phai "Ga" di chuyen sang ben phai va nam trong khung tro choi
            if (goright == true && chicken.Left + chicken.Width < this.ClientSize.Width)
            {
                chicken.Left += 12;
                chicken.Image = Properties.Resources.chicken_normal;
            }

            //Kiem tra "Trung" roi
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && X.Tag == "Eggs")
                {

                    X.Top += speed;

                    //Neu "Trung" cham san 
                    if (X.Top + X.Height > this.ClientSize.Height)
                    {
                        splash.Image = Properties.Resources.splash;
                        splash.Location = X.Location;
                        splash.Height = 59;
                        splash.Width = 60;
                        splash.BackColor = System.Drawing.Color.Transparent;
                        this.Controls.Add(splash);
                        X.Top = rndY.Next(80, 300) * -1;
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                        missed++;
                        chicken.Image = Properties.Resources.chicken_hurt;
                    }

                    //Neu "Trung" roi dung vao gio cua "Ga"
                    if (X.Bounds.IntersectsWith(chicken.Bounds))
                    {
                        X.Top = rndY.Next(100, 300) * -1;
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                        score+= 10;
                    }

                    //Neu "Trung" roi hon 5 qua
                    if (missed > 5)
                    {
                        gameTimer.Stop();
                        DialogResult h = MessageBox.Show("Game Over!" + "\r\n" + "Nhấn OK để chơi lại", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            reset();
                       
                    }

                }
            }
        }

        //Reset lai tro choi
        private void reset()
        {
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && X.Tag == "Eggs")
                {
                    X.Top = rndY.Next(80, 300) * -1;
                    X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                }
            }
            chicken.Left = this.ClientSize.Width / 2;
            chicken.Image = Properties.Resources.chicken_normal2;
            score = 0;
            missed = 0;
            goleft = false;
            goright = false;
            gameTimer.Start();
        }
       
    }
}
