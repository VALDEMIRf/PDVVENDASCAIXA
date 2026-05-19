<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContasApagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContasApagar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.dgvContas = New System.Windows.Forms.DataGridView()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtTipoConta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFormaPagto = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpVencimento = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbContasPagas = New System.Windows.Forms.RadioButton()
        Me.txtBuscarTipoConta = New System.Windows.Forms.ComboBox()
        Me.txtBuscarFornecedor = New System.Windows.Forms.ComboBox()
        Me.rbContasPagar = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbTodas = New System.Windows.Forms.RadioButton()
        Me.rbTipoConta = New System.Windows.Forms.RadioButton()
        Me.rbFornecedor = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotalContasPagas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotalContasNaoPagas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalContasPagar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTotalLinhas = New System.Windows.Forms.Label()
        Me.btPagarParcela = New System.Windows.Forms.Button()
        Me.btGerarParcelamento = New System.Windows.Forms.Button()
        Me.btPendente = New System.Windows.Forms.Button()
        Me.btGrafico = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btPagar = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btSair)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(958, 47)
        Me.Panel1.TabIndex = 314
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 41)
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
        Me.Label5.Location = New System.Drawing.Point(234, -4)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(431, 51)
        Me.Label5.TabIndex = 311
        Me.Label5.Text = "CONTAS A PAGAR"
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
        Me.btSair.Location = New System.Drawing.Point(859, 7)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(85, 35)
        Me.btSair.TabIndex = 13
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'dgvContas
        '
        Me.dgvContas.AllowUserToAddRows = False
        Me.dgvContas.AllowUserToDeleteRows = False
        Me.dgvContas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvContas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvContas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvContas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvContas.GridColor = System.Drawing.Color.DarkBlue
        Me.dgvContas.Location = New System.Drawing.Point(12, 233)
        Me.dgvContas.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgvContas.Name = "dgvContas"
        Me.dgvContas.ReadOnly = True
        Me.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContas.Size = New System.Drawing.Size(817, 328)
        Me.dgvContas.TabIndex = 315
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(478, 59)
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
        Me.Label8.Location = New System.Drawing.Point(181, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 337
        Me.Label8.Text = "Descrição"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(528, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 338
        Me.Label1.Text = "Valor"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(523, 76)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(88, 20)
        Me.txtValor.TabIndex = 336
        '
        'txtTipoConta
        '
        Me.txtTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTipoConta.FormattingEnabled = True
        Me.txtTipoConta.Location = New System.Drawing.Point(181, 31)
        Me.txtTipoConta.Name = "txtTipoConta"
        Me.txtTipoConta.Size = New System.Drawing.Size(233, 21)
        Me.txtTipoConta.TabIndex = 333
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 339
        Me.Label4.Text = "Fornecedor"
        '
        'txtNDoc
        '
        Me.txtNDoc.Location = New System.Drawing.Point(8, 31)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(165, 20)
        Me.txtNDoc.TabIndex = 335
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 341
        Me.Label3.Text = "N° Docto"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFornecedor.FormattingEnabled = True
        Me.txtFornecedor.Location = New System.Drawing.Point(11, 76)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(441, 21)
        Me.txtFornecedor.TabIndex = 343
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(540, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 346
        Me.Label2.Text = "Forma de Pagto"
        '
        'txtFormaPagto
        '
        Me.txtFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFormaPagto.FormattingEnabled = True
        Me.txtFormaPagto.Location = New System.Drawing.Point(537, 31)
        Me.txtFormaPagto.Name = "txtFormaPagto"
        Me.txtFormaPagto.Size = New System.Drawing.Size(126, 21)
        Me.txtFormaPagto.TabIndex = 344
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpVencimento)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtFormaPagto)
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTipoConta)
        Me.GroupBox1.Controls.Add(Me.txtFornecedor)
        Me.GroupBox1.Controls.Add(Me.txtNDoc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(738, 112)
        Me.GroupBox1.TabIndex = 349
        Me.GroupBox1.TabStop = False
        '
        'dtpVencimento
        '
        Me.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimento.Location = New System.Drawing.Point(623, 77)
        Me.dtpVencimento.Name = "dtpVencimento"
        Me.dtpVencimento.Size = New System.Drawing.Size(85, 20)
        Me.dtpVencimento.TabIndex = 351
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(619, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 20)
        Me.Label7.TabIndex = 350
        Me.Label7.Text = "Vencimento"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbContasPagas)
        Me.GroupBox3.Controls.Add(Me.txtBuscarTipoConta)
        Me.GroupBox3.Controls.Add(Me.txtBuscarFornecedor)
        Me.GroupBox3.Controls.Add(Me.rbContasPagar)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.rbTodas)
        Me.GroupBox3.Controls.Add(Me.rbTipoConta)
        Me.GroupBox3.Controls.Add(Me.rbFornecedor)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(738, 49)
        Me.GroupBox3.TabIndex = 351
        Me.GroupBox3.TabStop = False
        '
        'rbContasPagas
        '
        Me.rbContasPagas.AutoSize = True
        Me.rbContasPagas.ForeColor = System.Drawing.Color.White
        Me.rbContasPagas.Location = New System.Drawing.Point(226, 20)
        Me.rbContasPagas.Name = "rbContasPagas"
        Me.rbContasPagas.Size = New System.Drawing.Size(91, 17)
        Me.rbContasPagas.TabIndex = 207
        Me.rbContasPagas.TabStop = True
        Me.rbContasPagas.Text = "Contas Pagas"
        Me.rbContasPagas.UseVisualStyleBackColor = True
        '
        'txtBuscarTipoConta
        '
        Me.txtBuscarTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBuscarTipoConta.FormattingEnabled = True
        Me.txtBuscarTipoConta.Location = New System.Drawing.Point(505, 18)
        Me.txtBuscarTipoConta.Name = "txtBuscarTipoConta"
        Me.txtBuscarTipoConta.Size = New System.Drawing.Size(220, 21)
        Me.txtBuscarTipoConta.TabIndex = 295
        '
        'txtBuscarFornecedor
        '
        Me.txtBuscarFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBuscarFornecedor.FormattingEnabled = True
        Me.txtBuscarFornecedor.Location = New System.Drawing.Point(504, 17)
        Me.txtBuscarFornecedor.Name = "txtBuscarFornecedor"
        Me.txtBuscarFornecedor.Size = New System.Drawing.Size(220, 21)
        Me.txtBuscarFornecedor.TabIndex = 310
        '
        'rbContasPagar
        '
        Me.rbContasPagar.AutoSize = True
        Me.rbContasPagar.ForeColor = System.Drawing.Color.White
        Me.rbContasPagar.Location = New System.Drawing.Point(125, 20)
        Me.rbContasPagar.Name = "rbContasPagar"
        Me.rbContasPagar.Size = New System.Drawing.Size(98, 17)
        Me.rbContasPagar.TabIndex = 208
        Me.rbContasPagar.TabStop = True
        Me.rbContasPagar.Text = "Contas a Pagar"
        Me.rbContasPagar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(4, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 206
        Me.Label6.Text = "Buscar:"
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
        Me.rbTipoConta.Location = New System.Drawing.Point(322, 20)
        Me.rbTipoConta.Name = "rbTipoConta"
        Me.rbTipoConta.Size = New System.Drawing.Size(92, 17)
        Me.rbTipoConta.TabIndex = 210
        Me.rbTipoConta.TabStop = True
        Me.rbTipoConta.Text = "Tipo de Conta"
        Me.rbTipoConta.UseVisualStyleBackColor = True
        '
        'rbFornecedor
        '
        Me.rbFornecedor.AutoSize = True
        Me.rbFornecedor.ForeColor = System.Drawing.Color.White
        Me.rbFornecedor.Location = New System.Drawing.Point(419, 20)
        Me.rbFornecedor.Name = "rbFornecedor"
        Me.rbFornecedor.Size = New System.Drawing.Size(79, 17)
        Me.rbFornecedor.TabIndex = 211
        Me.rbFornecedor.TabStop = True
        Me.rbFornecedor.Text = "Fornecedor"
        Me.rbFornecedor.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 567)
        Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 20)
        Me.Label10.TabIndex = 359
        Me.Label10.Text = "Contas Pagas"
        '
        'txtTotalContasPagas
        '
        Me.txtTotalContasPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasPagas.ForeColor = System.Drawing.Color.Green
        Me.txtTotalContasPagas.Location = New System.Drawing.Point(12, 597)
        Me.txtTotalContasPagas.Multiline = True
        Me.txtTotalContasPagas.Name = "txtTotalContasPagas"
        Me.txtTotalContasPagas.ReadOnly = True
        Me.txtTotalContasPagas.Size = New System.Drawing.Size(217, 33)
        Me.txtTotalContasPagas.TabIndex = 358
        Me.txtTotalContasPagas.Text = "R$ 0,00"
        Me.txtTotalContasPagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(246, 571)
        Me.Label11.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 20)
        Me.Label11.TabIndex = 357
        Me.Label11.Text = "Contas Não Pagas"
        '
        'txtTotalContasNaoPagas
        '
        Me.txtTotalContasNaoPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasNaoPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasNaoPagas.ForeColor = System.Drawing.Color.Red
        Me.txtTotalContasNaoPagas.Location = New System.Drawing.Point(238, 597)
        Me.txtTotalContasNaoPagas.Multiline = True
        Me.txtTotalContasNaoPagas.Name = "txtTotalContasNaoPagas"
        Me.txtTotalContasNaoPagas.ReadOnly = True
        Me.txtTotalContasNaoPagas.Size = New System.Drawing.Size(217, 33)
        Me.txtTotalContasNaoPagas.TabIndex = 356
        Me.txtTotalContasNaoPagas.Text = "R$ 0,00"
        Me.txtTotalContasNaoPagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(474, 573)
        Me.Label12.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 20)
        Me.Label12.TabIndex = 355
        Me.Label12.Text = "Total:"
        '
        'txtTotalContasPagar
        '
        Me.txtTotalContasPagar.BackColor = System.Drawing.Color.White
        Me.txtTotalContasPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasPagar.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalContasPagar.Location = New System.Drawing.Point(461, 597)
        Me.txtTotalContasPagar.Multiline = True
        Me.txtTotalContasPagar.Name = "txtTotalContasPagar"
        Me.txtTotalContasPagar.ReadOnly = True
        Me.txtTotalContasPagar.Size = New System.Drawing.Size(217, 33)
        Me.txtTotalContasPagar.TabIndex = 354
        Me.txtTotalContasPagar.Text = "R$ 0,00"
        Me.txtTotalContasPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(717, 569)
        Me.Label13.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 20)
        Me.Label13.TabIndex = 353
        Me.Label13.Text = "Nº de linhas:"
        '
        'lblTotalLinhas
        '
        Me.lblTotalLinhas.AutoSize = True
        Me.lblTotalLinhas.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalLinhas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLinhas.ForeColor = System.Drawing.Color.White
        Me.lblTotalLinhas.Location = New System.Drawing.Point(812, 570)
        Me.lblTotalLinhas.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotalLinhas.Name = "lblTotalLinhas"
        Me.lblTotalLinhas.Size = New System.Drawing.Size(14, 20)
        Me.lblTotalLinhas.TabIndex = 352
        Me.lblTotalLinhas.Text = "-"
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
        Me.btPagarParcela.Location = New System.Drawing.Point(838, 488)
        Me.btPagarParcela.Margin = New System.Windows.Forms.Padding(5)
        Me.btPagarParcela.Name = "btPagarParcela"
        Me.btPagarParcela.Size = New System.Drawing.Size(114, 58)
        Me.btPagarParcela.TabIndex = 368
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
        Me.btGerarParcelamento.Location = New System.Drawing.Point(846, 407)
        Me.btGerarParcelamento.Margin = New System.Windows.Forms.Padding(5)
        Me.btGerarParcelamento.Name = "btGerarParcelamento"
        Me.btGerarParcelamento.Size = New System.Drawing.Size(106, 50)
        Me.btGerarParcelamento.TabIndex = 367
        Me.btGerarParcelamento.Text = "Gerar      Parcelas"
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
        Me.btPendente.Location = New System.Drawing.Point(836, 251)
        Me.btPendente.Margin = New System.Windows.Forms.Padding(5)
        Me.btPendente.Name = "btPendente"
        Me.btPendente.Size = New System.Drawing.Size(115, 47)
        Me.btPendente.TabIndex = 366
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
        Me.btGrafico.Location = New System.Drawing.Point(844, 339)
        Me.btGrafico.Margin = New System.Windows.Forms.Padding(5)
        Me.btGrafico.Name = "btGrafico"
        Me.btGrafico.Size = New System.Drawing.Size(106, 38)
        Me.btGrafico.TabIndex = 365
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
        Me.btEditar.Location = New System.Drawing.Point(752, 100)
        Me.btEditar.Margin = New System.Windows.Forms.Padding(5)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(96, 42)
        Me.btEditar.TabIndex = 364
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
        Me.btExcluir.Location = New System.Drawing.Point(852, 106)
        Me.btExcluir.Margin = New System.Windows.Forms.Padding(5)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(96, 34)
        Me.btExcluir.TabIndex = 363
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
        Me.btPagar.Location = New System.Drawing.Point(828, 168)
        Me.btPagar.Margin = New System.Windows.Forms.Padding(5)
        Me.btPagar.Name = "btPagar"
        Me.btPagar.Size = New System.Drawing.Size(124, 58)
        Me.btPagar.TabIndex = 362
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
        Me.btSalvar.Location = New System.Drawing.Point(852, 57)
        Me.btSalvar.Margin = New System.Windows.Forms.Padding(5)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(96, 37)
        Me.btSalvar.TabIndex = 361
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = False
        '
        'btNovo
        '
        Me.btNovo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btNovo.BackColor = System.Drawing.Color.Transparent
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.ForeColor = System.Drawing.Color.White
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(752, 49)
        Me.btNovo.Margin = New System.Windows.Forms.Padding(5)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(90, 51)
        Me.btNovo.TabIndex = 360
        Me.btNovo.Text = "Novo "
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'frmContasApagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(958, 641)
        Me.Controls.Add(Me.btPagarParcela)
        Me.Controls.Add(Me.btGerarParcelamento)
        Me.Controls.Add(Me.btPendente)
        Me.Controls.Add(Me.btGrafico)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btExcluir)
        Me.Controls.Add(Me.btPagar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotalContasPagas)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTotalContasNaoPagas)
        Me.Controls.Add(Me.dgvContas)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalContasPagar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTotalLinhas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmContasApagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmContasApagar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btSair As Button
    Friend WithEvents dgvContas As DataGridView
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtTipoConta As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFornecedor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFormaPagto As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbContasPagas As RadioButton
    Friend WithEvents rbContasPagar As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents rbTodas As RadioButton
    Friend WithEvents rbTipoConta As RadioButton
    Friend WithEvents rbFornecedor As RadioButton
    Friend WithEvents txtBuscarTipoConta As ComboBox
    Friend WithEvents txtBuscarFornecedor As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalContasPagas As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotalContasNaoPagas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalContasPagar As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTotalLinhas As Label
    Friend WithEvents btNovo As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btPagar As Button
    Friend WithEvents btExcluir As Button
    Friend WithEvents dtpVencimento As DateTimePicker
    Friend WithEvents btEditar As Button
    Friend WithEvents btGrafico As Button
    Friend WithEvents btPendente As Button
    Friend WithEvents btGerarParcelamento As Button
    Friend WithEvents btPagarParcela As Button
End Class
