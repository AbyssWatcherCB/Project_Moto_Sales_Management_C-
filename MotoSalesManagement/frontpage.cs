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
    public partial class frontpage : Form
    {
        public frontpage()
        {
            InitializeComponent();
        }
        int start = 0;
        int end = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            end = start;
            if (end==20)
            {
                end = 0;
                timer1.Stop();
                this.Hide();
                loadingpage loadingpage = new loadingpage();
                loadingpage.Show();
                this.Hide();
            }

        }

        private void frontpage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
