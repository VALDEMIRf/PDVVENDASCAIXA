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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLancamentoContasPagar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Parcelamento = New System.Windows.Forms.TabPage()
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
        Me.dgvParcelas = New System.Windows.Forms.DataGridView()
        Me.id_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numDocto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoRestante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaixarParcela = New System.Windows.Forms.TabPage()
        Me.btEnviarDadosBaixar = New System.Windows.Forms.Button()
        Me.dgvBaixarConta = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSaldoRestante = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJuros = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.txtDataEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodigo = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtSituacao = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtConta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btConta = New System.Windows.Forms.Button()
        Me.btFornecedor = New System.Windows.Forms.Button()
        Me.txtFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFormaPagto = New System.Windows.Forms.ComboBox()
        Me.btFormaPagto = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Parcelamento.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtNumeroPacelas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BaixarParcela.SuspendLayout()
        CType(Me.dgvBaixarConta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(938, 673)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Parcelamento)
        Me.TabControl1.Controls.Add(Me.BaixarParcela)
        Me.TabControl1.Location = New System.Drawing.Point(3, 213)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(927, 437)
        Me.TabControl1.TabIndex = 347
        '
        'Parcelamento
        '
        Me.Parcelamento.BackColor = System.Drawing.Color.SteelBlue
        Me.Parcelamento.Controls.Add(Me.GroupBox2)
        Me.Parcelamento.Controls.Add(Me.dgvParcelas)
        Me.Parcelamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parcelamento.Location = New System.Drawing.Point(4, 22)
        Me.Parcelamento.Name = "Parcelamento"
        Me.Parcelamento.Padding = New System.Windows.Forms.Padding(3)
        Me.Parcelamento.Size = New System.Drawing.Size(919, 411)
        Me.Parcelamento.TabIndex = 0
        Me.Parcelamento.Text = "Parcelamento"
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
        Me.GroupBox2.Location = New System.Drawing.Point(5, 6)
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
        Me.rbParcelamento.Location = New System.Drawing.Point(9, 21)
        Me.rbParcelamento.Name = "rbParcelamento"
        Me.rbParcelamento.Size = New System.Drawing.Size(81, 22)
        Me.rbParcelamento.TabIndex = 343
        Me.rbParcelamento.TabStop = True
        Me.rbParcelamento.Text = "Parcelar"
        Me.rbParcelamento.UseVisualStyleBackColor = True
        '
        'txtNumeroPacelas
        '
        Me.txtNumeroPacelas.Location = New System.Drawing.Point(172, 16)
        Me.txtNumeroPacelas.Name = "txtNumeroPacelas"
        Me.txtNumeroPacelas.Size = New System.Drawing.Size(57, 26)
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
        Me.btGravarParcelas.Location = New System.Drawing.Point(748, 13)
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
        Me.btGerarParcelas.Location = New System.Drawing.Point(644, 13)
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
        Me.Label7.Location = New System.Drawing.Point(125, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 319
        Me.Label7.Text = "Qtd.:"
        '
        'mskData
        '
        Me.mskData.Enabled = False
        Me.mskData.Location = New System.Drawing.Point(538, 16)
        Me.mskData.Mask = "00/00/0000"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(98, 26)
        Me.mskData.TabIndex = 329
        Me.mskData.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(488, 19)
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
        Me.Label10.Location = New System.Drawing.Point(235, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 20)
        Me.Label10.TabIndex = 321
        Me.Label10.Text = "Valor a Parcelar.:"
        '
        'txtValorParcelas
        '
        Me.txtValorParcelas.Enabled = False
        Me.txtValorParcelas.Location = New System.Drawing.Point(363, 16)
        Me.txtValorParcelas.Name = "txtValorParcelas"
        Me.txtValorParcelas.Size = New System.Drawing.Size(117, 26)
        Me.txtValorParcelas.TabIndex = 320
        '
        'dgvParcelas
        '
        Me.dgvParcelas.AllowUserToAddRows = False
        Me.dgvParcelas.AllowUserToDeleteRows = False
        Me.dgvParcelas.BackgroundColor = System.Drawing.Color.White
        Me.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParcelas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_parcela, Me.parcela, Me.data_parcela, Me.valor_parcela, Me.numDocto, Me.descricao, Me.valorTotal, Me.situacao, Me.SaldoRestante})
        Me.dgvParcelas.GridColor = System.Drawing.Color.DarkBlue
        Me.dgvParcelas.Location = New System.Drawing.Point(3, 63)
        Me.dgvParcelas.Name = "dgvParcelas"
        Me.dgvParcelas.ReadOnly = True
        Me.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParcelas.Size = New System.Drawing.Size(909, 323)
        Me.dgvParcelas.TabIndex = 334
        '
        'id_parcela
        '
        Me.id_parcela.DataPropertyName = "id_parcela"
        Me.id_parcela.HeaderText = "id_parcela"
        Me.id_parcela.Name = "id_parcela"
        Me.id_parcela.ReadOnly = True
        Me.id_parcela.Visible = False
        Me.id_parcela.Width = 130
        '
        'parcela
        '
        Me.parcela.DataPropertyName = "parcela"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.parcela.DefaultCellStyle = DataGridViewCellStyle1
        Me.parcela.HeaderText = "parcela"
        Me.parcela.Name = "parcela"
        Me.parcela.ReadOnly = True
        '
        'data_parcela
        '
        Me.data_parcela.DataPropertyName = "data_parcela"
        Me.data_parcela.HeaderText = "data_parcela"
        Me.data_parcela.Name = "data_parcela"
        Me.data_parcela.ReadOnly = True
        Me.data_parcela.Width = 150
        '
        'valor_parcela
        '
        Me.valor_parcela.DataPropertyName = "valor_parcela"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.valor_parcela.DefaultCellStyle = DataGridViewCellStyle2
        Me.valor_parcela.HeaderText = "valor_parcela"
        Me.valor_parcela.Name = "valor_parcela"
        Me.valor_parcela.ReadOnly = True
        Me.valor_parcela.Width = 150
        '
        'numDocto
        '
        Me.numDocto.DataPropertyName = "numDocto"
        Me.numDocto.HeaderText = "numDocto"
        Me.numDocto.Name = "numDocto"
        Me.numDocto.ReadOnly = True
        Me.numDocto.Width = 180
        '
        'descricao
        '
        Me.descricao.DataPropertyName = "descricao"
        Me.descricao.HeaderText = "descricao"
        Me.descricao.Name = "descricao"
        Me.descricao.ReadOnly = True
        Me.descricao.Width = 200
        '
        'valorTotal
        '
        Me.valorTotal.DataPropertyName = "valorTotal"
        Me.valorTotal.HeaderText = "valorTotal"
        Me.valorTotal.Name = "valorTotal"
        Me.valorTotal.ReadOnly = True
        Me.valorTotal.Width = 150
        '
        'situacao
        '
        Me.situacao.DataPropertyName = "situacao"
        Me.situacao.HeaderText = "situacao"
        Me.situacao.Name = "situacao"
        Me.situacao.ReadOnly = True
        Me.situacao.Width = 160
        '
        'SaldoRestante
        '
        Me.SaldoRestante.DataPropertyName = "SaldoRestante"
        Me.SaldoRestante.HeaderText = "Saldo Restante"
        Me.SaldoRestante.Name = "SaldoRestante"
        Me.SaldoRestante.ReadOnly = True
        Me.SaldoRestante.Width = 150
        '
        'BaixarParcela
        '
        Me.BaixarParcela.BackColor = System.Drawing.Color.SteelBlue
        Me.BaixarParcela.Controls.Add(Me.btEnviarDadosBaixar)
        Me.BaixarParcela.Controls.Add(Me.dgvBaixarConta)
        Me.BaixarParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaixarParcela.Location = New System.Drawing.Point(4, 22)
        Me.BaixarParcela.Name = "BaixarParcela"
        Me.BaixarParcela.Padding = New System.Windows.Forms.Padding(3)
        Me.BaixarParcela.Size = New System.Drawing.Size(919, 411)
        Me.BaixarParcela.TabIndex = 1
        Me.BaixarParcela.Text = "Baixar Parcela"
        '
        'btEnviarDadosBaixar
        '
        Me.btEnviarDadosBaixar.BackColor = System.Drawing.Color.Transparent
        Me.btEnviarDadosBaixar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEnviarDadosBaixar.FlatAppearance.BorderSize = 0
        Me.btEnviarDadosBaixar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btEnviarDadosBaixar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btEnviarDadosBaixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEnviarDadosBaixar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEnviarDadosBaixar.ForeColor = System.Drawing.Color.White
        Me.btEnviarDadosBaixar.Image = CType(resources.GetObject("btEnviarDadosBaixar.Image"), System.Drawing.Image)
        Me.btEnviarDadosBaixar.Location = New System.Drawing.Point(14, 9)
        Me.btEnviarDadosBaixar.Margin = New System.Windows.Forms.Padding(5)
        Me.btEnviarDadosBaixar.Name = "btEnviarDadosBaixar"
        Me.btEnviarDadosBaixar.Size = New System.Drawing.Size(148, 35)
        Me.btEnviarDadosBaixar.TabIndex = 348
        Me.btEnviarDadosBaixar.Text = "Baixar Parcela"
        Me.btEnviarDadosBaixar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEnviarDadosBaixar.UseVisualStyleBackColor = False
        '
        'dgvBaixarConta
        '
        Me.dgvBaixarConta.AllowUserToAddRows = False
        Me.dgvBaixarConta.AllowUserToDeleteRows = False
        Me.dgvBaixarConta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvBaixarConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaixarConta.GridColor = System.Drawing.Color.DarkBlue
        Me.dgvBaixarConta.Location = New System.Drawing.Point(2, 55)
        Me.dgvBaixarConta.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgvBaixarConta.Name = "dgvBaixarConta"
        Me.dgvBaixarConta.ReadOnly = True
        Me.dgvBaixarConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBaixarConta.Size = New System.Drawing.Size(909, 350)
        Me.dgvBaixarConta.TabIndex = 321
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSaldoRestante)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtJuros)
        Me.GroupBox1.Controls.Add(Me.txtDesconto)
        Me.GroupBox1.Controls.Add(Me.txtDataEntrada)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.lblDesconto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtVencimento)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.txtSituacao)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtConta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtNDoc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btConta)
        Me.GroupBox1.Controls.Add(Me.btFornecedor)
        Me.GroupBox1.Controls.Add(Me.txtFornecedor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFormaPagto)
        Me.GroupBox1.Controls.Add(Me.btFormaPagto)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(926, 161)
        Me.GroupBox1.TabIndex = 345
        Me.GroupBox1.TabStop = False
        '
        'txtSaldoRestante
        '
        Me.txtSaldoRestante.Location = New System.Drawing.Point(634, 126)
        Me.txtSaldoRestante.Name = "txtSaldoRestante"
        Me.txtSaldoRestante.Size = New System.Drawing.Size(121, 20)
        Me.txtSaldoRestante.TabIndex = 379
        Me.txtSaldoRestante.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(635, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 378
        Me.Label2.Text = "Saldo Restante"
        '
        'txtJuros
        '
        Me.txtJuros.Location = New System.Drawing.Point(509, 127)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Size = New System.Drawing.Size(60, 20)
        Me.txtJuros.TabIndex = 377
        Me.txtJuros.Text = "0"
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(422, 127)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(71, 20)
        Me.txtDesconto.TabIndex = 322
        Me.txtDesconto.Text = "0"
        '
        'txtDataEntrada
        '
        Me.txtDataEntrada.Location = New System.Drawing.Point(252, 79)
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
        Me.txtCodigo.Location = New System.Drawing.Point(94, 16)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(35, 15)
        Me.txtCodigo.TabIndex = 310
        Me.txtCodigo.Text = "Novo"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.ForeColor = System.Drawing.Color.White
        Me.lblValor.Location = New System.Drawing.Point(96, 33)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(14, 15)
        Me.lblValor.TabIndex = 331
        Me.lblValor.Text = "0"
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesconto.ForeColor = System.Drawing.Color.White
        Me.lblDesconto.Location = New System.Drawing.Point(119, 35)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(14, 15)
        Me.lblDesconto.TabIndex = 330
        Me.lblDesconto.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(422, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 20)
        Me.Label12.TabIndex = 323
        Me.Label12.Text = "Desconto"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(252, 61)
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
        Me.Label14.Location = New System.Drawing.Point(510, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 20)
        Me.Label14.TabIndex = 325
        Me.Label14.Text = "Juros"
        '
        'txtVencimento
        '
        Me.txtVencimento.Location = New System.Drawing.Point(256, 126)
        Me.txtVencimento.Mask = "00/00/0000"
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(87, 20)
        Me.txtVencimento.TabIndex = 297
        Me.txtVencimento.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(416, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 300
        Me.Label8.Text = "Descrição"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 301
        Me.Label5.Text = "Valor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(254, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 303
        Me.Label6.Text = "Vencimento"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(416, 79)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(353, 20)
        Me.txtDescricao.TabIndex = 293
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(8, 128)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(74, 20)
        Me.txtValor.TabIndex = 299
        '
        'txtSituacao
        '
        Me.txtSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSituacao.FormattingEnabled = True
        Me.txtSituacao.Items.AddRange(New Object() {"Paga", "Não Paga", "Vencida", "Pendente"})
        Me.txtSituacao.Location = New System.Drawing.Point(88, 126)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(148, 21)
        Me.txtSituacao.TabIndex = 298
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(92, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 307
        Me.Label13.Text = "Situação"
        '
        'txtConta
        '
        Me.txtConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtConta.FormattingEnabled = True
        Me.txtConta.Location = New System.Drawing.Point(139, 30)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(189, 21)
        Me.txtConta.TabIndex = 294
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(414, 13)
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
        Me.Label9.Location = New System.Drawing.Point(139, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 304
        Me.Label9.Text = "Tipo Conta"
        '
        'txtNDoc
        '
        Me.txtNDoc.Location = New System.Drawing.Point(4, 30)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(86, 20)
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
        'btConta
        '
        Me.btConta.BackColor = System.Drawing.Color.Transparent
        Me.btConta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btConta.FlatAppearance.BorderSize = 0
        Me.btConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConta.ForeColor = System.Drawing.Color.White
        Me.btConta.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Create
        Me.btConta.Location = New System.Drawing.Point(339, 27)
        Me.btConta.Margin = New System.Windows.Forms.Padding(5)
        Me.btConta.Name = "btConta"
        Me.btConta.Size = New System.Drawing.Size(35, 27)
        Me.btConta.TabIndex = 295
        Me.btConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btConta.UseVisualStyleBackColor = False
        '
        'btFornecedor
        '
        Me.btFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.btFornecedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFornecedor.FlatAppearance.BorderSize = 0
        Me.btFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFornecedor.ForeColor = System.Drawing.Color.White
        Me.btFornecedor.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Create
        Me.btFornecedor.Location = New System.Drawing.Point(753, 28)
        Me.btFornecedor.Margin = New System.Windows.Forms.Padding(5)
        Me.btFornecedor.Name = "btFornecedor"
        Me.btFornecedor.Size = New System.Drawing.Size(35, 27)
        Me.btFornecedor.TabIndex = 308
        Me.btFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFornecedor.UseVisualStyleBackColor = False
        '
        'txtFornecedor
        '
        Me.txtFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFornecedor.FormattingEnabled = True
        Me.txtFornecedor.Location = New System.Drawing.Point(416, 33)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(332, 21)
        Me.txtFornecedor.TabIndex = 309
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 315
        Me.Label1.Text = "Forma de Pagto"
        '
        'txtFormaPagto
        '
        Me.txtFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFormaPagto.FormattingEnabled = True
        Me.txtFormaPagto.Location = New System.Drawing.Point(7, 78)
        Me.txtFormaPagto.Name = "txtFormaPagto"
        Me.txtFormaPagto.Size = New System.Drawing.Size(176, 21)
        Me.txtFormaPagto.TabIndex = 313
        '
        'btFormaPagto
        '
        Me.btFormaPagto.BackColor = System.Drawing.Color.Transparent
        Me.btFormaPagto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFormaPagto.FlatAppearance.BorderSize = 0
        Me.btFormaPagto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btFormaPagto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btFormaPagto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFormaPagto.ForeColor = System.Drawing.Color.White
        Me.btFormaPagto.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Create
        Me.btFormaPagto.Location = New System.Drawing.Point(185, 75)
        Me.btFormaPagto.Margin = New System.Windows.Forms.Padding(5)
        Me.btFormaPagto.Name = "btFormaPagto"
        Me.btFormaPagto.Size = New System.Drawing.Size(35, 27)
        Me.btFormaPagto.TabIndex = 314
        Me.btFormaPagto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFormaPagto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFormaPagto.UseVisualStyleBackColor = False
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
        Me.Panel2.Size = New System.Drawing.Size(938, 47)
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
        Me.btSair.Location = New System.Drawing.Point(655, 3)
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
        Me.ClientSize = New System.Drawing.Size(948, 680)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLancamentoContasPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   "
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Parcelamento.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtNumeroPacelas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BaixarParcela.ResumeLayout(False)
        CType(Me.dgvBaixarConta, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btFormaPagto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btSair As Button
    Friend WithEvents txtCodigo As Label
    Friend WithEvents txtFornecedor As ComboBox
    Friend WithEvents btFornecedor As Button
    Friend WithEvents txtConta As ComboBox
    Friend WithEvents btConta As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSituacao As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents mskData As MaskedTextBox
    Friend WithEvents lblDesconto As Label
    Friend WithEvents lblValor As Label
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Parcelamento As TabPage
    Friend WithEvents BaixarParcela As TabPage
    Friend WithEvents dgvBaixarConta As DataGridView
    Friend WithEvents txtSaldoRestante As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents id_parcela As DataGridViewTextBoxColumn
    Friend WithEvents parcela As DataGridViewTextBoxColumn
    Friend WithEvents data_parcela As DataGridViewTextBoxColumn
    Friend WithEvents valor_parcela As DataGridViewTextBoxColumn
    Friend WithEvents numDocto As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents valorTotal As DataGridViewTextBoxColumn
    Friend WithEvents situacao As DataGridViewTextBoxColumn
    Friend WithEvents SaldoRestante As DataGridViewTextBoxColumn
    Friend WithEvents btEnviarDadosBaixar As Button
End Class
