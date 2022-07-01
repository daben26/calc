Public Class frmCalc

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        Dim integer1 As Integer
        Dim integer2 As Integer
        Dim answer As Integer
        integer1 = Val(txt1.Text)
        integer2 = Val(txt2.Text)
        answer = integer1 + integer2
        lblAnswer.Text = answer


    End Sub

    Private Sub cmdsubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubtract.Click
        Dim integer1 As Integer
        Dim integer2 As Integer
        Dim answer As Integer
        integer1 = Val(txt1.Text)
        integer2 = Val(txt2.Text)
        answer = integer1 - integer2
        lblAnswer.Text = answer
    End Sub

    Private Sub cmdmultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmultiply.Click
        Dim integer1 As Integer
        Dim integer2 As Integer
        Dim answer As Integer
        integer1 = Val(txt1.Text)
        integer2 = Val(txt2.Text)
        answer = integer1 * integer2
        lblAnswer.Text = answer
    End Sub

    Private Sub cmddivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddivide.Click
        Dim integer1 As Integer
        Dim integer2 As Integer
        Dim answer As Integer
        integer1 = Val(txt1.Text)
        integer2 = Val(txt2.Text)
        answer = integer1 / integer2
        lblAnswer.Text = answer
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txt1.Text = ""
        txt2.Text = ""
        lblAnswer.Text = ""
        txt1.Focus()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
End Class
