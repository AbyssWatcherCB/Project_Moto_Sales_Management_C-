using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoSalesManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == ""|| txt_passeword.Text=="")
            {
                MessageBox.Show("Wrong information");
            }
            else if(txt_user.Text=="admin" && txt_passeword.Text=="admin")
            {
                this.Hide();
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong information");
            }
        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_passeword.Clear();
            txt_hider.Clear();
            txt_user.Clear();

        }

        private void btn_hideshow_MouseDown(object sender, MouseEventArgs e)
        {
            txt_hider.Hide();
        }

        private void btn_hideshow_MouseUp(object sender, MouseEventArgs e)
        {
            txt_hider.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_passeword.Text = txt_hider.Text;
        }
    }
}
