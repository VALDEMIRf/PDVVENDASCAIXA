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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtNumParcela = New System.Windows.Forms.TextBox()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.txtValorParcela = New System.Windows.Forms.TextBox()
        Me.lbtxtSaldoRestante = New System.Windows.Forms.Label()
        Me.txtSaldoRestante = New System.Windows.Forms.TextBox()
        Me.lbtxtValorParcela = New System.Windows.Forms.Label()
        Me.lbtxtNumParcela = New System.Windows.Forms.Label()
        Me.lbtxtValorTotal = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.Label()
        Me.txtVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDataEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.btBaixarConta = New System.Windows.Forms.Button()
        Me.txtFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mstbDataPagto = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtJuros = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSituacao = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btSair)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1144, 59)
        Me.Panel1.TabIndex = 314
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 312
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Elephant", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(190, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(313, 26)
        Me.Label5.TabIndex = 311
        Me.Label5.Text = "BAIXAR CONTAS A PAGAR"
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
        Me.btSair.Location = New System.Drawing.Point(570, 9)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(94, 43)
        Me.btSair.TabIndex = 300
        Me.btSair.Text = "Voltar"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(642, 53)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(16, 18)
        Me.lblCodigo.TabIndex = 301
        Me.lblCodigo.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Controls.Add(Me.dg1)
        Me.Panel2.Controls.Add(Me.dg)
        Me.Panel2.Controls.Add(Me.txtValorTotal)
        Me.Panel2.Controls.Add(Me.txtNumParcela)
        Me.Panel2.Controls.Add(Me.btCalcular)
        Me.Panel2.Controls.Add(Me.txtValorParcela)
        Me.Panel2.Controls.Add(Me.lbtxtSaldoRestante)
        Me.Panel2.Controls.Add(Me.txtSaldoRestante)
        Me.Panel2.Controls.Add(Me.lbtxtValorParcela)
        Me.Panel2.Controls.Add(Me.lbtxtNumParcela)
        Me.Panel2.Controls.Add(Me.lbtxtValorTotal)
        Me.Panel2.Controls.Add(Me.txtDescricao)
        Me.Panel2.Controls.Add(Me.txtVencimento)
        Me.Panel2.Controls.Add(Me.txtValorPago)
        Me.Panel2.Controls.Add(Me.lblCodigo)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtObs)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtDataEntrada)
        Me.Panel2.Controls.Add(Me.btBaixarConta)
        Me.Panel2.Controls.Add(Me.txtFornecedor)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.mstbDataPagto)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txtJuros)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtDesconto)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txtSituacao)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtDocumento)
        Me.Panel2.Location = New System.Drawing.Point(6, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1126, 549)
        Me.Panel2.TabIndex = 315
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkBlue
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg1.BackgroundColor = System.Drawing.Color.White
        Me.dg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg1.GridColor = System.Drawing.Color.CadetBlue
        Me.dg1.Location = New System.Drawing.Point(6, 411)
        Me.dg1.Margin = New System.Windows.Forms.Padding(4)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg1.Size = New System.Drawing.Size(1108, 102)
        Me.dg1.TabIndex = 369
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(6, 288)
        Me.dg.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(1108, 109)
        Me.dg.TabIndex = 368
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Enabled = False
        Me.txtValorTotal.Location = New System.Drawing.Point(765, 26)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorTotal.TabIndex = 5
        '
        'txtNumParcela
        '
        Me.txtNumParcela.Enabled = False
        Me.txtNumParcela.Location = New System.Drawing.Point(791, 64)
        Me.txtNumParcela.Name = "txtNumParcela"
        Me.txtNumParcela.Size = New System.Drawing.Size(61, 20)
        Me.txtNumParcela.TabIndex = 0
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
        Me.btCalcular.Location = New System.Drawing.Point(402, 220)
        Me.btCalcular.Margin = New System.Windows.Forms.Padding(5)
        Me.btCalcular.Name = "btCalcular"
        Me.btCalcular.Size = New System.Drawing.Size(98, 34)
        Me.btCalcular.TabIndex = 367
        Me.btCalcular.Text = "Calcular"
        Me.btCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btCalcular.UseVisualStyleBackColor = False
        '
        'txtValorParcela
        '
        Me.txtValorParcela.Enabled = False
        Me.txtValorParcela.Location = New System.Drawing.Point(776, 90)
        Me.txtValorParcela.Name = "txtValorParcela"
        Me.txtValorParcela.Size = New System.Drawing.Size(95, 20)
        Me.txtValorParcela.TabIndex = 358
        '
        'lbtxtSaldoRestante
        '
        Me.lbtxtSaldoRestante.AutoSize = True
        Me.lbtxtSaldoRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtxtSaldoRestante.ForeColor = System.Drawing.Color.White
        Me.lbtxtSaldoRestante.Location = New System.Drawing.Point(319, 227)
        Me.lbtxtSaldoRestante.Name = "lbtxtSaldoRestante"
        Me.lbtxtSaldoRestante.Size = New System.Drawing.Size(75, 20)
        Me.lbtxtSaldoRestante.TabIndex = 366
        Me.lbtxtSaldoRestante.Text = "Restante"
        '
        'txtSaldoRestante
        '
        Me.txtSaldoRestante.AcceptsReturn = True
        Me.txtSaldoRestante.Enabled = False
        Me.txtSaldoRestante.Location = New System.Drawing.Point(782, 148)
        Me.txtSaldoRestante.Name = "txtSaldoRestante"
        Me.txtSaldoRestante.Size = New System.Drawing.Size(89, 20)
        Me.txtSaldoRestante.TabIndex = 356
        Me.txtSaldoRestante.Text = "0"
        '
        'lbtxtValorParcela
        '
        Me.lbtxtValorParcela.AutoSize = True
        Me.lbtxtValorParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtxtValorParcela.ForeColor = System.Drawing.Color.White
        Me.lbtxtValorParcela.Location = New System.Drawing.Point(307, 141)
        Me.lbtxtValorParcela.Name = "lbtxtValorParcela"
        Me.lbtxtValorParcela.Size = New System.Drawing.Size(96, 18)
        Me.lbtxtValorParcela.TabIndex = 364
        Me.lbtxtValorParcela.Text = "Valor Parcela"
        '
        'lbtxtNumParcela
        '
        Me.lbtxtNumParcela.AutoSize = True
        Me.lbtxtNumParcela.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtxtNumParcela.ForeColor = System.Drawing.Color.White
        Me.lbtxtNumParcela.Location = New System.Drawing.Point(80, 141)
        Me.lbtxtNumParcela.Name = "lbtxtNumParcela"
        Me.lbtxtNumParcela.Size = New System.Drawing.Size(58, 18)
        Me.lbtxtNumParcela.TabIndex = 363
        Me.lbtxtNumParcela.Text = "Parcela"
        '
        'lbtxtValorTotal
        '
        Me.lbtxtValorTotal.AutoSize = True
        Me.lbtxtValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtxtValorTotal.ForeColor = System.Drawing.Color.White
        Me.lbtxtValorTotal.Location = New System.Drawing.Point(563, 104)
        Me.lbtxtValorTotal.Name = "lbtxtValorTotal"
        Me.lbtxtValorTotal.Size = New System.Drawing.Size(79, 18)
        Me.lbtxtValorTotal.TabIndex = 362
        Me.lbtxtValorTotal.Text = "Valor Total"
        '
        'txtDescricao
        '
        Me.txtDescricao.AutoSize = True
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.ForeColor = System.Drawing.Color.White
        Me.txtDescricao.Location = New System.Drawing.Point(88, 51)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(66, 20)
        Me.txtDescricao.TabIndex = 361
        Me.txtDescricao.Text = "Label16"
        '
        'txtVencimento
        '
        Me.txtVencimento.Enabled = False
        Me.txtVencimento.Location = New System.Drawing.Point(347, 25)
        Me.txtVencimento.Mask = "00/00/0000"
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(87, 20)
        Me.txtVencimento.TabIndex = 360
        Me.txtVencimento.ValidatingType = GetType(Date)
        '
        'txtValorPago
        '
        Me.txtValorPago.Location = New System.Drawing.Point(569, 139)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(89, 20)
        Me.txtValorPago.TabIndex = 345
        Me.txtValorPago.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(206, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 18)
        Me.Label13.TabIndex = 359
        Me.Label13.Text = "Valor Parcela:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(234, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 357
        Me.Label4.Text = "Restante:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(7, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 18)
        Me.Label11.TabIndex = 355
        Me.Label11.Text = "Observação:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(98, 73)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(560, 20)
        Me.txtObs.TabIndex = 354
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(451, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 20)
        Me.Label10.TabIndex = 353
        Me.Label10.Text = "Dt Entrada"
        '
        'txtDataEntrada
        '
        Me.txtDataEntrada.Enabled = False
        Me.txtDataEntrada.Location = New System.Drawing.Point(455, 24)
        Me.txtDataEntrada.Mask = "00/00/0000"
        Me.txtDataEntrada.Name = "txtDataEntrada"
        Me.txtDataEntrada.Size = New System.Drawing.Size(76, 20)
        Me.txtDataEntrada.TabIndex = 352
        Me.txtDataEntrada.ValidatingType = GetType(Date)
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
        Me.btBaixarConta.Location = New System.Drawing.Point(723, -111)
        Me.btBaixarConta.Margin = New System.Windows.Forms.Padding(5)
        Me.btBaixarConta.Name = "btBaixarConta"
        Me.btBaixarConta.Size = New System.Drawing.Size(62, 72)
        Me.btBaixarConta.TabIndex = 301
        Me.btBaixarConta.Text = "Baixar Conta"
        Me.btBaixarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btBaixarConta.UseVisualStyleBackColor = False
        '
        'txtFornecedor
        '
        Me.txtFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFornecedor.FormattingEnabled = True
        Me.txtFornecedor.Location = New System.Drawing.Point(6, 25)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(332, 21)
        Me.txtFornecedor.TabIndex = 351
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 20)
        Me.Label9.TabIndex = 350
        Me.Label9.Text = "Fornecedor:"
        '
        'mstbDataPagto
        '
        Me.mstbDataPagto.Location = New System.Drawing.Point(336, 104)
        Me.mstbDataPagto.Mask = "00/00/0000"
        Me.mstbDataPagto.Name = "mstbDataPagto"
        Me.mstbDataPagto.Size = New System.Drawing.Size(79, 20)
        Me.mstbDataPagto.TabIndex = 349
        Me.mstbDataPagto.ValidatingType = GetType(Date)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(255, 105)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 20)
        Me.Label17.TabIndex = 348
        Me.Label17.Text = "Dt Pagto:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(472, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 20)
        Me.Label15.TabIndex = 346
        Me.Label15.Text = "Valor Pago:"
        '
        'txtJuros
        '
        Me.txtJuros.Location = New System.Drawing.Point(84, 181)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Size = New System.Drawing.Size(70, 20)
        Me.txtJuros.TabIndex = 343
        Me.txtJuros.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(22, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 20)
        Me.Label14.TabIndex = 344
        Me.Label14.Text = "Juros:"
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(293, 181)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(82, 20)
        Me.txtDesconto.TabIndex = 341
        Me.txtDesconto.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(205, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 20)
        Me.Label12.TabIndex = 342
        Me.Label12.Text = "Desconto:"
        '
        'txtSituacao
        '
        Me.txtSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSituacao.FormattingEnabled = True
        Me.txtSituacao.Items.AddRange(New Object() {"Paga", "Não Paga", "Vencida", "Em Parcelamento"})
        Me.txtSituacao.Location = New System.Drawing.Point(79, 104)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(159, 21)
        Me.txtSituacao.TabIndex = 299
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(7, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Situação:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(544, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Documento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Descrição:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Parcela:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(348, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Vencimento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(481, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Valor Total:"
        '
        'txtDocumento
        '
        Me.txtDocumento.Enabled = False
        Me.txtDocumento.Location = New System.Drawing.Point(541, 24)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(117, 20)
        Me.txtDocumento.TabIndex = 3
        '
        'frmBaixarContaPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1144, 628)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBaixarContaPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBaixarContaPagar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents txtNumParcela As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSituacao As ComboBox
    Friend WithEvents btSair As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btBaixarConta As Button
    Friend WithEvents mstbDataPagto As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents txtJuros As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtFornecedor As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDataEntrada As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSaldoRestante As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtValorParcela As TextBox
    Public WithEvents txtVencimento As MaskedTextBox
    Friend WithEvents txtDescricao As Label
    Friend WithEvents lbtxtSaldoRestante As Label
    Friend WithEvents lbtxtValorParcela As Label
    Friend WithEvents lbtxtValorTotal As Label
    Friend WithEvents lbtxtNumParcela As Label
    Friend WithEvents btCalcular As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents dg1 As DataGridView
End Class
