<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaixarContaPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaixarContaPagar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtSituacao = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtConta = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtFormaPagto = New System.Windows.Forms.ComboBox()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNrParcela = New System.Windows.Forms.Label()
        Me.lblRecebeValorTotal = New System.Windows.Forms.Label()
        Me.dtpPagamentoParcela = New System.Windows.Forms.DateTimePicker()
        Me.dtpVencimentoParcela = New System.Windows.Forms.DateTimePicker()
        Me.txtSaldoRestante = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btEmDia = New System.Windows.Forms.Button()
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtJuros = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.txtVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtValorParcela = New System.Windows.Forms.TextBox()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btBaixarConta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtCodigoParcela = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.lblCodigo)
        Me.Panel1.Controls.Add(Me.txtSituacao)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtConta)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtFornecedor)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtFormaPagto)
        Me.Panel1.Controls.Add(Me.txtNDoc)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtDescricao)
        Me.Panel1.Controls.Add(Me.txtCodigoParcela)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Location = New System.Drawing.Point(2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 359)
        Me.Panel1.TabIndex = 380
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(334, 87)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(11, 15)
        Me.lblCodigo.TabIndex = 396
        Me.lblCodigo.Text = "-"
        Me.lblCodigo.Visible = False
        '
        'txtSituacao
        '
        Me.txtSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSituacao.FormattingEnabled = True
        Me.txtSituacao.Items.AddRange(New Object() {"Paga", "Não Paga", "Vencida", "Pendente", "Baixada"})
        Me.txtSituacao.Location = New System.Drawing.Point(614, 114)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(124, 21)
        Me.txtSituacao.TabIndex = 394
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(528, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 395
        Me.Label13.Text = "Situação.:"
        '
        'txtConta
        '
        Me.txtConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtConta.FormattingEnabled = True
        Me.txtConta.Location = New System.Drawing.Point(128, 49)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(189, 21)
        Me.txtConta.TabIndex = 388
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(343, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 20)
        Me.Label10.TabIndex = 389
        Me.Label10.Text = "Fornecedor.:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 20)
        Me.Label11.TabIndex = 390
        Me.Label11.Text = "Tipo Conta.:"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFornecedor.FormattingEnabled = True
        Me.txtFornecedor.Location = New System.Drawing.Point(448, 53)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(291, 21)
        Me.txtFornecedor.TabIndex = 391
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(6, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 20)
        Me.Label12.TabIndex = 393
        Me.Label12.Text = "Forma de Pagto.:"
        '
        'txtFormaPagto
        '
        Me.txtFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFormaPagto.FormattingEnabled = True
        Me.txtFormaPagto.Location = New System.Drawing.Point(141, 81)
        Me.txtFormaPagto.Name = "txtFormaPagto"
        Me.txtFormaPagto.Size = New System.Drawing.Size(176, 21)
        Me.txtFormaPagto.TabIndex = 392
        '
        'txtNDoc
        '
        Me.txtNDoc.Location = New System.Drawing.Point(347, 115)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(160, 20)
        Me.txtNDoc.TabIndex = 386
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(265, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 387
        Me.Label4.Text = "N° Docto.:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNrParcela)
        Me.GroupBox1.Controls.Add(Me.lblRecebeValorTotal)
        Me.GroupBox1.Controls.Add(Me.dtpPagamentoParcela)
        Me.GroupBox1.Controls.Add(Me.dtpVencimentoParcela)
        Me.GroupBox1.Controls.Add(Me.txtSaldoRestante)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btEmDia)
        Me.GroupBox1.Controls.Add(Me.txtValorPago)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtJuros)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDesconto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPagamento)
        Me.GroupBox1.Controls.Add(Me.txtVencimento)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.txtValorParcela)
        Me.GroupBox1.Controls.Add(Me.btCalcular)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btBaixarConta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 208)
        Me.GroupBox1.TabIndex = 385
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pagamento"
        '
        'lblNrParcela
        '
        Me.lblNrParcela.AutoSize = True
        Me.lblNrParcela.Location = New System.Drawing.Point(477, 92)
        Me.lblNrParcela.Name = "lblNrParcela"
        Me.lblNrParcela.Size = New System.Drawing.Size(14, 20)
        Me.lblNrParcela.TabIndex = 402
        Me.lblNrParcela.Text = "-"
        Me.lblNrParcela.Visible = False
        '
        'lblRecebeValorTotal
        '
        Me.lblRecebeValorTotal.AutoSize = True
        Me.lblRecebeValorTotal.Location = New System.Drawing.Point(434, 86)
        Me.lblRecebeValorTotal.Name = "lblRecebeValorTotal"
        Me.lblRecebeValorTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblRecebeValorTotal.TabIndex = 401
        Me.lblRecebeValorTotal.Text = "-"
        Me.lblRecebeValorTotal.Visible = False
        '
        'dtpPagamentoParcela
        '
        Me.dtpPagamentoParcela.CalendarForeColor = System.Drawing.Color.SteelBlue
        Me.dtpPagamentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPagamentoParcela.Location = New System.Drawing.Point(112, 94)
        Me.dtpPagamentoParcela.Name = "dtpPagamentoParcela"
        Me.dtpPagamentoParcela.Size = New System.Drawing.Size(112, 26)
        Me.dtpPagamentoParcela.TabIndex = 400
        '
        'dtpVencimentoParcela
        '
        Me.dtpVencimentoParcela.CalendarForeColor = System.Drawing.Color.Red
        Me.dtpVencimentoParcela.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.dtpVencimentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimentoParcela.Location = New System.Drawing.Point(113, 62)
        Me.dtpVencimentoParcela.Name = "dtpVencimentoParcela"
        Me.dtpVencimentoParcela.Size = New System.Drawing.Size(112, 26)
        Me.dtpVencimentoParcela.TabIndex = 399
        '
        'txtSaldoRestante
        '
        Me.txtSaldoRestante.Enabled = False
        Me.txtSaldoRestante.ForeColor = System.Drawing.Color.Green
        Me.txtSaldoRestante.Location = New System.Drawing.Point(583, 114)
        Me.txtSaldoRestante.Name = "txtSaldoRestante"
        Me.txtSaldoRestante.ReadOnly = True
        Me.txtSaldoRestante.Size = New System.Drawing.Size(128, 26)
        Me.txtSaldoRestante.TabIndex = 398
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(455, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 18)
        Me.Label14.TabIndex = 397
        Me.Label14.Text = "Saldo Restante.:"
        '
        'btEmDia
        '
        Me.btEmDia.BackColor = System.Drawing.Color.Transparent
        Me.btEmDia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEmDia.FlatAppearance.BorderSize = 0
        Me.btEmDia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btEmDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btEmDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEmDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btEmDia.ForeColor = System.Drawing.Color.White
        Me.btEmDia.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Calculator
        Me.btEmDia.Location = New System.Drawing.Point(327, 93)
        Me.btEmDia.Margin = New System.Windows.Forms.Padding(5)
        Me.btEmDia.Name = "btEmDia"
        Me.btEmDia.Size = New System.Drawing.Size(90, 31)
        Me.btEmDia.TabIndex = 396
        Me.btEmDia.Text = "Em dia"
        Me.btEmDia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEmDia.UseVisualStyleBackColor = False
        '
        'txtValorPago
        '
        Me.txtValorPago.Enabled = False
        Me.txtValorPago.ForeColor = System.Drawing.Color.Green
        Me.txtValorPago.Location = New System.Drawing.Point(140, 169)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.ReadOnly = True
        Me.txtValorPago.Size = New System.Drawing.Size(128, 26)
        Me.txtValorPago.TabIndex = 395
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 18)
        Me.Label9.TabIndex = 394
        Me.Label9.Text = "Valor a ser Pago.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(330, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 393
        Me.Label8.Text = "% ao dia."
        '
        'txtJuros
        '
        Me.txtJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJuros.ForeColor = System.Drawing.Color.Red
        Me.txtJuros.Location = New System.Drawing.Point(276, 128)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Size = New System.Drawing.Size(44, 26)
        Me.txtJuros.TabIndex = 392
        Me.txtJuros.Text = "0.1"
        Me.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(164, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 18)
        Me.Label7.TabIndex = 391
        Me.Label7.Text = "%"
        '
        'txtDesconto
        '
        Me.txtDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.ForeColor = System.Drawing.Color.Blue
        Me.txtDesconto.Location = New System.Drawing.Point(116, 127)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(44, 26)
        Me.txtDesconto.TabIndex = 388
        Me.txtDesconto.Text = "5"
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(217, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 18)
        Me.Label6.TabIndex = 390
        Me.Label6.Text = "Juros.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(20, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 389
        Me.Label5.Text = "Desconto.:"
        '
        'txtPagamento
        '
        Me.txtPagamento.ForeColor = System.Drawing.Color.Blue
        Me.txtPagamento.Location = New System.Drawing.Point(404, 176)
        Me.txtPagamento.Mask = "00/00/0000"
        Me.txtPagamento.Name = "txtPagamento"
        Me.txtPagamento.Size = New System.Drawing.Size(87, 26)
        Me.txtPagamento.TabIndex = 388
        Me.txtPagamento.ValidatingType = GetType(Date)
        Me.txtPagamento.Visible = False
        '
        'txtVencimento
        '
        Me.txtVencimento.ForeColor = System.Drawing.Color.Red
        Me.txtVencimento.Location = New System.Drawing.Point(404, 176)
        Me.txtVencimento.Mask = "00/00/0000"
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(87, 26)
        Me.txtVencimento.TabIndex = 387
        Me.txtVencimento.ValidatingType = GetType(Date)
        Me.txtVencimento.Visible = False
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(370, 20)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(344, 63)
        Me.txtObs.TabIndex = 383
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Enabled = False
        Me.txtValorParcela.ForeColor = System.Drawing.Color.Green
        Me.txtValorParcela.Location = New System.Drawing.Point(114, 29)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.ReadOnly = True
        Me.txtValorParcela.Size = New System.Drawing.Size(128, 26)
        Me.txtValorParcela.TabIndex = 386
        '
        'btCalcular
        '
        Me.btCalcular.BackColor = System.Drawing.Color.Transparent
        Me.btCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCalcular.FlatAppearance.BorderSize = 0
        Me.btCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btCalcular.ForeColor = System.Drawing.Color.White
        Me.btCalcular.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Calculator
        Me.btCalcular.Location = New System.Drawing.Point(276, 165)
        Me.btCalcular.Margin = New System.Windows.Forms.Padding(5)
        Me.btCalcular.Name = "btCalcular"
        Me.btCalcular.Size = New System.Drawing.Size(98, 34)
        Me.btCalcular.TabIndex = 374
        Me.btCalcular.Text = "Calcular"
        Me.btCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btCalcular.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(5, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 371
        Me.Label3.Text = "Vencimento.:"
        '
        'btBaixarConta
        '
        Me.btBaixarConta.BackColor = System.Drawing.Color.Transparent
        Me.btBaixarConta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBaixarConta.FlatAppearance.BorderSize = 0
        Me.btBaixarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btBaixarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btBaixarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBaixarConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.btBaixarConta.ForeColor = System.Drawing.Color.White
        Me.btBaixarConta.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Calculator
        Me.btBaixarConta.Location = New System.Drawing.Point(578, 163)
        Me.btBaixarConta.Margin = New System.Windows.Forms.Padding(5)
        Me.btBaixarConta.Name = "btBaixarConta"
        Me.btBaixarConta.Size = New System.Drawing.Size(136, 35)
        Me.btBaixarConta.TabIndex = 371
        Me.btBaixarConta.Text = "Pagar Parcela"
        Me.btBaixarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btBaixarConta.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(9, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 370
        Me.Label2.Text = "Pagamento.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(259, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 369
        Me.Label1.Text = "Observações.:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(7, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 18)
        Me.Label19.TabIndex = 368
        Me.Label19.Text = "Valor Parcela.:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Location = New System.Drawing.Point(448, 81)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(291, 20)
        Me.txtDescricao.TabIndex = 384
        '
        'txtCodigoParcela
        '
        Me.txtCodigoParcela.Enabled = False
        Me.txtCodigoParcela.Location = New System.Drawing.Point(144, 115)
        Me.txtCodigoParcela.Name = "txtCodigoParcela"
        Me.txtCodigoParcela.ReadOnly = True
        Me.txtCodigoParcela.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoParcela.TabIndex = 382
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(358, 83)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 18)
        Me.Label25.TabIndex = 380
        Me.Label25.Text = "Descrição.:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.btSair)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(745, 47)
        Me.Panel2.TabIndex = 380
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 313
        Me.PictureBox2.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(136, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(438, 34)
        Me.Label16.TabIndex = 258
        Me.Label16.Text = "PAGAMENTO DE PARCELA"
        '
        'btSair
        '
        Me.btSair.BackColor = System.Drawing.Color.Transparent
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSair.ForeColor = System.Drawing.Color.White
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(629, 1)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(93, 36)
        Me.btSair.TabIndex = 13
        Me.btSair.Text = "Voltar"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(23, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(118, 18)
        Me.Label21.TabIndex = 365
        Me.Label21.Text = "Código Parcela.:"
        '
        'frmBaixarContaPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(750, 364)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBaixarContaPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBaixarContaPagar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btSair As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents btBaixarConta As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btCalcular As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtValorParcela As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents txtCodigoParcela As TextBox
    Public WithEvents txtPagamento As MaskedTextBox
    Public WithEvents txtVencimento As MaskedTextBox
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtJuros As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btEmDia As Button
    Friend WithEvents txtConta As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFornecedor As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFormaPagto As ComboBox
    Friend WithEvents txtSituacao As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtSaldoRestante As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpPagamentoParcela As DateTimePicker
    Friend WithEvents dtpVencimentoParcela As DateTimePicker
    Friend WithEvents lblRecebeValorTotal As Label
    Friend WithEvents lblNrParcela As Label
End Class
