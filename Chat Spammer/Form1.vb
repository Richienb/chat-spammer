Imports MaterialSkin

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Red500, Accent.Indigo200, TextShade.WHITE)
    End Sub

    Private Sub Spammer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spammer.Tick
        SendKeys.Send(TextBox1.Text)
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=netframework-4.7.2&viewFallbackFrom=netframework-4.5.0#remarks")
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Spammer.Interval = NumericUpDown1.Value
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Spammer.Enabled = Not Spammer.Enabled
        If Spammer.Enabled = True Then
            MaterialRaisedButton2.Text = "Stop"
        Else
            MaterialRaisedButton2.Text = "Start"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        MaterialRaisedButton2.Enabled = Spammer.Enabled = True Or Not TextBox1.Text = ""
    End Sub
End Class