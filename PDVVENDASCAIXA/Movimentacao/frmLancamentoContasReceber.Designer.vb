<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancamentoContasReceber
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
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDtProximoPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtValorRestante = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorPagar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDtVenda = New System.Windows.Forms.MaskedTextBox()
        Me.txtValorParcelas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.ComboBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNVenda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumParcelas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(242, 114)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(494, 20)
        Me.txtDescricao.TabIndex = 340
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(146, 117)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 20)
        Me.Label23.TabIndex = 359
        Me.Label23.Text = "Descrição:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(260, 307)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 337
        Me.Label2.Text = "Próximo Pgto:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(78, 307)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 20)
        Me.Label18.TabIndex = 358
        Me.Label18.Text = "Total:"
        '
        'txtDtProximoPagamento
        '
        Me.txtDtProximoPagamento.Location = New System.Drawing.Point(374, 302)
        Me.txtDtProximoPagamento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDtProximoPagamento.Mask = "00/00/0000"
        Me.txtDtProximoPagamento.Name = "txtDtProximoPagamento"
        Me.txtDtProximoPagamento.Size = New System.Drawing.Size(96, 20)
        Me.txtDtProximoPagamento.TabIndex = 348
        Me.txtDtProximoPagamento.ValidatingType = GetType(Date)
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(134, 301)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(107, 20)
        Me.txtTotal.TabIndex = 347
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(818, 257)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 20)
        Me.Label17.TabIndex = 357
        Me.Label17.Text = "Valor Pago:"
        '
        'txtValorPago
        '
        Me.txtValorPago.Location = New System.Drawing.Point(917, 254)
        Me.txtValorPago.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(107, 20)
        Me.txtValorPago.TabIndex = 345
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(844, 382)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 20)
        Me.Label16.TabIndex = 356
        Me.Label16.Text = "Valor Restante:"
        '
        'txtValorRestante
        '
        Me.txtValorRestante.Location = New System.Drawing.Point(965, 379)
        Me.txtValorRestante.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValorRestante.Name = "txtValorRestante"
        Me.txtValorRestante.Size = New System.Drawing.Size(107, 20)
        Me.txtValorRestante.TabIndex = 346
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(31, 257)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 20)
        Me.Label14.TabIndex = 354
        Me.Label14.Text = "Data Venda:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(447, 261)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 20)
        Me.Label6.TabIndex = 355
        Me.Label6.Text = "Valor Parcelas:"
        '
        'txtValorPagar
        '
        Me.txtValorPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorPagar.Location = New System.Drawing.Point(839, 168)
        Me.txtValorPagar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValorPagar.Name = "txtValorPagar"
        Me.txtValorPagar.Size = New System.Drawing.Size(96, 29)
        Me.txtValorPagar.TabIndex = 338
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(711, 174)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 20)
        Me.Label12.TabIndex = 351
        Me.Label12.Text = "Valor a Pagar:"
        '
        'txtDtVenda
        '
        Me.txtDtVenda.Location = New System.Drawing.Point(134, 254)
        Me.txtDtVenda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDtVenda.Mask = "00/00/0000"
        Me.txtDtVenda.Name = "txtDtVenda"
        Me.txtDtVenda.Size = New System.Drawing.Size(96, 20)
        Me.txtDtVenda.TabIndex = 341
        Me.txtDtVenda.ValidatingType = GetType(Date)
        '
        'txtValorParcelas
        '
        Me.txtValorParcelas.Location = New System.Drawing.Point(566, 257)
        Me.txtValorParcelas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValorParcelas.Name = "txtValorParcelas"
        Me.txtValorParcelas.Size = New System.Drawing.Size(107, 20)
        Me.txtValorParcelas.TabIndex = 344
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(257, 257)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 353
        Me.Label5.Text = "Nº Parcelas:"
        '
        'txtCliente
        '
        Me.txtCliente.FormattingEnabled = True
        Me.txtCliente.Items.AddRange(New Object() {"Pagar", "Receber"})
        Me.txtCliente.Location = New System.Drawing.Point(135, 210)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(416, 21)
        Me.txtCliente.TabIndex = 339
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(610, 301)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(128, 20)
        Me.txtStatus.TabIndex = 349
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(494, 306)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 20)
        Me.Label10.TabIndex = 352
        Me.Label10.Text = "Status Venda:"
        '
        'txtNVenda
        '
        Me.txtNVenda.Location = New System.Drawing.Point(135, 174)
        Me.txtNVenda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNVenda.Name = "txtNVenda"
        Me.txtNVenda.Size = New System.Drawing.Size(95, 20)
        Me.txtNVenda.TabIndex = 336
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 342
        Me.Label4.Text = "Nº de Venda:"
        '
        'txtNumParcelas
        '
        Me.txtNumParcelas.Location = New System.Drawing.Point(360, 254)
        Me.txtNumParcelas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumParcelas.Name = "txtNumParcelas"
        Me.txtNumParcelas.Size = New System.Drawing.Size(54, 20)
        Me.txtNumParcelas.TabIndex = 343
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(55, 213)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 20)
        Me.Label11.TabIndex = 350
        Me.Label11.Text = "Cliente:"
        '
        'frmLancamentoContasReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1087, 505)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtDtProximoPagamento)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtValorPago)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtValorRestante)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtValorPagar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDtVenda)
        Me.Controls.Add(Me.txtValorParcelas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNVenda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNumParcelas)
        Me.Controls.Add(Me.Label11)
        Me.Name = "frmLancamentoContasReceber"
        Me.Text = "frmLancamentoContasReceber"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtDtProximoPagamento As MaskedTextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtValorRestante As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtValorPagar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDtVenda As MaskedTextBox
    Friend WithEvents txtValorParcelas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCliente As ComboBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNVenda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumParcelas As TextBox
    Friend WithEvents Label11 As Label
End Class
