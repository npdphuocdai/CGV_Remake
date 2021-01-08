
namespace Viewer
{
    partial class frmTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicket));
            this.grcSelectMovie = new DevExpress.XtraEditors.GroupControl();
            this.laySelectMovie = new DevExpress.XtraLayout.LayoutControl();
            this.lueMovie = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.layGrSelectMovie = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layBtnSelect = new DevExpress.XtraLayout.LayoutControlItem();
            this.layLueMovie = new DevExpress.XtraLayout.LayoutControlItem();
            this.layTop = new DevExpress.XtraLayout.LayoutControl();
            this.layGrTop = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layGrSelectdMovie = new DevExpress.XtraLayout.LayoutControlItem();
            this.ucTicket1 = new Viewer.ucTicket();
            this.layShowTicket = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.grcSelectMovie)).BeginInit();
            this.grcSelectMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laySelectMovie)).BeginInit();
            this.laySelectMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMovie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layGrSelectMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBtnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layLueMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTop)).BeginInit();
            this.layTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layGrTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layGrSelectdMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layShowTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // grcSelectMovie
            // 
            this.grcSelectMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcSelectMovie.AppearanceCaption.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grcSelectMovie.AppearanceCaption.Options.UseFont = true;
            this.grcSelectMovie.Controls.Add(this.laySelectMovie);
            this.grcSelectMovie.Location = new System.Drawing.Point(2, 686);
            this.grcSelectMovie.Name = "grcSelectMovie";
            this.grcSelectMovie.Size = new System.Drawing.Size(1544, 122);
            this.grcSelectMovie.TabIndex = 17;
            this.grcSelectMovie.Text = "Select Movie";
            // 
            // laySelectMovie
            // 
            this.laySelectMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laySelectMovie.Controls.Add(this.lueMovie);
            this.laySelectMovie.Controls.Add(this.btnSelect);
            this.laySelectMovie.Location = new System.Drawing.Point(2, 47);
            this.laySelectMovie.Name = "laySelectMovie";
            this.laySelectMovie.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(851, 239, 812, 500);
            this.laySelectMovie.Root = this.layGrSelectMovie;
            this.laySelectMovie.Size = new System.Drawing.Size(1520, 73);
            this.laySelectMovie.TabIndex = 0;
            this.laySelectMovie.Text = "layoutControl1";
            // 
            // lueMovie
            // 
            this.lueMovie.EditValue = "Select Movie";
            this.lueMovie.Location = new System.Drawing.Point(231, 12);
            this.lueMovie.Name = "lueMovie";
            this.lueMovie.Properties.Appearance.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueMovie.Properties.Appearance.Options.UseFont = true;
            this.lueMovie.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMovie.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lueMovie.Size = new System.Drawing.Size(803, 50);
            this.lueMovie.StyleController = this.laySelectMovie;
            this.lueMovie.TabIndex = 7;
            this.lueMovie.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.lueMovie_EditValueChanging);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Appearance.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Appearance.Options.UseFont = true;
            this.btnSelect.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSelect.ImageOptions.SvgImage")));
            this.btnSelect.Location = new System.Drawing.Point(1038, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(470, 49);
            this.btnSelect.StyleController = this.laySelectMovie;
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // layGrSelectMovie
            // 
            this.layGrSelectMovie.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layGrSelectMovie.GroupBordersVisible = false;
            this.layGrSelectMovie.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layBtnSelect,
            this.layLueMovie});
            this.layGrSelectMovie.Name = "Root";
            this.layGrSelectMovie.Size = new System.Drawing.Size(1520, 73);
            this.layGrSelectMovie.TextVisible = false;
            // 
            // layBtnSelect
            // 
            this.layBtnSelect.Control = this.btnSelect;
            this.layBtnSelect.Location = new System.Drawing.Point(1026, 0);
            this.layBtnSelect.Name = "layBtnSelect";
            this.layBtnSelect.Size = new System.Drawing.Size(474, 53);
            this.layBtnSelect.TextSize = new System.Drawing.Size(0, 0);
            this.layBtnSelect.TextVisible = false;
            // 
            // layLueMovie
            // 
            this.layLueMovie.AppearanceItemCaption.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layLueMovie.AppearanceItemCaption.Options.UseFont = true;
            this.layLueMovie.Control = this.lueMovie;
            this.layLueMovie.Location = new System.Drawing.Point(0, 0);
            this.layLueMovie.MinSize = new System.Drawing.Size(290, 50);
            this.layLueMovie.Name = "layLueMovie";
            this.layLueMovie.Size = new System.Drawing.Size(1026, 53);
            this.layLueMovie.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layLueMovie.Text = "SelectMovie";
            this.layLueMovie.TextLocation = DevExpress.Utils.Locations.Left;
            this.layLueMovie.TextSize = new System.Drawing.Size(216, 44);
            // 
            // layTop
            // 
            this.layTop.Controls.Add(this.grcSelectMovie);
            this.layTop.Controls.Add(this.ucTicket1);
            this.layTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layTop.Location = new System.Drawing.Point(0, 0);
            this.layTop.Name = "layTop";
            this.layTop.Root = this.layGrTop;
            this.layTop.Size = new System.Drawing.Size(1548, 810);
            this.layTop.TabIndex = 1;
            this.layTop.Text = "layoutControl1";
            // 
            // layGrTop
            // 
            this.layGrTop.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layGrTop.GroupBordersVisible = false;
            this.layGrTop.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layShowTicket,
            this.layGrSelectdMovie});
            this.layGrTop.Name = "layGrTop";
            this.layGrTop.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layGrTop.Size = new System.Drawing.Size(1548, 810);
            this.layGrTop.TextVisible = false;
            // 
            // layGrSelectdMovie
            // 
            this.layGrSelectdMovie.Control = this.grcSelectMovie;
            this.layGrSelectdMovie.Location = new System.Drawing.Point(0, 684);
            this.layGrSelectdMovie.MaxSize = new System.Drawing.Size(0, 126);
            this.layGrSelectdMovie.MinSize = new System.Drawing.Size(5, 126);
            this.layGrSelectdMovie.Name = "layGrSelectdMovie";
            this.layGrSelectdMovie.Size = new System.Drawing.Size(1548, 126);
            this.layGrSelectdMovie.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layGrSelectdMovie.TextSize = new System.Drawing.Size(0, 0);
            this.layGrSelectdMovie.TextVisible = false;
            // 
            // ucTicket1
            // 
            this.ucTicket1.Location = new System.Drawing.Point(2, 2);
            this.ucTicket1.Name = "ucTicket1";
            this.ucTicket1.Size = new System.Drawing.Size(1544, 680);
            this.ucTicket1.TabIndex = 4;
            // 
            // layShowTicket
            // 
            this.layShowTicket.Control = this.ucTicket1;
            this.layShowTicket.Location = new System.Drawing.Point(0, 0);
            this.layShowTicket.MinSize = new System.Drawing.Size(138, 100);
            this.layShowTicket.Name = "layShowTicket";
            this.layShowTicket.Size = new System.Drawing.Size(1548, 684);
            this.layShowTicket.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layShowTicket.TextSize = new System.Drawing.Size(0, 0);
            this.layShowTicket.TextVisible = false;
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 810);
            this.Controls.Add(this.layTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTicket";
            this.Resize += new System.EventHandler(this.frmTicket_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grcSelectMovie)).EndInit();
            this.grcSelectMovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.laySelectMovie)).EndInit();
            this.laySelectMovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueMovie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layGrSelectMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layBtnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layLueMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layTop)).EndInit();
            this.layTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layGrTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layGrSelectdMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layShowTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl grcSelectMovie;
        private DevExpress.XtraLayout.LayoutControl laySelectMovie;
        private DevExpress.XtraEditors.LookUpEdit lueMovie;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraLayout.LayoutControlGroup layGrSelectMovie;
        private DevExpress.XtraLayout.LayoutControlItem layBtnSelect;
        private DevExpress.XtraLayout.LayoutControlItem layLueMovie;
        private DevExpress.XtraLayout.LayoutControl layTop;
        private DevExpress.XtraLayout.LayoutControlGroup layGrTop;
        private ucTicket ucTicket1;
        private DevExpress.XtraLayout.LayoutControlItem layShowTicket;
        private DevExpress.XtraLayout.LayoutControlItem layGrSelectdMovie;
    }
}