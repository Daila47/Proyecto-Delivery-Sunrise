Public Class Fiabreria
    Private Sub BEBIDASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BEBIDASToolStripMenuItem.Click
        Producto.Show()
        Me.Hide()
    End Sub

    Private Sub ALMACENToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ALMACENToolStripMenuItem1.Click
        Almacen.Show()
        Me.Hide()
    End Sub

    Private Sub LIMPIEZAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LIMPIEZAToolStripMenuItem1.Click
        Limpieza.Show()
        Me.Hide()
    End Sub

    Private Sub DESCUENTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DESCUENTOSToolStripMenuItem.Click
        Descuentos.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Fiambreria1.Show()
        Me.Hide()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        End
    End Sub
End Class