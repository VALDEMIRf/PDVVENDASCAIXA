<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceberContas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceberContas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btSair = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotalLinhas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalContasRecebidas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalContasNaoRecebidas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalContasReceber = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpVencimento = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFormaPagto = New System.Windows.Forms.ComboBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.ComboBox()
        Me.txtCliente = New System.Windows.Forms.ComboBox()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbContasRecebidas = New System.Windows.Forms.RadioButton()
        Me.txtBuscarTipoConta = New System.Windows.Forms.ComboBox()
        Me.txtBuscarCliente = New System.Windows.Forms.ComboBox()
        Me.rbContasReceber = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rbTodas = New System.Windows.Forms.RadioButton()
        Me.rbTipoConta = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.btPagarParcela = New System.Windows.Forms.Button()
        Me.btGerarParcelamento = New System.Windows.Forms.Button()
        Me.btPendente = New System.Windows.Forms.Button()
        Me.btGrafico = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btPagar = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.dgvContasReceber = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvContasReceber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btSair)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 60)
        Me.Panel1.TabIndex = 335
        '
        'btSair
        '
        Me.btSair.BackColor = System.Drawing.Color.Transparent
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSair.ForeColor = System.Drawing.Color.White
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(859, 14)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(85, 35)
        Me.btSair.TabIndex = 314
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 312
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Elephant", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(105, 3)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(510, 51)
        Me.Label5.TabIndex = 311
        Me.Label5.Text = "CONTAS A RECEBER"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(702, 576)
        Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 20)
        Me.Label10.TabIndex = 341
        Me.Label10.Text = "N° de linhas:"
        '
        'lblTotalLinhas
        '
        Me.lblTotalLinhas.AutoSize = True
        Me.lblTotalLinhas.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalLinhas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLinhas.ForeColor = System.Drawing.Color.White
        Me.lblTotalLinhas.Location = New System.Drawing.Point(801, 576)
        Me.lblTotalLinhas.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotalLinhas.Name = "lblTotalLinhas"
        Me.lblTotalLinhas.Size = New System.Drawing.Size(14, 20)
        Me.lblTotalLinhas.TabIndex = 340
        Me.lblTotalLinhas.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 576)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "Contas Recebidas"
        '
        'txtTotalContasRecebidas
        '
        Me.txtTotalContasRecebidas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasRecebidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasRecebidas.ForeColor = System.Drawing.Color.Green
        Me.txtTotalContasRecebidas.Location = New System.Drawing.Point(4, 601)
        Me.txtTotalContasRecebidas.Multiline = True
        Me.txtTotalContasRecebidas.Name = "txtTotalContasRecebidas"
        Me.txtTotalContasRecebidas.ReadOnly = True
        Me.txtTotalContasRecebidas.Size = New System.Drawing.Size(218, 33)
        Me.txtTotalContasRecebidas.TabIndex = 346
        Me.txtTotalContasRecebidas.Text = "R$ 0,00"
        Me.txtTotalContasRecebidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(238, 576)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 345
        Me.Label1.Text = "Contas Não Recebidas"
        '
        'txtTotalContasNaoRecebidas
        '
        Me.txtTotalContasNaoRecebidas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasNaoRecebidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasNaoRecebidas.ForeColor = System.Drawing.Color.Red
        Me.txtTotalContasNaoRecebidas.Location = New System.Drawing.Point(233, 601)
        Me.txtTotalContasNaoRecebidas.Multiline = True
        Me.txtTotalContasNaoRecebidas.Name = "txtTotalContasNaoRecebidas"
        Me.txtTotalContasNaoRecebidas.ReadOnly = True
        Me.txtTotalContasNaoRecebidas.Size = New System.Drawing.Size(218, 33)
        Me.txtTotalContasNaoRecebidas.TabIndex = 344
        Me.txtTotalContasNaoRecebidas.Text = "R$ 0,00"
        Me.txtTotalContasNaoRecebidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(487, 576)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 343
        Me.Label7.Text = "Total:"
        '
        'txtTotalContasReceber
        '
        Me.txtTotalContasReceber.BackColor = System.Drawing.Color.White
        Me.txtTotalContasReceber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasReceber.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalContasReceber.Location = New System.Drawing.Point(463, 601)
        Me.txtTotalContasReceber.Multiline = True
        Me.txtTotalContasReceber.Name = "txtTotalContasReceber"
        Me.txtTotalContasReceber.ReadOnly = True
        Me.txtTotalContasReceber.Size = New System.Drawing.Size(218, 33)
        Me.txtTotalContasReceber.TabIndex = 342
        Me.txtTotalContasReceber.Text = "R$ 0,00"
        Me.txtTotalContasReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpVencimento)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtFormaPagto)
        Me.GroupBox2.Controls.Add(Me.lblCodigo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtValor)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtDescricao)
        Me.GroupBox2.Controls.Add(Me.txtCliente)
        Me.GroupBox2.Controls.Add(Me.txtNDoc)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(738, 112)
        Me.GroupBox2.TabIndex = 374
        Me.GroupBox2.TabStop = False
        '
        'dtpVencimento
        '
        Me.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimento.Location = New System.Drawing.Point(635, 76)
        Me.dtpVencimento.Name = "dtpVencimento"
        Me.dtpVencimento.Size = New System.Drawing.Size(85, 20)
        Me.dtpVencimento.TabIndex = 351
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(631, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 350
        Me.Label6.Text = "Vencimento"
        '
        'txtFormaPagto
        '
        Me.txtFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFormaPagto.FormattingEnabled = True
        Me.txtFormaPagto.Location = New System.Drawing.Point(611, 31)
        Me.txtFormaPagto.Name = "txtFormaPagto"
        Me.txtFormaPagto.Size = New System.Drawing.Size(105, 21)
        Me.txtFormaPagto.TabIndex = 344
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(456, 11)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(14, 15)
        Me.lblCodigo.TabIndex = 348
        Me.lblCodigo.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(604, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 20)
        Me.Label8.TabIndex = 346
        Me.Label8.Text = "Forma de Pagto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(223, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 337
        Me.Label9.Text = "Descrição"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(540, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 20)
        Me.Label11.TabIndex = 338
        Me.Label11.Text = "Valor"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(532, 76)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(88, 20)
        Me.txtValor.TabIndex = 336
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(7, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 341
        Me.Label12.Text = "N° Docto"
        '
        'txtDescricao
        '
        Me.txtDescricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDescricao.FormattingEnabled = True
        Me.txtDescricao.Location = New System.Drawing.Point(223, 31)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(257, 21)
        Me.txtDescricao.TabIndex = 333
        '
        'txtCliente
        '
        Me.txtCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCliente.FormattingEnabled = True
        Me.txtCliente.Location = New System.Drawing.Point(11, 76)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(427, 21)
        Me.txtCliente.TabIndex = 343
        '
        'txtNDoc
        '
        Me.txtNDoc.Location = New System.Drawing.Point(8, 31)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(165, 20)
        Me.txtNDoc.TabIndex = 335
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(9, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 20)
        Me.Label13.TabIndex = 339
        Me.Label13.Text = "Cliente"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbContasRecebidas)
        Me.GroupBox4.Controls.Add(Me.txtBuscarTipoConta)
        Me.GroupBox4.Controls.Add(Me.txtBuscarCliente)
        Me.GroupBox4.Controls.Add(Me.rbContasReceber)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.rbTodas)
        Me.GroupBox4.Controls.Add(Me.rbTipoConta)
        Me.GroupBox4.Controls.Add(Me.rbCliente)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 176)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(764, 49)
        Me.GroupBox4.TabIndex = 375
        Me.GroupBox4.TabStop = False
        '
        'rbContasRecebidas
        '
        Me.rbContasRecebidas.AutoSize = True
        Me.rbContasRecebidas.ForeColor = System.Drawing.Color.White
        Me.rbContasRecebidas.Location = New System.Drawing.Point(238, 20)
        Me.rbContasRecebidas.Name = "rbContasRecebidas"
        Me.rbContasRecebidas.Size = New System.Drawing.Size(112, 17)
        Me.rbContasRecebidas.TabIndex = 207
        Me.rbContasRecebidas.TabStop = True
        Me.rbContasRecebidas.Text = "Contas Recebidas"
        Me.rbContasRecebidas.UseVisualStyleBackColor = True
        '
        'txtBuscarTipoConta
        '
        Me.txtBuscarTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBuscarTipoConta.FormattingEnabled = True
        Me.txtBuscarTipoConta.Location = New System.Drawing.Point(508, 17)
        Me.txtBuscarTipoConta.Name = "txtBuscarTipoConta"
        Me.txtBuscarTipoConta.Size = New System.Drawing.Size(233, 21)
        Me.txtBuscarTipoConta.TabIndex = 295
        Me.txtBuscarTipoConta.Visible = False
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBuscarCliente.FormattingEnabled = True
        Me.txtBuscarCliente.Location = New System.Drawing.Point(506, 17)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(235, 21)
        Me.txtBuscarCliente.TabIndex = 310
        Me.txtBuscarCliente.Visible = False
        '
        'rbContasReceber
        '
        Me.rbContasReceber.AutoSize = True
        Me.rbContasReceber.ForeColor = System.Drawing.Color.White
        Me.rbContasReceber.Location = New System.Drawing.Point(125, 20)
        Me.rbContasReceber.Name = "rbContasReceber"
        Me.rbContasReceber.Size = New System.Drawing.Size(111, 17)
        Me.rbContasReceber.TabIndex = 208
        Me.rbContasReceber.TabStop = True
        Me.rbContasReceber.Text = "Contas a Receber"
        Me.rbContasReceber.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(4, 17)
        Me.Label14.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 20)
        Me.Label14.TabIndex = 206
        Me.Label14.Text = "Buscar:"
        '
        'rbTodas
        '
        Me.rbTodas.AutoSize = True
        Me.rbTodas.ForeColor = System.Drawing.Color.White
        Me.rbTodas.Location = New System.Drawing.Point(68, 19)
        Me.rbTodas.Name = "rbTodas"
        Me.rbTodas.Size = New System.Drawing.Size(55, 17)
        Me.rbTodas.TabIndex = 206
        Me.rbTodas.TabStop = True
        Me.rbTodas.Text = "Todas"
        Me.rbTodas.UseVisualStyleBackColor = True
        '
        'rbTipoConta
        '
        Me.rbTipoConta.AutoSize = True
        Me.rbTipoConta.ForeColor = System.Drawing.Color.White
        Me.rbTipoConta.Location = New System.Drawing.Point(350, 20)
        Me.rbTipoConta.Name = "rbTipoConta"
        Me.rbTipoConta.Size = New System.Drawing.Size(92, 17)
        Me.rbTipoConta.TabIndex = 210
        Me.rbTipoConta.TabStop = True
        Me.rbTipoConta.Text = "Tipo de Conta"
        Me.rbTipoConta.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.ForeColor = System.Drawing.Color.White
        Me.rbCliente.Location = New System.Drawing.Point(443, 19)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(57, 17)
        Me.rbCliente.TabIndex = 211
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'btPagarParcela
        '
        Me.btPagarParcela.BackColor = System.Drawing.Color.Transparent
        Me.btPagarParcela.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPagarParcela.FlatAppearance.BorderSize = 0
        Me.btPagarParcela.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btPagarParcela.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btPagarParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPagarParcela.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPagarParcela.ForeColor = System.Drawing.Color.White
        Me.btPagarParcela.Image = CType(resources.GetObject("btPagarParcela.Image"), System.Drawing.Image)
        Me.btPagarParcela.Location = New System.Drawing.Point(841, 475)
        Me.btPagarParcela.Margin = New System.Windows.Forms.Padding(5)
        Me.btPagarParcela.Name = "btPagarParcela"
        Me.btPagarParcela.Size = New System.Drawing.Size(108, 61)
        Me.btPagarParcela.TabIndex = 384
        Me.btPagarParcela.Text = "Baixa de  Parcela"
        Me.btPagarParcela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPagarParcela.UseVisualStyleBackColor = False
        Me.btPagarParcela.Visible = False
        '
        'btGerarParcelamento
        '
        Me.btGerarParcelamento.BackColor = System.Drawing.Color.Transparent
        Me.btGerarParcelamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGerarParcelamento.Enabled = False
        Me.btGerarParcelamento.FlatAppearance.BorderSize = 0
        Me.btGerarParcelamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btGerarParcelamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btGerarParcelamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGerarParcelamento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGerarParcelamento.ForeColor = System.Drawing.Color.White
        Me.btGerarParcelamento.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.numbered_24
        Me.btGerarParcelamento.Location = New System.Drawing.Point(844, 395)
        Me.btGerarParcelamento.Margin = New System.Windows.Forms.Padding(5)
        Me.btGerarParcelamento.Name = "btGerarParcelamento"
        Me.btGerarParcelamento.Size = New System.Drawing.Size(105, 55)
        Me.btGerarParcelamento.TabIndex = 383
        Me.btGerarParcelamento.Text = "Gerar     Parcelas"
        Me.btGerarParcelamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btGerarParcelamento.UseVisualStyleBackColor = False
        '
        'btPendente
        '
        Me.btPendente.BackColor = System.Drawing.Color.Transparent
        Me.btPendente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPendente.Enabled = False
        Me.btPendente.FlatAppearance.BorderSize = 0
        Me.btPendente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btPendente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btPendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPendente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPendente.ForeColor = System.Drawing.Color.White
        Me.btPendente.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Filter
        Me.btPendente.Location = New System.Drawing.Point(836, 241)
        Me.btPendente.Margin = New System.Windows.Forms.Padding(5)
        Me.btPendente.Name = "btPendente"
        Me.btPendente.Size = New System.Drawing.Size(117, 60)
        Me.btPendente.TabIndex = 382
        Me.btPendente.Text = "Contas Pendentes"
        Me.btPendente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPendente.UseVisualStyleBackColor = False
        '
        'btGrafico
        '
        Me.btGrafico.BackColor = System.Drawing.Color.Transparent
        Me.btGrafico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGrafico.FlatAppearance.BorderSize = 0
        Me.btGrafico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btGrafico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGrafico.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGrafico.ForeColor = System.Drawing.Color.White
        Me.btGrafico.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Pie_chart
        Me.btGrafico.Location = New System.Drawing.Point(836, 325)
        Me.btGrafico.Margin = New System.Windows.Forms.Padding(5)
        Me.btGrafico.Name = "btGrafico"
        Me.btGrafico.Size = New System.Drawing.Size(108, 36)
        Me.btGrafico.TabIndex = 381
        Me.btGrafico.Text = "Gráfico"
        Me.btGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btGrafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btGrafico.UseVisualStyleBackColor = False
        '
        'btEditar
        '
        Me.btEditar.BackColor = System.Drawing.Color.Transparent
        Me.btEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEditar.Enabled = False
        Me.btEditar.FlatAppearance.BorderSize = 0
        Me.btEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEditar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEditar.ForeColor = System.Drawing.Color.White
        Me.btEditar.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Edit
        Me.btEditar.Location = New System.Drawing.Point(750, 105)
        Me.btEditar.Margin = New System.Windows.Forms.Padding(5)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(92, 44)
        Me.btEditar.TabIndex = 380
        Me.btEditar.Text = "Editar"
        Me.btEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEditar.UseVisualStyleBackColor = False
        '
        'btExcluir
        '
        Me.btExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExcluir.Enabled = False
        Me.btExcluir.FlatAppearance.BorderSize = 0
        Me.btExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExcluir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExcluir.ForeColor = System.Drawing.Color.White
        Me.btExcluir.Image = CType(resources.GetObject("btExcluir.Image"), System.Drawing.Image)
        Me.btExcluir.Location = New System.Drawing.Point(848, 109)
        Me.btExcluir.Margin = New System.Windows.Forms.Padding(5)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(99, 37)
        Me.btExcluir.TabIndex = 379
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btExcluir.UseVisualStyleBackColor = False
        '
        'btPagar
        '
        Me.btPagar.BackColor = System.Drawing.Color.Transparent
        Me.btPagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btPagar.Enabled = False
        Me.btPagar.FlatAppearance.BorderSize = 0
        Me.btPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPagar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPagar.ForeColor = System.Drawing.Color.White
        Me.btPagar.Image = CType(resources.GetObject("btPagar.Image"), System.Drawing.Image)
        Me.btPagar.Location = New System.Drawing.Point(805, 159)
        Me.btPagar.Margin = New System.Windows.Forms.Padding(5)
        Me.btPagar.Name = "btPagar"
        Me.btPagar.Size = New System.Drawing.Size(110, 58)
        Me.btPagar.TabIndex = 378
        Me.btPagar.Text = "Pgto de  Conta"
        Me.btPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btPagar.UseVisualStyleBackColor = False
        '
        'btSalvar
        '
        Me.btSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.FlatAppearance.BorderSize = 0
        Me.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.ForeColor = System.Drawing.Color.White
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.Location = New System.Drawing.Point(858, 64)
        Me.btSalvar.Margin = New System.Windows.Forms.Padding(5)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(83, 37)
        Me.btSalvar.TabIndex = 377
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = False
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.Color.Transparent
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.ForeColor = System.Drawing.Color.White
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(755, 66)
        Me.btNovo.Margin = New System.Windows.Forms.Padding(5)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(80, 34)
        Me.btNovo.TabIndex = 376
        Me.btNovo.Text = "Novo "
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'dgvContasReceber
        '
        Me.dgvContasReceber.AllowUserToAddRows = False
        Me.dgvContasReceber.AllowUserToDeleteRows = False
        Me.dgvContasReceber.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvContasReceber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvContasReceber.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvContasReceber.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvContasReceber.GridColor = System.Drawing.Color.DarkBlue
        Me.dgvContasReceber.Location = New System.Drawing.Point(7, 232)
        Me.dgvContasReceber.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgvContasReceber.Name = "dgvContasReceber"
        Me.dgvContasReceber.ReadOnly = True
        Me.dgvContasReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContasReceber.Size = New System.Drawing.Size(824, 334)
        Me.dgvContasReceber.TabIndex = 385
        '
        'frmReceberContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(953, 641)
        Me.Controls.Add(Me.dgvContasReceber)
        Me.Controls.Add(Me.btPagarParcela)
        Me.Controls.Add(Me.btGerarParcelamento)
        Me.Controls.Add(Me.btPendente)
        Me.Controls.Add(Me.btGrafico)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btExcluir)
        Me.Controls.Add(Me.btPagar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalContasRecebidas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalContasNaoRecebidas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalContasReceber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotalLinhas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReceberContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReceberContas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvContasReceber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotalLinhas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalContasRecebidas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalContasNaoRecebidas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalContasReceber As TextBox
    Friend WithEvents btSair As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpVencimento As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFormaPagto As ComboBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDescricao As ComboBox
    Friend WithEvents txtCliente As ComboBox
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbContasRecebidas As RadioButton
    Friend WithEvents txtBuscarTipoConta As ComboBox
    Friend WithEvents txtBuscarCliente As ComboBox
    Friend WithEvents rbContasReceber As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents rbTodas As RadioButton
    Friend WithEvents rbTipoConta As RadioButton
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents btPagarParcela As Button
    Friend WithEvents btGerarParcelamento As Button
    Friend WithEvents btPendente As Button
    Friend WithEvents btGrafico As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btExcluir As Button
    Friend WithEvents btPagar As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents dgvContasReceber As DataGridView
End Class
