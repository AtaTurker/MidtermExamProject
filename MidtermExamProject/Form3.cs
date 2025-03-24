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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            updateColor();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Value += 1;
        }
        private void updateColor()
        {
            int redintensity = trackBar1.Value;
            int greenintensity = vScrollBar1.Value;
            int blueintensity = hScrollBar1.Value;
            int alpha = 0;
            //it gives an error
            //Form3.DefaultBackColor = System.Drawing.Color(alpha, redintensity, greenintensity, blueintensity);
            label1.Text = $"Current Color: RGB({redintensity}, {greenintensity}, {blueintensity})";
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Value += 1;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Value += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
