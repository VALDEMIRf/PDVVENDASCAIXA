<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContasPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContasPagar))
        Me.dgContasPagar = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtTotalContasPagar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalContasNaoPagas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalContasPagas = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbContasVencidas = New System.Windows.Forms.RadioButton()
        Me.rbContasPagar = New System.Windows.Forms.RadioButton()
        Me.rbContasPagas = New System.Windows.Forms.RadioButton()
        Me.rbTodas = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbConta = New System.Windows.Forms.RadioButton()
        Me.rbFornecedor = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalContasAtrasadas = New System.Windows.Forms.TextBox()
        Me.rbDescricao = New System.Windows.Forms.RadioButton()
        Me.txtBuscarDescricao = New System.Windows.Forms.TextBox()
        Me.txtBuscarConta = New System.Windows.Forms.ComboBox()
        Me.txtBuscarFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        CType(Me.dgContasPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgContasPagar
        '
        Me.dgContasPagar.AllowUserToAddRows = False
        Me.dgContasPagar.AllowUserToDeleteRows = False
        Me.dgContasPagar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgContasPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgContasPagar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgContasPagar.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgContasPagar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgContasPagar.GridColor = System.Drawing.Color.DarkBlue
        Me.dgContasPagar.Location = New System.Drawing.Point(3, 20)
        Me.dgContasPagar.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgContasPagar.Name = "dgContasPagar"
        Me.dgContasPagar.ReadOnly = True
        Me.dgContasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContasPagar.Size = New System.Drawing.Size(1172, 328)
        Me.dgContasPagar.TabIndex = 190
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1041, 515)
        Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 20)
        Me.Label10.TabIndex = 192
        Me.Label10.Text = "Nº de linhas:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(1154, 517)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 191
        Me.lblTotal.Text = "-"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(1136, 6)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(13, 18)
        Me.lblCodigo.TabIndex = 195
        Me.lblCodigo.Text = "-"
        '
        'txtTotalContasPagar
        '
        Me.txtTotalContasPagar.BackColor = System.Drawing.Color.White
        Me.txtTotalContasPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasPagar.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalContasPagar.Location = New System.Drawing.Point(535, 539)
        Me.txtTotalContasPagar.Multiline = True
        Me.txtTotalContasPagar.Name = "txtTotalContasPagar"
        Me.txtTotalContasPagar.ReadOnly = True
        Me.txtTotalContasPagar.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasPagar.TabIndex = 196
        Me.txtTotalContasPagar.Text = "R$ 0,00"
        Me.txtTotalContasPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(544, 514)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 197
        Me.Label7.Text = "Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(192, 515)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Contas Não Pagas"
        '
        'txtTotalContasNaoPagas
        '
        Me.txtTotalContasNaoPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasNaoPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasNaoPagas.ForeColor = System.Drawing.Color.Red
        Me.txtTotalContasNaoPagas.Location = New System.Drawing.Point(190, 540)
        Me.txtTotalContasNaoPagas.Multiline = True
        Me.txtTotalContasNaoPagas.Name = "txtTotalContasNaoPagas"
        Me.txtTotalContasNaoPagas.ReadOnly = True
        Me.txtTotalContasNaoPagas.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasNaoPagas.TabIndex = 198
        Me.txtTotalContasNaoPagas.Text = "R$ 0,00"
        Me.txtTotalContasNaoPagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 515)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "Contas Pagas"
        '
        'txtTotalContasPagas
        '
        Me.txtTotalContasPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasPagas.ForeColor = System.Drawing.Color.Green
        Me.txtTotalContasPagas.Location = New System.Drawing.Point(14, 539)
        Me.txtTotalContasPagas.Multiline = True
        Me.txtTotalContasPagas.Name = "txtTotalContasPagas"
        Me.txtTotalContasPagas.ReadOnly = True
        Me.txtTotalContasPagas.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasPagas.TabIndex = 200
        Me.txtTotalContasPagas.Text = "R$ 0,00"
        Me.txtTotalContasPagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbContasVencidas)
        Me.GroupBox1.Controls.Add(Me.rbContasPagar)
        Me.GroupBox1.Controls.Add(Me.rbContasPagas)
        Me.GroupBox1.Controls.Add(Me.rbTodas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(10, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 75)
        Me.GroupBox1.TabIndex = 205
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar "
        '
        'rbContasVencidas
        '
        Me.rbContasVencidas.AutoSize = True
        Me.rbContasVencidas.Location = New System.Drawing.Point(131, 46)
        Me.rbContasVencidas.Name = "rbContasVencidas"
        Me.rbContasVencidas.Size = New System.Drawing.Size(132, 21)
        Me.rbContasVencidas.TabIndex = 209
        Me.rbContasVencidas.TabStop = True
        Me.rbContasVencidas.Text = "Contas Vencidas"
        Me.rbContasVencidas.UseVisualStyleBackColor = True
        '
        'rbContasPagar
        '
        Me.rbContasPagar.AutoSize = True
        Me.rbContasPagar.Location = New System.Drawing.Point(131, 16)
        Me.rbContasPagar.Name = "rbContasPagar"
        Me.rbContasPagar.Size = New System.Drawing.Size(124, 21)
        Me.rbContasPagar.TabIndex = 208
        Me.rbContasPagar.TabStop = True
        Me.rbContasPagar.Text = "Contas a Pagar"
        Me.rbContasPagar.UseVisualStyleBackColor = True
        '
        'rbContasPagas
        '
        Me.rbContasPagas.AutoSize = True
        Me.rbContasPagas.Location = New System.Drawing.Point(6, 46)
        Me.rbContasPagas.Name = "rbContasPagas"
        Me.rbContasPagas.Size = New System.Drawing.Size(114, 21)
        Me.rbContasPagas.TabIndex = 207
        Me.rbContasPagas.TabStop = True
        Me.rbContasPagas.Text = "Contas Pagas"
        Me.rbContasPagas.UseVisualStyleBackColor = True
        '
        'rbTodas
        '
        Me.rbTodas.AutoSize = True
        Me.rbTodas.Location = New System.Drawing.Point(6, 19)
        Me.rbTodas.Name = "rbTodas"
        Me.rbTodas.Size = New System.Drawing.Size(66, 21)
        Me.rbTodas.TabIndex = 206
        Me.rbTodas.TabStop = True
        Me.rbTodas.Text = "Todas"
        Me.rbTodas.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "Buscar:"
        '
        'rbConta
        '
        Me.rbConta.AutoSize = True
        Me.rbConta.ForeColor = System.Drawing.Color.White
        Me.rbConta.Location = New System.Drawing.Point(75, 17)
        Me.rbConta.Name = "rbConta"
        Me.rbConta.Size = New System.Drawing.Size(119, 22)
        Me.rbConta.TabIndex = 210
        Me.rbConta.TabStop = True
        Me.rbConta.Text = "Tipo de Conta"
        Me.rbConta.UseVisualStyleBackColor = True
        '
        'rbFornecedor
        '
        Me.rbFornecedor.AutoSize = True
        Me.rbFornecedor.ForeColor = System.Drawing.Color.White
        Me.rbFornecedor.Location = New System.Drawing.Point(206, 17)
        Me.rbFornecedor.Name = "rbFornecedor"
        Me.rbFornecedor.Size = New System.Drawing.Size(103, 22)
        Me.rbFornecedor.TabIndex = 211
        Me.rbFornecedor.TabStop = True
        Me.rbFornecedor.Text = "Fornecedor"
        Me.rbFornecedor.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgContasPagar)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1178, 351)
        Me.GroupBox2.TabIndex = 212
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(369, 515)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 214
        Me.Label4.Text = "Contas Vencidas"
        '
        'txtTotalContasAtrasadas
        '
        Me.txtTotalContasAtrasadas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasAtrasadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasAtrasadas.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTotalContasAtrasadas.Location = New System.Drawing.Point(363, 540)
        Me.txtTotalContasAtrasadas.Multiline = True
        Me.txtTotalContasAtrasadas.Name = "txtTotalContasAtrasadas"
        Me.txtTotalContasAtrasadas.ReadOnly = True
        Me.txtTotalContasAtrasadas.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasAtrasadas.TabIndex = 213
        Me.txtTotalContasAtrasadas.Text = "R$ 0,00"
        Me.txtTotalContasAtrasadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbDescricao
        '
        Me.rbDescricao.AutoSize = True
        Me.rbDescricao.ForeColor = System.Drawing.Color.White
        Me.rbDescricao.Location = New System.Drawing.Point(316, 17)
        Me.rbDescricao.Name = "rbDescricao"
        Me.rbDescricao.Size = New System.Drawing.Size(94, 22)
        Me.rbDescricao.TabIndex = 216
        Me.rbDescricao.TabStop = True
        Me.rbDescricao.Text = "Descrição"
        Me.rbDescricao.UseVisualStyleBackColor = True
        '
        'txtBuscarDescricao
        '
        Me.txtBuscarDescricao.Location = New System.Drawing.Point(412, 14)
        Me.txtBuscarDescricao.Name = "txtBuscarDescricao"
        Me.txtBuscarDescricao.Size = New System.Drawing.Size(396, 24)
        Me.txtBuscarDescricao.TabIndex = 217
        '
        'txtBuscarConta
        '
        Me.txtBuscarConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBuscarConta.FormattingEnabled = True
        Me.txtBuscarConta.Location = New System.Drawing.Point(412, 14)
        Me.txtBuscarConta.Name = "txtBuscarConta"
        Me.txtBuscarConta.Size = New System.Drawing.Size(396, 26)
        Me.txtBuscarConta.TabIndex = 295
        '
        'txtBuscarFornecedor
        '
        Me.txtBuscarFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBuscarFornecedor.FormattingEnabled = True
        Me.txtBuscarFornecedor.Location = New System.Drawing.Point(413, 14)
        Me.txtBuscarFornecedor.Name = "txtBuscarFornecedor"
        Me.txtBuscarFornecedor.Size = New System.Drawing.Size(396, 26)
        Me.txtBuscarFornecedor.TabIndex = 310
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Elephant", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(403, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(431, 51)
        Me.Label5.TabIndex = 311
        Me.Label5.Text = "CONTAS A PAGAR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 72)
        Me.Panel1.TabIndex = 313
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(81, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 312
        Me.PictureBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBuscarConta)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.rbConta)
        Me.GroupBox3.Controls.Add(Me.rbDescricao)
        Me.GroupBox3.Controls.Add(Me.rbFornecedor)
        Me.GroupBox3.Controls.Add(Me.txtBuscarFornecedor)
        Me.GroupBox3.Controls.Add(Me.txtBuscarDescricao)
        Me.GroupBox3.Location = New System.Drawing.Point(286, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(815, 49)
        Me.GroupBox3.TabIndex = 314
        Me.GroupBox3.TabStop = False
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.Color.Transparent
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.ForeColor = System.Drawing.Color.White
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(720, 529)
        Me.btNovo.Margin = New System.Windows.Forms.Padding(5)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(168, 43)
        Me.btNovo.TabIndex = 0
        Me.btNovo.Text = "Novo Cadastro"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'btSair
        '
        Me.btSair.BackColor = System.Drawing.Color.Transparent
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.ForeColor = System.Drawing.Color.White
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(925, 533)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(85, 35)
        Me.btSair.TabIndex = 13
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'frmContasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1200, 585)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalContasAtrasadas)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalContasPagas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalContasNaoPagas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalContasPagar)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContasPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas a Pagar"
        CType(Me.dgContasPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgContasPagar As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btNovo As Button
    Friend WithEvents btSair As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtTotalContasPagar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalContasNaoPagas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalContasPagas As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbContasVencidas As RadioButton
    Friend WithEvents rbContasPagar As RadioButton
    Friend WithEvents rbContasPagas As RadioButton
    Friend WithEvents rbTodas As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents rbConta As RadioButton
    Friend WithEvents rbFornecedor As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalContasAtrasadas As TextBox
    Friend WithEvents rbDescricao As RadioButton
    Friend WithEvents txtBuscarDescricao As TextBox
    Friend WithEvents txtBuscarConta As ComboBox
    Friend WithEvents txtBuscarFornecedor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
End Class
