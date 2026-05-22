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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaixarContaPagar))
        Me.dgvParcelas = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSituacao = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResto = New System.Windows.Forms.Label()
        Me.txtAtualizarSaldo = New System.Windows.Forms.TextBox()
        Me.lblSaldoAtualizado = New System.Windows.Forms.Label()
        Me.lblVlrParcelas = New System.Windows.Forms.Label()
        Me.txtSaldoAtual = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblJuros = New System.Windows.Forms.Label()
        Me.txtNumParcela = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNrParcela = New System.Windows.Forms.Label()
        Me.txtPagamento = New System.Windows.Forms.DateTimePicker()
        Me.lblRecebeValorTotal = New System.Windows.Forms.Label()
        Me.dtpVencimentoParcela = New System.Windows.Forms.DateTimePicker()
        Me.txtSaldoRestante = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
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
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvParcelas
        '
        Me.dgvParcelas.AllowUserToAddRows = False
        Me.dgvParcelas.AllowUserToDeleteRows = False
        Me.dgvParcelas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvParcelas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvParcelas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvParcelas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvParcelas.GridColor = System.Drawing.Color.DarkBlue
        Me.dgvParcelas.Location = New System.Drawing.Point(10, 161)
        Me.dgvParcelas.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgvParcelas.Name = "dgvParcelas"
        Me.dgvParcelas.ReadOnly = True
        Me.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParcelas.Size = New System.Drawing.Size(876, 349)
        Me.dgvParcelas.TabIndex = 404
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSituacao)
        Me.GroupBox2.Controls.Add(Me.Label13)
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
        Me.GroupBox2.Location = New System.Drawing.Point(10, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(876, 106)
        Me.GroupBox2.TabIndex = 403
        Me.GroupBox2.TabStop = False
        '
        'txtSituacao
        '
        Me.txtSituacao.Enabled = False
        Me.txtSituacao.Location = New System.Drawing.Point(509, 73)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.ReadOnly = True
        Me.txtSituacao.Size = New System.Drawing.Size(148, 20)
        Me.txtSituacao.TabIndex = 402
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(506, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 401
        Me.Label13.Text = "Situação"
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
        Me.txtDataEntrada.Enabled = False
        Me.txtDataEntrada.Location = New System.Drawing.Point(7, 73)
        Me.txtDataEntrada.Mask = "00/00/0000"
        Me.txtDataEntrada.Name = "txtDataEntrada"
        Me.txtDataEntrada.ReadOnly = True
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
        Me.txtVencimento.Enabled = False
        Me.txtVencimento.Location = New System.Drawing.Point(229, 73)
        Me.txtVencimento.Mask = "00/00/0000"
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.ReadOnly = True
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
        Me.Label23.Size = New System.Drawing.Size(85, 20)
        Me.Label23.TabIndex = 301
        Me.Label23.Text = "Valor Total"
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
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(100, 73)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(101, 20)
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
        Me.txtNDoc.Enabled = False
        Me.txtNDoc.Location = New System.Drawing.Point(4, 30)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.ReadOnly = True
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
        Me.Label29.Location = New System.Drawing.Point(332, 52)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(123, 20)
        Me.Label29.TabIndex = 315
        Me.Label29.Text = "Forma de Pagto"
        '
        'txtFormaPagto
        '
        Me.txtFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFormaPagto.FormattingEnabled = True
        Me.txtFormaPagto.Location = New System.Drawing.Point(334, 72)
        Me.txtFormaPagto.Name = "txtFormaPagto"
        Me.txtFormaPagto.Size = New System.Drawing.Size(157, 21)
        Me.txtFormaPagto.TabIndex = 313
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResto)
        Me.GroupBox1.Controls.Add(Me.txtAtualizarSaldo)
        Me.GroupBox1.Controls.Add(Me.lblSaldoAtualizado)
        Me.GroupBox1.Controls.Add(Me.lblVlrParcelas)
        Me.GroupBox1.Controls.Add(Me.txtSaldoAtual)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblDesconto)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblJuros)
        Me.GroupBox1.Controls.Add(Me.txtNumParcela)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblNrParcela)
        Me.GroupBox1.Controls.Add(Me.txtPagamento)
        Me.GroupBox1.Controls.Add(Me.lblRecebeValorTotal)
        Me.GroupBox1.Controls.Add(Me.dtpVencimentoParcela)
        Me.GroupBox1.Controls.Add(Me.txtSaldoRestante)
        Me.GroupBox1.Controls.Add(Me.Label14)
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
        Me.GroupBox1.Location = New System.Drawing.Point(893, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 462)
        Me.GroupBox1.TabIndex = 402
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pagamento"
        '
        'lblResto
        '
        Me.lblResto.AutoSize = True
        Me.lblResto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResto.Location = New System.Drawing.Point(18, 339)
        Me.lblResto.Name = "lblResto"
        Me.lblResto.Size = New System.Drawing.Size(59, 17)
        Me.lblResto.TabIndex = 413
        Me.lblResto.Text = "Label15"
        Me.lblResto.Visible = False
        '
        'txtAtualizarSaldo
        '
        Me.txtAtualizarSaldo.Enabled = False
        Me.txtAtualizarSaldo.Location = New System.Drawing.Point(110, 121)
        Me.txtAtualizarSaldo.Name = "txtAtualizarSaldo"
        Me.txtAtualizarSaldo.ReadOnly = True
        Me.txtAtualizarSaldo.Size = New System.Drawing.Size(129, 26)
        Me.txtAtualizarSaldo.TabIndex = 403
        '
        'lblSaldoAtualizado
        '
        Me.lblSaldoAtualizado.AutoSize = True
        Me.lblSaldoAtualizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoAtualizado.Location = New System.Drawing.Point(139, 276)
        Me.lblSaldoAtualizado.Name = "lblSaldoAtualizado"
        Me.lblSaldoAtualizado.Size = New System.Drawing.Size(59, 17)
        Me.lblSaldoAtualizado.TabIndex = 412
        Me.lblSaldoAtualizado.Text = "Label15"
        Me.lblSaldoAtualizado.Visible = False
        '
        'lblVlrParcelas
        '
        Me.lblVlrParcelas.AutoSize = True
        Me.lblVlrParcelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVlrParcelas.Location = New System.Drawing.Point(128, 250)
        Me.lblVlrParcelas.Name = "lblVlrParcelas"
        Me.lblVlrParcelas.Size = New System.Drawing.Size(59, 17)
        Me.lblVlrParcelas.TabIndex = 411
        Me.lblVlrParcelas.Text = "Label15"
        Me.lblVlrParcelas.Visible = False
        '
        'txtSaldoAtual
        '
        Me.txtSaldoAtual.Enabled = False
        Me.txtSaldoAtual.ForeColor = System.Drawing.Color.Green
        Me.txtSaldoAtual.Location = New System.Drawing.Point(230, 393)
        Me.txtSaldoAtual.Name = "txtSaldoAtual"
        Me.txtSaldoAtual.ReadOnly = True
        Me.txtSaldoAtual.Size = New System.Drawing.Size(11, 26)
        Me.txtSaldoAtual.TabIndex = 410
        Me.txtSaldoAtual.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(4, 426)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 18)
        Me.Label12.TabIndex = 409
        Me.Label12.Text = "Saldo Restante.:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 408
        Me.Label1.Text = "Desconto:"
        Me.Label1.Visible = False
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.Location = New System.Drawing.Point(223, 370)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(18, 20)
        Me.lblDesconto.TabIndex = 407
        Me.lblDesconto.Text = "0"
        Me.lblDesconto.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(169, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 406
        Me.Label10.Text = "Juros:"
        Me.Label10.Visible = False
        '
        'lblJuros
        '
        Me.lblJuros.AutoSize = True
        Me.lblJuros.Location = New System.Drawing.Point(221, 341)
        Me.lblJuros.Name = "lblJuros"
        Me.lblJuros.Size = New System.Drawing.Size(18, 20)
        Me.lblJuros.TabIndex = 405
        Me.lblJuros.Text = "0"
        Me.lblJuros.Visible = False
        '
        'txtNumParcela
        '
        Me.txtNumParcela.Enabled = False
        Me.txtNumParcela.Location = New System.Drawing.Point(110, 28)
        Me.txtNumParcela.Mask = "00000"
        Me.txtNumParcela.Name = "txtNumParcela"
        Me.txtNumParcela.ReadOnly = True
        Me.txtNumParcela.Size = New System.Drawing.Size(50, 26)
        Me.txtNumParcela.TabIndex = 404
        Me.txtNumParcela.ValidatingType = GetType(Integer)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(37, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 401
        Me.Label4.Text = "Parcela:"
        '
        'lblNrParcela
        '
        Me.lblNrParcela.AutoSize = True
        Me.lblNrParcela.Location = New System.Drawing.Point(160, 12)
        Me.lblNrParcela.Name = "lblNrParcela"
        Me.lblNrParcela.Size = New System.Drawing.Size(14, 20)
        Me.lblNrParcela.TabIndex = 402
        Me.lblNrParcela.Text = "-"
        '
        'txtPagamento
        '
        Me.txtPagamento.CalendarForeColor = System.Drawing.Color.SteelBlue
        Me.txtPagamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtPagamento.Location = New System.Drawing.Point(109, 153)
        Me.txtPagamento.Name = "txtPagamento"
        Me.txtPagamento.Size = New System.Drawing.Size(112, 26)
        Me.txtPagamento.TabIndex = 400
        '
        'lblRecebeValorTotal
        '
        Me.lblRecebeValorTotal.AutoSize = True
        Me.lblRecebeValorTotal.Location = New System.Drawing.Point(180, 12)
        Me.lblRecebeValorTotal.Name = "lblRecebeValorTotal"
        Me.lblRecebeValorTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblRecebeValorTotal.TabIndex = 401
        Me.lblRecebeValorTotal.Text = "-"
        Me.lblRecebeValorTotal.Visible = False
        '
        'dtpVencimentoParcela
        '
        Me.dtpVencimentoParcela.CalendarForeColor = System.Drawing.Color.Red
        Me.dtpVencimentoParcela.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.dtpVencimentoParcela.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimentoParcela.Location = New System.Drawing.Point(110, 90)
        Me.dtpVencimentoParcela.Name = "dtpVencimentoParcela"
        Me.dtpVencimentoParcela.Size = New System.Drawing.Size(112, 26)
        Me.dtpVencimentoParcela.TabIndex = 399
        '
        'txtSaldoRestante
        '
        Me.txtSaldoRestante.Enabled = False
        Me.txtSaldoRestante.ForeColor = System.Drawing.Color.Green
        Me.txtSaldoRestante.Location = New System.Drawing.Point(124, 422)
        Me.txtSaldoRestante.Name = "txtSaldoRestante"
        Me.txtSaldoRestante.ReadOnly = True
        Me.txtSaldoRestante.Size = New System.Drawing.Size(122, 26)
        Me.txtSaldoRestante.TabIndex = 398
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(6, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 18)
        Me.Label14.TabIndex = 397
        Me.Label14.Text = "Saldo Atual.:"
        '
        'txtValorPago
        '
        Me.txtValorPago.Enabled = False
        Me.txtValorPago.ForeColor = System.Drawing.Color.Green
        Me.txtValorPago.Location = New System.Drawing.Point(111, 299)
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
        Me.Label9.Location = New System.Drawing.Point(6, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 18)
        Me.Label9.TabIndex = 394
        Me.Label9.Text = "Valor a Pagar.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(156, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 393
        Me.Label8.Text = "% ao dia."
        '
        'txtJuros
        '
        Me.txtJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJuros.ForeColor = System.Drawing.Color.Red
        Me.txtJuros.Location = New System.Drawing.Point(108, 186)
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
        Me.Label7.Location = New System.Drawing.Point(166, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 18)
        Me.Label7.TabIndex = 391
        Me.Label7.Text = "%"
        '
        'txtDesconto
        '
        Me.txtDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.ForeColor = System.Drawing.Color.Blue
        Me.txtDesconto.Location = New System.Drawing.Point(109, 215)
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
        Me.Label6.Location = New System.Drawing.Point(38, 190)
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
        Me.Label5.Location = New System.Drawing.Point(18, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 389
        Me.Label5.Text = "Desconto.:"
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Enabled = False
        Me.txtValorParcela.ForeColor = System.Drawing.Color.Green
        Me.txtValorParcela.Location = New System.Drawing.Point(110, 58)
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
        Me.btCalcular.Location = New System.Drawing.Point(9, 250)
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
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 93)
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
        Me.btBaixarConta.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Dollar1
        Me.btBaixarConta.Location = New System.Drawing.Point(12, 368)
        Me.btBaixarConta.Margin = New System.Windows.Forms.Padding(5)
        Me.btBaixarConta.Name = "btBaixarConta"
        Me.btBaixarConta.Size = New System.Drawing.Size(91, 43)
        Me.btBaixarConta.TabIndex = 371
        Me.btBaixarConta.Text = "Pagar Parcela"
        Me.btBaixarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btBaixarConta.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 158)
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
        Me.Label19.Location = New System.Drawing.Point(6, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 18)
        Me.Label19.TabIndex = 368
        Me.Label19.Text = "Valor Parcela.:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.btSair)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1162, 47)
        Me.Panel2.TabIndex = 405
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
        Me.Label16.Location = New System.Drawing.Point(232, 3)
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
        Me.btSair.Location = New System.Drawing.Point(1037, 3)
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
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1162, 526)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvParcelas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBaixarContaPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBaixarContaPagar"
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvParcelas As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSituacao As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblCodigoConta As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblIdparcela As Label
    Public WithEvents txtDataEntrada As MaskedTextBox
    Friend WithEvents Label20 As Label
    Public WithEvents txtVencimento As MaskedTextBox
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblResto As Label
    Friend WithEvents txtAtualizarSaldo As TextBox
    Friend WithEvents lblSaldoAtualizado As Label
    Friend WithEvents lblVlrParcelas As Label
    Friend WithEvents txtSaldoAtual As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDesconto As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblJuros As Label
    Public WithEvents txtNumParcela As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNrParcela As Label
    Friend WithEvents txtPagamento As DateTimePicker
    Friend WithEvents lblRecebeValorTotal As Label
    Friend WithEvents dtpVencimentoParcela As DateTimePicker
    Friend WithEvents txtSaldoRestante As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtJuros As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtValorParcela As TextBox
    Friend WithEvents btCalcular As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btBaixarConta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btSair As Button
End Class
