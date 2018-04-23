Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors
Imports WindowsApplication3.Data

Namespace WindowsApplication3
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            recordBindingSource.DataSource = DataHelper.GetData(100)
            imageComboBoxEdit.Properties.Items.AddEnum(GetType(FilterPanelLocation))
            imageComboBoxEdit.EditValue = FilterPanelLocation.Top

            treeList1.ActiveFilterString = "[ID] > 1"
        End Sub

        Private Sub OnFilterPanelLocationChanged(ByVal sender As Object, ByVal e As EventArgs) Handles imageComboBoxEdit.SelectedIndexChanged
            treeList1.FilterPanelLocation = CType(imageComboBoxEdit.EditValue, FilterPanelLocation)
        End Sub
    End Class
End Namespace
