using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD=System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Form1()).Show(); this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label2.Visible = true;
            dataGridView2.Visible = true;
            try
            {
                DB db = new DB();
                string command = "SELECT * FROM `items`";
                db.openConnection();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(command, db.getConnection());
                SD.DataTable table = new SD.DataTable();
                ms_data.Fill(table);
                dataGridView2.DataSource = table;
                db.closeConnection();
            }
            catch
            {
                MessageBox.Show("Connection lost");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {
                dataGridView2.CurrentCell = null;
                dataGridView2.Rows[i].Visible = false;
                dataGridView2.Rows[i].Visible = false;
                for (int c = 0; c < dataGridView2.Columns.Count; c++)
                {
                    if (dataGridView2[c, i].Value.ToString() == textBox1.Text)
                    {
                        dataGridView2.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }
    }
}
