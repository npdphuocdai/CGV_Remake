
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
            this.dtoViewEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtoViewEmployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtoViewEmployeeBindingSource
            // 
            this.dtoViewEmployeeBindingSource.DataSource = typeof(DTO.dtoViewEmployee);
            // 
            // ucViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ucViewEmployee";
            this.Size = new System.Drawing.Size(1124, 382);
            ((System.ComponentModel.ISupportInitialize)(this.dtoViewEmployeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dtoViewEmployeeBindingSource;
    }
}
