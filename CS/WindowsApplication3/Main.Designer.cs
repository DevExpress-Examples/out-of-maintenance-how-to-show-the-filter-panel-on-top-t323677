
namespace WindowsApplication3 {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.recordBindingSource = new System.Windows.Forms.BindingSource();
            this.treeList1 = new WindowsApplication3.CustomTreeList();
            this.colText = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDt = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colState = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colImage = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.imageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // recordBindingSource
            // 
            this.recordBindingSource.DataSource = typeof(WindowsApplication3.Data.Record);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colText,
            this.colDt,
            this.colState,
            this.colImage});
            this.treeList1.DataSource = this.recordBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.FilterPanelLocation = WindowsApplication3.FilterPanelLocation.Bottom;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.EnableFiltering = true;
            this.treeList1.Size = new System.Drawing.Size(541, 360);
            this.treeList1.TabIndex = 0;
            // 
            // colText
            // 
            this.colText.FieldName = "Text";
            this.colText.Name = "colText";
            this.colText.Visible = true;
            this.colText.VisibleIndex = 0;
            this.colText.Width = 131;
            // 
            // colDt
            // 
            this.colDt.FieldName = "Dt";
            this.colDt.Name = "colDt";
            this.colDt.Visible = true;
            this.colDt.VisibleIndex = 1;
            this.colDt.Width = 131;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 2;
            this.colState.Width = 131;
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 3;
            this.colImage.Width = 130;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.imageComboBoxEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 360);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(541, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // imageComboBoxEdit
            // 
            this.imageComboBoxEdit.Location = new System.Drawing.Point(116, 5);
            this.imageComboBoxEdit.Name = "imageComboBoxEdit";
            this.imageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit.Size = new System.Drawing.Size(260, 20);
            this.imageComboBoxEdit.TabIndex = 0;
            this.imageComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.OnFilterPanelLocationChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 406);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.recordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource recordBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private CustomTreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colText;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDt;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colState;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colImage;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit;
    }
}