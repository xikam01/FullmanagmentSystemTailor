using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Dashboard_Managment_system
{
    public partial class salary : UserControl
    {
        public salary()
        {
            InitializeComponent();
        } SqlConnection con = new SqlConnection("Data Source=DESKTOP-LSO4IN1;Initial Catalog=HamseTailor;Integrated Security=True");
           SqlCommand cmd;
           SqlDataAdapter da;
           int ID = 0;

        private void salary_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from salary", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            if (txt_Sal_Id.Text != "" && txt_Sal_name.Text != "" && txt_Sal_phone.Text != "" && txt_Sal_empol.Text != "")
            {
                cmd = new SqlCommand("insert into salary values(@Sal_Id, @Sal_name, @Sal_phone, @Sal_empol)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Sal_Id", txt_Sal_Id.Text);
                cmd.Parameters.AddWithValue("@Sal_name", txt_Sal_name.Text);
                cmd.Parameters.AddWithValue("@Sal_phone", txt_Sal_phone.Text);
                cmd.Parameters.AddWithValue("@Sal_empol", txt_Sal_empol.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Saved Successfully");
                DisplayData();
                ClearData();
            }
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from salary", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();

        }
        private void ClearData()
        {
            txt_Sal_Id.Clear();
            txt_Sal_name.Clear();
            txt_Sal_phone.Clear();
            txt_Sal_empol.Clear();
            ID = 0;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (txt_Sal_Id.Text != "" && txt_Sal_name.Text != "" && txt_Sal_phone.Text != "" && txt_Sal_empol.Text != "")
            {
                cmd = new SqlCommand("update salary set Sal_Id=@Sal_Id, Sal_name=@Sal_name, Sal_phone=@Sal_phone, Sal_empol=@Sal_empol", con);
                con.Open();
                ID = Convert.ToInt32(txt_Sal_Id.Text);
                cmd.Parameters.AddWithValue("@Sal_Id", txt_Sal_Id.Text);
                cmd.Parameters.AddWithValue("@Sal_name", txt_Sal_name.Text);
                cmd.Parameters.AddWithValue("@Sal_phone", txt_Sal_phone.Text);
                cmd.Parameters.AddWithValue("@Sal_empol", txt_Sal_empol.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (txt_Sal_Id.Text != "")
            {
                cmd = new SqlCommand("delete salary where Sal_Id=@Sal_Id", con);
                con.Open();
                ID = Convert.ToInt32(txt_Sal_Id.Text);
                cmd.Parameters.AddWithValue("@Sal_Id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
        }
    }

