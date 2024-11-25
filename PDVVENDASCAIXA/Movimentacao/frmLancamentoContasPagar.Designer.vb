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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvListaparcelas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblRecebeVencimento = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtValoraPagar = New System.Windows.Forms.Label()
        Me.lblRecebeNumParcela = New System.Windows.Forms.Label()
        Me.lblCodigoParcela = New System.Windows.Forms.Label()
        Me.btBaixarConta = New System.Windows.Forms.Button()
        Me.lblRecebeJuros = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblRecebeValorParcela = New System.Windows.Forms.Label()
        Me.lblSaldoRestante = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mskDataPagto = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
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
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtJuros = New System.Windows.Forms.TextBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.txtDataEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.txtCodigo = New System.Windows.Forms.Label()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.dgvParcelas = New System.Windows.Forms.DataGridView()
        Me.id_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numDocto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvListaparcelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtNumeroPacelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.dgvListaparcelas)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.dgvParcelas)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 630)
        Me.Panel1.TabIndex = 0
        '
        'dgvListaparcelas
        '
        Me.dgvListaparcelas.AllowUserToAddRows = False
        Me.dgvListaparcelas.AllowUserToDeleteRows = False
        Me.dgvListaparcelas.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaparcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaparcelas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgvListaparcelas.GridColor = System.Drawing.Color.DarkBlue
        Me.dgvListaparcelas.Location = New System.Drawing.Point(377, 54)
        Me.dgvListaparcelas.Name = "dgvListaparcelas"
        Me.dgvListaparcelas.ReadOnly = True
        Me.dgvListaparcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaparcelas.Size = New System.Drawing.Size(817, 276)
        Me.dgvListaparcelas.TabIndex = 378
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_parcela"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_parcela"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "parcela"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.HeaderText = "parcela"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "data_parcela"
        Me.DataGridViewTextBoxColumn3.HeaderText = "data_parcela"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "valor_parcela"
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "valor_parcela"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "numDocto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "numDocto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "descricao"
        Me.DataGridViewTextBoxColumn6.HeaderText = "descricao"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "valorTotal"
        Me.DataGridViewTextBoxColumn7.HeaderText = "valorTotal"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "situacao"
        Me.DataGridViewTextBoxColumn8.HeaderText = "situacao"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblRecebeVencimento)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtValoraPagar)
        Me.GroupBox3.Controls.Add(Me.lblRecebeNumParcela)
        Me.GroupBox3.Controls.Add(Me.lblCodigoParcela)
        Me.GroupBox3.Controls.Add(Me.btBaixarConta)
        Me.GroupBox3.Controls.Add(Me.lblRecebeJuros)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.lblRecebeValorParcela)
        Me.GroupBox3.Controls.Add(Me.lblSaldoRestante)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.btCalcular)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.mskDataPagto)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(825, 398)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 228)
        Me.GroupBox3.TabIndex = 377
        Me.GroupBox3.TabStop = False
        '
        'lblRecebeVencimento
        '
        Me.lblRecebeVencimento.AutoSize = True
        Me.lblRecebeVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecebeVencimento.ForeColor = System.Drawing.Color.White
        Me.lblRecebeVencimento.Location = New System.Drawing.Point(100, 78)
        Me.lblRecebeVencimento.Name = "lblRecebeVencimento"
        Me.lblRecebeVencimento.Size = New System.Drawing.Size(16, 18)
        Me.lblRecebeVencimento.TabIndex = 381
        Me.lblRecebeVencimento.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(83, 60)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 18)
        Me.Label25.TabIndex = 380
        Me.Label25.Text = "Data Pgto"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(4, 103)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(365, 5)
        Me.Panel3.TabIndex = 379
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(284, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 20)
        Me.Label20.TabIndex = 377
        Me.Label20.Text = "Juros"
        '
        'txtValoraPagar
        '
        Me.txtValoraPagar.AutoSize = True
        Me.txtValoraPagar.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValoraPagar.ForeColor = System.Drawing.Color.Red
        Me.txtValoraPagar.Location = New System.Drawing.Point(42, 139)
        Me.txtValoraPagar.Name = "txtValoraPagar"
        Me.txtValoraPagar.Size = New System.Drawing.Size(41, 23)
        Me.txtValoraPagar.TabIndex = 375
        Me.txtValoraPagar.Text = "0,00"
        '
        'lblRecebeNumParcela
        '
        Me.lblRecebeNumParcela.AutoSize = True
        Me.lblRecebeNumParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecebeNumParcela.ForeColor = System.Drawing.Color.White
        Me.lblRecebeNumParcela.Location = New System.Drawing.Point(26, 78)
        Me.lblRecebeNumParcela.Name = "lblRecebeNumParcela"
        Me.lblRecebeNumParcela.Size = New System.Drawing.Size(16, 18)
        Me.lblRecebeNumParcela.TabIndex = 369
        Me.lblRecebeNumParcela.Text = "0"
        '
        'lblCodigoParcela
        '
        Me.lblCodigoParcela.AutoSize = True
        Me.lblCodigoParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoParcela.ForeColor = System.Drawing.Color.White
        Me.lblCodigoParcela.Location = New System.Drawing.Point(21, 185)
        Me.lblCodigoParcela.Name = "lblCodigoParcela"
        Me.lblCodigoParcela.Size = New System.Drawing.Size(18, 20)
        Me.lblCodigoParcela.TabIndex = 345
        Me.lblCodigoParcela.Text = "0"
        Me.lblCodigoParcela.Visible = False
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
        Me.btBaixarConta.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Fall
        Me.btBaixarConta.Location = New System.Drawing.Point(184, 178)
        Me.btBaixarConta.Margin = New System.Windows.Forms.Padding(5)
        Me.btBaixarConta.Name = "btBaixarConta"
        Me.btBaixarConta.Size = New System.Drawing.Size(129, 35)
        Me.btBaixarConta.TabIndex = 371
        Me.btBaixarConta.Text = "Baixar Conta"
        Me.btBaixarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btBaixarConta.UseVisualStyleBackColor = False
        '
        'lblRecebeJuros
        '
        Me.lblRecebeJuros.AutoSize = True
        Me.lblRecebeJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecebeJuros.ForeColor = System.Drawing.Color.White
        Me.lblRecebeJuros.Location = New System.Drawing.Point(298, 78)
        Me.lblRecebeJuros.Name = "lblRecebeJuros"
        Me.lblRecebeJuros.Size = New System.Drawing.Size(18, 20)
        Me.lblRecebeJuros.TabIndex = 332
        Me.lblRecebeJuros.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(6, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 18)
        Me.Label21.TabIndex = 365
        Me.Label21.Text = "Parcela"
        '
        'lblRecebeValorParcela
        '
        Me.lblRecebeValorParcela.AutoSize = True
        Me.lblRecebeValorParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecebeValorParcela.ForeColor = System.Drawing.Color.White
        Me.lblRecebeValorParcela.Location = New System.Drawing.Point(193, 78)
        Me.lblRecebeValorParcela.Name = "lblRecebeValorParcela"
        Me.lblRecebeValorParcela.Size = New System.Drawing.Size(16, 18)
        Me.lblRecebeValorParcela.TabIndex = 370
        Me.lblRecebeValorParcela.Text = "0"
        '
        'lblSaldoRestante
        '
        Me.lblSaldoRestante.AutoSize = True
        Me.lblSaldoRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoRestante.ForeColor = System.Drawing.Color.Maroon
        Me.lblSaldoRestante.Location = New System.Drawing.Point(227, 139)
        Me.lblSaldoRestante.Name = "lblSaldoRestante"
        Me.lblSaldoRestante.Size = New System.Drawing.Size(49, 24)
        Me.lblSaldoRestante.TabIndex = 373
        Me.lblSaldoRestante.Text = "0,00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(167, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 18)
        Me.Label19.TabIndex = 368
        Me.Label19.Text = "Valor Parcela"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Maroon
        Me.Label22.Location = New System.Drawing.Point(192, 113)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 24)
        Me.Label22.TabIndex = 372
        Me.Label22.Text = "Saldo Total"
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
        Me.btCalcular.Location = New System.Drawing.Point(169, 19)
        Me.btCalcular.Margin = New System.Windows.Forms.Padding(5)
        Me.btCalcular.Name = "btCalcular"
        Me.btCalcular.Size = New System.Drawing.Size(98, 34)
        Me.btCalcular.TabIndex = 374
        Me.btCalcular.Text = "Calcular"
        Me.btCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btCalcular.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(7, 114)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 23)
        Me.Label15.TabIndex = 327
        Me.Label15.Text = "Valor a Pagar"
        '
        'mskDataPagto
        '
        Me.mskDataPagto.Location = New System.Drawing.Point(11, 33)
        Me.mskDataPagto.Mask = "00/00/0000"
        Me.mskDataPagto.Name = "mskDataPagto"
        Me.mskDataPagto.Size = New System.Drawing.Size(87, 20)
        Me.mskDataPagto.TabIndex = 340
        Me.mskDataPagto.ValidatingType = GetType(Date)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(8, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 20)
        Me.Label17.TabIndex = 339
        Me.Label17.Text = "Dt Pagto"
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
        Me.GroupBox2.Location = New System.Drawing.Point(382, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(812, 53)
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
        Me.rbParcelamento.Size = New System.Drawing.Size(145, 22)
        Me.rbParcelamento.TabIndex = 343
        Me.rbParcelamento.TabStop = True
        Me.rbParcelamento.Text = "Em Parcelamento"
        Me.rbParcelamento.UseVisualStyleBackColor = True
        '
        'txtNumeroPacelas
        '
        Me.txtNumeroPacelas.Location = New System.Drawing.Point(166, 29)
        Me.txtNumeroPacelas.Name = "txtNumeroPacelas"
        Me.txtNumeroPacelas.Size = New System.Drawing.Size(58, 20)
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
        Me.btGravarParcelas.Location = New System.Drawing.Point(636, 12)
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
        Me.btGerarParcelas.Location = New System.Drawing.Point(539, 13)
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
        Me.Label7.Location = New System.Drawing.Point(161, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 319
        Me.Label7.Text = "Parcelas"
        '
        'mskData
        '
        Me.mskData.Enabled = False
        Me.mskData.Location = New System.Drawing.Point(419, 29)
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
        Me.Label11.Location = New System.Drawing.Point(396, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 20)
        Me.Label11.TabIndex = 306
        Me.Label11.Text = "Dt Parcelamento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(253, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 20)
        Me.Label10.TabIndex = 321
        Me.Label10.Text = "Valor a Parcelar"
        '
        'txtValorParcelas
        '
        Me.txtValorParcelas.Enabled = False
        Me.txtValorParcelas.Location = New System.Drawing.Point(257, 29)
        Me.txtValorParcelas.Name = "txtValorParcelas"
        Me.txtValorParcelas.Size = New System.Drawing.Size(121, 20)
        Me.txtValorParcelas.TabIndex = 320
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtValorPago)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtJuros)
        Me.GroupBox1.Controls.Add(Me.btnExcluir)
        Me.GroupBox1.Controls.Add(Me.txtDesconto)
        Me.GroupBox1.Controls.Add(Me.txtDataEntrada)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.btSalvar)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.lblDesconto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.Label2)
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
        Me.GroupBox1.Size = New System.Drawing.Size(370, 347)
        Me.GroupBox1.TabIndex = 345
        Me.GroupBox1.TabStop = False
        '
        'txtValorPago
        '
        Me.txtValorPago.Location = New System.Drawing.Point(162, 239)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(94, 20)
        Me.txtValorPago.TabIndex = 343
        Me.txtValorPago.Text = "0"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(165, 221)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 20)
        Me.Label23.TabIndex = 343
        Me.Label23.Text = "Valor Pago"
        '
        'txtJuros
        '
        Me.txtJuros.Location = New System.Drawing.Point(91, 240)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Size = New System.Drawing.Size(60, 20)
        Me.txtJuros.TabIndex = 377
        Me.txtJuros.Text = "0"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(130, 307)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(84, 38)
        Me.btnExcluir.TabIndex = 12
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(4, 240)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(71, 20)
        Me.txtDesconto.TabIndex = 322
        Me.txtDesconto.Text = "0"
        '
        'txtDataEntrada
        '
        Me.txtDataEntrada.Location = New System.Drawing.Point(4, 200)
        Me.txtDataEntrada.Mask = "00/00/0000"
        Me.txtDataEntrada.Name = "txtDataEntrada"
        Me.txtDataEntrada.Size = New System.Drawing.Size(76, 20)
        Me.txtDataEntrada.TabIndex = 343
        Me.txtDataEntrada.ValidatingType = GetType(Date)
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = True
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(225, 114)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(45, 20)
        Me.txtCodigo.TabIndex = 310
        Me.txtCodigo.Text = "Novo"
        Me.txtCodigo.Visible = False
        '
        'btSalvar
        '
        Me.btSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.FlatAppearance.BorderSize = 0
        Me.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.ForeColor = System.Drawing.Color.White
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.Location = New System.Drawing.Point(12, 306)
        Me.btSalvar.Margin = New System.Windows.Forms.Padding(5)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(108, 37)
        Me.btSalvar.TabIndex = 10
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = False
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.ForeColor = System.Drawing.Color.White
        Me.lblValor.Location = New System.Drawing.Point(294, 114)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(18, 20)
        Me.lblValor.TabIndex = 331
        Me.lblValor.Text = "0"
        Me.lblValor.Visible = False
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesconto.ForeColor = System.Drawing.Color.White
        Me.lblDesconto.Location = New System.Drawing.Point(319, 115)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(18, 20)
        Me.lblDesconto.TabIndex = 330
        Me.lblDesconto.Text = "0"
        Me.lblDesconto.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(4, 221)
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
        Me.Label18.Location = New System.Drawing.Point(4, 182)
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
        Me.Label14.Location = New System.Drawing.Point(92, 221)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 20)
        Me.Label14.TabIndex = 325
        Me.Label14.Text = "Juros"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(3, 283)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(348, 20)
        Me.txtObs.TabIndex = 316
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 317
        Me.Label2.Text = "Obs.:"
        '
        'txtVencimento
        '
        Me.txtVencimento.Location = New System.Drawing.Point(264, 239)
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
        Me.Label8.Location = New System.Drawing.Point(4, 140)
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
        Me.Label5.Location = New System.Drawing.Point(104, 180)
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
        Me.Label6.Location = New System.Drawing.Point(262, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 303
        Me.Label6.Text = "Vencimento"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(4, 160)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(353, 20)
        Me.txtDescricao.TabIndex = 293
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(100, 200)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(74, 20)
        Me.txtValor.TabIndex = 299
        '
        'txtSituacao
        '
        Me.txtSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSituacao.FormattingEnabled = True
        Me.txtSituacao.Items.AddRange(New Object() {"Paga", "Não Paga", "Vencida"})
        Me.txtSituacao.Location = New System.Drawing.Point(180, 198)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(148, 21)
        Me.txtSituacao.TabIndex = 298
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(184, 180)
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
        Me.Label4.Location = New System.Drawing.Point(4, 53)
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
        Me.btConta.Location = New System.Drawing.Point(332, 27)
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
        Me.btFornecedor.Location = New System.Drawing.Point(330, 68)
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
        Me.txtFornecedor.Location = New System.Drawing.Point(6, 73)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(332, 21)
        Me.txtFornecedor.TabIndex = 309
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 315
        Me.Label1.Text = "Forma de Pagto"
        '
        'txtFormaPagto
        '
        Me.txtFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFormaPagto.FormattingEnabled = True
        Me.txtFormaPagto.Location = New System.Drawing.Point(4, 117)
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
        Me.btFormaPagto.Location = New System.Drawing.Point(182, 114)
        Me.btFormaPagto.Margin = New System.Windows.Forms.Padding(5)
        Me.btFormaPagto.Name = "btFormaPagto"
        Me.btFormaPagto.Size = New System.Drawing.Size(35, 27)
        Me.btFormaPagto.TabIndex = 314
        Me.btFormaPagto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFormaPagto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFormaPagto.UseVisualStyleBackColor = False
        '
        'dgvParcelas
        '
        Me.dgvParcelas.AllowUserToAddRows = False
        Me.dgvParcelas.AllowUserToDeleteRows = False
        Me.dgvParcelas.BackgroundColor = System.Drawing.Color.White
        Me.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParcelas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_parcela, Me.parcela, Me.data_parcela, Me.valor_parcela, Me.numDocto, Me.descricao, Me.valorTotal, Me.situacao})
        Me.dgvParcelas.GridColor = System.Drawing.Color.DarkBlue
        Me.dgvParcelas.Location = New System.Drawing.Point(5, 399)
        Me.dgvParcelas.Name = "dgvParcelas"
        Me.dgvParcelas.ReadOnly = True
        Me.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParcelas.Size = New System.Drawing.Size(817, 231)
        Me.dgvParcelas.TabIndex = 334
        '
        'id_parcela
        '
        Me.id_parcela.DataPropertyName = "id_parcela"
        Me.id_parcela.HeaderText = "id_parcela"
        Me.id_parcela.Name = "id_parcela"
        Me.id_parcela.ReadOnly = True
        Me.id_parcela.Visible = False
        '
        'parcela
        '
        Me.parcela.DataPropertyName = "parcela"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.parcela.DefaultCellStyle = DataGridViewCellStyle5
        Me.parcela.HeaderText = "parcela"
        Me.parcela.Name = "parcela"
        Me.parcela.ReadOnly = True
        Me.parcela.Width = 50
        '
        'data_parcela
        '
        Me.data_parcela.DataPropertyName = "data_parcela"
        Me.data_parcela.HeaderText = "data_parcela"
        Me.data_parcela.Name = "data_parcela"
        Me.data_parcela.ReadOnly = True
        Me.data_parcela.Width = 90
        '
        'valor_parcela
        '
        Me.valor_parcela.DataPropertyName = "valor_parcela"
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.valor_parcela.DefaultCellStyle = DataGridViewCellStyle6
        Me.valor_parcela.HeaderText = "valor_parcela"
        Me.valor_parcela.Name = "valor_parcela"
        Me.valor_parcela.ReadOnly = True
        Me.valor_parcela.Width = 80
        '
        'numDocto
        '
        Me.numDocto.DataPropertyName = "numDocto"
        Me.numDocto.HeaderText = "numDocto"
        Me.numDocto.Name = "numDocto"
        Me.numDocto.ReadOnly = True
        Me.numDocto.Width = 150
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
        '
        'situacao
        '
        Me.situacao.DataPropertyName = "situacao"
        Me.situacao.HeaderText = "situacao"
        Me.situacao.Name = "situacao"
        Me.situacao.ReadOnly = True
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
        Me.Panel2.Size = New System.Drawing.Size(1204, 47)
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
        Me.Label16.Location = New System.Drawing.Point(160, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(480, 28)
        Me.Label16.TabIndex = 258
        Me.Label16.Text = "MANUTENÇÃO DE CONTAS A PAGAR"
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
        Me.btSair.Location = New System.Drawing.Point(1019, 3)
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
        Me.ClientSize = New System.Drawing.Size(1214, 640)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLancamentoContasPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lancamento de Contas a Pagar"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvListaparcelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtNumeroPacelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFormaPagto As ComboBox
    Friend WithEvents btFormaPagto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btSair As Button
    Friend WithEvents btSalvar As Button
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
    Friend WithEvents btnExcluir As Button
    Friend WithEvents lblDesconto As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents lblRecebeJuros As Label
    Friend WithEvents btGerarParcelas As Button
    Friend WithEvents dgvParcelas As DataGridView
    Friend WithEvents btGravarParcelas As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtValorParcelas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNumeroPacelas As NumericUpDown
    Friend WithEvents mskDataPagto As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents Label12 As Label
    Public WithEvents txtVencimento As MaskedTextBox
    Public WithEvents txtDataEntrada As MaskedTextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblRecebeValorParcela As Label
    Friend WithEvents lblRecebeNumParcela As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btCalcular As Button
    Friend WithEvents lblSaldoRestante As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btBaixarConta As Button
    Friend WithEvents lblCodigoParcela As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtValoraPagar As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtJuros As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents id_parcela As DataGridViewTextBoxColumn
    Friend WithEvents parcela As DataGridViewTextBoxColumn
    Friend WithEvents data_parcela As DataGridViewTextBoxColumn
    Friend WithEvents valor_parcela As DataGridViewTextBoxColumn
    Friend WithEvents numDocto As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents valorTotal As DataGridViewTextBoxColumn
    Friend WithEvents situacao As DataGridViewTextBoxColumn
    Friend WithEvents dgvListaparcelas As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblRecebeVencimento As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents rbParcelamento As RadioButton
End Class
