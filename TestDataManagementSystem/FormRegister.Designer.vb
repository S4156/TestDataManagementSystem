<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnRegister = New Button()
        txtProductId = New TextBox()
        Label1 = New Label()
        txtLotNo = New TextBox()
        txtTester = New TextBox()
        dtpTestDate = New DateTimePicker()
        txtValue = New TextBox()
        cmbResult = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(93, 329)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(151, 58)
        btnRegister.TabIndex = 0
        btnRegister.Text = "登録"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' txtProductId
        ' 
        txtProductId.Location = New Point(93, 41)
        txtProductId.Name = "txtProductId"
        txtProductId.Size = New Size(151, 23)
        txtProductId.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 2
        Label1.Text = "製品番号"
        ' 
        ' txtLotNo
        ' 
        txtLotNo.Location = New Point(93, 82)
        txtLotNo.Name = "txtLotNo"
        txtLotNo.Size = New Size(151, 23)
        txtLotNo.TabIndex = 3
        ' 
        ' txtTester
        ' 
        txtTester.Location = New Point(93, 169)
        txtTester.Name = "txtTester"
        txtTester.Size = New Size(151, 23)
        txtTester.TabIndex = 4
        ' 
        ' dtpTestDate
        ' 
        dtpTestDate.Location = New Point(93, 126)
        dtpTestDate.Name = "dtpTestDate"
        dtpTestDate.Size = New Size(151, 23)
        dtpTestDate.TabIndex = 5
        ' 
        ' txtValue
        ' 
        txtValue.Location = New Point(92, 215)
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(151, 23)
        txtValue.TabIndex = 6
        ' 
        ' cmbResult
        ' 
        cmbResult.DropDownStyle = ComboBoxStyle.DropDownList
        cmbResult.FormattingEnabled = True
        cmbResult.Items.AddRange(New Object() {"合格", "不合格"})
        cmbResult.Location = New Point(92, 261)
        cmbResult.Name = "cmbResult"
        cmbResult.Size = New Size(151, 23)
        cmbResult.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 8
        Label2.Text = "ロット番号"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 9
        Label3.Text = "検査日"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 10
        Label4.Text = "検査担当者"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(39, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 11
        Label5.Text = "測定値"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(31, 264)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 12
        Label6.Text = "検査結果"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(273, 329)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(151, 59)
        btnClear.TabIndex = 13
        btnClear.Text = "クリア"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' FormRegister
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(503, 450)
        Controls.Add(btnClear)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cmbResult)
        Controls.Add(txtValue)
        Controls.Add(dtpTestDate)
        Controls.Add(txtTester)
        Controls.Add(txtLotNo)
        Controls.Add(Label1)
        Controls.Add(txtProductId)
        Controls.Add(btnRegister)
        Name = "FormRegister"
        Text = "登録画面"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegister As Button
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLotNo As TextBox
    Friend WithEvents txtTester As TextBox
    Friend WithEvents dtpTestDate As DateTimePicker
    Friend WithEvents txtValue As TextBox
    Friend WithEvents cmbResult As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClear As Button

End Class
