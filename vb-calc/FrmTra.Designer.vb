<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTra
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMenseki = New System.Windows.Forms.Label()
        Me.txtJyotei = New System.Windows.Forms.TextBox()
        Me.txtKatei = New System.Windows.Forms.TextBox()
        Me.lblTakasa = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "上底(cm)："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "下底(cm)："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "高さ(cm)："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "面積(cm^2)："
        '
        'lblMenseki
        '
        Me.lblMenseki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMenseki.Location = New System.Drawing.Point(226, 228)
        Me.lblMenseki.Name = "lblMenseki"
        Me.lblMenseki.Size = New System.Drawing.Size(100, 23)
        Me.lblMenseki.TabIndex = 4
        '
        'txtJyotei
        '
        Me.txtJyotei.Location = New System.Drawing.Point(229, 35)
        Me.txtJyotei.Name = "txtJyotei"
        Me.txtJyotei.Size = New System.Drawing.Size(100, 25)
        Me.txtJyotei.TabIndex = 5
        '
        'txtKatei
        '
        Me.txtKatei.Location = New System.Drawing.Point(229, 103)
        Me.txtKatei.Name = "txtKatei"
        Me.txtKatei.Size = New System.Drawing.Size(100, 25)
        Me.txtKatei.TabIndex = 6
        '
        'lblTakasa
        '
        Me.lblTakasa.Location = New System.Drawing.Point(229, 165)
        Me.lblTakasa.Name = "lblTakasa"
        Me.lblTakasa.Size = New System.Drawing.Size(100, 25)
        Me.lblTakasa.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(229, 292)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "計算"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'FrmTra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 332)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTakasa)
        Me.Controls.Add(Me.txtKatei)
        Me.Controls.Add(Me.txtJyotei)
        Me.Controls.Add(Me.lblMenseki)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmTra"
        Me.Text = "台形の面積"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMenseki As Label
    Friend WithEvents txtJyotei As TextBox
    Friend WithEvents txtKatei As TextBox
    Friend WithEvents lblTakasa As TextBox
    Friend WithEvents btnCalc As Button
End Class
