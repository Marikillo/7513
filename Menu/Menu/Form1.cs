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

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text.Trim();
            string Pass = textBox2.Text.Trim();
            if (Name == "" || Pass == "")
            {
                MessageBox.Show("Вы не ввели данные");
            }
            else
            {
                SqlConnection connect = new SqlConnection(Program.st_connect);
                connect.Open();
                string s = $"select * from Admin where Name ='{Name}' and Pass='" + Pass + "'";
                SqlCommand command = new SqlCommand(s, connect);
                //SqlDataReader reader = command.ExecuteReader();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);
                if (data.Rows.Count > 0)
                {
                    Program.id_admin = (int)data.Rows[0]["id_admin"];
                    if (Program.id_admin == (int)data.Rows[0]["id_admin"])
                    {
                        Form2 f = new Form2();
                        f.Show();
                    }
                }
                connect.Close();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
        }
    }
}
