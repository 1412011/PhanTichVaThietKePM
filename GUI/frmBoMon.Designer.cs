namespace GUI
{
    partial class frmBoMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoMon));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bOMONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYHOCSINHDataSet = new GUI.QUANLYHOCSINHDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.gridControlBoMon = new DevExpress.XtraGrid.GridControl();
            this.gridViewBoMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaBoMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenMonHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoTietHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colheSoMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltruongBoMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bOMONTableAdapter = new GUI.QUANLYHOCSINHDataSetTableAdapters.BOMONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOMONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYHOCSINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBoMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBoMon)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bOMONBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(460, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.ToolTipText = "Thêm";
            // 
            // bOMONBindingSource
            // 
            this.bOMONBindingSource.DataMember = "BOMON";
            this.bOMONBindingSource.DataSource = this.qUANLYHOCSINHDataSet;
            // 
            // qUANLYHOCSINHDataSet
            // 
            this.qUANLYHOCSINHDataSet.DataSetName = "QUANLYHOCSINHDataSet";
            this.qUANLYHOCSINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.ToolTipText = "Xóa";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::GUI.Properties.Resources.save_16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Lưu";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::GUI.Properties.Resources.refresh_16;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Nạp lại";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // gridControlBoMon
            // 
            this.gridControlBoMon.DataSource = this.bOMONBindingSource;
            this.gridControlBoMon.Location = new System.Drawing.Point(0, 41);
            this.gridControlBoMon.MainView = this.gridViewBoMon;
            this.gridControlBoMon.Name = "gridControlBoMon";
            this.gridControlBoMon.Size = new System.Drawing.Size(457, 392);
            this.gridControlBoMon.TabIndex = 1;
            this.gridControlBoMon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBoMon});
            // 
            // gridViewBoMon
            // 
            this.gridViewBoMon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaBoMon,
            this.coltenMonHoc,
            this.colsoTietHoc,
            this.colheSoMon,
            this.coltruongBoMon});
            this.gridViewBoMon.GridControl = this.gridControlBoMon;
            this.gridViewBoMon.Name = "gridViewBoMon";
            this.gridViewBoMon.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBoMon.OptionsView.ShowGroupPanel = false;
            // 
            // colmaBoMon
            // 
            this.colmaBoMon.Caption = "Mã bộ môn";
            this.colmaBoMon.FieldName = "maBoMon";
            this.colmaBoMon.Name = "colmaBoMon";
            this.colmaBoMon.OptionsColumn.ReadOnly = true;
            this.colmaBoMon.Visible = true;
            this.colmaBoMon.VisibleIndex = 0;
            // 
            // coltenMonHoc
            // 
            this.coltenMonHoc.Caption = "Tên môn học";
            this.coltenMonHoc.FieldName = "tenMonHoc";
            this.coltenMonHoc.Name = "coltenMonHoc";
            this.coltenMonHoc.Visible = true;
            this.coltenMonHoc.VisibleIndex = 1;
            // 
            // colsoTietHoc
            // 
            this.colsoTietHoc.Caption = "Số tiết / Học kỳ";
            this.colsoTietHoc.FieldName = "soTietHoc";
            this.colsoTietHoc.Name = "colsoTietHoc";
            this.colsoTietHoc.Visible = true;
            this.colsoTietHoc.VisibleIndex = 2;
            // 
            // colheSoMon
            // 
            this.colheSoMon.Caption = "Hệ số môn";
            this.colheSoMon.FieldName = "heSoMon";
            this.colheSoMon.Name = "colheSoMon";
            this.colheSoMon.Visible = true;
            this.colheSoMon.VisibleIndex = 3;
            // 
            // coltruongBoMon
            // 
            this.coltruongBoMon.Caption = "Mã trưởng bộ môn";
            this.coltruongBoMon.FieldName = "truongBoMon";
            this.coltruongBoMon.Name = "coltruongBoMon";
            this.coltruongBoMon.Visible = true;
            this.coltruongBoMon.VisibleIndex = 4;
            // 
            // bOMONTableAdapter
            // 
            this.bOMONTableAdapter.ClearBeforeFill = true;
            // 
            // frmBoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 433);
            this.Controls.Add(this.gridControlBoMon);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "frmBoMon";
            this.Text = "Bộ môn";
            this.Load += new System.EventHandler(this.frmBoMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOMONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYHOCSINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBoMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBoMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraGrid.GridControl gridControlBoMon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBoMon;
        private QUANLYHOCSINHDataSet qUANLYHOCSINHDataSet;
        private System.Windows.Forms.BindingSource bOMONBindingSource;
        private QUANLYHOCSINHDataSetTableAdapters.BOMONTableAdapter bOMONTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colmaBoMon;
        private DevExpress.XtraGrid.Columns.GridColumn coltenMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colsoTietHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colheSoMon;
        private DevExpress.XtraGrid.Columns.GridColumn coltruongBoMon;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}