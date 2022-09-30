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
    public partial class Orders : UserControl
    {
        public Orders()
        {
            InitializeComponent();
        }  SqlConnection con = new SqlConnection("Data Source=DESKTOP-LSO4IN1;Initial Catalog=HamseTailor;Integrated Security=True");
           SqlCommand cmd;
           SqlDataAdapter da;
           int ID = 0;

        private void Orders_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from orders", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (txt_Ord_Id.Text != "" && Cus_name.Text != "" && txt_Clothtype.Text != "" && txt_DateReceived.Text != "" && txt_Amountpaid.Text != "" && txt_Balance.Text != "")
            {
                cmd = new SqlCommand("insert into Orders values(@Ord_Id, @Cus_name, @Clothtype, @DateReceived, @Amountpaid,@Balance)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Ord_Id", txt_Ord_Id.Text);
                cmd.Parameters.AddWithValue("@Cus_name", Cus_name.Text);
                cmd.Parameters.AddWithValue("@Clothtype", txt_Clothtype.Text);
                cmd.Parameters.AddWithValue("@DateReceived", txt_DateReceived.Text);
                cmd.Parameters.AddWithValue("@Amountpaid", txt_Amountpaid.Text);
                cmd.Parameters.AddWithValue("@Balance", txt_Balance.Text);
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
            da = new SqlDataAdapter("select * from Orders", con);
            da.Fill(dt);
            DVG.DataSource = dt;
            con.Close();

        }
        private void ClearData()
        {
            txt_Ord_Id.Clear();
            Cus_name.Clear();
            txt_Clothtype.Clear();
            txt_Amountpaid.Clear();
            txt_Balance.Clear();
            ID = 0;
        }
    }
}
