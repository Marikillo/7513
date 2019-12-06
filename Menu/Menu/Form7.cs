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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            //string id = dateTimePicker1.ToString();
            string s = "select Type.Racion, Bludo.name, Bludo.ves, Bludo.kal, Bludo.sost, Bludo.cena, Bludo.photo, Menu.Data " +
            "From dbo.Menu inner join dbo.Type on Menu.id_type = Type.id_type inner join Bludo on Menu.id_bludo = Bludo.id_bludo " +
            "where Menu.Data= " + "'" + dateTimePicker1.Value + "'";
            SqlDataAdapter adap = new SqlDataAdapter(s, conn);//Используем SqlDataAdapter т.к. будем выгружать данные в дата грид через дата сет 
                                                              //(адаптер потому что датагрид, выгружает данные в другом формате
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            //"'" + dateTimePicker1.Value + "'"
        }
    }
}
