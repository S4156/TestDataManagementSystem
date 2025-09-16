Public Class FormRegister
    Private RegisterRepo As New Repository()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbResult.SelectedIndex = 1
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            If String.IsNullOrWhiteSpace(txtProductId.Text) Or String.IsNullOrWhiteSpace(txtLotNo.Text) Or String.IsNullOrWhiteSpace(txtValue.Text) Then
                MessageBox.Show("必須項目を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ClearInputs()
                Return
            End If
            RegisterRepo.AddTestResult(txtProductId.Text, txtLotNo.Text, dtpTestDate.Value, txtTester.Text, Double.Parse(txtValue.Text), cmbResult.SelectedItem.ToString())
            MessageBox.Show("データを登録しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("正しい値を入力してください ", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearInputs()
        End Try

    End Sub


    Private Sub ClearInputs()
        txtProductId.Text = ""
        txtLotNo.Text = ""
        dtpTestDate.Value = DateTime.Now
        txtTester.Text = ""
        txtValue.Text = ""
        cmbResult.SelectedIndex = 1
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub
End Class
