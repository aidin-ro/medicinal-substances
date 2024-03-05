using DevExpress.XtraEditors;
using Studies_of_medicinal_substances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLayer
{
    public partial class Import_Value_input : DevExpress.XtraEditors.XtraForm
    {
        public Import_Value_input()
        {
            InitializeComponent();
        }



        private void Import_Value_input_Load(object sender, EventArgs e)
        {
            Chemical_combo.Properties.Items.Clear();
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {

                var Chemicallist = chemicalEn.tChemical_Base.ToList();

                foreach (var Chemical in Chemicallist)
                {
                    Chemical_combo.Properties.Items.Add(Chemical.fName);
                }
            }
            Chemical_combo.SelectedIndexChanged += Chemical_combo_SelectedIndexChanged;
        }
        private void Chemical_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit comboBox = (DevExpress.XtraEditors.ComboBoxEdit)sender;
            string selectedChemicalName = comboBox.SelectedItem.ToString();

            // اضافه کردن ستون‌های مورد نیاز به DataGridView
            Import_data_gridview.Columns.Clear();

            // ستون نام ماده تشکیل‌دهنده
            DataGridViewTextBoxColumn ChemiclaNameColumn = new DataGridViewTextBoxColumn();
            ChemiclaNameColumn.Name = "Chmical";
            ChemiclaNameColumn.HeaderText = "Chmical";
            Import_data_gridview.Columns.Add(ChemiclaNameColumn);

            // ستون حجم واردات
            DataGridViewTextBoxColumn importVolumeColumn = new DataGridViewTextBoxColumn();
            importVolumeColumn.Name = "Import_Volume";
            importVolumeColumn.HeaderText = "Import Volume";
            Import_data_gridview.Columns.Add(importVolumeColumn);

            // ستون قیمت میانگین
            DataGridViewTextBoxColumn averagePriceColumn = new DataGridViewTextBoxColumn();
            averagePriceColumn.Name = "Average_Price";
            averagePriceColumn.HeaderText = "Average Price";
            Import_data_gridview.Columns.Add(averagePriceColumn);

            // ستون قیمت دلاری
            DataGridViewTextBoxColumn dollarPriceColumn = new DataGridViewTextBoxColumn();
            dollarPriceColumn.Name = "Dollar_Price";
            dollarPriceColumn.HeaderText = "Dollar Price";
            Import_data_gridview.Columns.Add(dollarPriceColumn);

            // ستون سال واردات
            DataGridViewTextBoxColumn importYearColumn = new DataGridViewTextBoxColumn();
            importYearColumn.Name = "fImport_Year";
            importYearColumn.HeaderText = "Import Year";
            Import_data_gridview.Columns.Add(importYearColumn);

            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                // بارگذاری آیدی ماده با استفاده از نام ماده
                var Chemical = chemicalEn.tChemical_Base
                    .FirstOrDefault(cc => cc.fName == selectedChemicalName);

                if (Chemical != null)
                {
                    long selectedChemicalId = Chemical.fID;

                    // بارگذاری آیدی‌های مواد تشکیل‌دهنده مرتبط با ماده انتخاب شده
                    var ImportsId = chemicalEn.tImport_Value
                        .Where(cc => cc.fChemical_Base == selectedChemicalId)
                        .Select(cc => cc.fID) // فرض می‌کنیم که fConstituent_Chemical آیدی مواد تشکیل‌دهنده است
                        .ToList();

                    // پاک کردن جدول قبلی
                    Import_data_gridview.Rows.Clear();

                    // بارگذاری نام‌های مواد تشکیل‌دهنده با استفاده از آیدی‌های بازیابی شده
                    foreach (var ImportId in ImportsId)
                    {
                        var Import = chemicalEn.tImport_Value // فرض می‌کنیم که این جدول نام مواد تشکیل‌دهنده را نگه می‌دارد
                            .FirstOrDefault(cc => cc.fID == ImportId);
                        if (Import != null)
                        {
                            int rowIndex = Import_data_gridview.Rows.Add();
                            Import_data_gridview.Rows[rowIndex].Cells["Chmical"].Value = Chemical.fName; // فرض می‌کنیم که fName نام مواد تشکیل‌دهنده است
                            Import_data_gridview.Rows[rowIndex].Cells["Import_Volume"].Value = Import.fImport_Volume; // فرض می‌کنیم که fImport_Volume حجم واردات است
                            Import_data_gridview.Rows[rowIndex].Cells["Average_Price"].Value = Import.fAverage_Price; // فرض می‌کنیم که fAverage_Price قیمت میانگین است
                            Import_data_gridview.Rows[rowIndex].Cells["Dollar_Price"].Value = Import.fDollar_Price; // فرض می‌کنیم که fDollar_Price قیمت دلاری است
                            Import_data_gridview.Rows[rowIndex].Cells["fImport_Year"].Value = Import.fImport_Year; // فرض می‌کنیم که fImport_Year سال واردات است
                        }
                    }
                }
                else
                {
                    // مدیریت خطا در صورت عدم یافت نام ماده
                    MessageBox.Show("The selected chemical name does not exist in the database.");
                }
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (ChemicalEntities chemicalEn = new ChemicalEntities())
                {
                    string selected_Chemical = Chemical_combo.SelectedItem.ToString();
                    var selected_Chemical_ID = chemicalEn.tChemical_Base.FirstOrDefault(c => c.fName == selected_Chemical).fID;
                    tImport_Value addimport = new tImport_Value()
                    {
                        fChemical_Base = selected_Chemical_ID,
                        fImport_Volume = int.Parse(Import_Volume_txtbox.Text),
                        fAverage_Price = int.Parse(Average_Price_txtbox.Text),
                        fDollar_Price = int.Parse(Dollar_Price_txtbox.Text),
                        fImport_Year = int.Parse(Import_Year_txtbox.Text)
                    };
                    chemicalEn.tImport_Value.Add(addimport);
                    chemicalEn.SaveChanges(); // This line commits the changes to the database
                }
                XtraMessageBox.Show(".اطلاعات ذخیره شد");
            }
            catch (Exception)
            {

                XtraMessageBox.Show(".اطلاعات ذخیره نشد");
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new inputs();
            newform.Show();
        }
    }
}
