using DevExpress.XtraEditors;
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

namespace Studies_of_medicinal_substances
{
    public partial class Manufacturing_Companies_input : DevExpress.XtraEditors.XtraForm
    {
        public Manufacturing_Companies_input()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new inputs();
            newform.Show();
        }

        private void Manufacturing_Companies_input_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.Items.Clear();
            comboBoxEdit2.Properties.Items.Clear();
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {


                
                var companieslist = chemicalEn.tCompanies.ToList();

                foreach (var company in companieslist)
                {
                    comboBoxEdit1.Properties.Items.Add(company.fCompanyName);
                }

                var Chemicallist = chemicalEn.tChemical_Base.ToList();

                foreach (var Chemical in Chemicallist)
                {
                    comboBoxEdit2.Properties.Items.Add(Chemical.fName);
                }
            }
            comboBoxEdit1.SelectedIndexChanged += comboBoxEdit1_SelectedIndexChanged;
        }


        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DevExpress.XtraEditors.ComboBoxEdit comboBox = (DevExpress.XtraEditors.ComboBoxEdit)sender;
            string selectedCompanyName = comboBox.SelectedItem.ToString();
            DataGridViewTextBoxColumn componentNameColumn = new DataGridViewTextBoxColumn();
            componentNameColumn.Name = "ComponentName";
            componentNameColumn.HeaderText = "Component Name";
            Chemicals.Columns.Clear();
            Chemicals.Columns.Add(componentNameColumn);
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                //  بارگذاری  آیدی  شرکت  با  استفاده  از  نام  شرکت
                var Company = chemicalEn.tCompanies
                    .FirstOrDefault(cc => cc.fCompanyName == selectedCompanyName);

                if (Company != null)
                {
                    long selectedCompanylId = Company.fID;

                    //  بارگذاری  آیدی‌های  مواد تولیدی  مرتبط  با  شرکت  انتخاب  شده
                    var MChemicals = chemicalEn.tManufacturing_Companies
                        .Where(cc => cc.fCompany_ID == selectedCompanylId)
                        .Select(cc => cc.fChemical_Base_ID) 
                        .ToList();

                    //  پاک  کردن  جدول  قبلی
                    Chemicals.Rows.Clear();

                    //  بارگذاری  نام‌های  مواد تولیدی  با  استفاده  از  آیدی‌های  بازیابی  شده
                    foreach (var ChemicalId in MChemicals)
                    {
                        var Chemical = chemicalEn.tChemical_Base //  فرض  می‌کنیم  که  این  جدول  نام  مواد  تشکیل‌دهنده  را  نگه  می‌دارد
                            .FirstOrDefault(cc => cc.fID == ChemicalId);
                        if (Chemical != null)
                        {
                            int rowIndex = Chemicals.Rows.Add();
                            Chemicals.Rows[rowIndex].Cells["ComponentName"].Value = Chemical.fName; //  فرض  می‌کنیم  که fName  نام  مواد  تشکیل‌دهنده  است
                        }
                    }
                }
                else
                {
                    //  مدیریت  خطا  در  صورت  عدم  یافت  نام  ماده
                    MessageBox.Show("The selected Company name does not exist in the database.");
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string selected_company = comboBoxEdit1.SelectedItem.ToString();

            string selected_Chemical = comboBoxEdit2.SelectedItem.ToString();

            try
            {
                using (ChemicalEntities chemicalEn = new ChemicalEntities())
                {

                    var selected_company_ID = chemicalEn.tCompanies.FirstOrDefault(c => c.fCompanyName == selected_company).fID;

                    var selected_chemical_ID = chemicalEn.tChemical_Base.FirstOrDefault(ch => ch.fName == selected_Chemical).fID;

                    tManufacturing_Companies Manufacturing_Company = new tManufacturing_Companies()
                    {
                        fChemical_Base_ID = selected_chemical_ID,
                        fCompany_ID = selected_company_ID

                    };
                    chemicalEn.tManufacturing_Companies.Add(Manufacturing_Company);
                    chemicalEn.SaveChanges();
                    XtraMessageBox.Show("تولید کننده افزوده شده");
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("تولید کننده افزوده نشده");
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
