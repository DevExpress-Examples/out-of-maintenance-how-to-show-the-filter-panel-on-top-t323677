Namespace WindowsApplication3
    Partial Public Class Main
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.recordBindingSource = New System.Windows.Forms.BindingSource()
            Me.treeList1 = New WindowsApplication3.CustomTreeList()
            Me.colText = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colDt = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colState = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colImage = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.imageComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
            DirectCast(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.imageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            ' 
            ' recordBindingSource
            ' 
            Me.recordBindingSource.DataSource = GetType(WindowsApplication3.Data.Record)
            ' 
            ' treeList1
            ' 
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colText, Me.colDt, Me.colState, Me.colImage})
            Me.treeList1.DataSource = Me.recordBindingSource
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.FilterPanelLocation = WindowsApplication3.FilterPanelLocation.Bottom
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.EnableFiltering = True
            Me.treeList1.Size = New System.Drawing.Size(541, 360)
            Me.treeList1.TabIndex = 0
            ' 
            ' colText
            ' 
            Me.colText.FieldName = "Text"
            Me.colText.Name = "colText"
            Me.colText.Visible = True
            Me.colText.VisibleIndex = 0
            Me.colText.Width = 131
            ' 
            ' colDt
            ' 
            Me.colDt.FieldName = "Dt"
            Me.colDt.Name = "colDt"
            Me.colDt.Visible = True
            Me.colDt.VisibleIndex = 1
            Me.colDt.Width = 131
            ' 
            ' colState
            ' 
            Me.colState.FieldName = "State"
            Me.colState.Name = "colState"
            Me.colState.Visible = True
            Me.colState.VisibleIndex = 2
            Me.colState.Width = 131
            ' 
            ' colImage
            ' 
            Me.colImage.FieldName = "Image"
            Me.colImage.Name = "colImage"
            Me.colImage.Visible = True
            Me.colImage.VisibleIndex = 3
            Me.colImage.Width = 130
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.imageComboBoxEdit)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 360)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(541, 46)
            Me.panelControl1.TabIndex = 1
            ' 
            ' imageComboBoxEdit
            ' 
            Me.imageComboBoxEdit.Location = New System.Drawing.Point(116, 5)
            Me.imageComboBoxEdit.Name = "imageComboBoxEdit"
            Me.imageComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.imageComboBoxEdit.Size = New System.Drawing.Size(260, 20)
            Me.imageComboBoxEdit.TabIndex = 0
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(541, 406)
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Main"
            Me.Text = "Main"
            DirectCast(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            DirectCast(Me.imageComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private recordBindingSource As System.Windows.Forms.BindingSource
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private treeList1 As CustomTreeList
        Private colText As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private colDt As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private colState As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private colImage As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents imageComboBoxEdit As DevExpress.XtraEditors.ImageComboBoxEdit
    End Class
End Namespace