<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTri
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTeihen = New System.Windows.Forms.TextBox()
        Me.txtTakasa = New System.Windows.Forms.TextBox()
        Me.lblMenseki = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "底辺(cm)："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "高さ(cm)："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "面積(cm^2)："
        '
        'txtTeihen
        '
        Me.txtTeihen.Location = New System.Drawing.Point(232, 102)
        Me.txtTeihen.Name = "txtTeihen"
        Me.txtTeihen.Size = New System.Drawing.Size(158, 25)
        Me.txtTeihen.TabIndex = 3
        '
        'txtTakasa
        '
        Me.txtTakasa.Location = New System.Drawing.Point(232, 177)
        Me.txtTakasa.Name = "txtTakasa"
        Me.txtTakasa.Size = New System.Drawing.Size(158, 25)
        Me.txtTakasa.TabIndex = 4
        '
        'lblMenseki
        '
        Me.lblMenseki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMenseki.Location = New System.Drawing.Point(229, 245)
        Me.lblMenseki.Name = "lblMenseki"
        Me.lblMenseki.Size = New System.Drawing.Size(161, 32)
        Me.lblMenseki.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(300, 313)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "計算"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'FrmTri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblMenseki)
        Me.Controls.Add(Me.txtTakasa)
        Me.Controls.Add(Me.txtTeihen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmTri"
        Me.Text = "三角形の面積"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTeihen As TextBox
    Friend WithEvents txtTakasa As TextBox
    Friend WithEvents lblMenseki As Label
    Friend WithEvents btnCalc As Button
End Class
