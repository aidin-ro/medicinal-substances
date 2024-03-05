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
    public partial class Tec_Production_input : DevExpress.XtraEditors.XtraForm
    {
        public Tec_Production_input()
        {
            InitializeComponent();
        }

        

        private void Tec_Production_input_Load(object sender, EventArgs e)
        {
            Tec_combo.Properties.Items.Clear();
            Chemical_combo.Properties.Items.Clear();
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {



                var Tec_list = chemicalEn.tTechnologies.ToList();

                foreach (var Tec in Tec_list)
                {
                    Tec_combo.Properties.Items.Add(Tec.fName);
                }

                var Chemicallist = chemicalEn.tChemical_Base.ToList();

                foreach (var Chemical in Chemicallist)
                {
                    Chemical_combo.Properties.Items.Add(Chemical.fName);
                }
            }
            Tec_combo.SelectedIndexChanged += Tec_combo_SelectedIndexChanged;
        }

        private void Tec_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.ComboBoxEdit comboBox = (DevExpress.XtraEditors.ComboBoxEdit)sender;
            string selectedTecName = comboBox.SelectedItem.ToString();
            Tec_data_gridview.Columns.Clear();
            DataGridViewTextBoxColumn componentNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "Chemical Name",
                HeaderText = "Chemical Name"
            };
            Tec_data_gridview.Columns.Add(componentNameColumn);


            DataGridViewTextBoxColumn TecColumn = new DataGridViewTextBoxColumn
            {
                Name = "Tec Name",
                HeaderText = "Tec Name"
            };
            Tec_data_gridview.Columns.Add(TecColumn);
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                //  بارگذاری  آیدی  ماده  با  استفاده  از  نام  ماده
                var Tec = chemicalEn.tTechnologies
                    .FirstOrDefault(cc => cc.fName == selectedTecName);

                if (Tec != null)
                {
                    long selectedTecId = Tec.fID;

                    //  بارگذاری  آیدی‌های  مواد  تشکیل‌دهنده  مرتبط  با  ماده  انتخاب  شده
                    var ChemicalIds = chemicalEn.tTechnologies_Production
                        .Where(cc => cc.fTec_ID == selectedTecId)
                        .Select(cc => cc.fChmical_ID) //  فرض  می‌کنیم  که fConstituent_Chemical  آیدی  مواد  تشکیل‌دهنده  است
                        .ToList();

                    //  پاک  کردن  جدول  قبلی
                    Tec_data_gridview.Rows.Clear();

                    //  بارگذاری  نام‌های  مواد  تشکیل‌دهنده  با  استفاده  از  آیدی‌های  بازیابی  شده
                    foreach (var ChemicalId in ChemicalIds)
                    {
                        var Chemical = chemicalEn.tChemical_Base //  فرض  می‌کنیم  که  این  جدول  نام  مواد  تشکیل‌دهنده  را  نگه  می‌دارد
                            .FirstOrDefault(cc => cc.fID == ChemicalId);
                        if (Chemical != null)
                        {
                            int rowIndex = Tec_data_gridview.Rows.Add();
                            Tec_data_gridview.Rows[rowIndex].Cells["Chemical Name"].Value = Chemical.fName;

                            Tec_data_gridview.Rows[rowIndex].Cells["Tec Name"].Value = selectedTecName;//  فرض  می‌کنیم  که fName  نام  مواد  تشکیل‌دهنده  است
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

        private void Submit_Click(object sender, EventArgs e)
        {
            string selected_Tec = Tec_combo.SelectedItem.ToString();

            string selected_Chemical = Chemical_combo.SelectedItem.ToString();

            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {

                var selected_Tec_ID = chemicalEn.tTechnologies.FirstOrDefault(c => c.fName == selected_Tec).fID;

                var selected_chemical_ID = chemicalEn.tChemical_Base.FirstOrDefault(ch => ch.fName == selected_Chemical).fID;

                tTechnologies_Production addTec_pred = new tTechnologies_Production()
                {
                    fChmical_ID = selected_chemical_ID,
                    fTec_ID = selected_Tec_ID

                };
                chemicalEn.tTechnologies_Production.Add(addTec_pred);
                chemicalEn.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new inputs();
            newform.Show();

        }
    }
}
