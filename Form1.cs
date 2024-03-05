using DLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace Studies_of_medicinal_substances
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Import_Value_input import_Value_ = new Import_Value_input();
            import_Value_.MdiParent = this;
            import_Value_.WindowState = FormWindowState.Maximized;
            import_Value_.Show();
        }
    }
}
