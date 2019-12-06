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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bludoDataSet.Bludo". При необходимости она может быть перемещена или удалена.
            this.bludoTableAdapter.Fill(this.bludoDataSet.Bludo);
            dataGridView1.MultiSelect = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentRow.Index;
            int id_bludo = Convert.ToInt32(dataGridView1[0, k].Value);
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "DELETE FROM Bludo WHERE id_bludo=" + id_bludo.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            comm.ExecuteScalar();
            conn.Close();
            MessageBox.Show("Блюдо удалено");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            int edit_id = (int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value;
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "select * from Bludo where id_bludo ='" + edit_id + "' ";
            SqlCommand command = new SqlCommand(s, conn);
            SqlDataReader read = command.ExecuteReader();
            read.Read();
            Form4 f = new Form4()
            {
                Edit_ID = edit_id
            };
            f.textBox1.Text = read.GetString(1);
            f.textBox2.Text = read.GetInt32(2).ToString();
            f.textBox3.Text = read.GetInt32(3).ToString();
            f.textBox4.Text = read.GetString(4);
            f.textBox5.Text = read.GetInt32(5).ToString();
            string s3 = read.GetString(6);
            f.pictureBox1.Image = Image.FromFile(s3);
            f.label6.Text = s3;
            f.Show();
            this.bludoTableAdapter.Fill(this.bludoDataSet.Bludo);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            /*SqlConnection connection = new SqlConnection(Program.st_connect);
            connection.Open();
            string s = "select name, ves, kal, sost, cena, photo" +
                "from Bludo where id_bludo>0";
            SqlDataAdapter adapter = new SqlDataAdapter(s,connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            connection.Close();*/
            this.bludoTableAdapter.Fill(this.bludoDataSet.Bludo);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }
    }
}
