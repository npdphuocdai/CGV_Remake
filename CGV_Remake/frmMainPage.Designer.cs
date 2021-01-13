
namespace Viewer
{
    partial class frmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.fldContainter = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.acrLeft = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceButtonHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceLogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceAccount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceUsername = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceChangePass = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceServices = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceTicket = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceStatistics = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDashboard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceViewnEdit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceViewEmployees = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceAddEmployee = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceViewCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceViewMovie = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.SkinsLink = new DevExpress.XtraBars.BarSubItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.acrLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fldContainter
            // 
            this.fldContainter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fldContainter.Location = new System.Drawing.Point(312, 39);
            this.fldContainter.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.fldContainter.Name = "fldContainter";
            this.fldContainter.Size = new System.Drawing.Size(937, 577);
            this.fldContainter.TabIndex = 0;
            // 
            // acrLeft
            // 
            this.acrLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.acrLeft.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceHome,
            this.aceAccount,
            this.aceServices,
            this.aceStatistics,
            this.aceViewnEdit});
            this.acrLeft.Location = new System.Drawing.Point(0, 39);
            this.acrLeft.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.acrLeft.Name = "acrLeft";
            this.acrLeft.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.acrLeft.Size = new System.Drawing.Size(312, 577);
            this.acrLeft.TabIndex = 1;
            this.acrLeft.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceHome
            // 
            this.aceHome.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceButtonHome,
            this.aceLogOut});
            this.aceHome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceHome.ImageOptions.SvgImage")));
            this.aceHome.Name = "aceHome";
            this.aceHome.Text = "Home";
            // 
            // aceButtonHome
            // 
            this.aceButtonHome.Name = "aceButtonHome";
            this.aceButtonHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceButtonHome.Text = "Home";
            this.aceButtonHome.Click += new System.EventHandler(this.aceButtonHome_Click);
            // 
            // aceLogOut
            // 
            this.aceLogOut.Name = "aceLogOut";
            this.aceLogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceLogOut.Text = "Log Out";
            this.aceLogOut.Click += new System.EventHandler(this.aceLogOut_Click);
            // 
            // aceAccount
            // 
            this.aceAccount.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceUsername,
            this.aceChangePass});
            this.aceAccount.Expanded = true;
            this.aceAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceAccount.ImageOptions.SvgImage")));
            this.aceAccount.Name = "aceAccount";
            this.aceAccount.Text = "Account";
            // 
            // aceUsername
            // 
            this.aceUsername.Name = "aceUsername";
            this.aceUsername.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceUsername.Text = "Log In";
            this.aceUsername.Click += new System.EventHandler(this.aceUsername_Click);
            // 
            // aceChangePass
            // 
            this.aceChangePass.Name = "aceChangePass";
            this.aceChangePass.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceChangePass.Text = "Change Password";
            this.aceChangePass.Click += new System.EventHandler(this.aceChangePass_Click);
            // 
            // aceServices
            // 
            this.aceServices.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceTicket});
            this.aceServices.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceServices.ImageOptions.SvgImage")));
            this.aceServices.Name = "aceServices";
            this.aceServices.Text = "Services";
            // 
            // aceTicket
            // 
            this.aceTicket.Name = "aceTicket";
            this.aceTicket.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceTicket.Text = "Ticket";
            this.aceTicket.Click += new System.EventHandler(this.aceTicket_Click);
            // 
            // aceStatistics
            // 
            this.aceStatistics.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceDashboard});
            this.aceStatistics.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceStatistics.ImageOptions.SvgImage")));
            this.aceStatistics.Name = "aceStatistics";
            this.aceStatistics.Text = "Statistics";
            // 
            // aceDashboard
            // 
            this.aceDashboard.Name = "aceDashboard";
            this.aceDashboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDashboard.Text = "Dashboard";
            this.aceDashboard.Click += new System.EventHandler(this.aceDashboard_Click);
            // 
            // aceViewnEdit
            // 
            this.aceViewnEdit.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceViewEmployees,
            this.aceAddEmployee,
            this.aceViewCustomer,
            this.aceViewMovie});
            this.aceViewnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceViewnEdit.ImageOptions.SvgImage")));
            this.aceViewnEdit.Name = "aceViewnEdit";
            this.aceViewnEdit.Text = "Management";
            // 
            // aceViewEmployees
            // 
            this.aceViewEmployees.Name = "aceViewEmployees";
            this.aceViewEmployees.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceViewEmployees.Text = "View Employees";
            this.aceViewEmployees.Click += new System.EventHandler(this.aceViewEmployees_Click);
            // 
            // aceAddEmployee
            // 
            this.aceAddEmployee.Name = "aceAddEmployee";
            this.aceAddEmployee.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceAddEmployee.Text = "Add Employee";
            this.aceAddEmployee.Click += new System.EventHandler(this.aceAddEmployee_Click);
            // 
            // aceViewCustomer
            // 
            this.aceViewCustomer.Name = "aceViewCustomer";
            this.aceViewCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceViewCustomer.Text = "Customer Management";
            this.aceViewCustomer.Click += new System.EventHandler(this.aceViewCustomer_Click);
            // 
            // aceViewMovie
            // 
            this.aceViewMovie.Name = "aceViewMovie";
            this.aceViewMovie.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceViewMovie.Text = "Movie Management";
            this.aceViewMovie.Click += new System.EventHandler(this.aceViewMovie_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.SkinsLink,
            this.skinBarSubItem1,
            this.skinDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1249, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.SkinsLink);
            // 
            // SkinsLink
            // 
            this.SkinsLink.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.SkinsLink.Caption = "Theme";
            this.SkinsLink.Id = 0;
            this.SkinsLink.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SkinsLink.ImageOptions.SvgImage")));
            this.SkinsLink.Name = "SkinsLink";
            this.SkinsLink.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 1;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 2;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 3;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.SkinsLink,
            this.skinBarSubItem1,
            this.skinDropDownButtonItem1,
            this.skinPaletteDropDownButtonItem1});
            this.fluentFormDefaultManager1.MaxItemId = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 616);
            this.ControlContainer = this.fldContainter;
            this.Controls.Add(this.fldContainter);
            this.Controls.Add(this.acrLeft);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMainPage.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMainPage";
            this.NavigationControl = this.acrLeft;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGV Managerment";
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acrLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl acrLeft;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHome;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceButtonHome;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceLogOut;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceAccount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceServices;
        public DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fldContainter;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceStatistics;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDashboard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceViewnEdit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceTicket;
        private DevExpress.XtraBars.BarSubItem SkinsLink;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceUsername;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceChangePass;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceViewEmployees;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceAddEmployee;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceViewCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceViewMovie;
    }
}

