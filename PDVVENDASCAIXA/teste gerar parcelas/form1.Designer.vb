<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumeroPacelas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.txtParcela = New System.Windows.Forms.TextBox()
        Me.dgvParcelas = New System.Windows.Forms.DataGridView()
        Me.Parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvValor = New System.Windows.Forms.DataGridView()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvValor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(112, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Parcelas:"
        '
        'txtNumeroPacelas
        '
        Me.txtNumeroPacelas.Location = New System.Drawing.Point(115, 247)
        Me.txtNumeroPacelas.Name = "txtNumeroPacelas"
        Me.txtNumeroPacelas.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPacelas.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(341, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Data Pagamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Valor Parcela:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(548, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 58)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Gravar Parcela"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(438, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 58)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Gerar Paracela"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mskData
        '
        Me.mskData.Location = New System.Drawing.Point(344, 247)
        Me.mskData.Mask = "99/99/9999"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(75, 20)
        Me.mskData.TabIndex = 23
        '
        'txtParcela
        '
        Me.txtParcela.Location = New System.Drawing.Point(9, 248)
        Me.txtParcela.Name = "txtParcela"
        Me.txtParcela.Size = New System.Drawing.Size(100, 20)
        Me.txtParcela.TabIndex = 22
        '
        'dgvParcelas
        '
        Me.dgvParcelas.AllowUserToAddRows = False
        Me.dgvParcelas.AllowUserToDeleteRows = False
        Me.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParcelas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Parcela, Me.Data, Me.Valor})
        Me.dgvParcelas.Location = New System.Drawing.Point(9, 297)
        Me.dgvParcelas.Name = "dgvParcelas"
        Me.dgvParcelas.Size = New System.Drawing.Size(584, 150)
        Me.dgvParcelas.TabIndex = 21
        '
        'Parcela
        '
        Me.Parcela.HeaderText = "Parcela"
        Me.Parcela.Name = "Parcela"
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        '
        'dgvValor
        '
        Me.dgvValor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvValor.Location = New System.Drawing.Point(336, 12)
        Me.dgvValor.Name = "dgvValor"
        Me.dgvValor.Size = New System.Drawing.Size(294, 150)
        Me.dgvValor.TabIndex = 20
        '
        'btnGravar
        '
        Me.btnGravar.Location = New System.Drawing.Point(191, 71)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(75, 23)
        Me.btnGravar.TabIndex = 19
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Valor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Produto:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(207, 30)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 16
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(33, 31)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(100, 20)
        Me.txtProduto.TabIndex = 15
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 507)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumeroPacelas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mskData)
        Me.Controls.Add(Me.txtParcela)
        Me.Controls.Add(Me.dgvParcelas)
        Me.Controls.Add(Me.dgvValor)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtProduto)
        Me.Name = "form1"
        Me.Text = "form1"
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvValor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumeroPacelas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents mskData As MaskedTextBox
    Friend WithEvents txtParcela As TextBox
    Friend WithEvents dgvParcelas As DataGridView
    Friend WithEvents Parcela As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents dgvValor As DataGridView
    Friend WithEvents btnGravar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtProduto As TextBox
End Class
