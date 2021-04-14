using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD=System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой
{
    public partial class Form2 : Form
    {
        private string s;

        public Form2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form4()).Show(); this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
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
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            s = dataGridView2.CurrentCell.Value.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            try
            {
                
                db.openConnection();
                string command = "DELETE FROM items WHERE (ID=" + Convert.ToInt16(s) + ");";
                MySqlCommand ms_data = new MySqlCommand(command, db.getConnection());
                ms_data.ExecuteNonQuery();
                MessageBox.Show("Видалення успішне", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Видалення не виконано\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }


    }
}
