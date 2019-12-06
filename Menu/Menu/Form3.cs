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
using System.IO;

namespace Menu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" ||
                textBox2.Text.Trim() == "" ||
                textBox3.Text.Trim() == ""
                )
            {
                MessageBox.Show("не все поля заполнены!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(Program.st_connect);
                conn.Open();
                string s = "select* from Bludo where name='" + textBox1.Text.Trim() + "'";
                SqlCommand comm = new SqlCommand(s, conn);
                SqlDataReader read = comm.ExecuteReader();
                if (read.HasRows)
                {
                    MessageBox.Show("Такое блюдо уже существует");
                }
                else
                {
                    read.Close();
                    string s1 = "insert into Bludo values " +
                    "('" + textBox1.Text.Trim() + "'," +
                    "" + textBox2.Text.Trim() + "," +
                    "" + textBox3.Text.Trim() + "," +
                    "'" + textBox4.Text.Trim() + "'," +
                    "'" + textBox5.Text.Trim() + "'," +
                    "'" + label6.Text.Trim() + "')";
                    SqlCommand comm1 = new SqlCommand(s1, conn);
                    comm1.ExecuteScalar();
                    this.Close();


                }
                conn.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    label6.Text = Path.GetFileName(openFileDialog1.FileName);
                    File.Copy(openFileDialog1.FileName, AppDomain.CurrentDomain.BaseDirectory + label6.Text, true);//true = перезапись имени файла без ошибок

                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
        }
    }
}
