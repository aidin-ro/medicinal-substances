using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLayer;

namespace Studies_of_medicinal_substances
{
    public partial class Consumer_input : DevExpress.XtraEditors.XtraForm
    {
        public Consumer_input()
        {
            InitializeComponent();
        }

        private void Consumer_input_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.Items.Clear();
            comboBoxEdit2.Properties.Items.Clear();
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {



                var companieslist = chemicalEn.tCompanies.ToList();

                foreach (var companiy in companieslist)
                {
                    comboBoxEdit1.Properties.Items.Add(companiy.fCompanyName);
                }

                var Chemicallist = chemicalEn.tChemical_Base.ToList();

                foreach (var Chemical in Chemicallist)
                {
                    comboBoxEdit2.Properties.Items.Add(Chemical.fName);
                }
            }
            comboBoxEdit1.SelectedIndexChanged += Chemical_Base_combo_SelectedIndexChanged;
        }

        private void Chemical_Base_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit comboBox = (DevExpress.XtraEditors.ComboBoxEdit)sender;
            string selectedCompanyName = comboBox.SelectedItem.ToString();

            DataGridViewTextBoxColumn componentNameColumn = new DataGridViewTextBoxColumn();
            componentNameColumn.Name = "ComponentName";
            componentNameColumn.HeaderText = "Component Name";
            Components_data_gridview.Columns.Clear();
            Components_data_gridview.Columns.Add(componentNameColumn);
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                //  بارگذاری  آیدی  ماده  با  استفاده  از  نام  ماده
                var Company = chemicalEn.tCompanies
                    .FirstOrDefault(cc => cc.fCompanyName == selectedCompanyName);

                if (Company != null)
                {
                    long selectedChemicalId = Company.fID;

                    //  بارگذاری  آیدی‌های  مواد  تشکیل‌دهنده  مرتبط  با  ماده  انتخاب  شده
                    var ChemicalsId = chemicalEn.tConsumer_companies
                        .Where(cc => cc.fCompany_ID == selectedChemicalId)
                        .Select(cc => cc.fChmical_Base_ID) //  فرض  می‌کنیم  که fConstituent_Chemical  آیدی  مواد  تشکیل‌دهنده  است
                        .ToList();

                    //  پاک  کردن  جدول  قبلی
                    Components_data_gridview.Rows.Clear();

                    //  بارگذاری  نام‌های  مواد  تشکیل‌دهنده  با  استفاده  از  آیدی‌های  بازیابی  شده
                    foreach (var ChemicalId in ChemicalsId)
                    {
                        var Chemical = chemicalEn.tChemical_Base //  فرض  می‌کنیم  که  این  جدول  نام  مواد  تشکیل‌دهنده  را  نگه  می‌دارد
                            .FirstOrDefault(cc => cc.fID == ChemicalId);
                        if (Chemical != null)
                        {
                            int rowIndex = Components_data_gridview.Rows.Add();
                            Components_data_gridview.Rows[rowIndex].Cells["ComponentName"].Value = Chemical.fName; //  فرض  می‌کنیم  که fName  نام  مواد  تشکیل‌دهنده  است
                        }
                    }
                }
                else
                {
                    //  مدیریت  خطا  در  صورت  عدم  یافت  نام  ماده
                    MessageBox.Show("The selected chemical name does not exist in the database.");
                }
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string selected_company = comboBoxEdit1.SelectedItem.ToString();

            string selected_Chemical = comboBoxEdit2.SelectedItem.ToString();

            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {

                var selected_company_ID = chemicalEn.tCompanies.FirstOrDefault(c => c.fCompanyName == selected_company).fID;

                var selected_chemical_ID = chemicalEn.tChemical_Base.FirstOrDefault(ch => ch.fName == selected_Chemical).fID;

                tConsumer_companies Consumer = new tConsumer_companies()
                {
                    fChmical_Base_ID = selected_chemical_ID,
                    fCompany_ID = selected_company_ID

                };
                chemicalEn.tConsumer_companies.Add(Consumer);
                chemicalEn.SaveChanges();
            }
            UpdateDataGridView();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new inputs();
            newform.Show();
        }
        private long GetCompanyIdByName(string chemicalName)
        {
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                var Company = chemicalEn.tCompanies
                    .FirstOrDefault(cc => cc.fCompanyName == chemicalName);
                return Company?.fID ?? 0;
            }
        }
        private void UpdateDataGridView()
        {
            //  پاک  کردن  ردیف‌های  قبلی
            Components_data_gridview.Rows.Clear();

            //  بارگذاری  مجدد  دیتاگرید  با  استفاده  از  اطلاعات  به‌روز
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                //  بارگذاری  مجدد  اطلاعات  مواد  تشکیل‌دهنده  بر  اساس  ماده  انتخاب  شده
                long selectedCompanyId = GetCompanyIdByName(comboBoxEdit1.SelectedItem.ToString());
                var ChemicalsIds = chemicalEn.tConsumer_companies
                    .Where(cc => cc.fCompany_ID == selectedCompanyId)
                    .Select(cc => cc.fChmical_Base_ID)
                    .ToList();

                foreach (var ChemicalId in ChemicalsIds)
                {
                    var Chemical = chemicalEn.tChemical_Base
                        .FirstOrDefault(cc => cc.fID == ChemicalId);
                    if (Chemical != null)
                    {
                        int rowIndex = Components_data_gridview.Rows.Add();
                        Components_data_gridview.Rows[rowIndex].Cells["ComponentName"].Value = Chemical.fName;
                    }
                }
            }
        }
    }
}

