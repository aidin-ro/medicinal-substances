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
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        } 

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Show_From_DB_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            var newform = new Chemical_Base_Show_Data();
            newform.Show();
        }

        private void Add_to_DB_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var newform = new inputs();
            newform.Show();
        }
    }
}
