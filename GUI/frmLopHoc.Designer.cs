namespace GUI
{
    partial class frmLopHoc
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
            this.gridControlLop = new DevExpress.XtraGrid.GridControl();
            this.gridViewLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookupGVCN = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnKhoiLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookupKhoiLop = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.kHOILOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYHOCSINHDataSet = new GUI.QUANLYHOCSINHDataSet();
            this.gridColumnNamHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookupNamHoc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ColComboboxKhoiLop = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ColComboboxNamHoc = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.kHOILOPTableAdapter = new GUI.QUANLYHOCSINHDataSetTableAdapters.KHOILOPTableAdapter();
            this.nAMHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nAMHOCTableAdapter = new GUI.QUANLYHOCSINHDataSetTableAdapters.NAMHOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupGVCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupKhoiLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOILOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYHOCSINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupNamHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColComboboxKhoiLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColComboboxNamHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlLop
            // 
            this.gridControlLop.Location = new System.Drawing.Point(12, 35);
            this.gridControlLop.MainView = this.gridViewLop;
            this.gridControlLop.Name = "gridControlLop";
            this.gridControlLop.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.LookupKhoiLop,
            this.LookupNamHoc,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3,
            this.ColComboboxKhoiLop,
            this.ColComboboxNamHoc,
            this.LookupGVCN});
            this.gridControlLop.Size = new System.Drawing.Size(710, 318);
            this.gridControlLop.TabIndex = 0;
            this.gridControlLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLop});
            // 
            // gridViewLop
            // 
            this.gridViewLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumnKhoiLop,
            this.gridColumnNamHoc});
            this.gridViewLop.GridControl = this.gridControlLop;
            this.gridViewLop.Name = "gridViewLop";
            this.gridViewLop.OptionsView.ShowAutoFilterRow = true;
            this.gridViewLop.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Lớp";
            this.gridColumn1.FieldName = "maLop";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 70;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên lớp";
            this.gridColumn2.FieldName = "tenLop";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 96;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sĩ số";
            this.gridColumn3.FieldName = "siSo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 70;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "GVCN";
            this.gridColumn4.ColumnEdit = this.LookupGVCN;
            this.gridColumn4.FieldName = "giaoVienCN";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 160;
            // 
            // LookupGVCN
            // 
            this.LookupGVCN.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.LookupGVCN.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.LookupGVCN.AutoHeight = false;
            this.LookupGVCN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupGVCN.Name = "LookupGVCN";
            // 
            // gridColumnKhoiLop
            // 
            this.gridColumnKhoiLop.Caption = "Khối lớp";
            this.gridColumnKhoiLop.ColumnEdit = this.LookupKhoiLop;
            this.gridColumnKhoiLop.FieldName = "khoiLop";
            this.gridColumnKhoiLop.Name = "gridColumnKhoiLop";
            this.gridColumnKhoiLop.Visible = true;
            this.gridColumnKhoiLop.VisibleIndex = 4;
            this.gridColumnKhoiLop.Width = 150;
            // 
            // LookupKhoiLop
            // 
            this.LookupKhoiLop.AutoHeight = false;
            this.LookupKhoiLop.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupKhoiLop.DataSource = this.kHOILOPBindingSource;
            this.LookupKhoiLop.DisplayMember = "tenKhoiLop";
            this.LookupKhoiLop.Name = "LookupKhoiLop";
            this.LookupKhoiLop.ValueMember = "tenKhoiLop";
            // 
            // kHOILOPBindingSource
            // 
            this.kHOILOPBindingSource.DataMember = "KHOILOP";
            this.kHOILOPBindingSource.DataSource = this.qUANLYHOCSINHDataSet;
            // 
            // qUANLYHOCSINHDataSet
            // 
            this.qUANLYHOCSINHDataSet.DataSetName = "QUANLYHOCSINHDataSet";
            this.qUANLYHOCSINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridColumnNamHoc
            // 
            this.gridColumnNamHoc.Caption = "Năm học";
            this.gridColumnNamHoc.ColumnEdit = this.LookupNamHoc;
            this.gridColumnNamHoc.FieldName = "namHoc";
            this.gridColumnNamHoc.Name = "gridColumnNamHoc";
            this.gridColumnNamHoc.Visible = true;
            this.gridColumnNamHoc.VisibleIndex = 5;
            this.gridColumnNamHoc.Width = 150;
            // 
            // LookupNamHoc
            // 
            this.LookupNamHoc.AutoHeight = false;
            this.LookupNamHoc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupNamHoc.DataSource = this.nAMHOCBindingSource;
            this.LookupNamHoc.DisplayMember = "tenNamHoc";
            this.LookupNamHoc.Name = "LookupNamHoc";
            this.LookupNamHoc.ValueMember = "tenNamHoc";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // ColComboboxKhoiLop
            // 
            this.ColComboboxKhoiLop.AutoHeight = false;
            this.ColComboboxKhoiLop.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ColComboboxKhoiLop.Name = "ColComboboxKhoiLop";
            // 
            // ColComboboxNamHoc
            // 
            this.ColComboboxNamHoc.AutoHeight = false;
            this.ColComboboxNamHoc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ColComboboxNamHoc.Name = "ColComboboxNamHoc";
            this.ColComboboxNamHoc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // kHOILOPTableAdapter
            // 
            this.kHOILOPTableAdapter.ClearBeforeFill = true;
            // 
            // nAMHOCBindingSource
            // 
            this.nAMHOCBindingSource.DataMember = "NAMHOC";
            this.nAMHOCBindingSource.DataSource = this.qUANLYHOCSINHDataSet;
            // 
            // nAMHOCTableAdapter
            // 
            this.nAMHOCTableAdapter.ClearBeforeFill = true;
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 406);
            this.Controls.Add(this.gridControlLop);
            this.Name = "frmLopHoc";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.frmLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupGVCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupKhoiLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOILOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYHOCSINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupNamHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColComboboxKhoiLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColComboboxNamHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLop;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnKhoiLop;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNamHoc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupKhoiLop;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupNamHoc;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ColComboboxKhoiLop;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ColComboboxNamHoc;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private QUANLYHOCSINHDataSet qUANLYHOCSINHDataSet;
        private System.Windows.Forms.BindingSource kHOILOPBindingSource;
        private QUANLYHOCSINHDataSetTableAdapters.KHOILOPTableAdapter kHOILOPTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupGVCN;
        private System.Windows.Forms.BindingSource nAMHOCBindingSource;
        private QUANLYHOCSINHDataSetTableAdapters.NAMHOCTableAdapter nAMHOCTableAdapter;
    }
}