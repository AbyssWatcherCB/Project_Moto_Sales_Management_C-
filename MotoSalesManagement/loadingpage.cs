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
    public partial class loadingpage : Form
    {
        public loadingpage()
        {
            InitializeComponent();
        }

        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            circularProgressBar1.Value = start;
            if (circularProgressBar1.Value == 100)
            {
                circularProgressBar1.Value = 0;
                timer1.Stop();
                this.Hide();
                Login login = new Login() ;
                login.Show();
                this.Hide();
            }


        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
