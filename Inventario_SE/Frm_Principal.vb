Public Class Frm_Principal
    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hideSubmenu()

    End Sub
    Private Sub hideSubmenu()
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
    End Sub
    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        showSubmenu(Panel1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        showSubmenu(Panel2)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        showSubmenu(Panel3)
    End Sub
    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelChildForm.Controls.Add(childForm)
        panelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    'Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    openChildForm(New Form2())
    '    '...
    '    'your codes
    '    '...
    '    hideSubmenu()
    'End Sub
End Class