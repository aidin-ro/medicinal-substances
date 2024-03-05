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
    public partial class Tec_Production_input : Form
    {
        public Tec_Production_input()
        {
            InitializeComponent();
        }

        

        private void Tec_Production_input_Load(object sender, EventArgs e)
        {
            Tec_combo.Items.Clear();
            Chemical_combo.Items.Clear();
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {



                var Tec_list = chemicalEn.tTechnologies.ToList();

                foreach (var Tec in Tec_list)
                {
                    Tec_combo.Items.Add(Tec.fName);
                }

                var Chemicallist = chemicalEn.tChemical_Base.ToList();

                foreach (var Chemical in Chemicallist)
                {
                    Chemical_combo.Items.Add(Chemical.fName);
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
