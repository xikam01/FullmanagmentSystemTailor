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
    public partial class Goods : UserControl
    {
        public Goods()
        {
            InitializeComponent();
        }   SqlConnection con = new SqlConnection("Data Source=DESKTOP-LSO4IN1;Initial Catalog=HamseTailor;Integrated Security=True");
          SqlCommand cmd;
          SqlDataAdapter da;
          int ID = 0;

        private void Goods_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from Goods", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
                if (txt_Go_id.Text != "" && txt_God_company.Text != "" && txt_God_tybe.Text != "" && txt_God_add.Text != "" && txt_God_size.Text != "" && txt_God_quantity.Text != "" && txt_God_price.Text != "" )
            {
                cmd = new SqlCommand("insert into Goods values(@Go_id, @God_company, @God_tybe, @God_add, @God_size,@God_quantity,  @God_price)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Go_id", txt_Go_id.Text);
                cmd.Parameters.AddWithValue("@God_company", txt_God_company.Text);
                cmd.Parameters.AddWithValue("@God_tybe", txt_God_tybe.Text);
                cmd.Parameters.AddWithValue("@God_add", txt_God_add.Text);
                cmd.Parameters.AddWithValue("@God_size", txt_God_size.Text);
                cmd.Parameters.AddWithValue("@God_quantity", txt_God_quantity.Text);
                cmd.Parameters.AddWithValue("@God_price", txt_God_price.Text);
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
            da = new SqlDataAdapter("select * from Goods", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();

        }
        private void ClearData()

        {
            txt_Go_id.Clear();
            txt_God_company.Clear();
            txt_God_tybe.Clear();
            txt_God_add.Clear();
            txt_God_size.Clear();
            txt_God_quantity.Clear();
            txt_God_price.Clear();

            ID = 0;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (txt_Go_id.Text != "" && txt_God_company.Text != "" && txt_God_tybe.Text != "" && txt_God_add.Text != "" && txt_God_size.Text != "" && txt_God_quantity.Text != "" && txt_God_price.Text != "")
            {
                cmd = new SqlCommand("update Goods set Go_id=@Go_id, God_company=@God_company, God_tybe=@God_tybe, God_add=@God_add, God_size=@God_size,God_quantity=@God_quantity,God_price=@God_price where Go_id=@Go_id", con);
                con.Open();
                ID = Convert.ToInt32(txt_Go_id.Text);
                cmd.Parameters.AddWithValue("@Go_id", txt_Go_id.Text);
                cmd.Parameters.AddWithValue("@God_company", txt_God_company.Text);
                cmd.Parameters.AddWithValue("@God_tybe", txt_God_tybe.Text);
                cmd.Parameters.AddWithValue("@God_add", txt_God_add.Text);
                cmd.Parameters.AddWithValue("@God_size", txt_God_size.Text);
                cmd.Parameters.AddWithValue("@God_quantity", txt_God_quantity.Text);
                cmd.Parameters.AddWithValue("@God_price", txt_God_price.Text);
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
            if (txt_Go_id.Text != "")
            {
                cmd = new SqlCommand("delete Goods where Go_id=@Go_id", con);
                con.Open();
                ID = Convert.ToInt32(txt_Go_id.Text);
                cmd.Parameters.AddWithValue("@Go_id", ID);
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

