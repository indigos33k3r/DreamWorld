﻿Imports System.ComponentModel

Public Class Choice
    Implements IDisposable

#Region "ScreenSize"
    Public ScreenPosition As ScreenPos
    Private Handler As New EventHandler(AddressOf resize_page)

    'The following detects  the location of the form in screen coordinates
    Private Sub resize_page(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.Text = "Form screen position = " + Me.Location.ToString
        ScreenPosition.SaveXY(Me.Left, Me.Top)
    End Sub
    Private Sub SetScreen()
        Me.Show()
        ScreenPosition = New ScreenPos(Me.Name)
        AddHandler ResizeEnd, Handler
        Dim xy As List(Of Integer) = ScreenPosition.GetXY()
        Me.Left = xy.Item(0)
        Me.Top = xy.Item(1)
    End Sub

#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set the column header style.
        Dim columnHeaderStyle As New DataGridViewCellStyle
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)
        DataGridView.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        OKButton1.Enabled = False
        DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView.MultiSelect = False

        DataGridView.Text = "Select from..."
        SetScreen()

    End Sub

    Public Sub FillGrid(type As String, Optional JustRunning As Boolean = False)

        Dim RegionClass As RegionMaker = RegionMaker.Instance(Form1.MysqlConn)

        Dim L As New List(Of String)

        ' add to list Unique Name
        If type = "Group" Then
            DataGridView.Rows.Add("New Name")
        End If

        For Each X As Integer In RegionClass.RegionNumbers
            Dim name As String
            If type = "Group" Then
                name = RegionClass.GroupName(X)
            Else
                name = RegionClass.RegionName(X)
            End If

            ' Only show running sims option
            If (JustRunning And RegionClass.Booted(X)) Then
                If L.Contains(name) Then
                Else
                    If name <> "" Then DataGridView.Rows.Add(name)
                End If
            ElseIf Not JustRunning Then
                If L.Contains(name) Then
                Else
                    If name <> "" Then DataGridView.Rows.Add(name)
                End If
            End If

            L.Add(name)
        Next

        DataGridView.Sort(Group, ListSortDirection.Ascending)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OKButton1.Click

        Dim selectedRowCount = DataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected)
        If selectedRowCount > 1 Then
            MsgBox("Please select only one row", vbInformation, "Oops")
        End If
        If selectedRowCount = 1 Then
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub RowClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick

        If e.RowIndex = -1 Then
            Return
        End If
        OKButton1.Enabled = True
        DialogResult = DialogResult.OK
    End Sub
    Private Sub CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        OKButton1.Enabled = True
    End Sub

    Private Sub CancelButton1_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class