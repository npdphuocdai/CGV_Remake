
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1124, 382);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            this.colEmployeePotrait.Visible = true;
            this.colEmployeePotrait.VisibleIndex = 1;
            this.colEmployeePotrait.Width = 94;
            // 
            // colBasicSalary
            // 
            this.colBasicSalary.FieldName = "BasicSalary";
            this.colBasicSalary.MinWidth = 25;
            this.colBasicSalary.Name = "colBasicSalary";
            this.colBasicSalary.Visible = true;
            this.colBasicSalary.VisibleIndex = 2;
            this.colBasicSalary.Width = 94;
            // 
            // colStartDay
            // 
            this.colStartDay.FieldName = "StartDay";
            this.colStartDay.MinWidth = 25;
            this.colStartDay.Name = "colStartDay";
            this.colStartDay.Visible = true;
            this.colStartDay.VisibleIndex = 3;
            this.colStartDay.Width = 94;
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.FieldName = "EmployeeFullName";
            this.colEmployeeFullName.MinWidth = 25;
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            this.colEmployeeFullName.Visible = true;
            this.colEmployeeFullName.VisibleIndex = 4;
            this.colEmployeeFullName.Width = 94;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.MinWidth = 25;
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 5;
            this.colGender.Width = 94;
            // 
            // colEmployeeAddress
            // 
            this.colEmployeeAddress.FieldName = "EmployeeAddress";
            this.colEmployeeAddress.MinWidth = 25;
            this.colEmployeeAddress.Name = "colEmployeeAddress";
            this.colEmployeeAddress.Visible = true;
            this.colEmployeeAddress.VisibleIndex = 6;
            this.colEmployeeAddress.Width = 94;
            // 
            // colEmployeeEmail
            // 
            this.colEmployeeEmail.FieldName = "EmployeeEmail";
            this.colEmployeeEmail.MinWidth = 25;
            this.colEmployeeEmail.Name = "colEmployeeEmail";
            this.colEmployeeEmail.Visible = true;
            this.colEmployeeEmail.VisibleIndex = 7;
            this.colEmployeeEmail.Width = 94;
            // 
            // colEmployeeBirthday
            // 
            this.colEmployeeBirthday.FieldName = "EmployeeBirthday";
            this.colEmployeeBirthday.MinWidth = 25;
            this.colEmployeeBirthday.Name = "colEmployeeBirthday";
            this.colEmployeeBirthday.Visible = true;
            this.colEmployeeBirthday.VisibleIndex = 8;
            this.colEmployeeBirthday.Width = 94;
            // 
            // colEmployeePhoneNumber
            // 
            this.colEmployeePhoneNumber.FieldName = "EmployeePhoneNumber";
            this.colEmployeePhoneNumber.MinWidth = 25;
            this.colEmployeePhoneNumber.Name = "colEmployeePhoneNumber";
            this.colEmployeePhoneNumber.Visible = true;
            this.colEmployeePhoneNumber.VisibleIndex = 9;
            this.colEmployeePhoneNumber.Width = 94;
            // 
            // colJobtitleName
            // 
            this.colJobtitleName.FieldName = "JobtitleName";
            this.colJobtitleName.MinWidth = 25;
            this.colJobtitleName.Name = "colJobtitleName";
            this.colJobtitleName.Visible = true;
            this.colJobtitleName.VisibleIndex = 10;
            this.colJobtitleName.Width = 94;
            // 
            // colCoefficientsSalary
            // 
            this.colCoefficientsSalary.FieldName = "CoefficientsSalary";
            this.colCoefficientsSalary.MinWidth = 25;
            this.colCoefficientsSalary.Name = "colCoefficientsSalary";
            this.colCoefficientsSalary.Visible = true;
            this.colCoefficientsSalary.VisibleIndex = 11;
            this.colCoefficientsSalary.Width = 94;
            // 
            // colPositionAllowance
            // 
            this.colPositionAllowance.FieldName = "PositionAllowance";
            this.colPositionAllowance.MinWidth = 25;
            this.colPositionAllowance.Name = "colPositionAllowance";
            this.colPositionAllowance.Visible = true;
            this.colPositionAllowance.VisibleIndex = 12;
            this.colPositionAllowance.Width = 94;
            // 
            // colMajor
            // 
            this.colMajor.FieldName = "Major";
            this.colMajor.MinWidth = 25;
            this.colMajor.Name = "colMajor";
            this.colMajor.Visible = true;
            this.colMajor.VisibleIndex = 13;
            this.colMajor.Width = 94;
            // 
            // ucViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "ucViewEmployee";
            this.Size = new System.Drawing.Size(1124, 382);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
