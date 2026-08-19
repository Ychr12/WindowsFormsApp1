using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite; 

namespace WindowsFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            var ThisSQLiteConnection = new SQLiteConnection(@"Data Source=C:\Users\Chengliang Xiao\Desktop\示例数据库.db");
            var Datatable = new DataTable();
            var adp = new SQLiteDataAdapter("select * from users", ThisSQLiteConnection);
            adp.Fill(Datatable);
            dataGridView1.DataSource = Datatable;

        }
    }
}
