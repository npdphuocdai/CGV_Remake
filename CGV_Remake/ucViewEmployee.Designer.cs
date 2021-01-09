
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucViewEmployee));
            this.layTong = new DevExpress.XtraLayout.LayoutControl();
            this.gridViewEmployee = new DevExpress.XtraGrid.GridControl();
            this.dgvViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnViewProfile = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layBtnViewProfile = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtoViewEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeePotrait = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBasicSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeePhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobtitleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoefficientsSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPositionAllowance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMajor = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layTong)).BeginInit();
            this.layTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBtnViewProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoViewEmployeeBindingSource)).BeginInit();
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
            this.gridViewEmployee.Size = new System.Drawing.Size(1496, 613);
            this.gridViewEmployee.TabIndex = 5;
            this.gridViewEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvViewEmployee});
            // 
            // dgvViewEmployee
            // 
            this.dgvViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colEmployeePotrait,
            this.colBasicSalary,
            this.colStartDay,
            this.colEmployeeFullName,
            this.colGender,
            this.colEmployeeAddress,
            this.colEmployeeEmail,
            this.colEmployeeBirthday,
            this.colEmployeePhoneNumber,
            this.colJobtitleName,
            this.colCoefficientsSalary,
            this.colPositionAllowance,
            this.colMajor});
            this.dgvViewEmployee.GridControl = this.gridViewEmployee;
            this.dgvViewEmployee.Name = "dgvViewEmployee";
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Appearance.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Appearance.Options.UseFont = true;
            this.btnViewProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewProfile.ImageOptions.SvgImage")));
            this.btnViewProfile.Location = new System.Drawing.Point(502, 619);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(496, 49);
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
            this.layBtnViewProfile.Location = new System.Drawing.Point(500, 617);
            this.layBtnViewProfile.Name = "layBtnViewProfile";
            this.layBtnViewProfile.Size = new System.Drawing.Size(500, 53);
            this.layBtnViewProfile.TextSize = new System.Drawing.Size(0, 0);
            this.layBtnViewProfile.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 617);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(500, 53);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(1000, 617);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(500, 53);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridViewEmployee;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1500, 617);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // dtoViewEmployeeBindingSource
            // 
            this.dtoViewEmployeeBindingSource.DataSource = typeof(DTO.dtoViewEmployee);
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.MinWidth = 25;
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 0;
            this.colEmployeeID.Width = 94;
            // 
            // colEmployeePotrait
            // 
            this.colEmployeePotrait.FieldName = "EmployeePotrait";
            this.colEmployeePotrait.MinWidth = 25;
            this.colEmployeePotrait.Name = "colEmployeePotrait";
            this.colEmployeePotrait.Width = 94;
            // 
            // colBasicSalary
            // 
            this.colBasicSalary.FieldName = "BasicSalary";
            this.colBasicSalary.MinWidth = 25;
            this.colBasicSalary.Name = "colBasicSalary";
            this.colBasicSalary.Visible = true;
            this.colBasicSalary.VisibleIndex = 1;
            this.colBasicSalary.Width = 94;
            // 
            // colStartDay
            // 
            this.colStartDay.FieldName = "StartDay";
            this.colStartDay.MinWidth = 25;
            this.colStartDay.Name = "colStartDay";
            this.colStartDay.Visible = true;
            this.colStartDay.VisibleIndex = 2;
            this.colStartDay.Width = 94;
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.FieldName = "EmployeeFullName";
            this.colEmployeeFullName.MinWidth = 25;
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            this.colEmployeeFullName.Visible = true;
            this.colEmployeeFullName.VisibleIndex = 3;
            this.colEmployeeFullName.Width = 94;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.MinWidth = 25;
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 4;
            this.colGender.Width = 94;
            // 
            // colEmployeeAddress
            // 
            this.colEmployeeAddress.FieldName = "EmployeeAddress";
            this.colEmployeeAddress.MinWidth = 25;
            this.colEmployeeAddress.Name = "colEmployeeAddress";
            this.colEmployeeAddress.Visible = true;
            this.colEmployeeAddress.VisibleIndex = 5;
            this.colEmployeeAddress.Width = 94;
            // 
            // colEmployeeEmail
            // 
            this.colEmployeeEmail.FieldName = "EmployeeEmail";
            this.colEmployeeEmail.MinWidth = 25;
            this.colEmployeeEmail.Name = "colEmployeeEmail";
            this.colEmployeeEmail.Visible = true;
            this.colEmployeeEmail.VisibleIndex = 6;
            this.colEmployeeEmail.Width = 94;
            // 
            // colEmployeeBirthday
            // 
            this.colEmployeeBirthday.FieldName = "EmployeeBirthday";
            this.colEmployeeBirthday.MinWidth = 25;
            this.colEmployeeBirthday.Name = "colEmployeeBirthday";
            this.colEmployeeBirthday.Visible = true;
            this.colEmployeeBirthday.VisibleIndex = 7;
            this.colEmployeeBirthday.Width = 94;
            // 
            // colEmployeePhoneNumber
            // 
            this.colEmployeePhoneNumber.FieldName = "EmployeePhoneNumber";
            this.colEmployeePhoneNumber.MinWidth = 25;
            this.colEmployeePhoneNumber.Name = "colEmployeePhoneNumber";
            this.colEmployeePhoneNumber.Visible = true;
            this.colEmployeePhoneNumber.VisibleIndex = 8;
            this.colEmployeePhoneNumber.Width = 94;
            // 
            // colJobtitleName
            // 
            this.colJobtitleName.FieldName = "JobtitleName";
            this.colJobtitleName.MinWidth = 25;
            this.colJobtitleName.Name = "colJobtitleName";
            this.colJobtitleName.Visible = true;
            this.colJobtitleName.VisibleIndex = 9;
            this.colJobtitleName.Width = 94;
            // 
            // colCoefficientsSalary
            // 
            this.colCoefficientsSalary.FieldName = "CoefficientsSalary";
            this.colCoefficientsSalary.MinWidth = 25;
            this.colCoefficientsSalary.Name = "colCoefficientsSalary";
            this.colCoefficientsSalary.Visible = true;
            this.colCoefficientsSalary.VisibleIndex = 10;
            this.colCoefficientsSalary.Width = 94;
            // 
            // colPositionAllowance
            // 
            this.colPositionAllowance.FieldName = "PositionAllowance";
            this.colPositionAllowance.MinWidth = 25;
            this.colPositionAllowance.Name = "colPositionAllowance";
            this.colPositionAllowance.Visible = true;
            this.colPositionAllowance.VisibleIndex = 11;
            this.colPositionAllowance.Width = 94;
            // 
            // colMajor
            // 
            this.colMajor.FieldName = "Major";
            this.colMajor.MinWidth = 25;
            this.colMajor.Name = "colMajor";
            this.colMajor.Visible = true;
            this.colMajor.VisibleIndex = 12;
            this.colMajor.Width = 94;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBtnViewProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoViewEmployeeBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeePotrait;
        private DevExpress.XtraGrid.Columns.GridColumn colBasicSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDay;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeePhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colJobtitleName;
        private DevExpress.XtraGrid.Columns.GridColumn colCoefficientsSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colPositionAllowance;
        private DevExpress.XtraGrid.Columns.GridColumn colMajor;
    }
}
