Imports System.Data.SQLite

Public Class Repository
    Private connectionString As String = "Data Source = " & IO.Path.Combine(Application.StartupPath, "TestResults.db") & ";Version=3;"
    Private dt As New DataTable()

    Public Sub AddTestResult(productId As String, lotNo As String, testDate As DateTime, tester As String, value As Double, result As String)
        Try
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Dim sql As String = "INSERT INTO TestResults " &
                                "(ProductId, LotNo, TestDate, Tester, Value, Result) " &
                                "VALUES (@ProductId, @LotNo, @TestDate, @Tester, @Value, @Result)"
                Using cmd As New SQLiteCommand(sql, con)
                    cmd.Parameters.AddWithValue("@ProductId", productId)
                    cmd.Parameters.AddWithValue("@LotNo", lotNo)
                    cmd.Parameters.AddWithValue("@TestDate", testDate.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@Tester", tester)
                    cmd.Parameters.AddWithValue("@Value", value)
                    cmd.Parameters.AddWithValue("@Result", result)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("データベース書き込み中にエラーが発生しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetAllResults() As DataTable
        Try
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Dim sql As String = "SELECT * FROM TestResults"
                Dim da As New SQLiteDataAdapter(sql, con)
                dt.Clear()
                da.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            MessageBox.Show("データ取得中にエラーが発生しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Sub DeleteTestResult(selectedRows As DataGridViewSelectedRowCollection)
        Try
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Dim sql As String = "DELETE FROM TestResults WHERE Id = @Id"
                Using cmd As New SQLiteCommand(sql, con)
                    For Each row As DataGridViewRow In selectedRows
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@Id", row.Cells("Id").Value)
                        cmd.ExecuteNonQuery()
                    Next
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("データ削除中にエラーが発生しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        MessageBox.Show("データを削除しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub UpdateTestResult()
        Try
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Dim sql As String = "UPDATE TestResults SET ProductId = @ProductId, LotNo = @LotNo, TestDate = @TestDate, Tester = @Tester, Value = @Value, Result = @Result WHERE Id = @Id"
                Using cmd As New SQLiteCommand(sql, con)
                    Dim modified As DataTable = dt.GetChanges(DataRowState.Modified)
                    If modified IsNot Nothing Then
                        For Each row As DataRow In modified.Rows
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@ProductId", row("ProductId").ToString)
                            cmd.Parameters.AddWithValue("@LotNo", row("LotNo").ToString)
                            cmd.Parameters.AddWithValue("@TestDate", Convert.ToDateTime(row("TestDate")).ToString("yyyy-MM-dd"))
                            cmd.Parameters.AddWithValue("@Tester", row("Tester").ToString)
                            cmd.Parameters.AddWithValue("@Value", Convert.ToDouble(row("Value")))
                            cmd.Parameters.AddWithValue("@Result", row("Result").ToString)
                            cmd.Parameters.AddWithValue("@Id", Integer.Parse(row("Id")))
                            cmd.ExecuteNonQuery()
                        Next
                    End If
                End Using
            End Using
        Catch ex As Exception
        MessageBox.Show("データ更新中にエラーが発生しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return
        End Try
        MessageBox.Show("データを更新しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub SearchResults(ProductId As String, LotNo As String, StartDate As DateTime?, EndDate As DateTime?)
        Try
            If dt Is Nothing Then
                dt = GetAllResults()
            End If
        Catch ex As Exception
            MessageBox.Show("データ取得中にエラーが発生しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        Using con As New SQLiteConnection(connectionString)
            con.Open()
            Dim sql As String = "SELECT * FROM TestResults WHERE 1=1"
            Dim cmd As New SQLiteCommand()
            cmd.Connection = con

            If Not String.IsNullOrWhiteSpace(ProductId) Then
                sql &= " AND ProductId = @ProductId"
                cmd.Parameters.AddWithValue("@ProductId", ProductId)
            End If

            If Not String.IsNullOrWhiteSpace(LotNo) Then
                sql &= " AND LotNo = @LotNo"
                cmd.Parameters.AddWithValue("@LotNo", LotNo)
            End If

            If StartDate.HasValue Then
                sql &= " AND TestDate >= @StartDate"
                cmd.Parameters.AddWithValue("@StartDate", StartDate.Value.ToString("yyyy-MM-dd"))
            End If
            If EndDate.HasValue Then
                sql &= " AND TestDate <= @EndDate"
                cmd.Parameters.AddWithValue("@EndDate", EndDate.Value.ToString("yyyy-MM-dd"))
            End If
            cmd.CommandText = sql
            Using da As New SQLiteDataAdapter(cmd)
                dt.Clear()
                da.Fill(dt)
            End Using

        End Using

    End Sub

    Public Function GetPassRates(startDate As DateTime?, endDate As DateTime?) As List(Of PassRateResult)
        Dim results As New List(Of PassRateResult)

        Using con As New SQLiteConnection(connectionString)
            con.Open()
            Dim cmd As New SQLiteCommand()
            cmd.Connection = con
            Dim sql = "
                SELECT TestDate,
                       SUM(CASE WHEN Result = '合格' THEN 1 ELSE 0 END) * 1.0 / COUNT(*) * 100 AS PassRate
                FROM TestResults
                WHERE 1 = 1"
            If startDate.HasValue Then
                sql &= " AND TestDate >= @StartDate"
                cmd.Parameters.AddWithValue("@StartDate", startDate.Value.ToString("yyyy-MM-dd"))
            End If
            If endDate.HasValue Then
                sql &= " AND TestDate <= @EndDate"
                cmd.Parameters.AddWithValue("@EndDate", endDate.Value.ToString("yyyy-MM-dd"))
            End If
            sql &= " GROUP BY TestDate ORDER BY TestDate;"
            cmd.CommandText = sql
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    results.Add(New PassRateResult() With {
                            .TestDate = DateTime.Parse(reader("TestDate")),
                            .PassRate = Double.Parse(reader("PassRate"))
                        })
                End While
            End Using
        End Using

        Return results
    End Function

End Class
