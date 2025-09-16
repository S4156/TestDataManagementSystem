Public Class FormMain
    Private Sub btnShowRegister_Click(sender As Object, e As EventArgs) Handles btnShowRegister.Click
        FormRegister.ShowDialog()
    End Sub
    Private Sub btnShowList_Click(sender As Object, e As EventArgs) Handles btnShowList.Click
        FormList.ShowDialog()
    End Sub
End Class