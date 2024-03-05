using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLayer;
namespace Studies_of_medicinal_substances
{
    public partial class Chemical_Base_Show_Data : DevExpress.XtraEditors.XtraForm
    {
        public Chemical_Base_Show_Data()
        {
            InitializeComponent();
        }

        private void Chemical_Base_Show_Data_Load(object sender, EventArgs e)
        {


            ChemicalEntities chemicalEn = new ChemicalEntities();



            tChemicalBaseBindingSource7.DataSource = chemicalEn.tChemical_Base.ToList();

            gridView.ActiveFilterString = "[fDeleted] <> 1";
            gridView.OptionsBehavior.Editable = false;
            gridView.ShowFindPanel();
            gridView.Appearance.Row.Font = new Font("Tahoma", 10);

        }



          
      

        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
