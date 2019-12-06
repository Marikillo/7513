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
using Microsoft.Office.Interop.Excel;

namespace Menu
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            int id = Convert.ToInt32(comboBox1.SelectedValue);
            string s = "select Type.Racion, Bludo.name, Bludo.ves, Bludo.kal, Bludo.sost, Bludo.cena, Bludo.photo, Menu.Data " +
            "From dbo.Menu inner join dbo.Type on Menu.id_type = Type.id_type inner join Bludo on Menu.id_bludo = Bludo.id_bludo "+
            "where Bludo.id_bludo= "+id;
            SqlDataAdapter adap = new SqlDataAdapter(s, conn);//Используем SqlDataAdapter т.к. будем выгружать данные в дата грид через дата сет 
                                                              //(адаптер потому что датагрид, выгружает данные в другом формате
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bludoDataSet3.Bludo". При необходимости она может быть перемещена или удалена.
            this.bludoTableAdapter.Fill(this.bludoDataSet3.Bludo);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application myExcel = new Microsoft.Office.Interop.Excel.Application();//создаем виртуальный объект Excel
            //создать книгу в объекте Excel
            myExcel.Application.Workbooks.Add(Type.Missing);
            //Настраиваем ячейки
            myExcel.Columns.ColumnWidth = 15;
            //Пишем заголовки ячеек
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                myExcel.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;// заголовки программно
            }

            /*myExcel.Cells[1, 2] = "Заголовок 2"; //заголовки прописаны
            myExcel.Cells[1, 3] = "Заголовок 3";
            myExcel.Cells[1, 4] = "Заголовок 4";*/

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    myExcel.Cells[j + 2, i + 1] = dataGridView1[i, j].Value.ToString();
                }
            }

            myExcel.Visible = true;
        }
    }
}
