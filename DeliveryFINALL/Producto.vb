Public Class Producto
    Private Sub ALMACENToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ALMACENToolStripMenuItem1.Click
        Almacen.Show()
        Me.Hide()
    End Sub

    Private Sub LIMPIEZAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LIMPIEZAToolStripMenuItem1.Click
        Limpieza.Show()
        Me.Hide()
    End Sub

    Private Sub FIAMBRERIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIAMBRERIAToolStripMenuItem.Click
        Fiabreria.Show()
        Me.Hide()
    End Sub

    Private Sub DESCUENTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DESCUENTOSToolStripMenuItem.Click
        Descuentos.Show()
        Me.Hide()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        End
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Bebidas1.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RadioButton2.Checked = True Then
            Bebidad2.Show()
            Me.Hide()
        End If

    End Sub
End Class
