using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLayer;
namespace Studies_of_medicinal_substances
{
    public partial class Chemical_Base_Show_Data : Form
    {
        public Chemical_Base_Show_Data()
        {
            InitializeComponent();
        }

        private void Chemical_Base_Show_Data_Load(object sender, EventArgs e)
        {
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                var Chemical = chemicalEn.tChemical_Base.FirstOrDefault(c => c.fName == "Diazepam"); // جایگزین نام مورد نظر خود باشید
                if (Chemical != null)
                {
                    var imageBytes = Chemical.fImage;
                    var bitmapImage = byteArrayToImage(imageBytes); // تابعی که تصویر را به BitmapImage تبدیل می‌کند
                    pictureBox.Image = bitmapImage;
                }
            }
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }



    }
}
