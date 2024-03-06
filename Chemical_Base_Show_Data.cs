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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DLayer;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace Studies_of_medicinal_substances
{
    public partial class Chemical_Base_Show_Data : DevExpress.XtraEditors.XtraForm
    {
        public Chemical_Base_Show_Data()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Chemical_Base_Show_Data_Load(object sender, EventArgs e)
        {


            ChemicalEntities chemicalEn = new ChemicalEntities();



            tChemicalBaseBindingSource7.DataSource = chemicalEn.tChemical_Base.ToList();

            gridView.ActiveFilterString = "[fDeleted] <> 1";
            gridView.OptionsBehavior.Editable = false;
            gridView.ShowFindPanel();
            gridView.Appearance.Row.Font = new Font("Tahoma", 10);
            gridControl.MouseDoubleClick += gridView_DoubleClick;
        }



          
      

        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (sender is GridControl control && e is DXMouseEventArgs args)
            {
                GridView gridView = control.MainView as GridView;
                if (gridView != null)
                {
                    GridHitInfo hitInfo = gridView.CalcHitInfo(args.Location);
                    if (hitInfo.InRow || hitInfo.InRowCell)
                    {
                        // Assuming the name of the material is in the first column (index 0)
                        string ChemicalName = gridView.GetRowCellValue(hitInfo.RowHandle, "fName").ToString();
                        using (ChemicalEntities chemicalEn = new ChemicalEntities())
                        {

                            var chemical = chemicalEn.tChemical_Base
                                 .FirstOrDefault(c => c.fName == ChemicalName);

                            if (chemical != null)
                            {

                                long fID = chemical.fID;
                                try
                                {
                                    var Show_Chemical = new Show_One_Chemical();
                                    Show_Chemical.SetID(fID);
                                    Show_Chemical.Show();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error showing form: " + ex.Message);
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show(".آیدی مورد نظر در دیتا بیس پیدا نشد");
                            }
                        }
                    }
                }
            }
        }
    }
}
