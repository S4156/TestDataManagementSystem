<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        btnShowRegister = New Button()
        btnShowList = New Button()
        SuspendLayout()
        ' 
        ' btnShowRegister
        ' 
        btnShowRegister.Location = New Point(111, 154)
        btnShowRegister.Name = "btnShowRegister"
        btnShowRegister.Size = New Size(221, 107)
        btnShowRegister.TabIndex = 0
        btnShowRegister.Text = "データ登録"
        btnShowRegister.UseVisualStyleBackColor = True
        ' 
        ' btnShowList
        ' 
        btnShowList.Location = New Point(457, 154)
        btnShowList.Name = "btnShowList"
        btnShowList.Size = New Size(221, 107)
        btnShowList.TabIndex = 1
        btnShowList.Text = "データ一覧"
        btnShowList.UseVisualStyleBackColor = True
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnShowList)
        Controls.Add(btnShowRegister)
        Name = "FormMain"
        Text = "検査データ管理システム"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnShowRegister As Button
    Friend WithEvents btnShowList As Button
End Class
