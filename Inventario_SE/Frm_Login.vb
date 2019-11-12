Public Class Frm_Login

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click

        Application.Exit()

    End Sub
    Private Sub btMini_Click(sender As Object, e As EventArgs) Handles btMini.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub txtrut_Enter(sender As Object, e As EventArgs) Handles txtrut.Enter
        If txtrut.Text = "Usuario" Then
            txtrut.Text = ""
            txtrut.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub txtrut_Leave(sender As Object, e As EventArgs) Handles txtrut.Leave
        If txtrut.Text = "" Then
            txtrut.Text = "Usuario"
            txtrut.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtpassword_Enter(sender As Object, e As EventArgs) Handles txtpassword.Enter
        If txtpassword.Text = "Contraseña" Then
            txtpassword.Text = ""
            txtpassword.ForeColor = Color.LightGray
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        If txtpassword.Text = "" Then
            txtpassword.Text = "Contraseña"
            txtpassword.ForeColor = Color.Silver
            txtpassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If txtrut.Text = "" Then
            MsgBox("Indique su rut, la contraseña llegara al correo que tiene registrado en la aplicacion", vbInformation, "Info")

        End If
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        If txtrut.Text = "153486735" And txtpassword.Text = "1234" Then
            Me.Close()
            Frm_Principal.Show()
        Else
            MsgBox("Error!, el usuario y contraseña no coinciden, reintentelo", vbCritical, "Error en credenciales")
            txtrut.Clear()
            txtpassword.Clear()

        End If
    End Sub
End Class
