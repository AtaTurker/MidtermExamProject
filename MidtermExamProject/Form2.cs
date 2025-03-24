using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermExamProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("You selected Grade: A");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show("You selected Grade: B");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                MessageBox.Show("You selected Grade: C");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                MessageBox.Show("You selected Grade: D");
            }
            if (comboBox1.SelectedIndex == 4)
            {
                MessageBox.Show("You selected Grade: E");
            }
            if (comboBox1.SelectedIndex == 5)
            {
                MessageBox.Show("You selected Grade: F");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add(textBox1);
            }
            else MessageBox.Show("Please enter a task", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else MessageBox.Show("Please select a task","Wrong input",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1 = null;
        }
    }
}
