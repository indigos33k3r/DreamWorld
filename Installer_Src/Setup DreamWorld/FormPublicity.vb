﻿Public Class FormPublicity

    Dim initted As Boolean = False

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


    Private Sub Publicity_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SetScreen()

        GDPRCheckBox.Checked = Form1.MySetting.GDPR()
        DataSnapshotCheckBox.Checked = Form1.MySetting.DataSnapshot()
        Try
            PictureBox9.Image = Bitmap.FromFile(Form1.MyFolder & "\OutworldzFiles\Photo.png")
        Catch
            PictureBox9.Image = My.Resources.blankbox
        End Try

        initted = True

    End Sub

    Private Sub DataSnapshotCheckBox_CheckedChanged(sender As Object, e As EventArgs)

        If initted Then
            Form1.MySetting.DataSnapshot() = DataSnapshotCheckBox.Checked
            Form1.MySetting.SaveSettings()
        End If

    End Sub

    Private Sub GDPRCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles GDPRCheckBox.CheckedChanged

        If initted Then
            Form1.MySetting.GDPR() = GDPRCheckBox.Checked
            Form1.MySetting.SaveSettings()
        End If

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        Dim ofd As New OpenFileDialog
        ofd.Filter = "PNG Files (*.PNG,*.png)|*.png;|All Files (*.*)|*.*"
        ofd.FilterIndex = 1
        ofd.Multiselect = False
        If ofd.ShowDialog = DialogResult.OK Then
            If ofd.FileName <> String.Empty Then
                PictureBox9.Image = Nothing
                PictureBox9.Image = Bitmap.FromFile(ofd.FileName)
                Try
                    My.Computer.FileSystem.DeleteFile(Form1.MyFolder & "\OutworldzFiles\Photo.png")
                Catch
                End Try
                Try
                    PictureBox9.Image.Save(Form1.MyFolder & "\OutworldzFiles\Photo.png", System.Drawing.Imaging.ImageFormat.Png)
                Catch ex As Exception
                    Form1.Log(ex.Message)
                End Try

                Dim params As New Specialized.NameValueCollection
                params.Add("MachineID", Form1.MySetting.MachineID())
                params.Add("DnsName", Form1.MySetting.PublicIP)

                Dim Myupload As New UploadImage
                Dim URL = New Uri("https://www.outworldz.com/cgi/uploadphoto.plx")
                Myupload.PostContent_UploadFile(URL, Form1.MyFolder & "\OutworldzFiles\Photo.png", params)

            End If
        End If

    End Sub

End Class