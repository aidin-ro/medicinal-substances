using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DLayer;
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

namespace Studies_of_medicinal_substances
{
    public partial class Show_One_Chemical : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private long _id ;
        public Show_One_Chemical()
        {
            InitializeComponent();
        }

        private void Show_One_Chemical_Load(object sender, EventArgs e)
        {

            DisplayChemicalDetails(_id);
            this.Visible = true;
        }
        public void SetID(long id)
        {
            _id = id;
        }
        private tChemical_Base GetChemicalById(long id)
        {
            try
            {
                using (ChemicalEntities chemicalEn = new ChemicalEntities())
                {
                    return chemicalEn.tChemical_Base.FirstOrDefault(c => c.fID == id);
                }
            }
            catch (Exception ex)
            {
                // Log the exception or show a message to the user
                MessageBox.Show($"Error fetching chemical data: {ex.Message}");
                return null;
            }
        }
        private void DisplayChemicalDetails(long id)
        {
            // Retrieve the chemical data
            var chemical = GetChemicalById(id);
            if (chemical != null)
            {
                // Update LabelControls with the chemical data
                labelControlName.Text = chemical.fName;
                labelControlCode.Text = chemical.fCode;
                labelControlPersianDescription.Text = chemical.fPersianDescription;
                labelControlEnglishDescription.Text = chemical.fEnglishDescription;
                labelControlPersianDescription.AutoSize = true;
                labelControlEnglishDescription.AutoSize = true;

                if (chemical.fImage != null && chemical.fImage.Length > 0)
                {
                    using (var ms = new MemoryStream(chemical.fImage))
                    {
                        pictureEdit1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureEdit1.Image = null; // Or set to a default image if needed
                }
            }
            else
            {
                // Handle the case where no chemical was found with the given ID
                XtraMessageBox.Show("No chemical found with the given ID.");
            }
        }




        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}