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
    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();
        } SqlConnection con = new SqlConnection("Data Source=DESKTOP-LSO4IN1;Initial Catalog=HamseTailor;Integrated Security=True");
          SqlCommand cmd;
          SqlDataAdapter da;
          int ID = 0;

        private void Payment_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from payment", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" && txt_clothtype.Text != "" && txt_Pay_type.Text != "" && DTP.Text != "" && txt_balance.Text != "" )
            {
                cmd = new SqlCommand("insert into payment values(@Pay_id, @Pay_clothtype, @Pay_type, @Pay_Date, @Pay_balance)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Pay_id", txt_id.Text);
                cmd.Parameters.AddWithValue("@Pay_clothtype", txt_clothtype.Text);
                cmd.Parameters.AddWithValue("@Pay_type", txt_Pay_type.Text);
                cmd.Parameters.AddWithValue("@Pay_Date", DTP.Value);
                cmd.Parameters.AddWithValue("@Pay_balance", txt_balance.Text);
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
            da = new SqlDataAdapter("select * from payment", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();

        }
        private void ClearData()
        {
            txt_id.Clear();
            txt_clothtype.Clear();
            txt_Pay_type.Clear();
            txt_balance.Clear();
            ID = 0;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" && txt_clothtype.Text != "" && txt_Pay_type.Text != "" && DTP.Text != "" && txt_balance.Text != "")
            {
                cmd = new SqlCommand("update payment set Pay_id=@Pay_id, Pay_clothtype=@Pay_clothtype, Pay_type=@Pay_type, Pay_Date=@Pay_Date, Pay_balance=@Pay_balance where Pay_id=@Pay_id", con);
                con.Open();
                ID = Convert.ToInt32(txt_id.Text);
                cmd.Parameters.AddWithValue("@Pay_id", txt_id.Text);
                cmd.Parameters.AddWithValue("@Pay_clothtype", txt_clothtype.Text);
                cmd.Parameters.AddWithValue("@Pay_type", txt_Pay_type.Text);
                cmd.Parameters.AddWithValue("@Pay_Date", DTP.Value);
                cmd.Parameters.AddWithValue("@Pay_balance", txt_balance.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Mudane Waa laguu Fuliyey amarkaaga","seccesfully");
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
            if (txt_id.Text != "")
            {
                cmd = new SqlCommand("delete payment where Pay_id=@Pay_id", con);
                con.Open();
                ID = Convert.ToInt32(txt_id.Text);
                cmd.Parameters.AddWithValue("@Pay_id", ID);
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
