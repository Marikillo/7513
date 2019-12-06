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
    public partial class Form4 : Form
    {
        public int Edit_ID { get; set; }
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s1 = "update Bludo set " +
                    "name='" + textBox1.Text.Trim() + "', " +
                    "ves='" + textBox2.Text.Trim() + "', " +
                    "kal='" + textBox3.Text.Trim() + "', " +
                    "sost='" + textBox4.Text.Trim() + "', " +
                    "cena='" + textBox5.Text.Trim() + "', " +
                    "photo='" + label6.Text.Trim() + "' " +
                    "where id_bludo=" + Edit_ID;
            SqlCommand comm1 = new SqlCommand(s1, conn);
            comm1.ExecuteScalar();
            this.Close();
            conn.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
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
