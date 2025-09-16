
Public Class FormList
    Private isUpdated As Boolean = False
    Private ListRepo As New Repository()
    Private Sub FormList_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvViewer.DataSource = ListRepo.GetAllResults()

    End Sub
    Private Sub dgvViewer_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViewer.CellValueChanged
        isUpdated = True
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub

    Private Sub Search()
        Dim StartDate As DateTime? = Nothing
        Dim EndDate As DateTime? = Nothing
        If dtpStartDate.Checked Then
            StartDate = dtpStartDate.Value
        End If
        If dtpEndDate.Checked Then
            EndDate = dtpEndDate.Value
        End If
        ListRepo.SearchResults(txtSearchProductId.Text, txtSearchLotNo.Text, StartDate, EndDate)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvViewer.Rows.GetRowCount(DataGridViewElementStates.Selected) = 0 Then
            MessageBox.Show("削除するデータを選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Dim result As DialogResult = MessageBox.Show("選択されたデータを削除します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                ListRepo.DeleteTestResult(dgvViewer.SelectedRows)
                ListRepo.GetAllResults()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If isUpdated = False Then
            MessageBox.Show("更新するデータを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            ListRepo.UpdateTestResult()
            isUpdated = False
        End If

    End Sub

    Private Sub btnShowGraph_Click(sender As Object, e As EventArgs) Handles btnShowGraph.Click
        Dim StartDate As DateTime? = Nothing
        Dim EndDate As DateTime? = Nothing
        If dtpStartDate.Checked Then
            StartDate = dtpStartDate.Value
        End If
        If dtpEndDate.Checked Then
            EndDate = dtpEndDate.Value
        End If
        Dim results = ListRepo.GetPassRates(StartDate, EndDate)
        Dim xs As New List(Of DateTime)
        Dim ys As New List(Of Double)
        For Each result In results
            xs.Add(result.TestDate)
            ys.Add(result.PassRate)
        Next
        FormsPlot1.Plot.Clear()
        FormsPlot1.Plot.Add.Scatter(xs, ys)
        FormsPlot1.Plot.Axes.DateTimeTicksBottom()
        FormsPlot1.Plot.Axes.Left.Label.Text = "PASS Rate(%)"

        FormsPlot1.Refresh()
    End Sub
End Class

