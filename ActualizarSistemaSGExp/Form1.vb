Imports System.IO
Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim archivo As String = "\\192.168.1.11\Comercial\ActualizacionSistema\SGExp.exe"

        If File.Exists(archivo) Then
            Me.UseWaitCursor = True
            My.Computer.FileSystem.CopyFile(archivo, Application.StartupPath & "\SGExp.exe", Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException)
            Process.Start(Application.StartupPath & "\SGExp.exe")

            Me.UseWaitCursor = False
            Me.Close()
        Else
            MessageBox.Show("Archivo no encontrado")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start(Application.StartupPath & "\SGExp.exe")

        Me.Close()
    End Sub
End Class
