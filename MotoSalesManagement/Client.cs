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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\source\repos\MotoSalesManagement\MotoSalesManagement\Clientdtb.mdf;Integrated Security=True");

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_name.Text == "" || txt_adrss.Text == "" || txt_num.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string ahmed = "insert into ClientTbl values('" + txt_id.Text + "','" + txt_name.Text + "','" + txt_adrss.Text + "','" + txt_num.Text + "','" + comb_pay.SelectedItem.ToString() + "','" + comb_mark.SelectedItem.ToString() + "','" + cmbo_gendre.SelectedItem.ToString() + "','" + dtp_pay.Value.Date + "')";
                    SqlCommand cmd = new SqlCommand(ahmed, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" client success add to the record ");
                    Con.Close();
                    populate();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void lbl_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string ahmed = "select * from ClientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(ahmed, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgr_client.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void Client_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_id.Text== "")
            {
                MessageBox.Show("Entre the client ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string ahmed = "delete from ClientTbl where Idtxt_id='" + txt_id.Text + "';";
                    SqlCommand cmd = new SqlCommand(ahmed, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("the client is deleted ");
                    Con.Close();
                    populate();

                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void dgr_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgr_client.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = dgr_client.SelectedRows[0].Cells[1].Value.ToString();
            txt_adrss.Text = dgr_client.SelectedRows[0].Cells[2].Value.ToString();
            cmbo_gendre.Text = dgr_client.SelectedRows[0].Cells[3].Value.ToString();
            comb_mark.Text = dgr_client.SelectedRows[0].Cells[4].Value.ToString();
            txt_num.Text = dgr_client.SelectedRows[0].Cells[6].Value.ToString();
            comb_pay.Text = dgr_client.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_name.Text == "" || txt_adrss.Text == "" || txt_num.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string ahmed = "update ClientTbl set txt_name='" + txt_name.Text + "',txt_adrss='" + txt_adrss.Text + "',cmbo_gendre='" + cmbo_gendre.SelectedItem.ToString() + "',comb_mark='" + comb_mark.SelectedItem.ToString() + "', dtp_pay='" + dtp_pay.Value.Date + "', txt_num='" + txt_num.Text + "', combo_pay='" + comb_pay.SelectedItem.ToString() + "' where Idtxt_id='" + txt_id.Text + "';";
                    SqlCommand cmd = new SqlCommand(ahmed,Con) ;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client Updated");
                    Con.Close();
                    populate();

                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }

}
