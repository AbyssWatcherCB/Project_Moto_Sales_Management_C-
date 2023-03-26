using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MotoSalesManagement
{
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MotoSalesManagement\MotoSalesManagement\Clientdtb.mdf;Integrated Security=True");



        private void payment_Load(object sender, EventArgs e)
        {

        }
        public void Fetchampdata()
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Entre Client ID ");
            }
            else
            {
                Con.Open();
                string ahmed = "select * from ClientTbl where Idtxt_id='" + txt_id.Text + "'";
                SqlCommand cmd = new SqlCommand(ahmed, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txt_id.Text = dr["Idtxt_id"].ToString();

                    txt_name.Text = dr["txt_name"].ToString();

                    comb_pay.Text = dr["combo_pay"].ToString();


                }
                Con.Close();
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Fetchampdata();
        }
        float monthpayment = 0;
        string state = "";
        private void btn_view_Click(object sender, EventArgs e)
        {
            if (comb_pay.Text == "")
            {
                MessageBox.Show("entre type of payment");
            }
            else if(txt_price.Text==""|| Convert.ToInt32(txt_price.Text)<1000)
            {
                MessageBox.Show("Entre the correct price");

            }
            else
            {

                if (comb_pay.Text == "Check")
                {
                    rtxt_resultat.Text = "Client ID : " + txt_id.Text + "\n" + "Client name : " + txt_name.Text + "\n" + "Type of payment : " + comb_pay.Text + "\n" + "Price of the motocycle : "+ txt_price.Text+" DH";
                }
                if (comb_pay.Text == "Pay in cash")
                {
                    rtxt_resultat.Text = "Client ID : " + txt_id.Text + "\n" + "Client name : " + txt_name.Text + "\n" + "Type of payment : " + comb_pay.Text + "\n" + "Price of the motocycle : " + txt_price.Text+ " DH";
                }
                if (comb_pay.Text == "Loan") 
                {
                    monthpayment= Convert.ToInt32(txt_price.Text) / 12;

                    rtxt_resultat.Text = "Client ID : " + txt_id.Text + "\n" + "Client name : " + txt_name.Text + "\n" + "Type of payment : " + comb_pay.Text + "\n" + "Price of the motocycle : " + txt_price.Text +" DH"+"\n"+"pay per month : "+monthpayment.ToString()+" DH";
                }

            }
        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
