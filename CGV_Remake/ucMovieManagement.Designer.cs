
namespace Viewer
{
    partial class ucMovieManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMovieManagement));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layTong = new DevExpress.XtraLayout.LayoutControl();
            this.lblTop = new DevExpress.XtraEditors.LabelControl();
            this.GridFilm = new DevExpress.XtraGrid.GridControl();
            this.dgvViewFilm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDuration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilmName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenreID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReleaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStopDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layLblTop = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layTong)).BeginInit();
            this.layTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layLblTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layTong
            // 
            this.layTong.Controls.Add(this.lblTop);
            this.layTong.Controls.Add(this.GridFilm);
            this.layTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layTong.Location = new System.Drawing.Point(0, 0);
            this.layTong.Name = "layTong";
            this.layTong.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(544, 227, 812, 500);
            this.layTong.Root = this.Root;
            this.layTong.Size = new System.Drawing.Size(1299, 598);
            this.layTong.TabIndex = 3;
            this.layTong.Text = "layoutControl1";
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
            this.lblTop.Size = new System.Drawing.Size(1293, 70);
            this.lblTop.StyleController = this.layTong;
            this.lblTop.TabIndex = 3;
            this.lblTop.Text = "Customer";
            // 
            // GridFilm
            // 
            this.GridFilm.Location = new System.Drawing.Point(3, 77);
            this.GridFilm.MainView = this.dgvViewFilm;
            this.GridFilm.Name = "GridFilm";
            this.GridFilm.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnUpdate});
            this.GridFilm.Size = new System.Drawing.Size(1293, 308);
            this.GridFilm.TabIndex = 0;
            this.GridFilm.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvViewFilm});
            // 
            // dgvViewFilm
            // 
            this.dgvViewFilm.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUpdate,
            this.colDuration,
            this.colFilmName,
            this.colGenreID,
            this.colReleaseDate,
            this.colStopDate});
            this.dgvViewFilm.GridControl = this.GridFilm;
            this.dgvViewFilm.Name = "dgvViewFilm";
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
            this.colUpdate.VisibleIndex = 5;
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
            // 
            // colDuration
            // 
            this.colDuration.FieldName = "Duration";
            this.colDuration.MinWidth = 25;
            this.colDuration.Name = "colDuration";
            this.colDuration.Visible = true;
            this.colDuration.VisibleIndex = 1;
            this.colDuration.Width = 94;
            // 
            // colFilmName
            // 
            this.colFilmName.FieldName = "FilmName";
            this.colFilmName.MinWidth = 25;
            this.colFilmName.Name = "colFilmName";
            this.colFilmName.Visible = true;
            this.colFilmName.VisibleIndex = 0;
            this.colFilmName.Width = 94;
            // 
            // colGenreID
            // 
            this.colGenreID.FieldName = "GenreID";
            this.colGenreID.MinWidth = 25;
            this.colGenreID.Name = "colGenreID";
            this.colGenreID.Visible = true;
            this.colGenreID.VisibleIndex = 4;
            this.colGenreID.Width = 94;
            // 
            // colReleaseDate
            // 
            this.colReleaseDate.FieldName = "ReleaseDate";
            this.colReleaseDate.MinWidth = 25;
            this.colReleaseDate.Name = "colReleaseDate";
            this.colReleaseDate.Visible = true;
            this.colReleaseDate.VisibleIndex = 2;
            this.colReleaseDate.Width = 94;
            // 
            // colStopDate
            // 
            this.colStopDate.FieldName = "StopDate";
            this.colStopDate.MinWidth = 25;
            this.colStopDate.Name = "colStopDate";
            this.colStopDate.Visible = true;
            this.colStopDate.VisibleIndex = 3;
            this.colStopDate.Width = 94;
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
            this.Root.Size = new System.Drawing.Size(1299, 598);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GridFilm;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1297, 312);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layLblTop
            // 
            this.layLblTop.Control = this.lblTop;
            this.layLblTop.Location = new System.Drawing.Point(0, 0);
            this.layLblTop.Name = "layLblTop";
            this.layLblTop.Size = new System.Drawing.Size(1297, 74);
            this.layLblTop.TextSize = new System.Drawing.Size(0, 0);
            this.layLblTop.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 386);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 210);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(5, 210);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1297, 210);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ucMovieManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layTong);
            this.Name = "ucMovieManagement";
            this.Size = new System.Drawing.Size(1299, 598);
            ((System.ComponentModel.ISupportInitialize)(this.layTong)).EndInit();
            this.layTong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layLblTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layTong;
        private DevExpress.XtraEditors.LabelControl lblTop;
        private DevExpress.XtraGrid.GridControl GridFilm;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvViewFilm;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn colDuration;
        private DevExpress.XtraGrid.Columns.GridColumn colFilmName;
        private DevExpress.XtraGrid.Columns.GridColumn colGenreID;
        private DevExpress.XtraGrid.Columns.GridColumn colReleaseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStopDate;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layLblTop;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
