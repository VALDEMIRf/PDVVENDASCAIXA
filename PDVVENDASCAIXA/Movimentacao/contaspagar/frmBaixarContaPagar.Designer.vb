<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBaixarContaPagar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaixarContaPagar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCodigoConta = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblIdparcela = New System.Windows.Forms.Label()
        Me.txtDataEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtConta = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtFormaPagto = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNrParcela = New System.Windows.Forms.Label()
        Me.cboParcela = New System.Windows.Forms.ComboBox()
        Me.lblRecebeValorTotal = New System.Windows.Forms.Label()
        Me.txtPagamento = New System.Windows.Forms.DateTimePicker()
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
        Me.txtValorParcela = New System.Windows.Forms.TextBox()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btBaixarConta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 341)
        Me.Panel1.TabIndex = 380
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCodigoConta)
        Me.GroupBox2.Controls.Add(Me.lblCodigo)
        Me.GroupBox2.Controls.Add(Me.lblIdparcela)
        Me.GroupBox2.Controls.Add(Me.txtDataEntrada)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtVencimento)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtValor)
        Me.GroupBox2.Controls.Add(Me.txtConta)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.txtNDoc)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.txtFornecedor)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.txtFormaPagto)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(757, 106)
        Me.GroupBox2.TabIndex = 400
        Me.GroupBox2.TabStop = False
        '
        'lblCodigoConta
        '
        Me.lblCodigoConta.AutoSize = True
        Me.lblCodigoConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoConta.ForeColor = System.Drawing.Color.White
        Me.lblCodigoConta.Location = New System.Drawing.Point(698, 10)
        Me.lblCodigoConta.Name = "lblCodigoConta"
        Me.lblCodigoConta.Size = New System.Drawing.Size(14, 15)
        Me.lblCodigoConta.TabIndex = 399
        Me.lblCodigoConta.Text = "0"
        Me.lblCodigoConta.Visible = False
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(718, 10)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(14, 15)
        Me.lblCodigo.TabIndex = 396
        Me.lblCodigo.Text = "0"
        Me.lblCodigo.Visible = False
        '
        'lblIdparcela
        '
        Me.lblIdparcela.AutoSize = True
        Me.lblIdparcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdparcela.ForeColor = System.Drawing.Color.White
        Me.lblIdparcela.Location = New System.Drawing.Point(641, 9)
        Me.lblIdparcela.Name = "lblIdparcela"
        Me.lblIdparcela.Size = New System.Drawing.Size(16, 18)
        Me.lblIdparcela.TabIndex = 365
        Me.lblIdparcela.Text = "0"
        '
        'txtDataEntrada
        '
        Me.txtDataEntrada.Location = New System.Drawing.Point(7, 73)
        Me.txtDataEntrada.Mask = "00/00/0000"
        Me.txtDataEntrada.Name = "txtDataEntrada"
        Me.txtDataEntrada.Size = New System.Drawing.Size(76, 20)
        Me.txtDataEntrada.TabIndex = 343
        Me.txtDataEntrada.ValidatingType = GetType(Date)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(5, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 20)
        Me.Label20.TabIndex = 344
        Me.Label20.Text = "Dt Entrada"
        '
        'txtVencimento
        '
        Me.txtVencimento.Location = New System.Drawing.Point(229, 73)
        Me.txtVencimento.Mask = "00/00/0000"
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(87, 20)
        Me.txtVencimento.TabIndex = 297
        Me.txtVencimento.ValidatingType = GetType(Date)
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(104, 53)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(46, 20)
        Me.Label23.TabIndex = 301
        Me.Label23.Text = "Valor"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(227, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 20)
        Me.Label24.TabIndex = 303
        Me.Label24.Text = "Vencimento"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(100, 73)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(86, 20)
        Me.txtValor.TabIndex = 299
        '
        'txtConta
        '
        Me.txtConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtConta.FormattingEnabled = True
        Me.txtConta.Location = New System.Drawing.Point(188, 29)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(214, 21)
        Me.txtConta.TabIndex = 294
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(430, 7)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(91, 20)
        Me.Label26.TabIndex = 302
        Me.Label26.Text = "Fornecedor"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(195, 7)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(86, 20)
        Me.Label27.TabIndex = 304
        Me.Label27.Text = "Tipo Conta"
        '
        'txtNDoc
        '
        Me.txtNDoc.Location = New System.Drawing.Point(4, 30)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(171, 20)
        Me.txtNDoc.TabIndex = 296
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(3, 10)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 20)
        Me.Label28.TabIndex = 305
        Me.Label28.Text = "N° Docto"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFornecedor.FormattingEnabled = True
        Me.txtFornecedor.Location = New System.Drawing.Point(416, 29)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(332, 21)
        Me.txtFornecedor.TabIndex = 309
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(453, 53)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(123, 20)
        Me.Label29.TabIndex = 315
        Me.Label29.Text = "Forma de Pagto"
        '
        'txtFormaPagto
        '
        Me.txtFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFormaPagto.FormattingEnabled = True
        Me.txtFormaPagto.Location = New System.Drawing.Point(455, 73)
        Me.txtFormaPagto.Name = "txtFormaPagto"
        Me.txtFormaPagto.Size = New System.Drawing.Size(157, 21)
        Me.txtFormaPagto.TabIndex = 313
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(367, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 15)
        Me.Label11.TabIndex = 398
        Me.Label11.Text = "-"
        Me.Label11.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblNrParcela)
        Me.GroupBox1.Controls.Add(Me.cboParcela)
        Me.GroupBox1.Controls.Add(Me.lblRecebeValorTotal)
        Me.GroupBox1.Controls.Add(Me.txtPagamento)
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
        Me.GroupBox1.Controls.Add(Me.txtValorParcela)
        Me.GroupBox1.Controls.Add(Me.btCalcular)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btBaixarConta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(5, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 165)
        Me.GroupBox1.TabIndex = 385
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pagamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 401
        Me.Label4.Text = "Parcelas:"
        '
        'lblNrParcela
        '
        Me.lblNrParcela.AutoSize = True
        Me.lblNrParcela.Location = New System.Drawing.Point(96, 98)
        Me.lblNrParcela.Name = "lblNrParcela"
        Me.lblNrParcela.Size = New System.Drawing.Size(14, 20)
        Me.lblNrParcela.TabIndex = 402
        Me.lblNrParcela.Text = "-"
        Me.lblNrParcela.Visible = False
        '
        'cboParcela
        '
        Me.cboParcela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboParcela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboParcela.FormattingEnabled = True
        Me.cboParcela.Location = New System.Drawing.Point(90, 23)
        Me.cboParcela.Name = "cboParcela"
        Me.cboParcela.Size = New System.Drawing.Size(64, 28)
        Me.cboParcela.TabIndex = 400
        '
        'lblRecebeValorTotal
        '
        Me.lblRecebeValorTotal.AutoSize = True
        Me.lblRecebeValorTotal.Location = New System.Drawing.Point(21, 98)
        Me.lblRecebeValorTotal.Name = "lblRecebeValorTotal"
        Me.lblRecebeValorTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblRecebeValorTotal.TabIndex = 401
        Me.lblRecebeValorTotal.Text = "-"
        Me.lblRecebeValorTotal.Visible = False
        '
        'txtPagamento
        '
        Me.txtPagamento.CalendarForeColor = System.Drawing.Color.SteelBlue
        Me.txtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtPagamento.Location = New System.Drawing.Point(111, 64)
        Me.txtPagamento.Name = "txtPagamento"
        Me.txtPagamento.Size = New System.Drawing.Size(112, 26)
        Me.txtPagamento.TabIndex = 400
        '
        'dtpVencimentoParcela
        '
        Me.dtpVencimentoParcela.CalendarForeColor = System.Drawing.Color.Red
        Me.dtpVencimentoParcela.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.dtpVencimentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimentoParcela.Location = New System.Drawing.Point(603, 25)
        Me.dtpVencimentoParcela.Name = "dtpVencimentoParcela"
        Me.dtpVencimentoParcela.Size = New System.Drawing.Size(112, 26)
        Me.dtpVencimentoParcela.TabIndex = 399
        '
        'txtSaldoRestante
        '
        Me.txtSaldoRestante.Enabled = False
        Me.txtSaldoRestante.ForeColor = System.Drawing.Color.Green
        Me.txtSaldoRestante.Location = New System.Drawing.Point(506, 126)
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
        Me.Label14.Location = New System.Drawing.Point(378, 130)
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
        Me.btEmDia.Location = New System.Drawing.Point(625, 63)
        Me.btEmDia.Margin = New System.Windows.Forms.Padding(5)
        Me.btEmDia.Name = "btEmDia"
        Me.btEmDia.Size = New System.Drawing.Size(90, 31)
        Me.btEmDia.TabIndex = 396
        Me.btEmDia.Text = "Em dia"
        Me.btEmDia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEmDia.UseVisualStyleBackColor = False
        Me.btEmDia.Visible = False
        '
        'txtValorPago
        '
        Me.txtValorPago.Enabled = False
        Me.txtValorPago.ForeColor = System.Drawing.Color.Green
        Me.txtValorPago.Location = New System.Drawing.Point(134, 125)
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
        Me.Label9.Location = New System.Drawing.Point(6, 129)
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
        Me.Label8.Location = New System.Drawing.Point(533, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 393
        Me.Label8.Text = "% ao dia."
        '
        'txtJuros
        '
        Me.txtJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJuros.ForeColor = System.Drawing.Color.Red
        Me.txtJuros.Location = New System.Drawing.Point(486, 64)
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
        Me.Label7.Location = New System.Drawing.Point(380, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 18)
        Me.Label7.TabIndex = 391
        Me.Label7.Text = "%"
        '
        'txtDesconto
        '
        Me.txtDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.ForeColor = System.Drawing.Color.Blue
        Me.txtDesconto.Location = New System.Drawing.Point(333, 64)
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
        Me.Label6.Location = New System.Drawing.Point(427, 68)
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
        Me.Label5.Location = New System.Drawing.Point(237, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 389
        Me.Label5.Text = "Desconto.:"
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Enabled = False
        Me.txtValorParcela.ForeColor = System.Drawing.Color.Green
        Me.txtValorParcela.Location = New System.Drawing.Point(301, 22)
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
        Me.btCalcular.Location = New System.Drawing.Point(270, 121)
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
        Me.Label3.Location = New System.Drawing.Point(495, 28)
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
        Me.btBaixarConta.Location = New System.Drawing.Point(646, 109)
        Me.btBaixarConta.Margin = New System.Windows.Forms.Padding(5)
        Me.btBaixarConta.Name = "btBaixarConta"
        Me.btBaixarConta.Size = New System.Drawing.Size(101, 46)
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
        Me.Label2.Location = New System.Drawing.Point(7, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 370
        Me.Label2.Text = "Pagamento.:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(194, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 18)
        Me.Label19.TabIndex = 368
        Me.Label19.Text = "Valor Parcela.:"
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
        Me.Panel2.Size = New System.Drawing.Size(789, 47)
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
        'frmBaixarContaPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(796, 348)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBaixarContaPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBaixarContaPagar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents btBaixarConta As Button
    Friend WithEvents lblIdparcela As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btCalcular As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtValorParcela As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtJuros As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btEmDia As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtSaldoRestante As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPagamento As DateTimePicker
    Friend WithEvents dtpVencimentoParcela As DateTimePicker
    Friend WithEvents lblRecebeValorTotal As Label
    Friend WithEvents lblNrParcela As Label
    Friend WithEvents lblCodigoConta As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents txtDataEntrada As MaskedTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtConta As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtFornecedor As ComboBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtFormaPagto As ComboBox
    Friend WithEvents cboParcela As ComboBox
    Friend WithEvents Label4 As Label
    Public WithEvents txtVencimento As MaskedTextBox
End Class
