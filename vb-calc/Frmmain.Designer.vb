<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmain
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
        Me.btnTri = New System.Windows.Forms.Button()
        Me.btnTra = New System.Windows.Forms.Button()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTri
        '
        Me.btnTri.Location = New System.Drawing.Point(101, 59)
        Me.btnTri.Name = "btnTri"
        Me.btnTri.Size = New System.Drawing.Size(236, 53)
        Me.btnTri.TabIndex = 0
        Me.btnTri.Text = "三角形の面積"
        Me.btnTri.UseVisualStyleBackColor = True
        '
        'btnTra
        '
        Me.btnTra.Location = New System.Drawing.Point(101, 137)
        Me.btnTra.Name = "btnTra"
        Me.btnTra.Size = New System.Drawing.Size(236, 46)
        Me.btnTra.TabIndex = 1
        Me.btnTra.Text = "台形の面積"
        Me.btnTra.UseVisualStyleBackColor = True
        '
        'btnBMI
        '
        Me.btnBMI.Location = New System.Drawing.Point(101, 202)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(236, 56)
        Me.btnBMI.TabIndex = 2
        Me.btnBMI.Text = "BMI指数"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 318)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.btnTra)
        Me.Controls.Add(Me.btnTri)
        Me.Name = "Frmmain"
        Me.Text = "メインメニュー"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTri As Button
    Friend WithEvents btnTra As Button
    Friend WithEvents btnBMI As Button
End Class
