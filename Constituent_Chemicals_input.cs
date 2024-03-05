using DLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studies_of_medicinal_substances
{
    public partial class Constituent_Chemicals_input : DevExpress.XtraEditors.XtraForm
    {
        public Constituent_Chemicals_input()
        {
            InitializeComponent();
        }

        private void Constituent_Chemicals_input_Load(object sender, EventArgs e)
        {
            comboBoxEdit2.Properties.Items.Clear();
            comboBoxEdit1.Properties.Items.Clear();
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {



                var Chemicalslist = chemicalEn.tChemical_Base.ToList();

                foreach (var Chemical in Chemicalslist)
                {
                    comboBoxEdit1.Properties.Items.Add(Chemical.fName);
                }

                foreach (var Chemical in Chemicalslist)
                {
                    comboBoxEdit2.Properties.Items.Add(Chemical.fName);
                }
            }
            comboBoxEdit2.SelectedIndexChanged += Chemical_Base_combo_SelectedIndexChanged;
        }

        private void Chemical_Base_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit comboBox = (DevExpress.XtraEditors.ComboBoxEdit)sender;
            string selectedChemicalName = comboBox.SelectedItem.ToString();

            DataGridViewTextBoxColumn componentNameColumn = new DataGridViewTextBoxColumn();
            componentNameColumn.Name = "ComponentName";
            componentNameColumn.HeaderText = "Component Name";
            Components_data_gridview.Columns.Clear();
            Components_data_gridview.Columns.Add(componentNameColumn);
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                //  بارگذاری  آیدی  ماده  با  استفاده  از  نام  ماده
                var chemical = chemicalEn.tChemical_Base
                    .FirstOrDefault(cc => cc.fName == selectedChemicalName);

                if (chemical != null)
                {
                    long selectedChemicalId = chemical.fID;

                    //  بارگذاری  آیدی‌های  مواد  تشکیل‌دهنده  مرتبط  با  ماده  انتخاب  شده
                    var componentIds = chemicalEn.tConstituent_Chemicals
                        .Where(cc => cc.fChemical_Base_ID == selectedChemicalId)
                        .Select(cc => cc.fConstituent_Chemical) //  فرض  می‌کنیم  که fConstituent_Chemical  آیدی  مواد  تشکیل‌دهنده  است
                        .ToList();

                    //  پاک  کردن  جدول  قبلی
                    Components_data_gridview.Rows.Clear();

                    //  بارگذاری  نام‌های  مواد  تشکیل‌دهنده  با  استفاده  از  آیدی‌های  بازیابی  شده
                    foreach (var componentId in componentIds)
                    {
                        var component = chemicalEn.tChemical_Base //  فرض  می‌کنیم  که  این  جدول  نام  مواد  تشکیل‌دهنده  را  نگه  می‌دارد
                            .FirstOrDefault(cc => cc.fID == componentId);
                        if (component != null)
                        {
                            int rowIndex = Components_data_gridview.Rows.Add();
                            Components_data_gridview.Rows[rowIndex].Cells["ComponentName"].Value = component.fName; //  فرض  می‌کنیم  که fName  نام  مواد  تشکیل‌دهنده  است
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
        private void SaveChemicals()
        {
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                //  بارگذاری  آیدی‌های  ماده‌های  انتخاب  شده
                long baseChemicalId = GetChemicalIdByName(comboBoxEdit2.SelectedItem.ToString());
                long componentChemicalId = GetChemicalIdByName(comboBoxEdit1.SelectedItem.ToString());

                //  اطمینان  حاصل  کردن  که  کلید  اصلی  تکراری  نیست
                if (baseChemicalId != 0 && componentChemicalId != 0)
                {
                    //  ثبت  اطلاعات  ماده‌ها  در  دیتابیس
                    var newChemicalRelation = new tConstituent_Chemicals
                    {
                        fChemical_Base_ID = baseChemicalId,
                        fConstituent_Chemical = componentChemicalId
                    };
                    chemicalEn.tConstituent_Chemicals.Add(newChemicalRelation);

                    try
                    {
                        chemicalEn.SaveChanges();
                        //  نمایش  پیغام  ثبت  شدن
                        MessageBox.Show("Chemicals have been saved successfully.");

                        UpdateDataGridView();

                    }
                    catch (DbUpdateException ex)
                    {
                        //  نمایش  پیغام  خطا  در  صورت  بروز  خطا  در  هنگام  ذخیره  سازی
                        MessageBox.Show("Error: " + ex.InnerException.Message);
                    }
                }
                else
                {
                    //  نمایش  پیغام  خطا  در  صورت  عدم  وجود  کلید  اصلی
                    MessageBox.Show("Error: Invalid chemical ID.");
                }
            }
        }

        private long GetChemicalIdByName(string chemicalName)
        {
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                var chemical = chemicalEn.tChemical_Base
                    .FirstOrDefault(cc => cc.fName == chemicalName);
                return chemical?.fID ?? 0;
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
                long selectedChemicalId = GetChemicalIdByName(comboBoxEdit2.SelectedItem.ToString());
                var componentIds = chemicalEn.tConstituent_Chemicals
                    .Where(cc => cc.fChemical_Base_ID == selectedChemicalId)
                    .Select(cc => cc.fConstituent_Chemical)
                    .ToList();

                foreach (var componentId in componentIds)
                {
                    var component = chemicalEn.tChemical_Base
                        .FirstOrDefault(cc => cc.fID == componentId);
                    if (component != null)
                    {
                        int rowIndex = Components_data_gridview.Rows.Add();
                        Components_data_gridview.Rows[rowIndex].Cells["ComponentName"].Value = component.fName;
                    }
                }
            }
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            SaveChemicals();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new inputs();
            newform.Show();
        }

        private void Components_data_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

