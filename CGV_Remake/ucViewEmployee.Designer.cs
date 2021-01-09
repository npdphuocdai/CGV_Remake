
namespace Viewer
{
    partial class ucViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucViewEmployee));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layTong = new DevExpress.XtraLayout.LayoutControl();
            this.gridViewEmployee = new DevExpress.XtraGrid.GridControl();
            this.dtoViewEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeePhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobtitleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnViewProfile = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layBtnViewProfile = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layTong)).BeginInit();
            this.layTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoViewEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBtnViewProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layTong
            // 
            this.layTong.Controls.Add(this.gridViewEmployee);
            this.layTong.Controls.Add(this.btnViewProfile);
            this.layTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layTong.Location = new System.Drawing.Point(0, 0);
            this.layTong.Name = "layTong";
            this.layTong.Root = this.Root;
            this.layTong.Size = new System.Drawing.Size(1500, 670);
            this.layTong.TabIndex = 0;
            this.layTong.Text = "layoutControl1";
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.DataSource = this.dtoViewEmployeeBindingSource;
            this.gridViewEmployee.Location = new System.Drawing.Point(2, 2);
            this.gridViewEmployee.MainView = this.dgvViewEmployee;
            this.gridViewEmployee.Name = "gridViewEmployee";
            this.gridViewEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnUpdate});
            this.gridViewEmployee.Size = new System.Drawing.Size(1496, 559);
            this.gridViewEmployee.TabIndex = 5;
            this.gridViewEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvViewEmployee});
            // 
            // dtoViewEmployeeBindingSource
            // 
            this.dtoViewEmployeeBindingSource.DataSource = typeof(DTO.dtoViewEmployee);
            // 
            // dgvViewEmployee
            // 
            this.dgvViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colEmployeeFullName,
            this.colGender,
            this.colEmployeeAddress,
            this.colEmployeeEmail,
            this.colEmployeeBirthday,
            this.colEmployeePhoneNumber,
            this.colJobtitleName,
            this.colUpdate});
            this.dgvViewEmployee.GridControl = this.gridViewEmployee;
            this.dgvViewEmployee.Name = "dgvViewEmployee";
            this.dgvViewEmployee.OptionsView.ShowAutoFilterRow = true;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeID.AppearanceCell.Options.UseFont = true;
            this.colEmployeeID.AppearanceCell.Options.UseTextOptions = true;
            this.colEmployeeID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeID.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.MinWidth = 25;
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.OptionsColumn.ReadOnly = true;
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 0;
            this.colEmployeeID.Width = 118;
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeFullName.AppearanceCell.Options.UseFont = true;
            this.colEmployeeFullName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeFullName.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeFullName.FieldName = "EmployeeFullName";
            this.colEmployeeFullName.MinWidth = 25;
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            this.colEmployeeFullName.Visible = true;
            this.colEmployeeFullName.VisibleIndex = 1;
            this.colEmployeeFullName.Width = 203;
            // 
            // colGender
            // 
            this.colGender.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGender.AppearanceCell.Options.UseFont = true;
            this.colGender.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGender.AppearanceHeader.Options.UseFont = true;
            this.colGender.FieldName = "Gender";
            this.colGender.MinWidth = 25;
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 2;
            this.colGender.Width = 104;
            // 
            // colEmployeeAddress
            // 
            this.colEmployeeAddress.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeAddress.AppearanceCell.Options.UseFont = true;
            this.colEmployeeAddress.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeAddress.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeAddress.FieldName = "EmployeeAddress";
            this.colEmployeeAddress.MinWidth = 25;
            this.colEmployeeAddress.Name = "colEmployeeAddress";
            this.colEmployeeAddress.Visible = true;
            this.colEmployeeAddress.VisibleIndex = 3;
            this.colEmployeeAddress.Width = 186;
            // 
            // colEmployeeEmail
            // 
            this.colEmployeeEmail.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeEmail.AppearanceCell.Options.UseFont = true;
            this.colEmployeeEmail.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeEmail.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeEmail.FieldName = "EmployeeEmail";
            this.colEmployeeEmail.MinWidth = 25;
            this.colEmployeeEmail.Name = "colEmployeeEmail";
            this.colEmployeeEmail.Visible = true;
            this.colEmployeeEmail.VisibleIndex = 4;
            this.colEmployeeEmail.Width = 186;
            // 
            // colEmployeeBirthday
            // 
            this.colEmployeeBirthday.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeBirthday.AppearanceCell.Options.UseFont = true;
            this.colEmployeeBirthday.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeBirthday.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeBirthday.FieldName = "EmployeeBirthday";
            this.colEmployeeBirthday.MinWidth = 25;
            this.colEmployeeBirthday.Name = "colEmployeeBirthday";
            this.colEmployeeBirthday.Visible = true;
            this.colEmployeeBirthday.VisibleIndex = 5;
            this.colEmployeeBirthday.Width = 186;
            // 
            // colEmployeePhoneNumber
            // 
            this.colEmployeePhoneNumber.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeePhoneNumber.AppearanceCell.Options.UseFont = true;
            this.colEmployeePhoneNumber.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeePhoneNumber.AppearanceHeader.Options.UseFont = true;
            this.colEmployeePhoneNumber.FieldName = "EmployeePhoneNumber";
            this.colEmployeePhoneNumber.MinWidth = 25;
            this.colEmployeePhoneNumber.Name = "colEmployeePhoneNumber";
            this.colEmployeePhoneNumber.Visible = true;
            this.colEmployeePhoneNumber.VisibleIndex = 6;
            this.colEmployeePhoneNumber.Width = 300;
            // 
            // colJobtitleName
            // 
            this.colJobtitleName.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colJobtitleName.AppearanceCell.Options.UseFont = true;
            this.colJobtitleName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colJobtitleName.AppearanceHeader.Options.UseFont = true;
            this.colJobtitleName.FieldName = "JobtitleName";
            this.colJobtitleName.MinWidth = 25;
            this.colJobtitleName.Name = "colJobtitleName";
            this.colJobtitleName.Visible = true;
            this.colJobtitleName.VisibleIndex = 7;
            this.colJobtitleName.Width = 183;
            // 
            // colUpdate
            // 
            this.colUpdate.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUpdate.AppearanceHeader.Options.UseFont = true;
            this.colUpdate.Caption = "Update";
            this.colUpdate.ColumnEdit = this.btnUpdate;
            this.colUpdate.MinWidth = 25;
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.Visible = true;
            this.colUpdate.VisibleIndex = 8;
            this.colUpdate.Width = 94;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Appearance.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Appearance.Options.UseFont = true;
            this.btnViewProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewProfile.ImageOptions.SvgImage")));
            this.btnViewProfile.Location = new System.Drawing.Point(502, 565);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(496, 103);
            this.btnViewProfile.StyleController = this.layTong;
            this.btnViewProfile.TabIndex = 4;
            this.btnViewProfile.Text = "View Profile";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layBtnViewProfile,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1500, 670);
            this.Root.TextVisible = false;
            // 
            // layBtnViewProfile
            // 
            this.layBtnViewProfile.Control = this.btnViewProfile;
            this.layBtnViewProfile.Location = new System.Drawing.Point(500, 563);
            this.layBtnViewProfile.MinSize = new System.Drawing.Size(264, 53);
            this.layBtnViewProfile.Name = "layBtnViewProfile";
            this.layBtnViewProfile.Size = new System.Drawing.Size(500, 107);
            this.layBtnViewProfile.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layBtnViewProfile.TextSize = new System.Drawing.Size(0, 0);
            this.layBtnViewProfile.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 563);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(500, 107);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(1000, 563);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(500, 107);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridViewEmployee;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1500, 563);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ucViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layTong);
            this.Name = "ucViewEmployee";
            this.Size = new System.Drawing.Size(1500, 670);
            ((System.ComponentModel.ISupportInitialize)(this.layTong)).EndInit();
            this.layTong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoViewEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBtnViewProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layTong;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridViewEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvViewEmployee;
        private DevExpress.XtraEditors.SimpleButton btnViewProfile;
        private DevExpress.XtraLayout.LayoutControlItem layBtnViewProfile;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource dtoViewEmployeeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeePhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colJobtitleName;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnUpdate;
    }
}
