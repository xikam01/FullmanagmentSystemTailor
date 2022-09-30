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
    public partial class Store : UserControl
    {
        public Store()
        {
            InitializeComponent();
        } SqlConnection con = new SqlConnection("Data Source=DESKTOP-LSO4IN1;Initial Catalog=HamseTailor;Integrated Security=True");
          SqlCommand cmd;
          SqlDataAdapter da;
          int ID = 0;

        private void Store_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from store", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (txt_St_id.Text != "" && txt_St_name.Text != "" && txt_St_type.Text != "" && txt_Quantity.Text != "")
            {
                cmd = new SqlCommand("insert into store values(@St_id, @St_name, @St_type, @Quantity)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@St_id", txt_St_id.Text);
                cmd.Parameters.AddWithValue("@St_name", txt_St_name.Text);
                cmd.Parameters.AddWithValue("@St_type", txt_St_type.Text);
                cmd.Parameters.AddWithValue("@Quantity", txt_Quantity.Text);
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
            da = new SqlDataAdapter("select * from store", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();

        }
        private void ClearData()
        {
            txt_St_id.Clear();
            txt_St_name.Clear();
            txt_St_type.Clear();
            txt_Quantity.Clear();
            ID = 0;
      
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (txt_St_id.Text != "" && txt_St_name.Text != "" && txt_St_type.Text != "" && txt_Quantity.Text != "")
            {
                cmd = new SqlCommand("update store set St_id=@St_id, St_name=@St_name, St_type=@St_type, Quantity=@Quantity", con);
                con.Open();
                ID = Convert.ToInt32(txt_St_id.Text);
                cmd.Parameters.AddWithValue("@St_id", txt_St_id.Text);
                cmd.Parameters.AddWithValue("@St_name", txt_St_name.Text);
                cmd.Parameters.AddWithValue("@St_type", txt_St_type.Text);
                cmd.Parameters.AddWithValue("@Quantity", txt_Quantity.Text);
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
            if (txt_St_id.Text != "")
            {
                cmd = new SqlCommand("delete store where St_id=@St_id", con);
                con.Open();
                ID = Convert.ToInt32(txt_St_id.Text);
                cmd.Parameters.AddWithValue("@St_id", ID);
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
