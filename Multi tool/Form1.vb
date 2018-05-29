Public Class Form1
    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ITalk_ThemeContainer1_Click(sender As Object, e As EventArgs) Handles ITalk_ThemeContainer1.Click

    End Sub

    Private Sub ITalk_LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ITalk_LinkLabel1.LinkClicked
        Process.Start("https://www.linkedin.com/in/earslan95/")
    End Sub

    Private Sub ITalk_Button_11_Click(sender As Object, e As EventArgs) Handles ITalk_Button_11.Click
        If Me.ITalk_TextBox_Small1.Text.Length.Equals(&H20) Then
            Me.ITalk_Label1.Text = "MD5 Hash"
        ElseIf Me.ITalk_TextBox_Small1.Text.Length.Equals(40) Then
            Me.ITalk_Label1.Text = "SHA-1 Hash/ /MySQL5 Hash"
        ElseIf Me.ITalk_TextBox_Small1.Text.Length.Equals(13) Then
            Me.ITalk_Label1.Text = "DES(Unix) Hash"
        ElseIf Me.ITalk_TextBox_Small1.Text.Length.Equals(&H10) Then
            Me.ITalk_Label1.Text = "MySQL Hash/ /DES(Oracle Hash)"
        ElseIf (Me.ITalk_TextBox_Small1.Text.Length.Equals(&H29) And Me.ITalk_TextBox_Small1.Text.StartsWith("*")) Then
            Me.ITalk_Label1.Text = "MySQL5 Hash"
        ElseIf Me.ITalk_TextBox_Small1.Text.Length.Equals(&H40) Then
            Me.ITalk_Label1.Text = "SHA-256 Hash"
        ElseIf Me.ITalk_TextBox_Small1.Text.Length.Equals(&H60) Then
            Me.ITalk_Label1.Text = "SHA-384 Hash"
        ElseIf Me.ITalk_TextBox_Small1.Text.Length.Equals(&H80) Then
            Me.ITalk_Label1.Text = "SHA-512 Hash"
        ElseIf (Me.ITalk_TextBox_Small1.Text.StartsWith("$1$") And Me.ITalk_TextBox_Small1.Text.Length.Equals(&H22)) Then
            Me.ITalk_Label1.Text = "MD5(Unix) Hash"
        ElseIf (Me.ITalk_TextBox_Small1.Text.StartsWith("$apr1$") And Me.ITalk_TextBox_Small1.Text.Length.Equals(&H25)) Then
            Me.ITalk_Label1.Text = "MD5(APR) Hash"
        ElseIf (Me.ITalk_TextBox_Small1.Text.StartsWith("$H$") And Me.ITalk_TextBox_Small1.Text.Length.Equals(&H22)) Then
            Me.ITalk_Label1.Text = "MD5(phpBB3) Hash"
        ElseIf (Me.ITalk_TextBox_Small1.Text.StartsWith("$P$") And Me.ITalk_TextBox_Small1.Text.Length.Equals(&H22)) Then
            Me.ITalk_Label1.Text = "MD5(Wordpress) Hash"
        ElseIf (Me.ITalk_TextBox_Small1.Text.StartsWith("$5$") And Me.ITalk_TextBox_Small1.Text.Length.Equals(&H27)) Then
            Me.ITalk_Label1.Text = "SHA-256(Unix) Hash"
        ElseIf (Me.ITalk_TextBox_Small1.Text.StartsWith("$6$") And Me.ITalk_TextBox_Small1.Text.Length.Equals(&H27)) Then
            Me.ITalk_Label1.Text = "SHA-512(Unix) Hash"
        ElseIf (Me.ITalk_TextBox_Small1.Text.Length.Equals(&H18) And Me.ITalk_TextBox_Small1.Text.EndsWith("==")) Then
            Me.ITalk_Label1.Text = "MD5(Base-64)"
        ElseIf (Me.ITalk_TextBox_Small1.Text.Length.Equals(&H1C) And Me.ITalk_TextBox_Small1.Text.EndsWith("=")) Then
            Me.ITalk_Label1.Text = "SHA-1(Base-64)"
        ElseIf (Me.ITalk_TextBox_Small1.Text.Length.Equals(40) And Me.ITalk_TextBox_Small1.Text.EndsWith("==")) Then
            Me.ITalk_Label1.Text = "SHA-224(Base-64)"
        ElseIf (Me.ITalk_TextBox_Small1.Text.Length.Equals(&H58) And Me.ITalk_TextBox_Small1.Text.EndsWith("==")) Then
            Me.ITalk_Label1.Text = "SHA-512(Base-64)"
        ElseIf (Me.ITalk_TextBox_Small1.Text.Length.Equals(&H2C) And Me.ITalk_TextBox_Small1.Text.EndsWith("=")) Then
            Me.ITalk_Label1.Text = "SHA-256(Base-64)"
        Else
            Me.ITalk_Label1.Text = "Entrée non valide / non identifiée"
            Interaction.Beep()
        End If
    End Sub

    Private Sub ITalk_Label1_Click(sender As Object, e As EventArgs) Handles ITalk_Label1.Click

    End Sub
End Class
