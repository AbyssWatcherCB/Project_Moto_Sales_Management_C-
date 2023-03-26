using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MotoSalesManagement
{
    public partial class ClientProfil : Form
    {
        public ClientProfil()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MotoSalesManagement\MotoSalesManagement\Clientdtb.mdf;Integrated Security=True");
        public void Fetchampdata()
        {
            Con.Open();
            string ahmed = "select * from ClientTbl where Idtxt_id='" + txt_id.Text + "'";
            SqlCommand cmd = new SqlCommand(ahmed,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lbl_client.Text = dr["Idtxt_id"].ToString();
                lbl_add.Text = dr["txt_adrss"].ToString();
                lbl_name.Text = dr["txt_name"].ToString();
                lbl_gendre.Text = dr["cmbo_gendre"].ToString();
                lbl_mark.Text = dr["comb_mark"].ToString();
                lbl_paydate.Text = dr["dtp_pay"].ToString();
                lbl_num.Text = dr["txt_num"].ToString();
                lbl_pay.Text = dr["combo_pay"].ToString();

                lbl_client.Visible = true;
                lbl_add.Visible = true;
                lbl_name.Visible = true;
                lbl_gendre.Visible = true;
                lbl_mark.Visible = true;
                lbl_paydate.Visible = true;
                lbl_num.Visible = true;
                lbl_pay.Visible = true;

            }

            Con.Close();
        }

        private void ClientProfil_Load(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Fetchampdata();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
