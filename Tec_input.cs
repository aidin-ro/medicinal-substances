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
    public partial class Tec_input : DevExpress.XtraEditors.XtraForm
    { 
        public Tec_input()
        {
            InitializeComponent();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new inputs();
            newform.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {
                tTechnologies addTec = new tTechnologies()
                {
                    fName = Tec_Name_input.Text,
                    fTec_Description = Description_input.Text,
                };
                chemicalEn.tTechnologies.Add(addTec);
                chemicalEn.SaveChanges(); // This line commits the changes to the database
            }
        }
    }
}
