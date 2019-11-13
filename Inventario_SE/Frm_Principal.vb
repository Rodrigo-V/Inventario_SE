Public Class Frm_Principal
    Private Sub MetroTabControl1_DrawItem(sender As Object, e As DrawItemEventArgs)
        Dim g As Graphics = e.Graphics
        Dim _textBrush As Brush
        Dim _tabPage As TabPage = MaterialTabControl1.TabPages(e.Index)
        Dim _tabBounds As Rectangle = MaterialTabControl1.GetTabRect(e.Index)

        If e.State = DrawItemState.Selected Then
            _textBrush = New SolidBrush(Color.Red)
            g.FillRectangle(Brushes.Gray, e.Bounds)
        Else
            _textBrush = New System.Drawing.SolidBrush(e.ForeColor)
            e.DrawBackground()
        End If

        Dim _tabFont As Font = New Font("Arial", CSng(10.0), FontStyle.Bold, GraphicsUnit.Pixel)
        Dim _stringFlags As StringFormat = New StringFormat()
        _stringFlags.Alignment = StringAlignment.Center
        _stringFlags.LineAlignment = StringAlignment.Center
        g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, New StringFormat(_stringFlags))
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class