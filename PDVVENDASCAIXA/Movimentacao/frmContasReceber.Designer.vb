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
        Me.txtDtProximoPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNVenda = New System.Windows.Forms.TextBox()
        Me.txtValorPagar = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.ComboBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNumParcelas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValorParcelas = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDtVenda = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtValorRestante = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.dgContasReceber = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNvenda = New System.Windows.Forms.RadioButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.txtBuscarNvenda = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblValorTotalPagar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblValorPago = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblValorAPagar = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btRelatorio = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnQuitarConta = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblNumTotalContasReceber = New System.Windows.Forms.Label()
        Me.btnDebitosCliente = New System.Windows.Forms.Button()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        CType(Me.dgContasReceber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(248, 147)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Próximo Pgto:"
        '
        'txtDtProximoPagamento
        '
        Me.txtDtProximoPagamento.Location = New System.Drawing.Point(362, 142)
        Me.txtDtProximoPagamento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDtProximoPagamento.Mask = "00/00/0000"
        Me.txtDtProximoPagamento.Name = "txtDtProximoPagamento"
        Me.txtDtProximoPagamento.Size = New System.Drawing.Size(96, 26)
        Me.txtDtProximoPagamento.TabIndex = 11
        Me.txtDtProximoPagamento.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nº de Venda:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(43, 53)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Cliente:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(960, 14)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Valor a Pagar:"
        '
        'txtNVenda
        '
        Me.txtNVenda.Location = New System.Drawing.Point(123, 14)
        Me.txtNVenda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNVenda.Name = "txtNVenda"
        Me.txtNVenda.Size = New System.Drawing.Size(95, 26)
        Me.txtNVenda.TabIndex = 1
        '
        'txtValorPagar
        '
        Me.txtValorPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorPagar.Location = New System.Drawing.Point(1071, 11)
        Me.txtValorPagar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValorPagar.Name = "txtValorPagar"
        Me.txtValorPagar.Size = New System.Drawing.Size(96, 29)
        Me.txtValorPagar.TabIndex = 2
        '
        'txtCliente
        '
        Me.txtCliente.FormattingEnabled = True
        Me.txtCliente.Items.AddRange(New Object() {"Pagar", "Receber"})
        Me.txtCliente.Location = New System.Drawing.Point(123, 50)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(416, 28)
        Me.txtCliente.TabIndex = 3
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(598, 141)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(128, 26)
        Me.txtStatus.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(482, 146)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 20)
        Me.Label10.TabIndex = 223
        Me.Label10.Text = "Status Venda:"
        '
        'txtNumParcelas
        '
        Me.txtNumParcelas.Location = New System.Drawing.Point(348, 94)
        Me.txtNumParcelas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumParcelas.Name = "txtNumParcelas"
        Me.txtNumParcelas.Size = New System.Drawing.Size(54, 26)
        Me.txtNumParcelas.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(245, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 230
        Me.Label5.Text = "Nº Parcelas:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(435, 101)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 20)
        Me.Label6.TabIndex = 232
        Me.Label6.Text = "Valor Parcelas:"
        '
        'txtValorParcelas
        '
        Me.txtValorParcelas.Location = New System.Drawing.Point(554, 97)
        Me.txtValorParcelas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValorParcelas.Name = "txtValorParcelas"
        Me.txtValorParcelas.Size = New System.Drawing.Size(107, 26)
        Me.txtValorParcelas.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(19, 97)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 20)
        Me.Label14.TabIndex = 232
        Me.Label14.Text = "Data Venda:"
        '
        'txtDtVenda
        '
        Me.txtDtVenda.Location = New System.Drawing.Point(122, 94)
        Me.txtDtVenda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDtVenda.Mask = "00/00/0000"
        Me.txtDtVenda.Name = "txtDtVenda"
        Me.txtDtVenda.Size = New System.Drawing.Size(96, 26)
        Me.txtDtVenda.TabIndex = 5
        Me.txtDtVenda.ValidatingType = GetType(Date)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(939, 101)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 20)
        Me.Label16.TabIndex = 236
        Me.Label16.Text = "Valor Restante:"
        '
        'txtValorRestante
        '
        Me.txtValorRestante.Location = New System.Drawing.Point(1060, 98)
        Me.txtValorRestante.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValorRestante.Name = "txtValorRestante"
        Me.txtValorRestante.Size = New System.Drawing.Size(107, 26)
        Me.txtValorRestante.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(718, 100)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 20)
        Me.Label17.TabIndex = 238
        Me.Label17.Text = "Valor Pago:"
        '
        'txtValorPago
        '
        Me.txtValorPago.Location = New System.Drawing.Point(817, 97)
        Me.txtValorPago.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(107, 26)
        Me.txtValorPago.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(66, 147)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 20)
        Me.Label18.TabIndex = 240
        Me.Label18.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(122, 141)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(107, 26)
        Me.txtTotal.TabIndex = 10
        '
        'dgContasReceber
        '
        Me.dgContasReceber.AllowUserToAddRows = False
        Me.dgContasReceber.AllowUserToDeleteRows = False
        Me.dgContasReceber.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgContasReceber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContasReceber.GridColor = System.Drawing.Color.DarkBlue
        Me.dgContasReceber.Location = New System.Drawing.Point(7, 187)
        Me.dgContasReceber.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgContasReceber.Name = "dgContasReceber"
        Me.dgContasReceber.ReadOnly = True
        Me.dgContasReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContasReceber.Size = New System.Drawing.Size(1160, 223)
        Me.dgContasReceber.TabIndex = 241
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNvenda)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.rbCliente)
        Me.GroupBox1.Controls.Add(Me.txtBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.txtBuscarNvenda)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(737, 126)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(433, 45)
        Me.GroupBox1.TabIndex = 322
        Me.GroupBox1.TabStop = False
        '
        'rbNvenda
        '
        Me.rbNvenda.AutoSize = True
        Me.rbNvenda.ForeColor = System.Drawing.Color.White
        Me.rbNvenda.Location = New System.Drawing.Point(147, 16)
        Me.rbNvenda.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbNvenda.Name = "rbNvenda"
        Me.rbNvenda.Size = New System.Drawing.Size(86, 21)
        Me.rbNvenda.TabIndex = 16
        Me.rbNvenda.TabStop = True
        Me.rbNvenda.Text = "Nº Venda"
        Me.rbNvenda.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(12, 16)
        Me.Label21.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 17)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Buscar:"
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.ForeColor = System.Drawing.Color.White
        Me.rbCliente.Location = New System.Drawing.Point(73, 16)
        Me.rbCliente.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(69, 21)
        Me.rbCliente.TabIndex = 15
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Location = New System.Drawing.Point(247, 12)
        Me.txtBuscarCliente.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(170, 23)
        Me.txtBuscarCliente.TabIndex = 17
        '
        'txtBuscarNvenda
        '
        Me.txtBuscarNvenda.Location = New System.Drawing.Point(249, 12)
        Me.txtBuscarNvenda.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscarNvenda.Name = "txtBuscarNvenda"
        Me.txtBuscarNvenda.Size = New System.Drawing.Size(170, 23)
        Me.txtBuscarNvenda.TabIndex = 323
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblValorTotalPagar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(123, 445)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 131)
        Me.GroupBox2.TabIndex = 324
        Me.GroupBox2.TabStop = False
        '
        'lblValorTotalPagar
        '
        Me.lblValorTotalPagar.AutoSize = True
        Me.lblValorTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorTotalPagar.Location = New System.Drawing.Point(117, 34)
        Me.lblValorTotalPagar.Name = "lblValorTotalPagar"
        Me.lblValorTotalPagar.Size = New System.Drawing.Size(87, 39)
        Me.lblValorTotalPagar.TabIndex = 2
        Me.lblValorTotalPagar.Text = "0,00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "R$"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblValorPago)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(367, 445)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(237, 131)
        Me.GroupBox3.TabIndex = 325
        Me.GroupBox3.TabStop = False
        '
        'lblValorPago
        '
        Me.lblValorPago.AutoSize = True
        Me.lblValorPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorPago.Location = New System.Drawing.Point(117, 34)
        Me.lblValorPago.Name = "lblValorPago"
        Me.lblValorPago.Size = New System.Drawing.Size(87, 39)
        Me.lblValorPago.TabIndex = 2
        Me.lblValorPago.Text = "0,00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Pago"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 39)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "R$"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblValorAPagar)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Location = New System.Drawing.Point(610, 445)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(237, 131)
        Me.GroupBox4.TabIndex = 325
        Me.GroupBox4.TabStop = False
        '
        'lblValorAPagar
        '
        Me.lblValorAPagar.AutoSize = True
        Me.lblValorAPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorAPagar.Location = New System.Drawing.Point(117, 34)
        Me.lblValorAPagar.Name = "lblValorAPagar"
        Me.lblValorAPagar.Size = New System.Drawing.Size(87, 39)
        Me.lblValorAPagar.TabIndex = 2
        Me.lblValorAPagar.Text = "0,00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 104)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 20)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "A Pagar"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 39)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "R$"
        '
        'btSair
        '
        Me.btSair.BackColor = System.Drawing.Color.Transparent
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.ForeColor = System.Drawing.Color.White
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(1075, 589)
        Me.btSair.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(89, 33)
        Me.btSair.TabIndex = 19
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'btRelatorio
        '
        Me.btRelatorio.BackColor = System.Drawing.Color.Transparent
        Me.btRelatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRelatorio.FlatAppearance.BorderSize = 0
        Me.btRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRelatorio.ForeColor = System.Drawing.Color.White
        Me.btRelatorio.Image = CType(resources.GetObject("btRelatorio.Image"), System.Drawing.Image)
        Me.btRelatorio.Location = New System.Drawing.Point(530, 585)
        Me.btRelatorio.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btRelatorio.Name = "btRelatorio"
        Me.btRelatorio.Size = New System.Drawing.Size(114, 37)
        Me.btRelatorio.TabIndex = 16
        Me.btRelatorio.Text = "Relatório"
        Me.btRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btRelatorio.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(11, 585)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(127, 35)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Nova Conta"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(253, 585)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(103, 37)
        Me.btnExcluir.TabIndex = 14
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(150, 585)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(86, 36)
        Me.btnSalvar.TabIndex = 13
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnQuitarConta
        '
        Me.btnQuitarConta.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitarConta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarConta.FlatAppearance.BorderSize = 0
        Me.btnQuitarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnQuitarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuitarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarConta.ForeColor = System.Drawing.Color.White
        Me.btnQuitarConta.Image = CType(resources.GetObject("btnQuitarConta.Image"), System.Drawing.Image)
        Me.btnQuitarConta.Location = New System.Drawing.Point(367, 585)
        Me.btnQuitarConta.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnQuitarConta.Name = "btnQuitarConta"
        Me.btnQuitarConta.Size = New System.Drawing.Size(148, 37)
        Me.btnQuitarConta.TabIndex = 15
        Me.btnQuitarConta.Text = "Quitar a conta"
        Me.btnQuitarConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuitarConta.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(455, 420)
        Me.Label22.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(155, 20)
        Me.Label22.TabIndex = 333
        Me.Label22.Text = "Contas Encontradas"
        '
        'lblNumTotalContasReceber
        '
        Me.lblNumTotalContasReceber.AutoSize = True
        Me.lblNumTotalContasReceber.BackColor = System.Drawing.Color.Transparent
        Me.lblNumTotalContasReceber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTotalContasReceber.ForeColor = System.Drawing.Color.White
        Me.lblNumTotalContasReceber.Location = New System.Drawing.Point(399, 420)
        Me.lblNumTotalContasReceber.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblNumTotalContasReceber.Name = "lblNumTotalContasReceber"
        Me.lblNumTotalContasReceber.Size = New System.Drawing.Size(14, 20)
        Me.lblNumTotalContasReceber.TabIndex = 332
        Me.lblNumTotalContasReceber.Text = "-"
        '
        'btnDebitosCliente
        '
        Me.btnDebitosCliente.BackColor = System.Drawing.Color.Transparent
        Me.btnDebitosCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebitosCliente.FlatAppearance.BorderSize = 0
        Me.btnDebitosCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnDebitosCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDebitosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebitosCliente.ForeColor = System.Drawing.Color.White
        Me.btnDebitosCliente.Image = CType(resources.GetObject("btnDebitosCliente.Image"), System.Drawing.Image)
        Me.btnDebitosCliente.Location = New System.Drawing.Point(657, 585)
        Me.btnDebitosCliente.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnDebitosCliente.Name = "btnDebitosCliente"
        Me.btnDebitosCliente.Size = New System.Drawing.Size(218, 35)
        Me.btnDebitosCliente.TabIndex = 17
        Me.btnDebitosCliente.Text = "Débitos Total Cliente"
        Me.btnDebitosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDebitosCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDebitosCliente.UseVisualStyleBackColor = False
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(673, 52)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(494, 26)
        Me.txtDescricao.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(577, 55)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 20)
        Me.Label23.TabIndex = 335
        Me.Label23.Text = "Descrição:"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(869, 585)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(90, 35)
        Me.btnEditar.TabIndex = 18
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'frmContasReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1180, 632)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnDebitosCliente)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblNumTotalContasReceber)
        Me.Controls.Add(Me.btnQuitarConta)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btRelatorio)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgContasReceber)
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
        CType(Me.dgContasReceber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDtProximoPagamento As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNVenda As TextBox
    Friend WithEvents txtValorPagar As TextBox
    Friend WithEvents txtCliente As ComboBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNumParcelas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtValorParcelas As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDtVenda As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtValorRestante As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dgContasReceber As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNvenda As RadioButton
    Friend WithEvents Label21 As Label
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents txtBuscarNvenda As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblValorTotalPagar As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblValorPago As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblValorAPagar As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btSair As Button
    Friend WithEvents btRelatorio As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnQuitarConta As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents lblNumTotalContasReceber As Label
    Friend WithEvents btnDebitosCliente As Button
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnEditar As Button
End Class
