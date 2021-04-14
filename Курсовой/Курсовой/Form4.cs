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

namespace Курсовой
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Form2()).Show(); this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введіть назву");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введіть тип");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Введіть кількість");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Введіть ім'я");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Введіть прізвище");
                return;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `items` ( `Назва`, `Тип`, `Кількість`, `Ім'я`, `Прізвище`) VALUES (@item, @pass, @amount, @name, @surname)", db.getConnection());
            command.Parameters.Add("@item", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@amount", MySqlDbType.Int64).Value = textBox3.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = textBox5.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Товар був доданий!");
            else 
                MessageBox.Show("Товар не був доданий!");
            db.closeConnection();
        }
    }
}
