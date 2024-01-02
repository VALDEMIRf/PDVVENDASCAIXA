<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTesteValor
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtquant = New System.Windows.Forms.TextBox()
        Me.txtValorDecimal = New System.Windows.Forms.TextBox()
        Me.txtValorMoney = New System.Windows.Forms.TextBox()
        Me.txtValorVarchar = New System.Windows.Forms.TextBox()
        Me.txtResultadoDecimal = New System.Windows.Forms.TextBox()
        Me.txtResultadoMoney = New System.Windows.Forms.TextBox()
        Me.txtResultadoVarchar = New System.Windows.Forms.TextBox()
        Me.btGravar = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.cbProduto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btCalcular = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quantidade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "valor em decimal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor em money:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "valor em varchar:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(309, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "resultado eme decimal:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(325, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "resultado em money:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(320, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "resultado em varchar:"
        '
        'txtquant
        '
        Me.txtquant.Location = New System.Drawing.Point(160, 17)
        Me.txtquant.Name = "txtquant"
        Me.txtquant.Size = New System.Drawing.Size(111, 26)
        Me.txtquant.TabIndex = 7
        '
        'txtValorDecimal
        '
        Me.txtValorDecimal.Location = New System.Drawing.Point(160, 48)
        Me.txtValorDecimal.Name = "txtValorDecimal"
        Me.txtValorDecimal.Size = New System.Drawing.Size(100, 26)
        Me.txtValorDecimal.TabIndex = 8
        '
        'txtValorMoney
        '
        Me.txtValorMoney.Location = New System.Drawing.Point(160, 81)
        Me.txtValorMoney.Name = "txtValorMoney"
        Me.txtValorMoney.Size = New System.Drawing.Size(100, 26)
        Me.txtValorMoney.TabIndex = 9
        '
        'txtValorVarchar
        '
        Me.txtValorVarchar.Location = New System.Drawing.Point(160, 112)
        Me.txtValorVarchar.Name = "txtValorVarchar"
        Me.txtValorVarchar.Size = New System.Drawing.Size(100, 26)
        Me.txtValorVarchar.TabIndex = 10
        '
        'txtResultadoDecimal
        '
        Me.txtResultadoDecimal.Location = New System.Drawing.Point(502, 48)
        Me.txtResultadoDecimal.Name = "txtResultadoDecimal"
        Me.txtResultadoDecimal.Size = New System.Drawing.Size(100, 26)
        Me.txtResultadoDecimal.TabIndex = 11
        '
        'txtResultadoMoney
        '
        Me.txtResultadoMoney.Location = New System.Drawing.Point(502, 81)
        Me.txtResultadoMoney.Name = "txtResultadoMoney"
        Me.txtResultadoMoney.Size = New System.Drawing.Size(100, 26)
        Me.txtResultadoMoney.TabIndex = 12
        '
        'txtResultadoVarchar
        '
        Me.txtResultadoVarchar.Location = New System.Drawing.Point(502, 115)
        Me.txtResultadoVarchar.Name = "txtResultadoVarchar"
        Me.txtResultadoVarchar.Size = New System.Drawing.Size(100, 26)
        Me.txtResultadoVarchar.TabIndex = 13
        '
        'btGravar
        '
        Me.btGravar.Location = New System.Drawing.Point(617, 51)
        Me.btGravar.Name = "btGravar"
        Me.btGravar.Size = New System.Drawing.Size(87, 37)
        Me.btGravar.TabIndex = 14
        Me.btGravar.Text = "gravar"
        Me.btGravar.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(13, 148)
        Me.dg.Margin = New System.Windows.Forms.Padding(4)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(837, 271)
        Me.dg.TabIndex = 222
        '
        'cbProduto
        '
        Me.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.Location = New System.Drawing.Point(358, 17)
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(168, 28)
        Me.cbProduto.TabIndex = 223
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(290, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 224
        Me.Label8.Text = "Produto:"
        '
        'btCalcular
        '
        Me.btCalcular.Location = New System.Drawing.Point(617, 101)
        Me.btCalcular.Name = "btCalcular"
        Me.btCalcular.Size = New System.Drawing.Size(87, 37)
        Me.btCalcular.TabIndex = 225
        Me.btCalcular.Text = "calcular"
        Me.btCalcular.UseVisualStyleBackColor = True
        '
        'frmTesteValor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(867, 432)
        Me.Controls.Add(Me.btCalcular)
        Me.Controls.Add(Me.cbProduto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.btGravar)
        Me.Controls.Add(Me.txtResultadoVarchar)
        Me.Controls.Add(Me.txtResultadoMoney)
        Me.Controls.Add(Me.txtResultadoDecimal)
        Me.Controls.Add(Me.txtValorVarchar)
        Me.Controls.Add(Me.txtValorMoney)
        Me.Controls.Add(Me.txtValorDecimal)
        Me.Controls.Add(Me.txtquant)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmTesteValor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTesteValor"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtquant As TextBox
    Friend WithEvents txtValorDecimal As TextBox
    Friend WithEvents txtValorMoney As TextBox
    Friend WithEvents txtValorVarchar As TextBox
    Friend WithEvents txtResultadoDecimal As TextBox
    Friend WithEvents txtResultadoMoney As TextBox
    Friend WithEvents txtResultadoVarchar As TextBox
    Friend WithEvents btGravar As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents cbProduto As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btCalcular As Button
End Class
