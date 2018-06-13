namespace GUI
{
    partial class frmKetQuaThang
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Tháng 9");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tháng 10");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tháng 11");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tháng 12");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("HỌC KỲ 1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tháng 1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tháng 2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Tháng 3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Tháng 4");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("HỌC KỲ 2", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetQuaThang));
            this.gridControlKQThang = new DevExpress.XtraGrid.GridControl();
            this.gridViewKqThang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hocKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thangTrongNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maKetQua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemMieng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diem15p = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemTrungBinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hocLuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditHocLuc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.hOCLUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYHOCSINHDataSet = new GUI.QUANLYHOCSINHDataSet();
            this.hanhKiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditHanhKiem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.hANHKIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xepHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanXet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblGVMon = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditKhoiLop = new DevExpress.XtraEditors.LookUpEdit();
            this.kHOILOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEditLop = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditBoMon = new DevExpress.XtraEditors.LookUpEdit();
            this.bOMONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEditNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.nAMHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvthang = new System.Windows.Forms.TreeView();
            this.navBarGroupControlContainer2 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txttiet = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txt15 = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmieng = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLuuHanhKiem = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTT = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHanhkiem = new DevExpress.XtraEditors.LookUpEdit();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nAMHOCTableAdapter = new GUI.QUANLYHOCSINHDataSetTableAdapters.NAMHOCTableAdapter();
            this.kHOILOPTableAdapter = new GUI.QUANLYHOCSINHDataSetTableAdapters.KHOILOPTableAdapter();
            this.bOMONTableAdapter = new GUI.QUANLYHOCSINHDataSetTableAdapters.BOMONTableAdapter();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.bindingNavigatorKetquahoctap = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hOCLUCTableAdapter = new GUI.QUANLYHOCSINHDataSetTableAdapters.HOCLUCTableAdapter();
            this.hANHKIEMTableAdapter = new GUI.QUANLYHOCSINHDataSetTableAdapters.HANHKIEMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKQThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKqThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditHocLuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCLUCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYHOCSINHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditHanhKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANHKIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditKhoiLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOILOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBoMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOMONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.navBarGroupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmieng.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHanhkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKetquahoctap)).BeginInit();
            this.bindingNavigatorKetquahoctap.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlKQThang
            // 
            this.gridControlKQThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlKQThang.Location = new System.Drawing.Point(2, 48);
            this.gridControlKQThang.MainView = this.gridViewKqThang;
            this.gridControlKQThang.Name = "gridControlKQThang";
            this.gridControlKQThang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEditHanhKiem,
            this.LookUpEditHocLuc});
            this.gridControlKQThang.Size = new System.Drawing.Size(1023, 304);
            this.gridControlKQThang.TabIndex = 0;
            this.gridControlKQThang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKqThang});
            // 
            // gridViewKqThang
            // 
            this.gridViewKqThang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.sTT,
            this.hoTen,
            this.gioiTinh,
            this.hocKy,
            this.thangTrongNam,
            this.maKetQua,
            this.diemMieng,
            this.diem15p,
            this.diemTiet,
            this.diemTrungBinh,
            this.hocLuc,
            this.hanhKiem,
            this.xepHang,
            this.nhanXet});
            this.gridViewKqThang.GridControl = this.gridControlKQThang;
            this.gridViewKqThang.Name = "gridViewKqThang";
            this.gridViewKqThang.OptionsView.ShowAutoFilterRow = true;
            this.gridViewKqThang.OptionsView.ShowGroupPanel = false;
            this.gridViewKqThang.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewKqThang_RowClick);
            // 
            // sTT
            // 
            this.sTT.Caption = "STT";
            this.sTT.FieldName = "sTT";
            this.sTT.Name = "sTT";
            this.sTT.OptionsColumn.AllowEdit = false;
            this.sTT.Visible = true;
            this.sTT.VisibleIndex = 0;
            this.sTT.Width = 49;
            // 
            // hoTen
            // 
            this.hoTen.Caption = "Họ tên";
            this.hoTen.FieldName = "hoTen";
            this.hoTen.Name = "hoTen";
            this.hoTen.OptionsColumn.AllowEdit = false;
            this.hoTen.Visible = true;
            this.hoTen.VisibleIndex = 1;
            this.hoTen.Width = 150;
            // 
            // gioiTinh
            // 
            this.gioiTinh.Caption = "Giới tính";
            this.gioiTinh.FieldName = "gioiTinh";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.OptionsColumn.AllowEdit = false;
            this.gioiTinh.Visible = true;
            this.gioiTinh.VisibleIndex = 2;
            this.gioiTinh.Width = 48;
            // 
            // hocKy
            // 
            this.hocKy.Caption = "Học kỳ";
            this.hocKy.FieldName = "hocKy";
            this.hocKy.Name = "hocKy";
            this.hocKy.OptionsColumn.AllowEdit = false;
            this.hocKy.Visible = true;
            this.hocKy.VisibleIndex = 3;
            this.hocKy.Width = 45;
            // 
            // thangTrongNam
            // 
            this.thangTrongNam.Caption = "Tháng";
            this.thangTrongNam.FieldName = "thangTrongNam";
            this.thangTrongNam.Name = "thangTrongNam";
            this.thangTrongNam.OptionsColumn.AllowEdit = false;
            this.thangTrongNam.Visible = true;
            this.thangTrongNam.VisibleIndex = 4;
            this.thangTrongNam.Width = 45;
            // 
            // maKetQua
            // 
            this.maKetQua.Caption = "Mã KQ";
            this.maKetQua.FieldName = "maKetQua";
            this.maKetQua.Name = "maKetQua";
            this.maKetQua.OptionsColumn.AllowEdit = false;
            this.maKetQua.Visible = true;
            this.maKetQua.VisibleIndex = 5;
            this.maKetQua.Width = 45;
            // 
            // diemMieng
            // 
            this.diemMieng.Caption = "Miệng";
            this.diemMieng.FieldName = "diemMieng";
            this.diemMieng.Name = "diemMieng";
            this.diemMieng.Visible = true;
            this.diemMieng.VisibleIndex = 6;
            this.diemMieng.Width = 72;
            // 
            // diem15p
            // 
            this.diem15p.Caption = "15\'";
            this.diem15p.FieldName = "diem15p";
            this.diem15p.Name = "diem15p";
            this.diem15p.Visible = true;
            this.diem15p.VisibleIndex = 7;
            this.diem15p.Width = 72;
            // 
            // diemTiet
            // 
            this.diemTiet.Caption = "1 Tiết";
            this.diemTiet.FieldName = "diemTiet";
            this.diemTiet.Name = "diemTiet";
            this.diemTiet.Visible = true;
            this.diemTiet.VisibleIndex = 8;
            this.diemTiet.Width = 72;
            // 
            // diemTrungBinh
            // 
            this.diemTrungBinh.Caption = "Điểm TB";
            this.diemTrungBinh.FieldName = "diemTrungBinh";
            this.diemTrungBinh.Name = "diemTrungBinh";
            this.diemTrungBinh.Visible = true;
            this.diemTrungBinh.VisibleIndex = 9;
            this.diemTrungBinh.Width = 72;
            // 
            // hocLuc
            // 
            this.hocLuc.Caption = "Học lực";
            this.hocLuc.ColumnEdit = this.LookUpEditHocLuc;
            this.hocLuc.FieldName = "hocLuc";
            this.hocLuc.Name = "hocLuc";
            this.hocLuc.Visible = true;
            this.hocLuc.VisibleIndex = 10;
            this.hocLuc.Width = 85;
            // 
            // LookUpEditHocLuc
            // 
            this.LookUpEditHocLuc.AutoHeight = false;
            this.LookUpEditHocLuc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditHocLuc.DataSource = this.hOCLUCBindingSource;
            this.LookUpEditHocLuc.DisplayMember = "tenHocLuc";
            this.LookUpEditHocLuc.Name = "LookUpEditHocLuc";
            this.LookUpEditHocLuc.NullText = "Không có";
            this.LookUpEditHocLuc.ValueMember = "tenHocLuc";
            // 
            // hOCLUCBindingSource
            // 
            this.hOCLUCBindingSource.DataMember = "HOCLUC";
            this.hOCLUCBindingSource.DataSource = this.qUANLYHOCSINHDataSet;
            // 
            // qUANLYHOCSINHDataSet
            // 
            this.qUANLYHOCSINHDataSet.DataSetName = "QUANLYHOCSINHDataSet";
            this.qUANLYHOCSINHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hanhKiem
            // 
            this.hanhKiem.Caption = "Hạnh kiểm";
            this.hanhKiem.ColumnEdit = this.LookUpEditHanhKiem;
            this.hanhKiem.FieldName = "hanhKiem";
            this.hanhKiem.Name = "hanhKiem";
            this.hanhKiem.Visible = true;
            this.hanhKiem.VisibleIndex = 11;
            this.hanhKiem.Width = 85;
            // 
            // LookUpEditHanhKiem
            // 
            this.LookUpEditHanhKiem.AutoHeight = false;
            this.LookUpEditHanhKiem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditHanhKiem.DataSource = this.hANHKIEMBindingSource;
            this.LookUpEditHanhKiem.DisplayMember = "tenHanhKiem";
            this.LookUpEditHanhKiem.Name = "LookUpEditHanhKiem";
            this.LookUpEditHanhKiem.NullText = "Không có";
            this.LookUpEditHanhKiem.ValueMember = "tenHanhKiem";
            // 
            // hANHKIEMBindingSource
            // 
            this.hANHKIEMBindingSource.DataMember = "HANHKIEM";
            this.hANHKIEMBindingSource.DataSource = this.qUANLYHOCSINHDataSet;
            // 
            // xepHang
            // 
            this.xepHang.Caption = "Xếp hạng";
            this.xepHang.FieldName = "xepHang";
            this.xepHang.Name = "xepHang";
            this.xepHang.Visible = true;
            this.xepHang.VisibleIndex = 12;
            this.xepHang.Width = 61;
            // 
            // nhanXet
            // 
            this.nhanXet.Caption = "Nhận xét";
            this.nhanXet.FieldName = "nhanXet";
            this.nhanXet.Name = "nhanXet";
            this.nhanXet.Visible = true;
            this.nhanXet.VisibleIndex = 13;
            this.nhanXet.Width = 123;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.lblGVMon);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lookUpEditKhoiLop);
            this.groupControl1.Controls.Add(this.lookUpEditLop);
            this.groupControl1.Controls.Add(this.lookUpEditBoMon);
            this.groupControl1.Controls.Add(this.lookUpEditNamHoc);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(212, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1035, 113);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Tìm kiếm lớp";
            // 
            // lblGVMon
            // 
            this.lblGVMon.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGVMon.Appearance.Options.UseFont = true;
            this.lblGVMon.Location = new System.Drawing.Point(841, 30);
            this.lblGVMon.Name = "lblGVMon";
            this.lblGVMon.Size = new System.Drawing.Size(58, 14);
            this.lblGVMon.TabIndex = 13;
            this.lblGVMon.Text = "Không có";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(715, 31);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(120, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Giáo viên phụ trách môn:";
            // 
            // lookUpEditKhoiLop
            // 
            this.lookUpEditKhoiLop.EditValue = "Khối 10";
            this.lookUpEditKhoiLop.Location = new System.Drawing.Point(81, 54);
            this.lookUpEditKhoiLop.Name = "lookUpEditKhoiLop";
            this.lookUpEditKhoiLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditKhoiLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenKhoiLop", "Khối lớp")});
            this.lookUpEditKhoiLop.Properties.DataSource = this.kHOILOPBindingSource;
            this.lookUpEditKhoiLop.Properties.DisplayMember = "tenKhoiLop";
            this.lookUpEditKhoiLop.Properties.NullText = "Chọn khối lớp";
            this.lookUpEditKhoiLop.Properties.ValueMember = "tenKhoiLop";
            this.lookUpEditKhoiLop.Size = new System.Drawing.Size(149, 20);
            this.lookUpEditKhoiLop.TabIndex = 11;
            this.lookUpEditKhoiLop.EditValueChanged += new System.EventHandler(this.lookUpEditKhoiLop_EditValueChanged);
            // 
            // kHOILOPBindingSource
            // 
            this.kHOILOPBindingSource.DataMember = "KHOILOP";
            this.kHOILOPBindingSource.DataSource = this.qUANLYHOCSINHDataSet;
            // 
            // lookUpEditLop
            // 
            this.lookUpEditLop.Location = new System.Drawing.Point(81, 80);
            this.lookUpEditLop.Name = "lookUpEditLop";
            this.lookUpEditLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("maLop", "Mã lớp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenLop", "Tên lớp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("siSo", "Sĩ số")});
            this.lookUpEditLop.Properties.DisplayMember = "tenLop";
            this.lookUpEditLop.Properties.NullText = "Chọn lớp";
            this.lookUpEditLop.Properties.ValueMember = "maLop";
            this.lookUpEditLop.Size = new System.Drawing.Size(149, 20);
            this.lookUpEditLop.TabIndex = 10;
            this.lookUpEditLop.EditValueChanged += new System.EventHandler(this.lookUpEditLop_EditValueChanged_1);
            // 
            // lookUpEditBoMon
            // 
            this.lookUpEditBoMon.EditValue = 1;
            this.lookUpEditBoMon.Location = new System.Drawing.Point(376, 28);
            this.lookUpEditBoMon.Name = "lookUpEditBoMon";
            this.lookUpEditBoMon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditBoMon.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("maBoMon", "Mã Môn"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenMonHoc", "Tên bộ môn")});
            this.lookUpEditBoMon.Properties.DataSource = this.bOMONBindingSource;
            this.lookUpEditBoMon.Properties.DisplayMember = "tenMonHoc";
            this.lookUpEditBoMon.Properties.NullText = "Chọn môn học";
            this.lookUpEditBoMon.Properties.ValueMember = "maBoMon";
            this.lookUpEditBoMon.Size = new System.Drawing.Size(149, 20);
            this.lookUpEditBoMon.TabIndex = 9;
            this.lookUpEditBoMon.EditValueChanged += new System.EventHandler(this.lookUpEditBoMon_EditValueChanged);
            // 
            // bOMONBindingSource
            // 
            this.bOMONBindingSource.DataMember = "BOMON";
            this.bOMONBindingSource.DataSource = this.qUANLYHOCSINHDataSet;
            // 
            // lookUpEditNamHoc
            // 
            this.lookUpEditNamHoc.EditValue = "2016-2017";
            this.lookUpEditNamHoc.Location = new System.Drawing.Point(81, 28);
            this.lookUpEditNamHoc.Name = "lookUpEditNamHoc";
            this.lookUpEditNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditNamHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenNamHoc", "Năm học")});
            this.lookUpEditNamHoc.Properties.DataSource = this.nAMHOCBindingSource;
            this.lookUpEditNamHoc.Properties.DisplayMember = "tenNamHoc";
            this.lookUpEditNamHoc.Properties.NullText = "Chọn Năm học";
            this.lookUpEditNamHoc.Properties.ValueMember = "tenNamHoc";
            this.lookUpEditNamHoc.Size = new System.Drawing.Size(149, 20);
            this.lookUpEditNamHoc.TabIndex = 8;
            this.lookUpEditNamHoc.EditValueChanged += new System.EventHandler(this.lookUpEditNamHoc_EditValueChanged);
            // 
            // nAMHOCBindingSource
            // 
            this.nAMHOCBindingSource.DataMember = "NAMHOC";
            this.nAMHOCBindingSource.DataSource = this.qUANLYHOCSINHDataSet;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(319, 31);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Môn học";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Khối lớp:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Lớp:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Năm học:";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer2);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 206;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(206, 508);
            this.navBarControl1.TabIndex = 2;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Tháng";
            this.navBarGroup1.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupClientHeight = 283;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.panel1);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(206, 377);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvthang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 377);
            this.panel1.TabIndex = 3;
            // 
            // tvthang
            // 
            this.tvthang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvthang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvthang.ItemHeight = 22;
            this.tvthang.LineColor = System.Drawing.Color.Red;
            this.tvthang.Location = new System.Drawing.Point(0, 0);
            this.tvthang.Name = "tvthang";
            treeNode1.Name = "thang9";
            treeNode1.Text = "Tháng 9";
            treeNode2.Name = "thang10";
            treeNode2.Text = "Tháng 10";
            treeNode3.Name = "thang11";
            treeNode3.Text = "Tháng 11";
            treeNode4.Name = "thang12";
            treeNode4.Text = "Tháng 12";
            treeNode5.Name = "hocky1";
            treeNode5.Text = "HỌC KỲ 1";
            treeNode6.Name = "thang1";
            treeNode6.Text = "Tháng 1";
            treeNode7.Name = "thang2";
            treeNode7.Text = "Tháng 2";
            treeNode8.Name = "thang3";
            treeNode8.Text = "Tháng 3";
            treeNode9.Name = "thang4";
            treeNode9.Text = "Tháng 4";
            treeNode10.Name = "hocky2";
            treeNode10.Text = "HỌC KỲ 2";
            this.tvthang.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10});
            this.tvthang.Size = new System.Drawing.Size(206, 377);
            this.tvthang.TabIndex = 0;
            this.tvthang.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvthang_AfterSelect);
            this.tvthang.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvthang_NodeMouseClick);
            // 
            // navBarGroupControlContainer2
            // 
            this.navBarGroupControlContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer2.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer2.Controls.Add(this.panelControl1);
            this.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2";
            this.navBarGroupControlContainer2.Size = new System.Drawing.Size(198, 262);
            this.navBarGroupControlContainer2.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txttiet);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txt15);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.txtmieng);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.btnLuuHanhKiem);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.txtHoTen);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtSTT);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtHanhkiem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(198, 262);
            this.panelControl1.TabIndex = 0;
            // 
            // txttiet
            // 
            this.txttiet.Location = new System.Drawing.Point(59, 160);
            this.txttiet.Name = "txttiet";
            this.txttiet.Size = new System.Drawing.Size(134, 20);
            this.txttiet.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "1 tiết";
            // 
            // txt15
            // 
            this.txt15.Location = new System.Drawing.Point(59, 132);
            this.txt15.Name = "txt15";
            this.txt15.Size = new System.Drawing.Size(134, 20);
            this.txt15.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "15 phút";
            // 
            // txtmieng
            // 
            this.txtmieng.Location = new System.Drawing.Point(59, 102);
            this.txtmieng.Name = "txtmieng";
            this.txtmieng.Size = new System.Drawing.Size(134, 20);
            this.txtmieng.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Miệng";
            // 
            // btnLuuHanhKiem
            // 
            this.btnLuuHanhKiem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLuuHanhKiem.Location = new System.Drawing.Point(59, 198);
            this.btnLuuHanhKiem.Name = "btnLuuHanhKiem";
            this.btnLuuHanhKiem.Size = new System.Drawing.Size(83, 33);
            this.btnLuuHanhKiem.TabIndex = 6;
            this.btnLuuHanhKiem.Text = "Lưu";
            this.btnLuuHanhKiem.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hạnh kiểm";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(59, 42);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(134, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // txtSTT
            // 
            this.txtSTT.Location = new System.Drawing.Point(59, 12);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Properties.ReadOnly = true;
            this.txtSTT.Size = new System.Drawing.Size(134, 20);
            this.txtSTT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "STT";
            // 
            // txtHanhkiem
            // 
            this.txtHanhkiem.Location = new System.Drawing.Point(59, 72);
            this.txtHanhkiem.Name = "txtHanhkiem";
            this.txtHanhkiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHanhkiem.Properties.DataSource = this.hANHKIEMBindingSource;
            this.txtHanhkiem.Properties.DisplayMember = "tenHanhKiem";
            this.txtHanhkiem.Properties.NullText = "";
            this.txtHanhkiem.Properties.ValueMember = "tenHanhKiem";
            this.txtHanhkiem.Size = new System.Drawing.Size(134, 20);
            this.txtHanhkiem.TabIndex = 5;
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Thông tin";
            this.navBarGroup2.ControlContainer = this.navBarGroupControlContainer2;
            this.navBarGroup2.GroupClientHeight = 266;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nAMHOCTableAdapter
            // 
            this.nAMHOCTableAdapter.ClearBeforeFill = true;
            // 
            // kHOILOPTableAdapter
            // 
            this.kHOILOPTableAdapter.ClearBeforeFill = true;
            // 
            // bOMONTableAdapter
            // 
            this.bOMONTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.bindingNavigatorKetquahoctap);
            this.groupControl2.Controls.Add(this.gridControlKQThang);
            this.groupControl2.Location = new System.Drawing.Point(212, 119);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1035, 357);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Danh sách học sinh";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(950, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Tính điểm TB";
            // 
            // bindingNavigatorKetquahoctap
            // 
            this.bindingNavigatorKetquahoctap.AddNewItem = null;
            this.bindingNavigatorKetquahoctap.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorKetquahoctap.DeleteItem = null;
            this.bindingNavigatorKetquahoctap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigatorKetquahoctap.Location = new System.Drawing.Point(2, 20);
            this.bindingNavigatorKetquahoctap.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorKetquahoctap.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorKetquahoctap.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorKetquahoctap.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorKetquahoctap.Name = "bindingNavigatorKetquahoctap";
            this.bindingNavigatorKetquahoctap.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorKetquahoctap.Size = new System.Drawing.Size(1031, 25);
            this.bindingNavigatorKetquahoctap.TabIndex = 1;
            this.bindingNavigatorKetquahoctap.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // hOCLUCTableAdapter
            // 
            this.hOCLUCTableAdapter.ClearBeforeFill = true;
            // 
            // hANHKIEMTableAdapter
            // 
            this.hANHKIEMTableAdapter.ClearBeforeFill = true;
            // 
            // frmKetQuaThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 508);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmKetQuaThang";
            this.Text = "Kết quả tháng";
            this.Load += new System.EventHandler(this.frmKetQuaThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKQThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKqThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditHocLuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCLUCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYHOCSINHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditHanhKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANHKIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditKhoiLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOILOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBoMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOMONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAMHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.navBarGroupControlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmieng.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHanhkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorKetquahoctap)).EndInit();
            this.bindingNavigatorKetquahoctap.ResumeLayout(false);
            this.bindingNavigatorKetquahoctap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlKQThang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKqThang;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvthang;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditKhoiLop;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditLop;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditBoMon;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditNamHoc;
        private QUANLYHOCSINHDataSet qUANLYHOCSINHDataSet;
        private System.Windows.Forms.BindingSource nAMHOCBindingSource;
        private QUANLYHOCSINHDataSetTableAdapters.NAMHOCTableAdapter nAMHOCTableAdapter;
        private System.Windows.Forms.BindingSource kHOILOPBindingSource;
        private QUANLYHOCSINHDataSetTableAdapters.KHOILOPTableAdapter kHOILOPTableAdapter;
        private System.Windows.Forms.BindingSource bOMONBindingSource;
        private QUANLYHOCSINHDataSetTableAdapters.BOMONTableAdapter bOMONTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn sTT;
        private DevExpress.XtraGrid.Columns.GridColumn hoTen;
        private DevExpress.XtraGrid.Columns.GridColumn gioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn hocKy;
        private DevExpress.XtraGrid.Columns.GridColumn thangTrongNam;
        private DevExpress.XtraGrid.Columns.GridColumn maKetQua;
        private DevExpress.XtraGrid.Columns.GridColumn diemMieng;
        private DevExpress.XtraGrid.Columns.GridColumn diem15p;
        private DevExpress.XtraGrid.Columns.GridColumn diemTiet;
        private DevExpress.XtraGrid.Columns.GridColumn diemTrungBinh;
        private DevExpress.XtraGrid.Columns.GridColumn hocLuc;
        private DevExpress.XtraGrid.Columns.GridColumn hanhKiem;
        private DevExpress.XtraGrid.Columns.GridColumn xepHang;
        private DevExpress.XtraGrid.Columns.GridColumn nhanXet;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingNavigator bindingNavigatorKetquahoctap;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditHanhKiem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditHocLuc;
        private System.Windows.Forms.BindingSource hOCLUCBindingSource;
        private QUANLYHOCSINHDataSetTableAdapters.HOCLUCTableAdapter hOCLUCTableAdapter;
        private System.Windows.Forms.BindingSource hANHKIEMBindingSource;
        private QUANLYHOCSINHDataSetTableAdapters.HANHKIEMTableAdapter hANHKIEMTableAdapter;
        private DevExpress.XtraEditors.LabelControl lblGVMon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtSTT;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit txtHanhkiem;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraEditors.SimpleButton btnLuuHanhKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txttiet;
        private DevExpress.XtraEditors.TextEdit txt15;
        private DevExpress.XtraEditors.TextEdit txtmieng;
    }
}