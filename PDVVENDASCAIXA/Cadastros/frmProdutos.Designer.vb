<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProdutos
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdutos))
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtValorCompra = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbUnidade = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtCodBarras = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.cbFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtValorVenda = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btFornecedores = New System.Windows.Forms.Button()
        Me.btUnidadesMedidas = New System.Windows.Forms.Button()
        Me.btCategorias = New System.Windows.Forms.Button()
        Me.imgCodBar = New System.Windows.Forms.PictureBox()
        Me.btImagem = New System.Windows.Forms.Button()
        Me.pbImagem = New System.Windows.Forms.PictureBox()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCodBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkBlue
        Me.dg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg.GridColor = System.Drawing.Color.CadetBlue
        Me.dg.Location = New System.Drawing.Point(6, 190)
        Me.dg.Margin = New System.Windows.Forms.Padding(4)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(1016, 306)
        Me.dg.TabIndex = 0
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(90, 161)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(137, 20)
        Me.txtBuscar.TabIndex = 149
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 162)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Buscar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNovo)
        Me.GroupBox1.Controls.Add(Me.btSair)
        Me.GroupBox1.Controls.Add(Me.btnSalvar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnExcluir)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 494)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(438, 58)
        Me.GroupBox1.TabIndex = 190
        Me.GroupBox1.TabStop = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(7, 14)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(81, 37)
        Me.btnNovo.TabIndex = 161
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btSair
        '
        Me.btSair.BackColor = System.Drawing.Color.Transparent
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.ForeColor = System.Drawing.Color.White
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(360, 15)
        Me.btSair.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(73, 33)
        Me.btSair.TabIndex = 165
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(86, 13)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(87, 37)
        Me.btnSalvar.TabIndex = 162
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(186, 13)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(83, 36)
        Me.btnEditar.TabIndex = 163
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(275, 12)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(87, 37)
        Me.btnExcluir.TabIndex = 164
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'errErro
        '
        Me.errErro.ContainerControl = Me
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(245, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(466, 39)
        Me.Label16.TabIndex = 251
        Me.Label16.Text = "Gerenciamento de Produtos"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(523, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 17)
        Me.Label14.TabIndex = 250
        Me.Label14.Text = "R$"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(762, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 17)
        Me.Label9.TabIndex = 249
        Me.Label9.Text = "R$"
        '
        'txtValorCompra
        '
        Me.txtValorCompra.Enabled = False
        Me.txtValorCompra.Location = New System.Drawing.Point(548, 72)
        Me.txtValorCompra.Name = "txtValorCompra"
        Me.txtValorCompra.Size = New System.Drawing.Size(58, 20)
        Me.txtValorCompra.TabIndex = 231
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.SteelBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(541, 102)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 18)
        Me.Label13.TabIndex = 248
        Me.Label13.Text = "Cód. de Barras:"
        '
        'cbUnidade
        '
        Me.cbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidade.Enabled = False
        Me.cbUnidade.FormattingEnabled = True
        Me.cbUnidade.Location = New System.Drawing.Point(778, 44)
        Me.cbUnidade.Name = "cbUnidade"
        Me.cbUnidade.Size = New System.Drawing.Size(74, 21)
        Me.cbUnidade.TabIndex = 229
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(723, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 247
        Me.Label12.Text = "Unidade:"
        '
        'cbCategoria
        '
        Me.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategoria.Enabled = False
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(90, 128)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(233, 21)
        Me.cbCategoria.TabIndex = 228
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(32, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 246
        Me.Label10.Text = "Categoria:"
        '
        'txtNivel
        '
        Me.txtNivel.Location = New System.Drawing.Point(643, 45)
        Me.txtNivel.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(71, 20)
        Me.txtNivel.TabIndex = 243
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 233
        Me.Label2.Text = "Nome:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(552, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "Nível Mínimo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(-1, -4)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(35, 20)
        Me.txtCodigo.TabIndex = 237
        Me.txtCodigo.Visible = False
        '
        'txtCodBarras
        '
        Me.txtCodBarras.Location = New System.Drawing.Point(672, 101)
        Me.txtCodBarras.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(187, 20)
        Me.txtCodBarras.TabIndex = 244
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(89, 45)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(304, 20)
        Me.txtNome.TabIndex = 225
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 235
        Me.Label5.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(90, 69)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(304, 26)
        Me.txtDescricao.TabIndex = 226
        '
        'cbFornecedor
        '
        Me.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFornecedor.Enabled = False
        Me.cbFornecedor.FormattingEnabled = True
        Me.cbFornecedor.Location = New System.Drawing.Point(90, 99)
        Me.cbFornecedor.Name = "cbFornecedor"
        Me.cbFornecedor.Size = New System.Drawing.Size(304, 21)
        Me.cbFornecedor.TabIndex = 227
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(413, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 238
        Me.Label4.Text = "Valor de Compra:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "Fornecedor:"
        '
        'txtValorVenda
        '
        Me.txtValorVenda.Location = New System.Drawing.Point(786, 74)
        Me.txtValorVenda.Margin = New System.Windows.Forms.Padding(5)
        Me.txtValorVenda.MaxLength = 16
        Me.txtValorVenda.Name = "txtValorVenda"
        Me.txtValorVenda.Size = New System.Drawing.Size(72, 20)
        Me.txtValorVenda.TabIndex = 232
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(401, 46)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 234
        Me.Label7.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(483, 44)
        Me.txtQuantidade.Margin = New System.Windows.Forms.Padding(5)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(58, 20)
        Me.txtQuantidade.TabIndex = 230
        Me.txtQuantidade.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(659, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 236
        Me.Label3.Text = "Valor de Venda:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(899, 514)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 20)
        Me.Label11.TabIndex = 253
        Me.Label11.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(953, 513)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 252
        Me.lblTotal.Text = "-"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btFornecedores
        '
        Me.btFornecedores.BackColor = System.Drawing.Color.Transparent
        Me.btFornecedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFornecedores.FlatAppearance.BorderSize = 0
        Me.btFornecedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btFornecedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFornecedores.ForeColor = System.Drawing.Color.White
        Me.btFornecedores.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Create
        Me.btFornecedores.Location = New System.Drawing.Point(397, 95)
        Me.btFornecedores.Margin = New System.Windows.Forms.Padding(5)
        Me.btFornecedores.Name = "btFornecedores"
        Me.btFornecedores.Size = New System.Drawing.Size(35, 27)
        Me.btFornecedores.TabIndex = 256
        Me.btFornecedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFornecedores.UseVisualStyleBackColor = False
        '
        'btUnidadesMedidas
        '
        Me.btUnidadesMedidas.BackColor = System.Drawing.Color.Transparent
        Me.btUnidadesMedidas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btUnidadesMedidas.FlatAppearance.BorderSize = 0
        Me.btUnidadesMedidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btUnidadesMedidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btUnidadesMedidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btUnidadesMedidas.ForeColor = System.Drawing.Color.White
        Me.btUnidadesMedidas.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Create
        Me.btUnidadesMedidas.Location = New System.Drawing.Point(856, 40)
        Me.btUnidadesMedidas.Margin = New System.Windows.Forms.Padding(5)
        Me.btUnidadesMedidas.Name = "btUnidadesMedidas"
        Me.btUnidadesMedidas.Size = New System.Drawing.Size(35, 27)
        Me.btUnidadesMedidas.TabIndex = 255
        Me.btUnidadesMedidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btUnidadesMedidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btUnidadesMedidas.UseVisualStyleBackColor = False
        '
        'btCategorias
        '
        Me.btCategorias.BackColor = System.Drawing.Color.Transparent
        Me.btCategorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCategorias.FlatAppearance.BorderSize = 0
        Me.btCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCategorias.ForeColor = System.Drawing.Color.White
        Me.btCategorias.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Create
        Me.btCategorias.Location = New System.Drawing.Point(328, 125)
        Me.btCategorias.Margin = New System.Windows.Forms.Padding(5)
        Me.btCategorias.Name = "btCategorias"
        Me.btCategorias.Size = New System.Drawing.Size(35, 27)
        Me.btCategorias.TabIndex = 254
        Me.btCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btCategorias.UseVisualStyleBackColor = False
        '
        'imgCodBar
        '
        Me.imgCodBar.Location = New System.Drawing.Point(408, 128)
        Me.imgCodBar.Name = "imgCodBar"
        Me.imgCodBar.Size = New System.Drawing.Size(452, 50)
        Me.imgCodBar.TabIndex = 245
        Me.imgCodBar.TabStop = False
        '
        'btImagem
        '
        Me.btImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImagem.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btImagem.FlatAppearance.BorderSize = 0
        Me.btImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImagem.ForeColor = System.Drawing.Color.Transparent
        Me.btImagem.Image = CType(resources.GetObject("btImagem.Image"), System.Drawing.Image)
        Me.btImagem.Location = New System.Drawing.Point(947, 143)
        Me.btImagem.Margin = New System.Windows.Forms.Padding(4)
        Me.btImagem.Name = "btImagem"
        Me.btImagem.Size = New System.Drawing.Size(38, 27)
        Me.btImagem.TabIndex = 240
        Me.btImagem.UseVisualStyleBackColor = True
        '
        'pbImagem
        '
        Me.pbImagem.BackColor = System.Drawing.Color.White
        Me.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagem.Location = New System.Drawing.Point(892, 7)
        Me.pbImagem.Margin = New System.Windows.Forms.Padding(4)
        Me.pbImagem.Name = "pbImagem"
        Me.pbImagem.Size = New System.Drawing.Size(130, 130)
        Me.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagem.TabIndex = 239
        Me.pbImagem.TabStop = False
        '
        'frmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1035, 557)
        Me.Controls.Add(Me.btFornecedores)
        Me.Controls.Add(Me.btUnidadesMedidas)
        Me.Controls.Add(Me.btCategorias)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValorCompra)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbUnidade)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbCategoria)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.imgCodBar)
        Me.Controls.Add(Me.txtNivel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btImagem)
        Me.Controls.Add(Me.txtCodBarras)
        Me.Controls.Add(Me.pbImagem)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.cbFornecedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtValorVenda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Produtos"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCodBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btSair As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents errErro As ErrorProvider
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtValorCompra As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbUnidade As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents imgCodBar As PictureBox
    Friend WithEvents txtNivel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btImagem As Button
    Friend WithEvents txtCodBarras As TextBox
    Friend WithEvents pbImagem As PictureBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents cbFornecedor As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtValorVenda As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btUnidadesMedidas As Button
    Friend WithEvents btCategorias As Button
    Friend WithEvents btFornecedores As Button
End Class
