using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusaAirline
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            this.вакансииTableAdapter.Fill(this.planeDataSet.Вакансии);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var url = "https://docs.google.com/forms/d/e/1FAIpQLSda06QzFdRW4FYsubrW0lHOeEKqA21ks1mScUtvAPhKg4AdIw/viewform?usp=sf_link";
            System.Diagnostics.Process.Start(url);

        }
    }
}
