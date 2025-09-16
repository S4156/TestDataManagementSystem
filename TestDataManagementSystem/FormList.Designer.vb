<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormList
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvViewer = New DataGridView()
        btnSearch = New Button()
        txtSearchProductId = New TextBox()
        txtSearchLotNo = New TextBox()
        dtpStartDate = New DateTimePicker()
        dtpEndDate = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnDelete = New Button()
        btnUpdate = New Button()
        FormsPlot1 = New ScottPlot.WinForms.FormsPlot()
        btnShowGraph = New Button()
        CType(dgvViewer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvViewer
        ' 
        dgvViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvViewer.Location = New Point(19, 137)
        dgvViewer.Name = "dgvViewer"
        dgvViewer.RowHeadersWidth = 51
        dgvViewer.Size = New Size(758, 257)
        dgvViewer.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(497, 65)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(108, 56)
        btnSearch.TabIndex = 1
        btnSearch.Text = "検索"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearchProductId
        ' 
        txtSearchProductId.Location = New Point(85, 29)
        txtSearchProductId.Name = "txtSearchProductId"
        txtSearchProductId.Size = New Size(100, 23)
        txtSearchProductId.TabIndex = 2
        ' 
        ' txtSearchLotNo
        ' 
        txtSearchLotNo.Location = New Point(85, 64)
        txtSearchLotNo.Name = "txtSearchLotNo"
        txtSearchLotNo.Size = New Size(100, 23)
        txtSearchLotNo.TabIndex = 4
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Checked = False
        dtpStartDate.Location = New Point(85, 97)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.ShowCheckBox = True
        dtpStartDate.Size = New Size(183, 23)
        dtpStartDate.TabIndex = 6
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Checked = False
        dtpEndDate.Location = New Point(299, 97)
        dtpEndDate.Margin = New Padding(3, 2, 3, 2)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.ShowCheckBox = True
        dtpEndDate.Size = New Size(183, 23)
        dtpEndDate.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 11
        Label1.Text = "製品番号"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 12
        Label2.Text = "ロット番号"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 13
        Label3.Text = "検査日"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(274, 101)
        Label4.Name = "Label4"
        Label4.Size = New Size(19, 15)
        Label4.TabIndex = 14
        Label4.Text = "～"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(178, 402)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(116, 39)
        btnDelete.TabIndex = 15
        btnDelete.Text = "削除"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(19, 402)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(116, 39)
        btnUpdate.TabIndex = 16
        btnUpdate.Text = "更新"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' FormsPlot1
        ' 
        FormsPlot1.DisplayScale = 1.25F
        FormsPlot1.Location = New Point(322, 452)
        FormsPlot1.Margin = New Padding(3, 2, 3, 2)
        FormsPlot1.Name = "FormsPlot1"
        FormsPlot1.Size = New Size(464, 176)
        FormsPlot1.TabIndex = 17
        ' 
        ' btnShowGraph
        ' 
        btnShowGraph.Location = New Point(178, 526)
        btnShowGraph.Margin = New Padding(3, 2, 3, 2)
        btnShowGraph.Name = "btnShowGraph"
        btnShowGraph.Size = New Size(116, 39)
        btnShowGraph.TabIndex = 18
        btnShowGraph.Text = "グラフに出力"
        btnShowGraph.UseVisualStyleBackColor = True
        ' 
        ' FormList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(798, 651)
        Controls.Add(btnShowGraph)
        Controls.Add(FormsPlot1)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpEndDate)
        Controls.Add(dtpStartDate)
        Controls.Add(txtSearchLotNo)
        Controls.Add(txtSearchProductId)
        Controls.Add(btnSearch)
        Controls.Add(dgvViewer)
        Name = "FormList"
        Text = "検査データ一覧"
        CType(dgvViewer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvViewer As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchProductId As TextBox
    Friend WithEvents txtSearchLotNo As TextBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents FormsPlot1 As ScottPlot.WinForms.FormsPlot
    Friend WithEvents btnShowGraph As Button
End Class
