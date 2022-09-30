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
    public partial class customer : UserControl
    {
        public customer()
        {
            InitializeComponent();
        }SqlConnection con = new SqlConnection("Data Source=DESKTOP-LSO4IN1;Initial Catalog=HamseTailor;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        int ID = 0;

        private void Save_Click(object sender, EventArgs e)
        {
            if (Cus_Id.Text != "" && Cus_name.Text != "" && Cus_address.Text!= "" && Cus_phone.Text!= "" && Cus_gander.Text != "")
            {
                cmd = new SqlCommand("insert into customer values(@Cus_Id, @Cus_name, @Cus_address, @Cus_phone, @Cus_gander)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Cus_Id", Cus_Id.Text);
                cmd.Parameters.AddWithValue("@Cus_name", Cus_name.Text);
                cmd.Parameters.AddWithValue("@Cus_address", Cus_address.Text);
                cmd.Parameters.AddWithValue("@Cus_phone", Cus_phone.Text);
                cmd.Parameters.AddWithValue("@Cus_gander", Cus_gander.Text);
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
            da = new SqlDataAdapter("select * from customer", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();

        }
        private void ClearData()
        {
            Cus_Id.Clear();
            Cus_name.Clear();
            Cus_address.Clear();
            Cus_phone.Clear();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from customer", con);
            da.Fill(dt);

            DVG.DataSource = dt;
            con.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (Cus_Id.Text != "" && Cus_name.Text != "" && Cus_address.Text != "" && Cus_phone.Text != "" && Cus_gander.Text != "")
            {
                cmd = new SqlCommand("update customer set Cus_Id=@Cus_Id, Cus_name=@Cus_name, Cus_address=@Cus_address, Cus_phone=@Cus_phone, Cus_gander=@Cus_gander where Cus_Id=@Cus_Id", con);
                con.Open();
                ID = Convert.ToInt32(Cus_Id.Text);
                cmd.Parameters.AddWithValue("@Cus_Id", Cus_Id.Text);
                cmd.Parameters.AddWithValue("@Cus_name", Cus_name.Text);
                cmd.Parameters.AddWithValue("@Cus_address", Cus_address.Text);
                cmd.Parameters.AddWithValue("@Cus_phone", Cus_phone.Text);
                cmd.Parameters.AddWithValue("@Cus_gander", Cus_gander.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Mudane Waa laguu Fuliyey amarkaaga", "seccesfully");
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
            if (Cus_Id.Text != "")
            {
                cmd = new SqlCommand("delete customer where Cus_Id=@Cus_Id", con);
                con.Open();
                ID = Convert.ToInt32(Cus_Id.Text);
                cmd.Parameters.AddWithValue("@Cus_Id", ID);
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
