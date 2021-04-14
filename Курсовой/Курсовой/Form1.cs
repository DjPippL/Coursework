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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = radioButton1.Checked;
            textBox1.Visible = radioButton1.Checked;
            label2.Visible = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                {
                if (textBox1.Text == "пароль123")
                    {
                    (new Form2()).Show(); this.Close();
                }
                else
                    {
                    textBox1.Text = "";
                    MessageBox.Show("Невірний пароль!");
                    }
                }
            if (radioButton2.Checked == true)
                {
                (new Form3()).Show(); this.Close();
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                MessageBox.Show("Виберіть рівень доступу!");
                }
        }
    }
}
