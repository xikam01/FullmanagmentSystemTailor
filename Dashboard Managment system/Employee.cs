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
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
        }SqlConnection con = new SqlConnection("Data Source=DESKTOP-LSO4IN1;Initial Catalog=HamseTailor;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;

        private void Employee_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from employee", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Em_Id.Text != "" && Em_name.Text != "" && Em_phone.Text != "" && Em_Gander.Text != "" && Em_address.Text != "")
            {
                cmd = new SqlCommand("insert into employee values(@Em_Id, @Em_name, @Em_phone, @Em_Gander, @Em_address)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Em_Id", Em_Id.Text);
                cmd.Parameters.AddWithValue("@Em_name", Em_name.Text);
                cmd.Parameters.AddWithValue("@Em_phone", Em_phone.Text);
                cmd.Parameters.AddWithValue("@Em_Gander", Em_Gander.Text);
                cmd.Parameters.AddWithValue("@Em_address", Em_address.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Fadlan Dooro Kan ");
                DisplayData();
                ClearData();
            }
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from employee", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();

        }
        private void ClearData()
        {
            Em_Id.Clear();
            Em_name.Clear();
            Em_phone.Clear();
            Em_address.Clear();
            ID = 0;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Em_Id.Text != "" && Em_name.Text != "" && Em_phone.Text != "" && Em_Gander.Text != "" && Em_address.Text != "")
            {
                cmd = new SqlCommand("update employee set Em_Id=@Em_Id, Em_name=@Em_name, Em_phone=@Em_phone, Em_Gander=@Em_Gander, Em_address=@Em_address where Em_Id=@Em_Id", con);
                con.Open();
                ID = Convert.ToInt32(Em_Id.Text);
                cmd.Parameters.AddWithValue("@Em_Id", Em_Id.Text);
                cmd.Parameters.AddWithValue("@Em_name", Em_name.Text);
                cmd.Parameters.AddWithValue("@Em_phone", Em_phone.Text);
                cmd.Parameters.AddWithValue("@Em_Gander", Em_Gander.Text);
                cmd.Parameters.AddWithValue("@Em_address", Em_address.Text);
                cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show(" seccesfully Recode");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Fadlan Dooro Kan Aad waxka Badalayso" ,"Please Select Record to Update");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Em_Id.Text != "")
            {
                cmd = new SqlCommand("delete employee where Em_Id=@Em_Id", con);
                con.Open();
                ID = Convert.ToInt32(Em_Id.Text);
                cmd.Parameters.AddWithValue("@Em_Id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Mahubtaa In Aad Saarayso!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete", "Fadlan Dooro Kan Aa Tirtirayso");
            }
        }
    }
}
