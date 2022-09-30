using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_Managment_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            customer1.BringToFront();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            employee1.BringToFront();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Goods_Click(object sender, EventArgs e)
        {
            goods1.BringToFront();
        }

        private void Salary_Click(object sender, EventArgs e)
        {
            salary1.BringToFront();
        }

        private void Store_Click(object sender, EventArgs e)
        {
            store1.BringToFront();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            orders1.BringToFront();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            payment1.BringToFront();
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            purchase1.BringToFront();
        }
    }
}
