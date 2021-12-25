using System.Windows.Forms;

namespace MusaAirline
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, System.EventArgs e)
        {
            this.рейсыTableAdapter.Fill(this.planeDataSet.Рейсы);

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].FormattedValue.ToString().Contains(textBox1.Text))
                {

                    dataGridView1.Rows[i].Selected = true;
                }

                else if (dataGridView1.Rows[i].Cells[1].FormattedValue.ToString().Contains(textBox1.Text))
                {
                    dataGridView1.Rows[i].Selected = true;
                }
                else if (dataGridView1.Rows[i].Cells[2].FormattedValue.ToString().Contains(textBox1.Text))
                {
                    dataGridView1.Rows[i].Selected = true;
                }

                else if (dataGridView1.Rows[i].Cells[3].FormattedValue.ToString().Contains(textBox1.Text))
                {
                    dataGridView1.Rows[i].Selected = true;
                }
                else
                {
                    dataGridView1.Rows[i].Selected = false;



                }
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {

            string almaty = "Алматы";
            string shim = "Шымкент";
            string shim1 = "Караганды";
            string shim2 = "Москва";
            if (textBox2.Text == almaty && textBox3.Text == shim)
            {
                label3.Visible = true;
                label4.Visible = true;
                label3.Text = "681 км";
                label4.Text = "8ч. 5м";

            }
            else if (textBox2.Text == almaty && textBox3.Text == shim1)
            {
                label3.Visible = true;
                label4.Visible = true;
                label3.Text = "999 км";
                label4.Text = "13ч. 30м";


            }
            else if (textBox2.Text == almaty && textBox3.Text == shim2)
            {
                label3.Visible = true;
                label4.Visible = true;
                label3.Text = "3958 км";
                label4.Text = "48ч. 15м";


            }
        }
    }
}
