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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Security.Cryptography.X509Certificates;
using DevExpress.XtraEditors;

namespace Studies_of_medicinal_substances
{
    public partial class Chemical_Base_input : DevExpress.XtraEditors.XtraForm
    {
        public byte[] imageBytes;

        public Chemical_Base_input()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ChemicalEntities chemicalEn = new ChemicalEntities())
            {

                var chemicallst = chemicalEn.tChemical_Base.ToList();
                //label1.Text += chemicallst.First().fName;
                //label2.Text += chemicallst.First().fCode;
                //label3.Text += chemicallst.First().fPersianDescription;
                //dataGridView1.AutoGenerateColumns = false;
                //dataGridView1.ColumnCount = 2;
                //dataGridView1.Columns[0].Name = "id";
                //dataGridView1.Columns[0].HeaderText = "Image id";
                //dataGridView1.Columns[0].DataPropertyName = "id";

                //dataGridView1.Columns[1].Name = "Name";
                //dataGridView1.Columns[1].HeaderText = "Name";
                //dataGridView1.Columns[1].DataPropertyName = "Name";

                //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                //imageColumn.DataPropertyName = "Name";
                //imageColumn.Name = "Name";
                //imageColumn.HeaderText = "Name";
                //imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                //dataGridView1.Columns.Insert(2, imageColumn);
                //dataGridView1.RowTemplate.Height = 100;
                //dataGridView1.Columns[2].Width = 100;
                //dataGridView1.DataSource = chemicallst.First().fImage;
            }

        }

        private void Add_Chemical_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new inputs();
            newform.Show();



        }

        private void Select_Image_Click(object sender, EventArgs e)
        {

        }

        private void Select_Image_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (ChemicalEntities chemicalEn = new ChemicalEntities())
                {
                    tChemical_Base addchemical = new tChemical_Base()
                    {
                        fName = inputfName.Text,
                        fCode = inputfCode.Text,
                        fPersianDescription = inputfPersian.Text,
                        fEnglishDescription = inputfEnglish.Text,
                        fImage = imageBytes
                    };
                    chemicalEn.tChemical_Base.Add(addchemical);
                    chemicalEn.SaveChanges(); // This line commits the changes to the database
                }
                XtraMessageBox.Show("ماده افزوده شده");
                inputfName.Clear();
                inputfCode.Clear();
                inputfPersian.Clear();
                inputfEnglish.Clear();
                pictureEdit1.Image = null;
            }
            catch (Exception)
            {

                XtraMessageBox.Show("ماده افزوده نشده");
            }
        }

        private void Select_image_Click_2(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select an image file";
            openFileDialog1.Filter = "Image files|*.jpg;*.jpeg;*.png;*.*";
            openFileDialog1.InitialDirectory = @"C:\";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureEdit1.Image = Image.FromFile(openFileDialog1.FileName);
                string imagePath = openFileDialog1.FileName;
                imageBytes = File.ReadAllBytes(imagePath);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();

            var newform = new inputs();
            newform.Show();
        }
    }
}
