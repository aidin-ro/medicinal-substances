namespace Studies_of_medicinal_substances
{
    partial class Chemical_Base_Show_Data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tChemicalBaseBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.tChemicalBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfEnglishDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfPersianDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tChemicalBaseBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tChemicalBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tChemicalBaseBindingSource7
            // 
            this.tChemicalBaseBindingSource7.DataSource = typeof(DLayer.tChemical_Base);
            // 
            // tChemicalBaseBindingSource
            // 
            this.tChemicalBaseBindingSource.DataSource = typeof(DLayer.tChemical_Base);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.tChemicalBaseBindingSource7;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Font = new System.Drawing.Font("Sylfaen", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl.Size = new System.Drawing.Size(798, 449);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfName,
            this.colfCode,
            this.colfEnglishDescription,
            this.colfPersianDescription});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colfName, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colfName
            // 
            this.colfName.Caption = "نام";
            this.colfName.FieldName = "fName";
            this.colfName.Name = "colfName";
            this.colfName.Visible = true;
            this.colfName.VisibleIndex = 0;
            this.colfName.Width = 89;
            // 
            // colfCode
            // 
            this.colfCode.Caption = "کد";
            this.colfCode.FieldName = "fCode";
            this.colfCode.Name = "colfCode";
            this.colfCode.Visible = true;
            this.colfCode.VisibleIndex = 1;
            this.colfCode.Width = 95;
            // 
            // colfEnglishDescription
            // 
            this.colfEnglishDescription.Caption = "توضیحات اینگلیسی";
            this.colfEnglishDescription.FieldName = "fEnglishDescription";
            this.colfEnglishDescription.ImageOptions.ImageUri.Uri = "AlignLeft";
            this.colfEnglishDescription.Name = "colfEnglishDescription";
            this.colfEnglishDescription.Visible = true;
            this.colfEnglishDescription.VisibleIndex = 2;
            this.colfEnglishDescription.Width = 261;
            // 
            // colfPersianDescription
            // 
            this.colfPersianDescription.Caption = "توضیحات فارسی";
            this.colfPersianDescription.FieldName = "fPersianDescription";
            this.colfPersianDescription.ImageOptions.ImageUri.Uri = "AlignRight";
            this.colfPersianDescription.Name = "colfPersianDescription";
            this.colfPersianDescription.Visible = true;
            this.colfPersianDescription.VisibleIndex = 3;
            this.colfPersianDescription.Width = 334;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "fPersianDescription";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 334;
            // 
            // Chemical_Base_Show_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 449);
            this.Controls.Add(this.gridControl);
            this.Name = "Chemical_Base_Show_Data";
            this.Text = "Chemical_Base_Show_Data";
            this.Load += new System.EventHandler(this.Chemical_Base_Show_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tChemicalBaseBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tChemicalBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tChemicalBaseBindingSource7;
        private System.Windows.Forms.BindingSource tChemicalBaseBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colfName;
        private DevExpress.XtraGrid.Columns.GridColumn colfCode;
        private DevExpress.XtraGrid.Columns.GridColumn colfEnglishDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colfPersianDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}