using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DLayer;

namespace Studies_of_medicinal_substances
{
    public partial class companis_input : DevExpress.XtraEditors.XtraForm
    {
        public companis_input()
        {
            InitializeComponent();
        }

        private void Add_compani_Click(object sender, EventArgs e)
        {
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                tCompanies addcompaniy = new tCompanies()
                {
                    fCompanyName = fCompanyName_input.Text,
                    fNationalCode = fNationalCode_input.Text,
                    fEconomicCode = fEconomicCode_input.Text,
                    fRegisterNumber = fRegisterNumber_input.Text,
                };
                chemicalEn.tCompanies.Add(addcompaniy);
                chemicalEn.SaveChanges(); // This line commits the changes to the database
            }
        }

     

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                using (ChemicalEntities chemicalEn = new ChemicalEntities())
                {
                    tCompanies addcompaniy = new tCompanies()
                    {
                        fCompanyName = fCompanyName_input.Text,
                        fNationalCode = fNationalCode_input.Text,
                        fEconomicCode = fEconomicCode_input.Text,
                        fRegisterNumber = fRegisterNumber_input.Text,
                    };
                    chemicalEn.tCompanies.Add(addcompaniy);
                    chemicalEn.SaveChanges(); // This line commits the changes to the database
                }
                fCompanyName_input.Text = "";
                fNationalCode_input.Text = "";
                fEconomicCode_input.Text = "";
                fRegisterNumber_input.Text = "";
                XtraMessageBox.Show(".شرکت ذخیره شد");
            }
            catch (Exception)
            {

                XtraMessageBox.Show(".شرکت ذخیره نشد");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new inputs();
            newform.Show();
        }
    }
}
