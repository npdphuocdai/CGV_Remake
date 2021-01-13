
namespace Viewer
{
    partial class ucViewCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucViewCustomer));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.DataSource = new System.Windows.Forms.BindingSource(this.components);
            this.layTong = new DevExpress.XtraLayout.LayoutControl();
            this.grbAddCustomer = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtGender = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtBirthDay = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layBirthDay = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.layEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.layGender = new DevExpress.XtraLayout.LayoutControlItem();
            this.layPhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblTop = new DevExpress.XtraEditors.LabelControl();
            this.GridCustomer = new DevExpress.XtraGrid.GridControl();
            this.dgvViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layLblTop = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTong)).BeginInit();
            this.layTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbAddCustomer)).BeginInit();
            this.grbAddCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBirthDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layLblTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSource
            // 
            this.DataSource.DataSource = typeof(DTO.dtoCustomer);
            // 
            // layTong
            // 
            this.layTong.Controls.Add(this.grbAddCustomer);
            this.layTong.Controls.Add(this.lblTop);
            this.layTong.Controls.Add(this.GridCustomer);
            this.layTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layTong.Location = new System.Drawing.Point(0, 0);
            this.layTong.Name = "layTong";
            this.layTong.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(544, 227, 812, 500);
            this.layTong.Root = this.Root;
            this.layTong.Size = new System.Drawing.Size(1161, 745);
            this.layTong.TabIndex = 2;
            this.layTong.Text = "layoutControl1";
            // 
            // grbAddCustomer
            // 
            this.grbAddCustomer.AppearanceCaption.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddCustomer.AppearanceCaption.Options.UseFont = true;
            this.grbAddCustomer.Controls.Add(this.layoutControl1);
            this.grbAddCustomer.Location = new System.Drawing.Point(3, 536);
            this.grbAddCustomer.Name = "grbAddCustomer";
            this.grbAddCustomer.Size = new System.Drawing.Size(1155, 206);
            this.grbAddCustomer.TabIndex = 4;
            this.grbAddCustomer.Text = "Add Customer";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Controls.Add(this.txtPhoneNumber);
            this.layoutControl1.Controls.Add(this.txtGender);
            this.layoutControl1.Controls.Add(this.txtEmail);
            this.layoutControl1.Controls.Add(this.txtBirthDay);
            this.layoutControl1.Controls.Add(this.txtAddress);
            this.layoutControl1.Controls.Add(this.txtFullName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 45);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1151, 159);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(389, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(373, 33);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(784, 80);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Properties.Appearance.Options.UseFont = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(355, 30);
            this.txtPhoneNumber.StyleController = this.layoutControl1;
            this.txtPhoneNumber.TabIndex = 9;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(219, 80);
            this.txtGender.Name = "txtGender";
            this.txtGender.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Properties.Appearance.Options.UseFont = true;
            this.txtGender.Size = new System.Drawing.Size(354, 30);
            this.txtGender.StyleController = this.layoutControl1;
            this.txtGender.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(784, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(355, 30);
            this.txtEmail.StyleController = this.layoutControl1;
            this.txtEmail.TabIndex = 7;
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.Location = new System.Drawing.Point(219, 46);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthDay.Properties.Appearance.Options.UseFont = true;
            this.txtBirthDay.Size = new System.Drawing.Size(354, 30);
            this.txtBirthDay.StyleController = this.layoutControl1;
            this.txtBirthDay.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(784, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(355, 30);
            this.txtAddress.StyleController = this.layoutControl1;
            this.txtAddress.TabIndex = 5;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(219, 12);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Properties.Appearance.Options.UseFont = true;
            this.txtFullName.Size = new System.Drawing.Size(354, 30);
            this.txtFullName.StyleController = this.layoutControl1;
            this.txtFullName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layName,
            this.layBirthDay,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layAddress,
            this.layEmail,
            this.layGender,
            this.layPhoneNumber,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1151, 159);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layName
            // 
            this.layName.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layName.AppearanceItemCaption.Options.UseFont = true;
            this.layName.Control = this.txtFullName;
            this.layName.Location = new System.Drawing.Point(0, 0);
            this.layName.Name = "layName";
            this.layName.Size = new System.Drawing.Size(565, 34);
            this.layName.Text = "Customer Full Name: ";
            this.layName.TextSize = new System.Drawing.Size(204, 24);
            // 
            // layBirthDay
            // 
            this.layBirthDay.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layBirthDay.AppearanceItemCaption.Options.UseFont = true;
            this.layBirthDay.Control = this.txtBirthDay;
            this.layBirthDay.Location = new System.Drawing.Point(0, 34);
            this.layBirthDay.Name = "layBirthDay";
            this.layBirthDay.Size = new System.Drawing.Size(565, 34);
            this.layBirthDay.Text = "Birth Day: ";
            this.layBirthDay.TextSize = new System.Drawing.Size(204, 24);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnAdd;
            this.layoutControlItem3.Location = new System.Drawing.Point(377, 102);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(48, 33);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(377, 37);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 102);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(377, 37);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layAddress
            // 
            this.layAddress.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layAddress.AppearanceItemCaption.Options.UseFont = true;
            this.layAddress.Control = this.txtAddress;
            this.layAddress.Location = new System.Drawing.Point(565, 0);
            this.layAddress.Name = "layAddress";
            this.layAddress.Size = new System.Drawing.Size(566, 34);
            this.layAddress.Text = "Address: ";
            this.layAddress.TextSize = new System.Drawing.Size(204, 24);
            // 
            // layEmail
            // 
            this.layEmail.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layEmail.AppearanceItemCaption.Options.UseFont = true;
            this.layEmail.Control = this.txtEmail;
            this.layEmail.Location = new System.Drawing.Point(565, 34);
            this.layEmail.Name = "layEmail";
            this.layEmail.Size = new System.Drawing.Size(566, 34);
            this.layEmail.Text = "Email: ";
            this.layEmail.TextSize = new System.Drawing.Size(204, 24);
            // 
            // layGender
            // 
            this.layGender.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layGender.AppearanceItemCaption.Options.UseFont = true;
            this.layGender.Control = this.txtGender;
            this.layGender.Location = new System.Drawing.Point(0, 68);
            this.layGender.Name = "layGender";
            this.layGender.Size = new System.Drawing.Size(565, 34);
            this.layGender.Text = "Gender: ";
            this.layGender.TextSize = new System.Drawing.Size(204, 24);
            // 
            // layPhoneNumber
            // 
            this.layPhoneNumber.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layPhoneNumber.AppearanceItemCaption.Options.UseFont = true;
            this.layPhoneNumber.Control = this.txtPhoneNumber;
            this.layPhoneNumber.Location = new System.Drawing.Point(565, 68);
            this.layPhoneNumber.Name = "layPhoneNumber";
            this.layPhoneNumber.Size = new System.Drawing.Size(566, 34);
            this.layPhoneNumber.Text = "Phone Number: ";
            this.layPhoneNumber.TextSize = new System.Drawing.Size(204, 24);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(754, 102);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(377, 37);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblTop
            // 
            this.lblTop.Appearance.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.lblTop.Appearance.Options.UseFont = true;
            this.lblTop.Appearance.Options.UseForeColor = true;
            this.lblTop.Appearance.Options.UseTextOptions = true;
            this.lblTop.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTop.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTop.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblTop.LineVisible = true;
            this.lblTop.Location = new System.Drawing.Point(3, 3);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(1155, 70);
            this.lblTop.StyleController = this.layTong;
            this.lblTop.TabIndex = 3;
            this.lblTop.Text = "Customer";
            // 
            // GridCustomer
            // 
            this.GridCustomer.DataSource = this.DataSource;
            this.GridCustomer.Location = new System.Drawing.Point(3, 77);
            this.GridCustomer.MainView = this.dgvViewCustomer;
            this.GridCustomer.Name = "GridCustomer";
            this.GridCustomer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnUpdate});
            this.GridCustomer.Size = new System.Drawing.Size(1155, 455);
            this.GridCustomer.TabIndex = 0;
            this.GridCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvViewCustomer});
            // 
            // dgvViewCustomer
            // 
            this.dgvViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colFullName,
            this.colGender,
            this.colBirthDay,
            this.colAddress,
            this.colEmail,
            this.colPhoneNumber,
            this.colUpdate});
            this.dgvViewCustomer.GridControl = this.GridCustomer;
            this.dgvViewCustomer.Name = "dgvViewCustomer";
            // 
            // colCustomerID
            // 
            this.colCustomerID.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colCustomerID.AppearanceCell.Options.UseFont = true;
            this.colCustomerID.AppearanceCell.Options.UseTextOptions = true;
            this.colCustomerID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerID.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colCustomerID.AppearanceHeader.Options.UseFont = true;
            this.colCustomerID.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.MinWidth = 25;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.OptionsColumn.ReadOnly = true;
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 0;
            this.colCustomerID.Width = 94;
            // 
            // colFullName
            // 
            this.colFullName.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colFullName.AppearanceCell.Options.UseFont = true;
            this.colFullName.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colFullName.AppearanceHeader.Options.UseFont = true;
            this.colFullName.AppearanceHeader.Options.UseTextOptions = true;
            this.colFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFullName.FieldName = "FullName";
            this.colFullName.MinWidth = 25;
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 94;
            // 
            // colGender
            // 
            this.colGender.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colGender.AppearanceCell.Options.UseFont = true;
            this.colGender.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colGender.AppearanceHeader.Options.UseFont = true;
            this.colGender.AppearanceHeader.Options.UseTextOptions = true;
            this.colGender.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGender.FieldName = "Gender";
            this.colGender.MinWidth = 25;
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 5;
            this.colGender.Width = 94;
            // 
            // colBirthDay
            // 
            this.colBirthDay.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colBirthDay.AppearanceCell.Options.UseFont = true;
            this.colBirthDay.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colBirthDay.AppearanceHeader.Options.UseFont = true;
            this.colBirthDay.AppearanceHeader.Options.UseTextOptions = true;
            this.colBirthDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBirthDay.FieldName = "BirthDay";
            this.colBirthDay.MinWidth = 25;
            this.colBirthDay.Name = "colBirthDay";
            this.colBirthDay.Visible = true;
            this.colBirthDay.VisibleIndex = 3;
            this.colBirthDay.Width = 94;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colAddress.AppearanceHeader.Options.UseFont = true;
            this.colAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 25;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 94;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colEmail.AppearanceCell.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colEmail.AppearanceHeader.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            this.colEmail.Width = 94;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colPhoneNumber.AppearanceCell.Options.UseFont = true;
            this.colPhoneNumber.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colPhoneNumber.AppearanceHeader.Options.UseFont = true;
            this.colPhoneNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colPhoneNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.MinWidth = 25;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 6;
            this.colPhoneNumber.Width = 94;
            // 
            // colUpdate
            // 
            this.colUpdate.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colUpdate.AppearanceCell.Options.UseFont = true;
            this.colUpdate.AppearanceCell.Options.UseTextOptions = true;
            this.colUpdate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUpdate.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colUpdate.AppearanceHeader.Options.UseFont = true;
            this.colUpdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colUpdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUpdate.Caption = "Update";
            this.colUpdate.ColumnEdit = this.btnUpdate;
            this.colUpdate.MinWidth = 25;
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.Visible = true;
            this.colUpdate.VisibleIndex = 7;
            this.colUpdate.Width = 86;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layLblTop,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.Root.Size = new System.Drawing.Size(1161, 745);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GridCustomer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1159, 459);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layLblTop
            // 
            this.layLblTop.Control = this.lblTop;
            this.layLblTop.Location = new System.Drawing.Point(0, 0);
            this.layLblTop.Name = "layLblTop";
            this.layLblTop.Size = new System.Drawing.Size(1159, 74);
            this.layLblTop.TextSize = new System.Drawing.Size(0, 0);
            this.layLblTop.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grbAddCustomer;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 533);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 210);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(5, 210);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1159, 210);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ucViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layTong);
            this.Name = "ucViewCustomer";
            this.Size = new System.Drawing.Size(1161, 745);
            ((System.ComponentModel.ISupportInitialize)(this.DataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTong)).EndInit();
            this.layTong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbAddCustomer)).EndInit();
            this.grbAddCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBirthDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layLblTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DataSource;
        private DevExpress.XtraLayout.LayoutControl layTong;
        private DevExpress.XtraEditors.LabelControl lblTop;
        private DevExpress.XtraGrid.GridControl GridCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvViewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDay;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnUpdate;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layLblTop;
        private DevExpress.XtraEditors.GroupControl grbAddCustomer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.TextEdit txtGender;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtBirthDay;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layName;
        private DevExpress.XtraLayout.LayoutControlItem layBirthDay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layAddress;
        private DevExpress.XtraLayout.LayoutControlItem layEmail;
        private DevExpress.XtraLayout.LayoutControlItem layGender;
        private DevExpress.XtraLayout.LayoutControlItem layPhoneNumber;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
