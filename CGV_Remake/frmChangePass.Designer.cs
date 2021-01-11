
namespace Viewer
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.layFormLogin = new DevExpress.XtraLayout.LayoutControl();
            this.btnChangePass = new DevExpress.XtraEditors.SimpleButton();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layUserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.layButtonLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.layNewPass = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtConfirmPass = new DevExpress.XtraEditors.TextEdit();
            this.layConfirmPass = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layFormLogin)).BeginInit();
            this.layFormLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layButtonLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConfirmPass)).BeginInit();
            this.SuspendLayout();
            // 
            // layFormLogin
            // 
            this.layFormLogin.Controls.Add(this.txtConfirmPass);
            this.layFormLogin.Controls.Add(this.txtNewPass);
            this.layFormLogin.Controls.Add(this.btnChangePass);
            this.layFormLogin.Controls.Add(this.txtPass);
            this.layFormLogin.Controls.Add(this.txtUsername);
            this.layFormLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layFormLogin.Location = new System.Drawing.Point(0, 0);
            this.layFormLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layFormLogin.Name = "layFormLogin";
            this.layFormLogin.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(663, 0, 812, 500);
            this.layFormLogin.Root = this.Root;
            this.layFormLogin.Size = new System.Drawing.Size(630, 279);
            this.layFormLogin.TabIndex = 2;
            this.layFormLogin.Text = "layoutControl1";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Appearance.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Appearance.Options.UseFont = true;
            this.btnChangePass.Location = new System.Drawing.Point(148, 199);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(335, 49);
            this.btnChangePass.StyleController = this.layFormLogin;
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(233, 50);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(385, 34);
            this.txtPass.StyleController = this.layFormLogin;
            this.txtPass.TabIndex = 5;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(233, 12);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Size = new System.Drawing.Size(385, 34);
            this.txtUsername.StyleController = this.layFormLogin;
            this.txtUsername.TabIndex = 4;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layUserName,
            this.layPassword,
            this.layButtonLogin,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.layNewPass,
            this.layConfirmPass});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(630, 279);
            this.Root.TextVisible = false;
            // 
            // layUserName
            // 
            this.layUserName.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layUserName.AppearanceItemCaption.Options.UseFont = true;
            this.layUserName.Control = this.txtUsername;
            this.layUserName.Location = new System.Drawing.Point(0, 0);
            this.layUserName.Name = "layUserName";
            this.layUserName.Size = new System.Drawing.Size(610, 38);
            this.layUserName.Text = "Username:";
            this.layUserName.TextSize = new System.Drawing.Size(218, 27);
            // 
            // layPassword
            // 
            this.layPassword.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layPassword.AppearanceItemCaption.Options.UseFont = true;
            this.layPassword.Control = this.txtPass;
            this.layPassword.Location = new System.Drawing.Point(0, 38);
            this.layPassword.Name = "layPassword";
            this.layPassword.Size = new System.Drawing.Size(610, 38);
            this.layPassword.Text = "Old Password: ";
            this.layPassword.TextSize = new System.Drawing.Size(218, 27);
            // 
            // layButtonLogin
            // 
            this.layButtonLogin.Control = this.btnChangePass;
            this.layButtonLogin.Location = new System.Drawing.Point(136, 187);
            this.layButtonLogin.Name = "layButtonLogin";
            this.layButtonLogin.Size = new System.Drawing.Size(339, 53);
            this.layButtonLogin.TextSize = new System.Drawing.Size(0, 0);
            this.layButtonLogin.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 152);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(136, 107);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(475, 152);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(135, 107);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(136, 152);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(104, 23);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(339, 35);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(136, 240);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(339, 19);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(233, 88);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Properties.Appearance.Options.UseFont = true;
            this.txtNewPass.Size = new System.Drawing.Size(385, 34);
            this.txtNewPass.StyleController = this.layFormLogin;
            this.txtNewPass.TabIndex = 7;
            this.txtNewPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPass_KeyPress);
            // 
            // layNewPass
            // 
            this.layNewPass.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layNewPass.AppearanceItemCaption.Options.UseFont = true;
            this.layNewPass.Control = this.txtNewPass;
            this.layNewPass.Location = new System.Drawing.Point(0, 76);
            this.layNewPass.Name = "layNewPass";
            this.layNewPass.Size = new System.Drawing.Size(610, 38);
            this.layNewPass.Text = "New Password: ";
            this.layNewPass.TextSize = new System.Drawing.Size(218, 27);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(233, 126);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Properties.Appearance.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Properties.Appearance.Options.UseFont = true;
            this.txtConfirmPass.Size = new System.Drawing.Size(385, 34);
            this.txtConfirmPass.StyleController = this.layFormLogin;
            this.txtConfirmPass.TabIndex = 8;
            this.txtConfirmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPass_KeyPress);
            // 
            // layConfirmPass
            // 
            this.layConfirmPass.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layConfirmPass.AppearanceItemCaption.Options.UseFont = true;
            this.layConfirmPass.Control = this.txtConfirmPass;
            this.layConfirmPass.Location = new System.Drawing.Point(0, 114);
            this.layConfirmPass.Name = "layConfirmPass";
            this.layConfirmPass.Size = new System.Drawing.Size(610, 38);
            this.layConfirmPass.Text = "Confirm Password: ";
            this.layConfirmPass.TextSize = new System.Drawing.Size(218, 27);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 279);
            this.Controls.Add(this.layFormLogin);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmChangePass.IconOptions.Image")));
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)(this.layFormLogin)).EndInit();
            this.layFormLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layButtonLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layConfirmPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layFormLogin;
        private DevExpress.XtraEditors.TextEdit txtConfirmPass;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraEditors.SimpleButton btnChangePass;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layUserName;
        private DevExpress.XtraLayout.LayoutControlItem layPassword;
        private DevExpress.XtraLayout.LayoutControlItem layButtonLogin;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layNewPass;
        private DevExpress.XtraLayout.LayoutControlItem layConfirmPass;
    }
}