Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.ViewInfo

Namespace WindowsApplication3
    Public Class CustomTreeList
        Inherits TreeList

        Public Sub New()
        End Sub
        Protected Sub New(ByVal ignore As Object)
            MyBase.New(ignore)
        End Sub

        Protected Overrides Function CreateViewInfo() As DevExpress.XtraTreeList.ViewInfo.TreeListViewInfo
            Return New CustomTreeListViewInfo(Me)
        End Function

        Private filterPanelLocation_Renamed As FilterPanelLocation
        Public Property FilterPanelLocation() As FilterPanelLocation
            Get
                Return filterPanelLocation_Renamed
            End Get
            Set(ByVal value As FilterPanelLocation)
                If filterPanelLocation_Renamed <> value Then
                    filterPanelLocation_Renamed = value
                    OnPropertyChanged()
                    LayoutChanged()
                End If
            End Set
        End Property
    End Class
    Public Enum FilterPanelLocation
        Bottom
        Top
    End Enum

    Public Class CustomTreeListViewInfo
        Inherits TreeListViewInfo

        Public Sub New(ByVal treeList As TreeList)
            MyBase.New(treeList)
        End Sub

        Protected Overrides Function CalcClientRect(ByVal window As Rectangle) As Rectangle
            Dim rect As Rectangle = MyBase.CalcClientRect(window)
            If ShowFilterPanel AndAlso TreeList.FilterPanelLocation = FilterPanelLocation.Top Then
                Dim panelRect As Rectangle = FilterPanel.Bounds
                panelRect.Y = rect.Y
                FilterPanel.Bounds = panelRect
                rect.Y += panelRect.Height
            End If
            Return rect
        End Function
        Private Shadows ReadOnly Property TreeList() As CustomTreeList
            Get
                Return TryCast(MyBase.TreeList, CustomTreeList)
            End Get
        End Property
    End Class
End Namespace
