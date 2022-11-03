Public Class Form1
    Private Sub ValBtn1_Click(sender As Object, e As EventArgs) Handles ValBtn1.Click
        Dim stName As String
        stName = NameBox1.Text

        If ValidatePassword(PassBox1) = False Then
            MessageBox.Show("" & stName & " " & "password must have eight caracters long with at least a number",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("" & stName & " " & "password is accepted and saved", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function ValidatePassword(ByVal Password) As Boolean

        Dim regEx
        regEx = CreateObject("vbscript.regexp")

        regEx.Pattern = "^.*(?=.{8,})(?=.*\d).*$"
        ValidatePassword = regEx.Test(Password)

        regEx = Nothing
    End Function
End Class
