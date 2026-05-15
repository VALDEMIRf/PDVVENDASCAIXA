<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLancamentoContasPagar
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLancamentoContasPagar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvParcelas = New System.Windows.Forms.DataGridView()
        Me.id_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numDocto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoRestante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Conta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbParcelamento = New System.Windows.Forms.RadioButton()
        Me.txtNumeroPacelas = New System.Windows.Forms.NumericUpDown()
        Me.btGravarParcelas = New System.Windows.Forms.Button()
        Me.btGerarParcelas = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtValorParcelas = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSaldoRestante = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJuros = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.txtDataEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodigo = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.lblCodigoConta = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtSituacao = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtConta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFormaPagto = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtNumeroPacelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.dgvParcelas)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 673)
        Me.Panel1.TabIndex = 0
        '
        'dgvParcelas
        '
        Me.dgvParcelas.AllowUserToAddRows = False
        Me.dgvParcelas.AllowUserToDeleteRows = False
        Me.dgvParcelas.BackgroundColor = System.Drawing.Color.White
        Me.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParcelas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_parcela, Me.parcela, Me.data_parcela, Me.valor_parcela, Me.numDocto, Me.pago, Me.valorTotal, Me.situacao, Me.SaldoRestante, Me.Fornecedor, Me.Conta})
        Me.dgvParcelas.GridColor = System.Drawing.Color.DarkBlue
        Me.dgvParcelas.Location = New System.Drawing.Point(7, 212)
        Me.dgvParcelas.Name = "dgvParcelas"
        Me.dgvParcelas.ReadOnly = True
        Me.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParcelas.Size = New System.Drawing.Size(1003, 456)
        Me.dgvParcelas.TabIndex = 334
        '
        'id_parcela
        '
        Me.id_parcela.DataPropertyName = "id_parcela"
        Me.id_parcela.HeaderText = "id_parcela"
        Me.id_parcela.Name = "id_parcela"
        Me.id_parcela.ReadOnly = True
        Me.id_parcela.Visible = False
        Me.id_parcela.Width = 80
        '
        'parcela
        '
        Me.parcela.DataPropertyName = "parcela"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.parcela.DefaultCellStyle = DataGridViewCellStyle7
        Me.parcela.HeaderText = "parcela"
        Me.parcela.Name = "parcela"
        Me.parcela.ReadOnly = True
        Me.parcela.Width = 60
        '
        'data_parcela
        '
        Me.data_parcela.DataPropertyName = "data_parcela"
        Me.data_parcela.HeaderText = "data_parcela"
        Me.data_parcela.Name = "data_parcela"
        Me.data_parcela.ReadOnly = True
        Me.data_parcela.Width = 80
        '
        'valor_parcela
        '
        Me.valor_parcela.DataPropertyName = "valor_parcela"
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.valor_parcela.DefaultCellStyle = DataGridViewCellStyle8
        Me.valor_parcela.HeaderText = "valor_parcela"
        Me.valor_parcela.Name = "valor_parcela"
        Me.valor_parcela.ReadOnly = True
        Me.valor_parcela.Width = 130
        '
        'numDocto
        '
        Me.numDocto.DataPropertyName = "numDocto"
        Me.numDocto.HeaderText = "numDocto"
        Me.numDocto.Name = "numDocto"
        Me.numDocto.ReadOnly = True
        Me.numDocto.Width = 150
        '
        'pago
        '
        Me.pago.DataPropertyName = "Pago"
        Me.pago.HeaderText = "Pago"
        Me.pago.Name = "pago"
        Me.pago.ReadOnly = True
        Me.pago.Width = 40
        '
        'valorTotal
        '
        Me.valorTotal.DataPropertyName = "valorTotal"
        Me.valorTotal.HeaderText = "valorTotal"
        Me.valorTotal.Name = "valorTotal"
        Me.valorTotal.ReadOnly = True
        Me.valorTotal.Width = 130
        '
        'situacao
        '
        Me.situacao.DataPropertyName = "situacao"
        Me.situacao.HeaderText = "situacao"
        Me.situacao.Name = "situacao"
        Me.situacao.ReadOnly = True
        Me.situacao.Width = 80
        '
        'SaldoRestante
        '
        Me.SaldoRestante.DataPropertyName = "SaldoRestante"
        Me.SaldoRestante.HeaderText = "Saldo Restante"
        Me.SaldoRestante.Name = "SaldoRestante"
        Me.SaldoRestante.ReadOnly = True
        Me.SaldoRestante.Width = 130
        '
        'Fornecedor
        '
        Me.Fornecedor.DataPropertyName = "id_fornecedor"
        Me.Fornecedor.HeaderText = "Fornecedor"
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.ReadOnly = True
        Me.Fornecedor.Width = 70
        '
        'Conta
        '
        Me.Conta.DataPropertyName = "conta"
        Me.Conta.HeaderText = "Conta"
        Me.Conta.Name = "Conta"
        Me.Conta.ReadOnly = True
        Me.Conta.Width = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbParcelamento)
        Me.GroupBox2.Controls.Add(Me.txtNumeroPacelas)
        Me.GroupBox2.Controls.Add(Me.btGravarParcelas)
        Me.GroupBox2.Controls.Add(Me.btGerarParcelas)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.mskData)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtValorParcelas)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(907, 53)
        Me.GroupBox2.TabIndex = 346
        Me.GroupBox2.TabStop = False
        '
        'rbParcelamento
        '
        Me.rbParcelamento.AutoSize = True
        Me.rbParcelamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbParcelamento.ForeColor = System.Drawing.Color.White
        Me.rbParcelamento.Location = New System.Drawing.Point(9, 17)
        Me.rbParcelamento.Name = "rbParcelamento"
        Me.rbParcelamento.Size = New System.Drawing.Size(81, 22)
        Me.rbParcelamento.TabIndex = 343
        Me.rbParcelamento.TabStop = True
        Me.rbParcelamento.Text = "Parcelar"
        Me.rbParcelamento.UseVisualStyleBackColor = True
        '
        'txtNumeroPacelas
        '
        Me.txtNumeroPacelas.Location = New System.Drawing.Point(147, 19)
        Me.txtNumeroPacelas.Name = "txtNumeroPacelas"
        Me.txtNumeroPacelas.Size = New System.Drawing.Size(57, 20)
        Me.txtNumeroPacelas.TabIndex = 342
        '
        'btGravarParcelas
        '
        Me.btGravarParcelas.BackColor = System.Drawing.Color.Transparent
        Me.btGravarParcelas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGravarParcelas.Enabled = False
        Me.btGravarParcelas.FlatAppearance.BorderSize = 0
        Me.btGravarParcelas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btGravarParcelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btGravarParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGravarParcelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGravarParcelas.ForeColor = System.Drawing.Color.White
        Me.btGravarParcelas.Image = CType(resources.GetObject("btGravarParcelas.Image"), System.Drawing.Image)
        Me.btGravarParcelas.Location = New System.Drawing.Point(748, 12)
        Me.btGravarParcelas.Margin = New System.Windows.Forms.Padding(5)
        Me.btGravarParcelas.Name = "btGravarParcelas"
        Me.btGravarParcelas.Size = New System.Drawing.Size(150, 33)
        Me.btGravarParcelas.TabIndex = 336
        Me.btGravarParcelas.Text = "Gravar Parcelas"
        Me.btGravarParcelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btGravarParcelas.UseVisualStyleBackColor = False
        '
        'btGerarParcelas
        '
        Me.btGerarParcelas.BackColor = System.Drawing.Color.Transparent
        Me.btGerarParcelas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGerarParcelas.Enabled = False
        Me.btGerarParcelas.FlatAppearance.BorderSize = 0
        Me.btGerarParcelas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btGerarParcelas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btGerarParcelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerarParcelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerarParcelas.ForeColor = System.Drawing.Color.White
        Me.btGerarParcelas.Image = CType(resources.GetObject("btGerarParcelas.Image"), System.Drawing.Image)
        Me.btGerarParcelas.Location = New System.Drawing.Point(649, 11)
        Me.btGerarParcelas.Margin = New System.Windows.Forms.Padding(5)
        Me.btGerarParcelas.Name = "btGerarParcelas"
        Me.btGerarParcelas.Size = New System.Drawing.Size(97, 35)
        Me.btGerarParcelas.TabIndex = 335
        Me.btGerarParcelas.Text = "Parcelar"
        Me.btGerarParcelas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btGerarParcelas.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(99, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 319
        Me.Label7.Text = "Qtd.:"
        '
        'mskData
        '
        Me.mskData.Enabled = False
        Me.mskData.Location = New System.Drawing.Point(554, 20)
        Me.mskData.Mask = "00/00/0000"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(76, 20)
        Me.mskData.TabIndex = 329
        Me.mskData.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(502, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 20)
        Me.Label11.TabIndex = 306
        Me.Label11.Text = "Data.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(215, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 20)
        Me.Label10.TabIndex = 321
        Me.Label10.Text = "Valor a Parcelar.:"
        '
        'txtValorParcelas
        '
        Me.txtValorParcelas.Enabled = False
        Me.txtValorParcelas.Location = New System.Drawing.Point(344, 19)
        Me.txtValorParcelas.Name = "txtValorParcelas"
        Me.txtValorParcelas.Size = New System.Drawing.Size(136, 20)
        Me.txtValorParcelas.TabIndex = 320
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSaldoRestante)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtJuros)
        Me.GroupBox1.Controls.Add(Me.txtDesconto)
        Me.GroupBox1.Controls.Add(Me.txtDataEntrada)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblPago)
        Me.GroupBox1.Controls.Add(Me.lblCodigoConta)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtVencimento)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.txtSituacao)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtConta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtNDoc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFornecedor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFormaPagto)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(926, 106)
        Me.GroupBox1.TabIndex = 345
        Me.GroupBox1.TabStop = False
        '
        'txtSaldoRestante
        '
        Me.txtSaldoRestante.Location = New System.Drawing.Point(680, 73)
        Me.txtSaldoRestante.Name = "txtSaldoRestante"
        Me.txtSaldoRestante.Size = New System.Drawing.Size(121, 20)
        Me.txtSaldoRestante.TabIndex = 379
        Me.txtSaldoRestante.Text = "0"
        Me.txtSaldoRestante.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(681, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 378
        Me.Label2.Text = "Saldo Restante"
        Me.Label2.Visible = False
        '
        'txtJuros
        '
        Me.txtJuros.Location = New System.Drawing.Point(603, 74)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Size = New System.Drawing.Size(60, 20)
        Me.txtJuros.TabIndex = 377
        Me.txtJuros.Text = "0"
        Me.txtJuros.Visible = False
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(516, 74)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(71, 20)
        Me.txtDesconto.TabIndex = 322
        Me.txtDesconto.Text = "0"
        Me.txtDesconto.Visible = False
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
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = True
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(876, 60)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(35, 15)
        Me.txtCodigo.TabIndex = 310
        Me.txtCodigo.Text = "Novo"
        '
        'lblPago
        '
        Me.lblPago.AutoSize = True
        Me.lblPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPago.ForeColor = System.Drawing.Color.White
        Me.lblPago.Location = New System.Drawing.Point(810, 79)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(14, 15)
        Me.lblPago.TabIndex = 331
        Me.lblPago.Text = "0"
        '
        'lblCodigoConta
        '
        Me.lblCodigoConta.AutoSize = True
        Me.lblCodigoConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoConta.ForeColor = System.Drawing.Color.White
        Me.lblCodigoConta.Location = New System.Drawing.Point(897, 81)
        Me.lblCodigoConta.Name = "lblCodigoConta"
        Me.lblCodigoConta.Size = New System.Drawing.Size(14, 15)
        Me.lblCodigoConta.TabIndex = 330
        Me.lblCodigoConta.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(516, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 20)
        Me.Label12.TabIndex = 323
        Me.Label12.Text = "Desconto"
        Me.Label12.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(5, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 20)
        Me.Label18.TabIndex = 344
        Me.Label18.Text = "Dt Entrada"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(604, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 20)
        Me.Label14.TabIndex = 325
        Me.Label14.Text = "Juros"
        Me.Label14.Visible = False
        '
        'txtVencimento
        '
        Me.txtVencimento.Location = New System.Drawing.Point(250, 73)
        Me.txtVencimento.Mask = "00/00/0000"
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(87, 20)
        Me.txtVencimento.TabIndex = 297
        Me.txtVencimento.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(104, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 301
        Me.Label5.Text = "Valor Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(248, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 303
        Me.Label6.Text = "Vencimento"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(100, 73)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(130, 20)
        Me.txtValor.TabIndex = 299
        '
        'txtSituacao
        '
        Me.txtSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSituacao.FormattingEnabled = True
        Me.txtSituacao.Items.AddRange(New Object() {"Paga", "Não Paga", "Vencida", "Pendente"})
        Me.txtSituacao.Location = New System.Drawing.Point(357, 72)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(148, 21)
        Me.txtSituacao.TabIndex = 298
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(361, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 307
        Me.Label13.Text = "Situação"
        '
        'txtConta
        '
        Me.txtConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtConta.FormattingEnabled = True
        Me.txtConta.Location = New System.Drawing.Point(174, 29)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(192, 21)
        Me.txtConta.TabIndex = 294
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(391, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 302
        Me.Label4.Text = "Fornecedor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(174, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 304
        Me.Label9.Text = "Tipo Conta"
        '
        'txtNDoc
        '
        Me.txtNDoc.Location = New System.Drawing.Point(4, 30)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(164, 20)
        Me.txtNDoc.TabIndex = 296
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 305
        Me.Label3.Text = "N° Docto"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFornecedor.FormattingEnabled = True
        Me.txtFornecedor.Location = New System.Drawing.Point(372, 29)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(405, 21)
        Me.txtFornecedor.TabIndex = 309
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(794, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 315
        Me.Label1.Text = "Forma de Pagto"
        '
        'txtFormaPagto
        '
        Me.txtFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFormaPagto.FormattingEnabled = True
        Me.txtFormaPagto.Location = New System.Drawing.Point(798, 30)
        Me.txtFormaPagto.Name = "txtFormaPagto"
        Me.txtFormaPagto.Size = New System.Drawing.Size(102, 21)
        Me.txtFormaPagto.TabIndex = 313
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.btSair)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 47)
        Me.Panel2.TabIndex = 328
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
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(95, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(509, 28)
        Me.Label16.TabIndex = 258
        Me.Label16.Text = "PARCELAMENTO DE CONTAS A PAGAR"
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
        Me.btSair.Location = New System.Drawing.Point(827, 1)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(93, 36)
        Me.btSair.TabIndex = 13
        Me.btSair.Text = "Voltar"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'frmLancamentoContasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1039, 680)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLancamentoContasPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   "
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtNumeroPacelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFormaPagto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btSair As Button
    Friend WithEvents txtCodigo As Label
    Friend WithEvents txtFornecedor As ComboBox
    Friend WithEvents txtConta As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSituacao As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents mskData As MaskedTextBox
    Friend WithEvents lblCodigoConta As Label
    Friend WithEvents lblPago As Label
    Friend WithEvents btGerarParcelas As Button
    Friend WithEvents dgvParcelas As DataGridView
    Friend WithEvents btGravarParcelas As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtValorParcelas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNumeroPacelas As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents Label12 As Label
    Public WithEvents txtVencimento As MaskedTextBox
    Public WithEvents txtDataEntrada As MaskedTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtJuros As TextBox
    Friend WithEvents rbParcelamento As RadioButton
    Friend WithEvents txtSaldoRestante As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents id_parcela As DataGridViewTextBoxColumn
    Friend WithEvents parcela As DataGridViewTextBoxColumn
    Friend WithEvents data_parcela As DataGridViewTextBoxColumn
    Friend WithEvents valor_parcela As DataGridViewTextBoxColumn
    Friend WithEvents numDocto As DataGridViewTextBoxColumn
    Friend WithEvents pago As DataGridViewTextBoxColumn
    Friend WithEvents valorTotal As DataGridViewTextBoxColumn
    Friend WithEvents situacao As DataGridViewTextBoxColumn
    Friend WithEvents SaldoRestante As DataGridViewTextBoxColumn
    Friend WithEvents Fornecedor As DataGridViewTextBoxColumn
    Friend WithEvents Conta As DataGridViewTextBoxColumn
End Class
