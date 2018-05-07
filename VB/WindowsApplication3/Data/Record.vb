Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsApplication3.Data
    Public Class Record
        Public Sub New()
        End Sub
        Public Property ID() As Integer
        Public Property ParentID() As Integer
        Public Property Text() As String
        Public Property Dt() As Date?
        Public Property State() As Boolean
        Public Property Image() As Image
        Public Property TestDetails() As BindingList(Of Detail)
        Public Property Details() As BindingList(Of Detail)
    End Class

    Public Class Detail
        Public Property ID() As Integer
        Public Property Text() As String
        Public Property Info() As String
    End Class

    Public Class DataHelper
        Public Shared Function GetData(ByVal count As Integer, ByVal detailCount As Integer) As BindingList(Of Record)
            Dim records As New BindingList(Of Record)()
            Dim details As New BindingList(Of Detail)()
            Dim testDetails As New BindingList(Of Detail)()
            For j As Integer = 0 To detailCount - 1
                details.Add(New Detail() With { _
                    .ID = j, _
                    .Text = String.Format("Text {0}", j), _
                    .Info = String.Format("Info {0}", j) _
                })
                testDetails.Add(New Detail() With { _
                    .ID = j, _
                    .Text = String.Format("Test Text {0}", j), _
                    .Info = String.Format(" Test Info {0}", j) _
                })
            Next j
            For i As Integer = 0 To count - 1
                records.Add(New Record() With { _
                    .ID = i, _
                    .Text = String.Format("Text {0}", i), _
                    .Dt = Date.Now.AddDays(i), _
                    .State = i Mod 2 = 0, _
                    .Image = SystemIcons.Information.ToBitmap(), _
                    .Details = details, _
                    .TestDetails = testDetails _
                })
            Next i

            Return records
        End Function
        Public Shared Function GetData(ByVal count As Integer) As BindingList(Of Record)
            Dim records As New BindingList(Of Record)()
            For i As Integer = 0 To count - 1
                records.Add(New Record() With { _
                    .ID = i, _
                    .ParentID = i Mod 5, _
                    .Text = String.Format("Text {0}", i), _
                    .Dt = If(i Mod 2 = 0, Date.Now.AddDays(i), DirectCast(Nothing, Date?)), _
                    .State = i Mod 2 = 0, _
                    .Image = SystemIcons.Information.ToBitmap() _
                })
            Next i
            Return records
        End Function
        Public Shared Function GetDetailData(ByVal count As Integer) As BindingList(Of Detail)
            Dim records As New BindingList(Of Detail)()
            For i As Integer = 0 To count - 1
                records.Add(New Detail() With { _
                    .ID = i, _
                    .Text = String.Format("Text Text Text Text Text Text Text Text Text Text Text Text Text{0}", i), _
                    .Info = String.Format("Info {0}", i) _
                })
            Next i
            Return records
        End Function
    End Class
End Namespace
