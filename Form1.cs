using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_CRUD__App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AJIT-PC;Initial Catalog=\"Windows Forms CRUD App\";Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ut values(@id,@name,@age)", con);
            cmd.Parameters.AddWithValue("@id",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Sucessfully Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AJIT-PC;Initial Catalog=\"Windows Forms CRUD App\";Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update ut set values(@id,@name,@age)", con);
        }
    }
}
