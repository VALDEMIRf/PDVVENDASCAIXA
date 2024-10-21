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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblNumParcela = New System.Windows.Forms.Label()
        Me.btBaixarConta = New System.Windows.Forms.Button()
        Me.lblJuros = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblValorParcela = New System.Windows.Forms.Label()
        Me.lblSaldoRestante = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.mskDataPagto = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNumeroPacelas = New System.Windows.Forms.NumericUpDown()
        Me.btGravarParcelas = New System.Windows.Forms.Button()
        Me.btGerarParcelas = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtValorParcelas = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCodigoParcela = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.txtDataEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtParcela = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.lblDesconto = New System.Windows.Forms.Label()
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
        Me.lblSaldoParcela = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dgvParcelas = New System.Windows.Forms.DataGridView()
        Me.parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numDocto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valortotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.situacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.txtValorPago = New System.Windows.Forms.Label()
        Me.txtJuros = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.txtDesconto)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblSaldoParcela)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.dgvParcelas)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 683)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtJuros)
        Me.GroupBox3.Controls.Add(Me.txtValorPago)
        Me.GroupBox3.Controls.Add(Me.lblNumParcela)
        Me.GroupBox3.Controls.Add(Me.btBaixarConta)
        Me.GroupBox3.Controls.Add(Me.lblJuros)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.lblValorParcela)
        Me.GroupBox3.Controls.Add(Me.lblSaldoRestante)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.btCalcular)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.mskDataPagto)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 509)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(910, 135)
        Me.GroupBox3.TabIndex = 377
        Me.GroupBox3.TabStop = False
        '
        'lblNumParcela
        '
        Me.lblNumParcela.AutoSize = True
        Me.lblNumParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumParcela.ForeColor = System.Drawing.Color.White
        Me.lblNumParcela.Location = New System.Drawing.Point(98, 16)
        Me.lblNumParcela.Name = "lblNumParcela"
        Me.lblNumParcela.Size = New System.Drawing.Size(58, 18)
        Me.lblNumParcela.TabIndex = 369
        Me.lblNumParcela.Text = "Parcela"
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
        Me.btBaixarConta.Location = New System.Drawing.Point(764, 77)
        Me.btBaixarConta.Margin = New System.Windows.Forms.Padding(5)
        Me.btBaixarConta.Name = "btBaixarConta"
        Me.btBaixarConta.Size = New System.Drawing.Size(129, 35)
        Me.btBaixarConta.TabIndex = 371
        Me.btBaixarConta.Text = "Baixar Conta"
        Me.btBaixarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btBaixarConta.UseVisualStyleBackColor = False
        '
        'lblJuros
        '
        Me.lblJuros.AutoSize = True
        Me.lblJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJuros.ForeColor = System.Drawing.Color.White
        Me.lblJuros.Location = New System.Drawing.Point(875, 19)
        Me.lblJuros.Name = "lblJuros"
        Me.lblJuros.Size = New System.Drawing.Size(18, 20)
        Me.lblJuros.TabIndex = 332
        Me.lblJuros.Text = "0"
        Me.lblJuros.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(33, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 18)
        Me.Label21.TabIndex = 365
        Me.Label21.Text = "Parcela:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(674, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 20)
        Me.Label14.TabIndex = 325
        Me.Label14.Text = "Juros:"
        '
        'lblValorParcela
        '
        Me.lblValorParcela.AutoSize = True
        Me.lblValorParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorParcela.ForeColor = System.Drawing.Color.White
        Me.lblValorParcela.Location = New System.Drawing.Point(365, 20)
        Me.lblValorParcela.Name = "lblValorParcela"
        Me.lblValorParcela.Size = New System.Drawing.Size(96, 18)
        Me.lblValorParcela.TabIndex = 370
        Me.lblValorParcela.Text = "Valor Parcela"
        '
        'lblSaldoRestante
        '
        Me.lblSaldoRestante.AutoSize = True
        Me.lblSaldoRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoRestante.ForeColor = System.Drawing.Color.Maroon
        Me.lblSaldoRestante.Location = New System.Drawing.Point(518, 82)
        Me.lblSaldoRestante.Name = "lblSaldoRestante"
        Me.lblSaldoRestante.Size = New System.Drawing.Size(91, 24)
        Me.lblSaldoRestante.TabIndex = 373
        Me.lblSaldoRestante.Text = "Restante"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(264, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 18)
        Me.Label19.TabIndex = 368
        Me.Label19.Text = "Valor Parcela:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Maroon
        Me.Label22.Location = New System.Drawing.Point(426, 82)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 24)
        Me.Label22.TabIndex = 372
        Me.Label22.Text = "Restante:"
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
        Me.btCalcular.Location = New System.Drawing.Point(11, 72)
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
        Me.Label15.Location = New System.Drawing.Point(167, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 23)
        Me.Label15.TabIndex = 327
        Me.Label15.Text = "Valor Corrigido:"
        '
        'mskDataPagto
        '
        Me.mskDataPagto.Location = New System.Drawing.Point(564, 21)
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
        Me.Label17.Location = New System.Drawing.Point(485, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 20)
        Me.Label17.TabIndex = 339
        Me.Label17.Text = "Dt Pagto:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNumeroPacelas)
        Me.GroupBox2.Controls.Add(Me.btGravarParcelas)
        Me.GroupBox2.Controls.Add(Me.btGerarParcelas)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.mskData)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtValorParcelas)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(918, 52)
        Me.GroupBox2.TabIndex = 346
        Me.GroupBox2.TabStop = False
        '
        'txtNumeroPacelas
        '
        Me.txtNumeroPacelas.Location = New System.Drawing.Point(83, 12)
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
        Me.btGravarParcelas.Location = New System.Drawing.Point(757, 9)
        Me.btGravarParcelas.Margin = New System.Windows.Forms.Padding(5)
        Me.btGravarParcelas.Name = "btGravarParcelas"
        Me.btGravarParcelas.Size = New System.Drawing.Size(153, 34)
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
        Me.btGerarParcelas.Location = New System.Drawing.Point(648, 7)
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
        Me.Label7.Location = New System.Drawing.Point(7, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 319
        Me.Label7.Text = "Parcelas:"
        '
        'mskData
        '
        Me.mskData.Enabled = False
        Me.mskData.Location = New System.Drawing.Point(535, 11)
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
        Me.Label11.Location = New System.Drawing.Point(401, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 20)
        Me.Label11.TabIndex = 306
        Me.Label11.Text = "Dt Parcelamento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(162, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 20)
        Me.Label10.TabIndex = 321
        Me.Label10.Text = "Valor a Parcelar:"
        '
        'txtValorParcelas
        '
        Me.txtValorParcelas.Enabled = False
        Me.txtValorParcelas.Location = New System.Drawing.Point(290, 12)
        Me.txtValorParcelas.Name = "txtValorParcelas"
        Me.txtValorParcelas.Size = New System.Drawing.Size(94, 20)
        Me.txtValorParcelas.TabIndex = 320
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(827, 650)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(82, 20)
        Me.txtDesconto.TabIndex = 322
        Me.txtDesconto.Text = "0"
        Me.txtDesconto.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCodigoParcela)
        Me.GroupBox1.Controls.Add(Me.btnExcluir)
        Me.GroupBox1.Controls.Add(Me.txtDataEntrada)
        Me.GroupBox1.Controls.Add(Me.btSalvar)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtObs)
        Me.GroupBox1.Controls.Add(Me.txtParcela)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Controls.Add(Me.txtVencimento)
        Me.GroupBox1.Controls.Add(Me.lblDesconto)
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
        Me.GroupBox1.Size = New System.Drawing.Size(918, 152)
        Me.GroupBox1.TabIndex = 345
        Me.GroupBox1.TabStop = False
        '
        'lblCodigoParcela
        '
        Me.lblCodigoParcela.AutoSize = True
        Me.lblCodigoParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoParcela.ForeColor = System.Drawing.Color.White
        Me.lblCodigoParcela.Location = New System.Drawing.Point(837, 89)
        Me.lblCodigoParcela.Name = "lblCodigoParcela"
        Me.lblCodigoParcela.Size = New System.Drawing.Size(18, 20)
        Me.lblCodigoParcela.TabIndex = 345
        Me.lblCodigoParcela.Text = "0"
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
        Me.btnExcluir.Location = New System.Drawing.Point(688, 110)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(84, 38)
        Me.btnExcluir.TabIndex = 12
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'txtDataEntrada
        '
        Me.txtDataEntrada.Location = New System.Drawing.Point(457, 78)
        Me.txtDataEntrada.Mask = "00/00/0000"
        Me.txtDataEntrada.Name = "txtDataEntrada"
        Me.txtDataEntrada.Size = New System.Drawing.Size(87, 20)
        Me.txtDataEntrada.TabIndex = 343
        Me.txtDataEntrada.ValidatingType = GetType(Date)
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
        Me.btSalvar.Location = New System.Drawing.Point(557, 109)
        Me.btSalvar.Margin = New System.Windows.Forms.Padding(5)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(88, 39)
        Me.btSalvar.TabIndex = 10
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(453, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 20)
        Me.Label18.TabIndex = 344
        Me.Label18.Text = "Dt Entrada"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(9, 120)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(411, 20)
        Me.txtObs.TabIndex = 316
        '
        'txtParcela
        '
        Me.txtParcela.Location = New System.Drawing.Point(841, 109)
        Me.txtParcela.Name = "txtParcela"
        Me.txtParcela.Size = New System.Drawing.Size(10, 20)
        Me.txtParcela.TabIndex = 318
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 317
        Me.Label2.Text = "Obs.:"
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = True
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(857, 89)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(18, 20)
        Me.txtCodigo.TabIndex = 310
        Me.txtCodigo.Text = "0"
        Me.txtCodigo.Visible = False
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.ForeColor = System.Drawing.Color.White
        Me.lblValor.Location = New System.Drawing.Point(858, 120)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(18, 20)
        Me.lblValor.TabIndex = 331
        Me.lblValor.Text = "0"
        Me.lblValor.Visible = False
        '
        'txtVencimento
        '
        Me.txtVencimento.Location = New System.Drawing.Point(446, 120)
        Me.txtVencimento.Mask = "00/00/0000"
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(87, 20)
        Me.txtVencimento.TabIndex = 297
        Me.txtVencimento.ValidatingType = GetType(Date)
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesconto.ForeColor = System.Drawing.Color.White
        Me.lblDesconto.Location = New System.Drawing.Point(875, 87)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(18, 20)
        Me.lblDesconto.TabIndex = 330
        Me.lblDesconto.Text = "0"
        Me.lblDesconto.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 300
        Me.Label8.Text = "Descrição:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(551, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 301
        Me.Label5.Text = "Valor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(437, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 303
        Me.Label6.Text = "Vencimento:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(7, 78)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(444, 20)
        Me.txtDescricao.TabIndex = 293
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(553, 79)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(119, 20)
        Me.txtValor.TabIndex = 299
        '
        'txtSituacao
        '
        Me.txtSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSituacao.FormattingEnabled = True
        Me.txtSituacao.Items.AddRange(New Object() {"Paga", "Não Paga", "Vencida", "Em Parcelamento"})
        Me.txtSituacao.Location = New System.Drawing.Point(688, 78)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(131, 21)
        Me.txtSituacao.TabIndex = 298
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(700, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 20)
        Me.Label13.TabIndex = 307
        Me.Label13.Text = "Situação:"
        '
        'txtConta
        '
        Me.txtConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtConta.FormattingEnabled = True
        Me.txtConta.Location = New System.Drawing.Point(101, 34)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(189, 21)
        Me.txtConta.TabIndex = 294
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(329, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 302
        Me.Label4.Text = "Fornecedor:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(100, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 304
        Me.Label9.Text = "Tipo Conta:"
        '
        'txtNDoc
        '
        Me.txtNDoc.Location = New System.Drawing.Point(5, 34)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(86, 20)
        Me.txtNDoc.TabIndex = 296
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 305
        Me.Label3.Text = "N° Docto:"
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
        Me.btConta.Location = New System.Drawing.Point(289, 30)
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
        Me.btFornecedor.Location = New System.Drawing.Point(656, 30)
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
        Me.txtFornecedor.Location = New System.Drawing.Point(326, 34)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(332, 21)
        Me.txtFornecedor.TabIndex = 309
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(702, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 315
        Me.Label1.Text = "Forma de Pagto:"
        '
        'txtFormaPagto
        '
        Me.txtFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFormaPagto.FormattingEnabled = True
        Me.txtFormaPagto.Location = New System.Drawing.Point(699, 34)
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
        Me.btFormaPagto.Location = New System.Drawing.Point(874, 29)
        Me.btFormaPagto.Margin = New System.Windows.Forms.Padding(5)
        Me.btFormaPagto.Name = "btFormaPagto"
        Me.btFormaPagto.Size = New System.Drawing.Size(35, 27)
        Me.btFormaPagto.TabIndex = 314
        Me.btFormaPagto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFormaPagto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFormaPagto.UseVisualStyleBackColor = False
        '
        'lblSaldoParcela
        '
        Me.lblSaldoParcela.AutoSize = True
        Me.lblSaldoParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoParcela.ForeColor = System.Drawing.Color.Red
        Me.lblSaldoParcela.Location = New System.Drawing.Point(714, 652)
        Me.lblSaldoParcela.Name = "lblSaldoParcela"
        Me.lblSaldoParcela.Size = New System.Drawing.Size(19, 20)
        Me.lblSaldoParcela.TabIndex = 376
        Me.lblSaldoParcela.Text = "0"
        Me.lblSaldoParcela.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(740, 650)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 20)
        Me.Label12.TabIndex = 323
        Me.Label12.Text = "Desconto:"
        Me.Label12.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(657, 650)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 20)
        Me.Label24.TabIndex = 375
        Me.Label24.Text = "Saldo:"
        Me.Label24.Visible = False
        '
        'dgvParcelas
        '
        Me.dgvParcelas.AllowUserToAddRows = False
        Me.dgvParcelas.AllowUserToDeleteRows = False
        Me.dgvParcelas.BackgroundColor = System.Drawing.Color.White
        Me.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParcelas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.parcela, Me.data_parcela, Me.valor_parcela, Me.numDocto, Me.descricao, Me.valortotal, Me.situacao, Me.id_parcela})
        Me.dgvParcelas.GridColor = System.Drawing.Color.DarkBlue
        Me.dgvParcelas.Location = New System.Drawing.Point(5, 256)
        Me.dgvParcelas.Name = "dgvParcelas"
        Me.dgvParcelas.ReadOnly = True
        Me.dgvParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParcelas.Size = New System.Drawing.Size(914, 247)
        Me.dgvParcelas.TabIndex = 334
        '
        'parcela
        '
        Me.parcela.DataPropertyName = "parcela"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.parcela.DefaultCellStyle = DataGridViewCellStyle1
        Me.parcela.HeaderText = "Parcelas"
        Me.parcela.Name = "parcela"
        Me.parcela.ReadOnly = True
        Me.parcela.Width = 50
        '
        'data_parcela
        '
        Me.data_parcela.DataPropertyName = "data_parcela"
        Me.data_parcela.HeaderText = "Vencimento"
        Me.data_parcela.Name = "data_parcela"
        Me.data_parcela.ReadOnly = True
        Me.data_parcela.Width = 90
        '
        'valor_parcela
        '
        Me.valor_parcela.DataPropertyName = "valor_parcela"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.valor_parcela.DefaultCellStyle = DataGridViewCellStyle2
        Me.valor_parcela.HeaderText = "Valor Parcela"
        Me.valor_parcela.Name = "valor_parcela"
        Me.valor_parcela.ReadOnly = True
        Me.valor_parcela.Width = 80
        '
        'numDocto
        '
        Me.numDocto.DataPropertyName = "numDocto"
        Me.numDocto.HeaderText = "Documento"
        Me.numDocto.Name = "numDocto"
        Me.numDocto.ReadOnly = True
        Me.numDocto.Width = 150
        '
        'descricao
        '
        Me.descricao.DataPropertyName = "descricao"
        Me.descricao.HeaderText = "Descriçao"
        Me.descricao.Name = "descricao"
        Me.descricao.ReadOnly = True
        Me.descricao.Width = 250
        '
        'valortotal
        '
        Me.valortotal.DataPropertyName = "valortotal"
        Me.valortotal.HeaderText = "valor total"
        Me.valortotal.Name = "valortotal"
        Me.valortotal.ReadOnly = True
        Me.valortotal.Width = 80
        '
        'situacao
        '
        Me.situacao.DataPropertyName = "situacao"
        Me.situacao.HeaderText = "situacao"
        Me.situacao.Name = "situacao"
        Me.situacao.ReadOnly = True
        Me.situacao.Width = 120
        '
        'id_parcela
        '
        Me.id_parcela.DataPropertyName = "id_parcela"
        Me.id_parcela.HeaderText = "id_parcela"
        Me.id_parcela.Name = "id_parcela"
        Me.id_parcela.ReadOnly = True
        Me.id_parcela.Visible = False
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
        Me.Panel2.Size = New System.Drawing.Size(927, 47)
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
        Me.Label16.Location = New System.Drawing.Point(168, 9)
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
        Me.btSair.Location = New System.Drawing.Point(799, 5)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(93, 36)
        Me.btSair.TabIndex = 13
        Me.btSair.Text = "Voltar"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'txtValorPago
        '
        Me.txtValorPago.AutoSize = True
        Me.txtValorPago.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorPago.ForeColor = System.Drawing.Color.Red
        Me.txtValorPago.Location = New System.Drawing.Point(287, 82)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(124, 23)
        Me.txtValorPago.TabIndex = 375
        Me.txtValorPago.Text = "Valor Corrigido"
        '
        'txtJuros
        '
        Me.txtJuros.AutoSize = True
        Me.txtJuros.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJuros.ForeColor = System.Drawing.Color.White
        Me.txtJuros.Location = New System.Drawing.Point(729, 24)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Size = New System.Drawing.Size(96, 18)
        Me.txtJuros.TabIndex = 376
        Me.txtJuros.Text = "Valor Parcela"
        '
        'frmLancamentoContasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(939, 700)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLancamentoContasPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lancamento de Contas a Pagar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents lblJuros As Label
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
    Friend WithEvents parcela As DataGridViewTextBoxColumn
    Friend WithEvents data_parcela As DataGridViewTextBoxColumn
    Friend WithEvents valor_parcela As DataGridViewTextBoxColumn
    Friend WithEvents numDocto As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents valortotal As DataGridViewTextBoxColumn
    Friend WithEvents situacao As DataGridViewTextBoxColumn
    Friend WithEvents id_parcela As DataGridViewTextBoxColumn
    Friend WithEvents lblValorParcela As Label
    Friend WithEvents lblNumParcela As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btCalcular As Button
    Friend WithEvents lblSaldoRestante As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btBaixarConta As Button
    Friend WithEvents lblSaldoParcela As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblCodigoParcela As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtParcela As TextBox
    Friend WithEvents txtJuros As Label
    Friend WithEvents txtValorPago As Label
End Class
