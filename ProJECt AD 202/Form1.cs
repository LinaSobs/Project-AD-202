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

namespace ProJECt_AD_202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=YK-LAPTOP/SQLEXPRESS;Initial Catalog=StudentDatabase;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtSurname.Text != "" && txtAge.Text != "" && txtGender.Text != "" && txtAddress.Text != "" && txtCourse.Text != "")
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into student values(@StdName, @StdSurname, @Age, @Gender, @Address, @Course)", conn);
                    cmd.Parameters.AddWithValue("@StdName", txtName.Text);
                    cmd.Parameters.AddWithValue("@StdSurname", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Application submitted successfully.");

                }

                else
                {
                    MessageBox.Show("ERROR101");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtAge.Text = "";
            txtGender.Text = "";
            txtAddress.Text = "";
            txtCourse.Text = "";
        }
    }
}
