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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static Form1 f1 = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.mdb = new MySqlDataAdapter("insert into abiturient (Специальность,Фамиля,Имя)values('TextBox1.Text','TextBox2.Text,'TextBox3.Text')", Form1.connect);
                MessageBox.Show("Добавлено");
            }
            catch(SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
