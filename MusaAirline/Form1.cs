using System;
using System.Windows.Forms;

namespace MusaAirline
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

        private void button3_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox1.Visible = false;
            userControl11.Visible = true;
            userControl21.Visible = false;
            userControl31.Visible = false;
            userControl41.Visible = false;
            userControl51.Visible = false;

            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox1.Visible = false;
            userControl11.Visible = false;
            userControl21.Visible = true;
            userControl31.Visible = false;
            userControl41.Visible = false;
            userControl51.Visible = false;

            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox1.Visible = false;
            userControl11.Visible = false;
            userControl21.Visible = false;
            userControl31.Visible = false;
            userControl41.Visible = false;
            userControl51.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox1.Visible = false;
            userControl11.Visible = false;
            userControl21.Visible = false;
            userControl31.Visible = true;
            userControl41.Visible = false;
            userControl51.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = true;
            panel8.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox1.Visible = false;
            panel4.Visible = false;
            userControl11.Visible = false;
            userControl21.Visible = false;
            userControl31.Visible = false;
            userControl41.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = true;
            userControl51.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();




        }
    }
}
