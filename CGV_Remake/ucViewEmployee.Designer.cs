
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucViewEmployee));
            this.layTong = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnViewProfile = new DevExpress.XtraEditors.SimpleButton();
            this.layBtnViewProfile = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gridViewEmployee = new DevExpress.XtraGrid.GridControl();
            this.dgvViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layTong)).BeginInit();
            this.layTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBtnViewProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmployee)).BeginInit();
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
            // btnViewProfile
            // 
            this.btnViewProfile.Appearance.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Appearance.Options.UseFont = true;
            this.btnViewProfile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnViewProfile.Location = new System.Drawing.Point(502, 619);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(496, 49);
            this.btnViewProfile.StyleController = this.layTong;
            this.btnViewProfile.TabIndex = 4;
            this.btnViewProfile.Text = "View Profile";
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
            // gridViewEmployee
            // 
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
            this.dgvViewEmployee.GridControl = this.gridViewEmployee;
            this.dgvViewEmployee.Name = "dgvViewEmployee";
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
            // ucViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layTong);
            this.Name = "ucViewEmployee";
            this.Size = new System.Drawing.Size(1500, 670);
            ((System.ComponentModel.ISupportInitialize)(this.layTong)).EndInit();
            this.layTong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBtnViewProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewEmployee)).EndInit();
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
    }
}
