namespace GUI
{
    partial class HocKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HocKy));
            this.bindingNavigatorHocKy = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.gridControlHocKy = new DevExpress.XtraGrid.GridControl();
            this.gridViewHocKy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltenHocKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colheSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qUANLYHOCSINHDataSet1 = new GUI.QUANLYHOCSINHDataSet();
            this.hOCKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCKYTableAdapter1 = new GUI.QUANLYHOCSINHDataSetTableAdapters.HOCKYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocKy)).BeginInit();
            this.bindingNavigatorHocKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYHOCSINHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorHocKy
            // 
            this.bindingNavigatorHocKy.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorHocKy.BindingSource = this.hOCKYBindingSource;
            this.bindingNavigatorHocKy.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHocKy.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorHocKy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorHocKy.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorHocKy.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHocKy.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHocKy.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHocKy.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHocKy.Name = "bindingNavigatorHocKy";
            this.bindingNavigatorHocKy.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHocKy.Size = new System.Drawing.Size(359, 25);
            this.bindingNavigatorHocKy.TabIndex = 0;
            this.bindingNavigatorHocKy.Text = "bindingNavigator1";
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
            // gridControlHocKy
            // 
            this.gridControlHocKy.DataSource = this.hOCKYBindingSource;
            this.gridControlHocKy.Location = new System.Drawing.Point(0, 28);
            this.gridControlHocKy.MainView = this.gridViewHocKy;
            this.gridControlHocKy.Name = "gridControlHocKy";
            this.gridControlHocKy.Size = new System.Drawing.Size(327, 343);
            this.gridControlHocKy.TabIndex = 1;
            this.gridControlHocKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHocKy});
            // 
            // gridViewHocKy
            // 
            this.gridViewHocKy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltenHocKy,
            this.colheSo});
            this.gridViewHocKy.GridControl = this.gridControlHocKy;
            this.gridViewHocKy.Name = "gridViewHocKy";
            this.gridViewHocKy.OptionsView.ShowAutoFilterRow = true;
            this.gridViewHocKy.OptionsView.ShowGroupPanel = false;
            // 
            // coltenHocKy
            // 
            this.coltenHocKy.Caption = "Tên học kỳ";
            this.coltenHocKy.FieldName = "tenHocKy";
            this.coltenHocKy.Name = "coltenHocKy";
            this.coltenHocKy.Visible = true;
            this.coltenHocKy.VisibleIndex = 0;
            // 
            // colheSo
            // 
            this.colheSo.Caption = "Hệ số";
            this.colheSo.FieldName = "heSo";
            this.colheSo.Name = "colheSo";
            this.colheSo.Visible = true;
            this.colheSo.VisibleIndex = 1;
            // 
            // qUANLYHOCSINHDataSet1
            // 
            this.qUANLYHOCSINHDataSet1.DataSetName = "QUANLYHOCSINHDataSet";
            this.qUANLYHOCSINHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCKYBindingSource
            // 
            this.hOCKYBindingSource.DataMember = "HOCKY";
            this.hOCKYBindingSource.DataSource = this.qUANLYHOCSINHDataSet1;
            // 
            // hOCKYTableAdapter1
            // 
            this.hOCKYTableAdapter1.ClearBeforeFill = true;
            // 
            // HocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 400);
            this.Controls.Add(this.gridControlHocKy);
            this.Controls.Add(this.bindingNavigatorHocKy);
            this.Name = "HocKy";
            this.Text = "HocKy";
            this.Load += new System.EventHandler(this.HocKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocKy)).EndInit();
            this.bindingNavigatorHocKy.ResumeLayout(false);
            this.bindingNavigatorHocKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYHOCSINHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigatorHocKy;
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
        private DevExpress.XtraGrid.GridControl gridControlHocKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHocKy;
        private QUANLYHOCSINHDataSet qUANLYHOCSINHDataSet;
        private QUANLYHOCSINHDataSetTableAdapters.HOCKYTableAdapter hOCKYTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private DevExpress.XtraGrid.Columns.GridColumn coltenHocKy;
        private DevExpress.XtraGrid.Columns.GridColumn colheSo;
        private QUANLYHOCSINHDataSet qUANLYHOCSINHDataSet1;
        private System.Windows.Forms.BindingSource hOCKYBindingSource;
        private QUANLYHOCSINHDataSetTableAdapters.HOCKYTableAdapter hOCKYTableAdapter1;
    }
}