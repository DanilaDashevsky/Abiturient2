using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public MySqlCommand mycom;
        public static string connect = "Server=localhost;port=3306;user=root;password=root;database=danilka";
        public static MySqlConnection mycon = new MySqlConnection(connect);
        public static MySqlDataAdapter mdb;
        public DataSet cd;
        public static DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            mycon.Open();
            mdb = new MySqlDataAdapter("SELECT * FROM abituriens", connect);
            mdb.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mycom = new MySqlCommand("insert into abiturient (Специальность,Фамиля,Имя)values('TextBox1.Text','TextBox2.Text,'TextBox3.Text')", mycon);

            //Form2 f2 = new Form2();
            //f2.Show();
        }
    }
}
