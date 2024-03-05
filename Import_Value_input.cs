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
    public partial class Import_Value_input : Form
    {
        public Import_Value_input()
        {
            InitializeComponent();
        }



        private void Import_Value_input_Load(object sender, EventArgs e)
        {
            Chemical_combo.Items.Clear();
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {

                var Chemicallist = chemicalEn.tChemical_Base.ToList();

                foreach (var Chemical in Chemicallist)
                {
                    Chemical_combo.Items.Add(Chemical.fName);
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
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
                    fImport_Year = int.Parse(Import_Volume_txtbox.Text)
                };
                chemicalEn.tImport_Value.Add(addimport);
                chemicalEn.SaveChanges(); // This line commits the changes to the database
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
