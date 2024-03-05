using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studies_of_medicinal_substances
{
    public partial class inputs : Form
    {
        public inputs()
        {
            InitializeComponent();
        }

        private void Chemical_input_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            var newform = new Chemical_Base_input();
            newform.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Companies_input_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new companis_input();
            newform.Show();
        }

        private void inputs_Load(object sender, EventArgs e)
        {

        }

        private void Consumer_input_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new Consumer_input();
            newform.Show();
        }

        private void Constituent_Chemicals_input_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new Constituent_Chemicals_input();
            newform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

            var newform = new Manufacturing_Companies_input();
            newform.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();

            var newform = new Tec_input();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new Tec_Production_input();
            newform.Show();
        }
    }
}
