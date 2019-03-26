Imports MaterialSkin

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Red500, Accent.Indigo200, TextShade.WHITE)
    End Sub

    Private Sub Spammer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Spammer.Tick
        If Not MaterialSingleLineTextField1.Focused = True And Not NumericUpDown1.Focused = True Then SendKeys.Send(MaterialSingleLineTextField1.Text)
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Process.Start("https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=netframework-4.7.2&viewFallbackFrom=netframework-4.5.0#remarks")
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Spammer.Interval = NumericUpDown1.Value
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Spammer.Enabled = Not Spammer.Enabled
        MaterialRaisedButton2.Text = If(Spammer.Enabled = True, "Stop", "Start")
    End Sub

    Private Sub MaterialSingleLineTextField1_TextChanged(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField1.TextChanged
        MaterialRaisedButton2.Enabled = Spammer.Enabled = True Or Not MaterialSingleLineTextField1.Text = ""
    End Sub
End Class