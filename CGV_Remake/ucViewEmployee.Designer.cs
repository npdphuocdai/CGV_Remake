
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucViewEmployee));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.DataSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeePhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobTitleID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueJob = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.DataSourceJob = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBasicSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSourceJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.DataSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.dgvViewEmployee;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnUpdate,
            this.lueJob});
            this.gridControl1.Size = new System.Drawing.Size(1124, 511);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvViewEmployee});
            // 
            // DataSource
            // 
            this.DataSource.DataSource = typeof(DTO.dtoViewEmployees);
            // 
            // dgvViewEmployee
            // 
            this.dgvViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colEmployeeFullName,
            this.colGender,
            this.colEmployeeBirthday,
            this.colEmployeePhoneNumber,
            this.colEmployeeAddress,
            this.colEmployeeEmail,
            this.colJobTitleID,
            this.colBasicSalary,
            this.colUpdate});
            this.dgvViewEmployee.GridControl = this.gridControl1;
            this.dgvViewEmployee.Name = "dgvViewEmployee";
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeID.AppearanceCell.Options.UseFont = true;
            this.colEmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colEmployeeID.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeID.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeID.Caption = "ID";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.MinWidth = 25;
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 0;
            this.colEmployeeID.Width = 38;
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colEmployeeFullName.AppearanceCell.Options.UseFont = true;
            this.colEmployeeFullName.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colEmployeeFullName.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeFullName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeFullName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeFullName.Caption = "Full Name";
            this.colEmployeeFullName.FieldName = "EmployeeFullName";
            this.colEmployeeFullName.MinWidth = 25;
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            this.colEmployeeFullName.Visible = true;
            this.colEmployeeFullName.VisibleIndex = 1;
            this.colEmployeeFullName.Width = 136;
            // 
            // colGender
            // 
            this.colGender.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colGender.AppearanceCell.Options.UseFont = true;
            this.colGender.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colGender.AppearanceHeader.Options.UseFont = true;
            this.colGender.AppearanceHeader.Options.UseTextOptions = true;
            this.colGender.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGender.Caption = "Gender";
            this.colGender.FieldName = "Gender";
            this.colGender.MinWidth = 25;
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 2;
            this.colGender.Width = 96;
            // 
            // colEmployeeBirthday
            // 
            this.colEmployeeBirthday.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colEmployeeBirthday.AppearanceCell.Options.UseFont = true;
            this.colEmployeeBirthday.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colEmployeeBirthday.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeBirthday.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeBirthday.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeBirthday.Caption = "Birth Day";
            this.colEmployeeBirthday.FieldName = "EmployeeBirthday";
            this.colEmployeeBirthday.MinWidth = 25;
            this.colEmployeeBirthday.Name = "colEmployeeBirthday";
            this.colEmployeeBirthday.Visible = true;
            this.colEmployeeBirthday.VisibleIndex = 3;
            this.colEmployeeBirthday.Width = 108;
            // 
            // colEmployeePhoneNumber
            // 
            this.colEmployeePhoneNumber.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colEmployeePhoneNumber.AppearanceCell.Options.UseFont = true;
            this.colEmployeePhoneNumber.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colEmployeePhoneNumber.AppearanceHeader.Options.UseFont = true;
            this.colEmployeePhoneNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeePhoneNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeePhoneNumber.Caption = "Phone Number";
            this.colEmployeePhoneNumber.FieldName = "EmployeePhoneNumber";
            this.colEmployeePhoneNumber.MinWidth = 25;
            this.colEmployeePhoneNumber.Name = "colEmployeePhoneNumber";
            this.colEmployeePhoneNumber.Visible = true;
            this.colEmployeePhoneNumber.VisibleIndex = 4;
            this.colEmployeePhoneNumber.Width = 140;
            // 
            // colEmployeeAddress
            // 
            this.colEmployeeAddress.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colEmployeeAddress.AppearanceCell.Options.UseFont = true;
            this.colEmployeeAddress.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colEmployeeAddress.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeAddress.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeAddress.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeAddress.Caption = "Address";
            this.colEmployeeAddress.FieldName = "EmployeeAddress";
            this.colEmployeeAddress.MinWidth = 25;
            this.colEmployeeAddress.Name = "colEmployeeAddress";
            this.colEmployeeAddress.Visible = true;
            this.colEmployeeAddress.VisibleIndex = 5;
            this.colEmployeeAddress.Width = 92;
            // 
            // colEmployeeEmail
            // 
            this.colEmployeeEmail.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colEmployeeEmail.AppearanceCell.Options.UseFont = true;
            this.colEmployeeEmail.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colEmployeeEmail.AppearanceHeader.Options.UseFont = true;
            this.colEmployeeEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmployeeEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmployeeEmail.Caption = "Email";
            this.colEmployeeEmail.FieldName = "EmployeeEmail";
            this.colEmployeeEmail.MinWidth = 25;
            this.colEmployeeEmail.Name = "colEmployeeEmail";
            this.colEmployeeEmail.Visible = true;
            this.colEmployeeEmail.VisibleIndex = 7;
            this.colEmployeeEmail.Width = 165;
            // 
            // colJobTitleID
            // 
            this.colJobTitleID.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colJobTitleID.AppearanceCell.Options.UseFont = true;
            this.colJobTitleID.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colJobTitleID.AppearanceHeader.Options.UseFont = true;
            this.colJobTitleID.AppearanceHeader.Options.UseTextOptions = true;
            this.colJobTitleID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJobTitleID.Caption = "Job Title";
            this.colJobTitleID.ColumnEdit = this.lueJob;
            this.colJobTitleID.FieldName = "JobTitleID";
            this.colJobTitleID.MinWidth = 25;
            this.colJobTitleID.Name = "colJobTitleID";
            this.colJobTitleID.Visible = true;
            this.colJobTitleID.VisibleIndex = 6;
            this.colJobTitleID.Width = 102;
            // 
            // lueJob
            // 
            this.lueJob.AutoHeight = false;
            this.lueJob.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueJob.DataSource = this.DataSourceJob;
            this.lueJob.DisplayMember = "JobtitleName";
            this.lueJob.Name = "lueJob";
            this.lueJob.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.lueJob.ValueMember = "JobTitleID";
            // 
            // DataSourceJob
            // 
            this.DataSourceJob.DataSource = typeof(DTO.dtoViewEmployees);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colBasicSalary
            // 
            this.colBasicSalary.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.colBasicSalary.AppearanceCell.Options.UseFont = true;
            this.colBasicSalary.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.colBasicSalary.AppearanceHeader.Options.UseFont = true;
            this.colBasicSalary.AppearanceHeader.Options.UseTextOptions = true;
            this.colBasicSalary.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBasicSalary.FieldName = "BasicSalary";
            this.colBasicSalary.MinWidth = 25;
            this.colBasicSalary.Name = "colBasicSalary";
            this.colBasicSalary.Visible = true;
            this.colBasicSalary.VisibleIndex = 8;
            this.colBasicSalary.Width = 131;
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
            this.colUpdate.VisibleIndex = 9;
            this.colUpdate.Width = 86;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.btnUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ucViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "ucViewEmployee";
            this.Size = new System.Drawing.Size(1124, 511);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSourceJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvViewEmployee;
        private System.Windows.Forms.BindingSource DataSource;
        private DevExpress.XtraGrid.Columns.GridColumn colJobTitleID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colBasicSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeePhoneNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit lueJob;
        private System.Windows.Forms.BindingSource DataSourceJob;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnUpdate;
    }
}
