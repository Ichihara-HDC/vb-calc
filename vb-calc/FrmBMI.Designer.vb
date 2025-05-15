<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBMI
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
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.txtSincyo = New System.Windows.Forms.TextBox()
        Me.txtTaijyu = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "身長(m)："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "体重(kg)："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BMI指数："
        '
        'lblBMI
        '
        Me.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBMI.Location = New System.Drawing.Point(236, 197)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(128, 38)
        Me.lblBMI.TabIndex = 3
        '
        'txtSincyo
        '
        Me.txtSincyo.Location = New System.Drawing.Point(239, 34)
        Me.txtSincyo.Name = "txtSincyo"
        Me.txtSincyo.Size = New System.Drawing.Size(125, 25)
        Me.txtSincyo.TabIndex = 4
        '
        'txtTaijyu
        '
        Me.txtTaijyu.Location = New System.Drawing.Point(239, 120)
        Me.txtTaijyu.Name = "txtTaijyu"
        Me.txtTaijyu.Size = New System.Drawing.Size(125, 25)
        Me.txtTaijyu.TabIndex = 5
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(239, 305)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "計算"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'FrmBMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 365)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtTaijyu)
        Me.Controls.Add(Me.txtSincyo)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBMI"
        Me.Text = "BMI指数"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents txtSincyo As TextBox
    Friend WithEvents txtTaijyu As TextBox
    Friend WithEvents btnCalc As Button
End Class
