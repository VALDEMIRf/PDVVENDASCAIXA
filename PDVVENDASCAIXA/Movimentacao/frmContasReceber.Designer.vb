<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContasReceber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContasReceber))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDtEmissao = New System.Windows.Forms.MaskedTextBox()
        Me.txtDtVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.txtVlTotal = New System.Windows.Forms.TextBox()
        Me.txtClienteDevedor = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.dgContasPagar = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDtPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVlRecebido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSaldoDevedor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Geral = New System.Windows.Forms.TabPage()
        Me.Movimentação = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.dgContasPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Geral.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(260, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Emissão:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Vencimento:"
        '
        'txtDtEmissao
        '
        Me.txtDtEmissao.Location = New System.Drawing.Point(332, 18)
        Me.txtDtEmissao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDtEmissao.Mask = "00/00/0000"
        Me.txtDtEmissao.Name = "txtDtEmissao"
        Me.txtDtEmissao.Size = New System.Drawing.Size(108, 26)
        Me.txtDtEmissao.TabIndex = 4
        Me.txtDtEmissao.ValidatingType = GetType(Date)
        '
        'txtDtVencimento
        '
        Me.txtDtVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDtVencimento.Location = New System.Drawing.Point(122, 42)
        Me.txtDtVencimento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDtVencimento.Mask = "00/00/0000"
        Me.txtDtVencimento.Name = "txtDtVencimento"
        Me.txtDtVencimento.Size = New System.Drawing.Size(108, 29)
        Me.txtDtVencimento.TabIndex = 5
        Me.txtDtVencimento.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nº Doc / Parcela:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(7, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Telefone"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(48, 214)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Cliente/Fornecedor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(246, 17)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Valor do Título:"
        '
        'txtNDoc
        '
        Me.txtNDoc.Location = New System.Drawing.Point(141, 18)
        Me.txtNDoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(71, 26)
        Me.txtNDoc.TabIndex = 16
        '
        'txtVlTotal
        '
        Me.txtVlTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVlTotal.Location = New System.Drawing.Point(241, 42)
        Me.txtVlTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVlTotal.Name = "txtVlTotal"
        Me.txtVlTotal.Size = New System.Drawing.Size(119, 29)
        Me.txtVlTotal.TabIndex = 17
        '
        'txtClienteDevedor
        '
        Me.txtClienteDevedor.FormattingEnabled = True
        Me.txtClienteDevedor.Items.AddRange(New Object() {"Pagar", "Receber"})
        Me.txtClienteDevedor.Location = New System.Drawing.Point(42, 239)
        Me.txtClienteDevedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtClienteDevedor.Name = "txtClienteDevedor"
        Me.txtClienteDevedor.Size = New System.Drawing.Size(488, 28)
        Me.txtClienteDevedor.TabIndex = 21
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(7, 51)
        Me.MaskedTextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaskedTextBox3.Mask = "(99) 0 000-0000"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(132, 26)
        Me.MaskedTextBox3.TabIndex = 22
        '
        'dgContasPagar
        '
        Me.dgContasPagar.AllowUserToAddRows = False
        Me.dgContasPagar.AllowUserToDeleteRows = False
        Me.dgContasPagar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgContasPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContasPagar.GridColor = System.Drawing.Color.DarkBlue
        Me.dgContasPagar.Location = New System.Drawing.Point(559, 584)
        Me.dgContasPagar.Margin = New System.Windows.Forms.Padding(18, 15, 18, 15)
        Me.dgContasPagar.Name = "dgContasPagar"
        Me.dgContasPagar.ReadOnly = True
        Me.dgContasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContasPagar.Size = New System.Drawing.Size(196, 74)
        Me.dgContasPagar.TabIndex = 191
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(66, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(400, 49)
        Me.Label5.TabIndex = 218
        Me.Label5.Text = "CONTAS A RECEBER"
        '
        'txtDtPagamento
        '
        Me.txtDtPagamento.Location = New System.Drawing.Point(34, 354)
        Me.txtDtPagamento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDtPagamento.Mask = "00/00/0000"
        Me.txtDtPagamento.Name = "txtDtPagamento"
        Me.txtDtPagamento.Size = New System.Drawing.Size(108, 26)
        Me.txtDtPagamento.TabIndex = 220
        Me.txtDtPagamento.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 329)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Pagamento"
        '
        'txtVlRecebido
        '
        Me.txtVlRecebido.Location = New System.Drawing.Point(155, 354)
        Me.txtVlRecebido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVlRecebido.Name = "txtVlRecebido"
        Me.txtVlRecebido.Size = New System.Drawing.Size(128, 26)
        Me.txtVlRecebido.TabIndex = 222
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(156, 329)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 20)
        Me.Label9.TabIndex = 221
        Me.Label9.Text = "Valor Recebido"
        '
        'txtSaldoDevedor
        '
        Me.txtSaldoDevedor.Location = New System.Drawing.Point(307, 354)
        Me.txtSaldoDevedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSaldoDevedor.Name = "txtSaldoDevedor"
        Me.txtSaldoDevedor.Size = New System.Drawing.Size(148, 26)
        Me.txtSaldoDevedor.TabIndex = 224
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(303, 329)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 20)
        Me.Label10.TabIndex = 223
        Me.Label10.Text = "Saldo Devedor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(272, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(155, 79)
        Me.GroupBox2.TabIndex = 226
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contato"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Geral)
        Me.TabControl1.Controls.Add(Me.Movimentação)
        Me.TabControl1.Location = New System.Drawing.Point(6, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1053, 481)
        Me.TabControl1.TabIndex = 227
        '
        'Geral
        '
        Me.Geral.BackColor = System.Drawing.Color.SteelBlue
        Me.Geral.Controls.Add(Me.GroupBox4)
        Me.Geral.Controls.Add(Me.GroupBox3)
        Me.Geral.Controls.Add(Me.GroupBox1)
        Me.Geral.Controls.Add(Me.txtClienteDevedor)
        Me.Geral.Controls.Add(Me.txtDtPagamento)
        Me.Geral.Controls.Add(Me.txtSaldoDevedor)
        Me.Geral.Controls.Add(Me.Label11)
        Me.Geral.Controls.Add(Me.Label10)
        Me.Geral.Controls.Add(Me.Label1)
        Me.Geral.Controls.Add(Me.Label9)
        Me.Geral.Controls.Add(Me.txtVlRecebido)
        Me.Geral.ForeColor = System.Drawing.Color.White
        Me.Geral.Location = New System.Drawing.Point(4, 29)
        Me.Geral.Name = "Geral"
        Me.Geral.Padding = New System.Windows.Forms.Padding(3)
        Me.Geral.Size = New System.Drawing.Size(1045, 448)
        Me.Geral.TabIndex = 0
        Me.Geral.Text = "Geral"
        '
        'Movimentação
        '
        Me.Movimentação.BackColor = System.Drawing.Color.SteelBlue
        Me.Movimentação.Location = New System.Drawing.Point(4, 29)
        Me.Movimentação.Name = "Movimentação"
        Me.Movimentação.Padding = New System.Windows.Forms.Padding(3)
        Me.Movimentação.Size = New System.Drawing.Size(231, 159)
        Me.Movimentação.TabIndex = 1
        Me.Movimentação.Text = "Movimentação"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(213, 18)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(32, 26)
        Me.TextBox1.TabIndex = 227
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDtEmissao)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNDoc)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1012, 53)
        Me.GroupBox1.TabIndex = 228
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(448, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 20)
        Me.Label7.TabIndex = 228
        Me.Label7.Text = "Forma de Pgto:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Dinheiro", "Boleto", "Cartão Crédito", "Cartão Débito", "PIX", "Depósito Bancário"})
        Me.ComboBox1.Location = New System.Drawing.Point(570, 17)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 28)
        Me.ComboBox1.TabIndex = 229
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Servico", "Venda"})
        Me.ComboBox2.Location = New System.Drawing.Point(869, 17)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(129, 28)
        Me.ComboBox2.TabIndex = 231
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(735, 21)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 20)
        Me.Label13.TabIndex = 230
        Me.Label13.Text = "Tipo de Cobrança:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDtVencimento)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtVlTotal)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 95)
        Me.GroupBox3.TabIndex = 229
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(380, 60)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(463, 100)
        Me.GroupBox4.TabIndex = 230
        Me.GroupBox4.TabStop = False
        '
        'frmContasReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1106, 692)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgContasPagar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContasReceber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas a Receber"
        CType(Me.dgContasPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Geral.ResumeLayout(False)
        Me.Geral.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDtEmissao As MaskedTextBox
    Friend WithEvents txtDtVencimento As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents txtVlTotal As TextBox
    Friend WithEvents txtClienteDevedor As ComboBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents dgContasPagar As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDtPagamento As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVlRecebido As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSaldoDevedor As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Geral As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Movimentação As TabPage
End Class
