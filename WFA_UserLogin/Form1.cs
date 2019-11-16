using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_UserLogin
{
    public partial class Form1 : MetroForm
    {
        Random rnd = new Random();
        int kullanilanhak = 5;
        public Form1()
        {
            InitializeComponent();
            lblRastgeleSayi.Text = rnd.Next(10000000, 100000000).ToString();
            int kullanilanhak = 5;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtGirisAlani.Text== lblRastgeleSayi.Text)
            {
                MessageBox.Show("Giriş başarılıdır.");
            }

            else 
            {
                lblRastgeleSayi.Text = rnd.Next(10000000, 100000000).ToString();
                txtGirisAlani.Text = "";
                txtGirisAlani.Focus();
                switch (kullanilanhak)
                {
                    case 5:
                        star1.Visible = false;
                    break;
                    case 4:
                        star2.Visible = false;
                        break;
                    case 3:
                        star3.Visible = false;
                        break;
                    case 2:
                        star4.Visible = false;
                        break;
                    case 1:
                        star5.Visible = false;
                        break;
                }
                kullanilanhak -=1;
                if (kullanilanhak == 0)
                {
                    txtGirisAlani.Enabled = false;
                    btnLogin.Enabled = false;
                    lblRastgeleSayi.Text = "* * * * * * * *";
                    MessageBox.Show("Giriş sağlanamadı");
                    star1.Visible = true;
                    star2.Visible = true;
                    star3.Visible = true;
                    star4.Visible = true;
                    star5.Visible = true;
                }

            }


        }
    }
}
