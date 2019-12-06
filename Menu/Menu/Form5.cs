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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bludoDataSet2.Bludo". При необходимости она может быть перемещена или удалена.
            this.bludoTableAdapter.Fill(this.bludoDataSet2.Bludo);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bludoDataSet1.Type". При необходимости она может быть перемещена или удалена.
            this.typeTableAdapter.Fill(this.bludoDataSet1.Type);
            comboBox1.SelectedIndex = 0;
            dataGridView2.RowCount = 1;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView2.RowCount;
            n = n + 1;
            dataGridView2.RowCount = n;
            //получаем номер выделенной строки в первом датагриде
            int m = dataGridView1.CurrentRow.Index;
            dataGridView2[0, n - 2].Value = comboBox1.Text.ToString();
            dataGridView2[1, n - 2].Value = dataGridView1[1, m].Value.ToString();
            dataGridView2[2, n - 2].Value = dataGridView1[2, m].Value;
            dataGridView2[3, n - 2].Value = dataGridView1[3, m].Value;
            dataGridView2[4, n - 2].Value = dataGridView1[4, m].Value;
            dataGridView2[5, n - 2].Value = dataGridView1[5, m].Value;
            dataGridView2[6, n - 2].Value = dataGridView1[6, m].Value;
            dataGridView2[7, n - 2].Value = dateTimePicker1.Value.ToString();
            dataGridView2[8, n - 2].Value = dataGridView1[0, m].Value.ToString();
            dataGridView2[9, n - 2].Value = comboBox1.SelectedValue;
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 1)
            {
                int n = dataGridView2.CurrentRow.Index;
                dataGridView2.Rows.RemoveAt(n);
                dataGridView2.Refresh();
            }
            else
            {
                MessageBox.Show("Не трожь!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                SqlConnection conn = new SqlConnection(Program.st_connect);
                conn.Open();
                string s = "INSERT INTO Menu (id_bludo, id_type, Data) VALUES (" + dataGridView2[8, i].Value.ToString() + ", " + dataGridView2[9, i].Value.ToString() + ", " +
                    "'" + dataGridView2[7, i].Value + "')";
                SqlCommand comm = new SqlCommand(s, conn);
                comm.ExecuteScalar();


                conn.Close();
            }
            dataGridView2.Rows.Clear();
            dataGridView2.RowCount = 1;
            MessageBox.Show("Блюдо добавлено");
            this.Close();
        }
    }
}
