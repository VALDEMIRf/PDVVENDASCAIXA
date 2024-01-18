<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtValorVenda = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.cbProduto = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.btRel = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEstoque = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.pbImagem = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantVendida = New System.Windows.Forms.TextBox()
        Me.txtCodBarras = New System.Windows.Forms.TextBox()
        Me.lblValorVenda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalUnit = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalFinal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTroco = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.txtValorRecebido = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtValorVenda
        '
        Me.txtValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorVenda.Enabled = False
        Me.txtValorVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorVenda.Location = New System.Drawing.Point(425, 533)
        Me.txtValorVenda.Name = "txtValorVenda"
        Me.txtValorVenda.Size = New System.Drawing.Size(90, 31)
        Me.txtValorVenda.TabIndex = 198
        Me.txtValorVenda.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(405, 4)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(35, 23)
        Me.txtCodigo.TabIndex = 204
        Me.txtCodigo.Visible = False
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(450, 341)
        Me.txtQuantidade.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(89, 31)
        Me.txtQuantidade.TabIndex = 197
        Me.txtQuantidade.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(981, 161)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(28, 39)
        Me.lblTotal.TabIndex = 212
        Me.lblTotal.Text = "-"
        '
        'cbProduto
        '
        Me.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduto.Enabled = False
        Me.cbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.Location = New System.Drawing.Point(450, 170)
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(448, 37)
        Me.cbProduto.TabIndex = 194
        '
        'cbCliente
        '
        Me.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCliente.Enabled = False
        Me.cbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(450, 249)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(457, 37)
        Me.cbCliente.TabIndex = 195
        '
        'btRel
        '
        Me.btRel.BackColor = System.Drawing.Color.Transparent
        Me.btRel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRel.FlatAppearance.BorderSize = 0
        Me.btRel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btRel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRel.ForeColor = System.Drawing.Color.Black
        Me.btRel.Image = CType(resources.GetObject("btRel.Image"), System.Drawing.Image)
        Me.btRel.Location = New System.Drawing.Point(16, 520)
        Me.btRel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btRel.Name = "btRel"
        Me.btRel.Size = New System.Drawing.Size(162, 52)
        Me.btRel.TabIndex = 166
        Me.btRel.Text = "Comprovante"
        Me.btRel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btRel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btRel.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.ForeColor = System.Drawing.Color.Black
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(7, 473)
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
        Me.btSair.ForeColor = System.Drawing.Color.Black
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(192, 539)
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
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(83, 492)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(95, 37)
        Me.btnSalvar.TabIndex = 162
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.ForeColor = System.Drawing.Color.Black
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(192, 490)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(86, 37)
        Me.btnExcluir.TabIndex = 164
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(618, 3)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(137, 23)
        Me.txtBuscar.TabIndex = 216
        Me.txtBuscar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(555, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "Buscar:"
        Me.Label1.Visible = False
        '
        'txtNum
        '
        Me.txtNum.Enabled = False
        Me.txtNum.Location = New System.Drawing.Point(107, 3)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(109, 23)
        Me.txtNum.TabIndex = 217
        Me.txtNum.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 218
        Me.Label2.Text = "Núm. Venda:"
        Me.Label2.Visible = False
        '
        'txtEstoque
        '
        Me.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstoque.Enabled = False
        Me.txtEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstoque.Location = New System.Drawing.Point(450, 498)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(163, 31)
        Me.txtEstoque.TabIndex = 219
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle3
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(10, 59)
        Me.dg.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dg.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(433, 404)
        Me.dg.TabIndex = 221
        '
        'pbImagem
        '
        Me.pbImagem.BackColor = System.Drawing.Color.White
        Me.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImagem.Location = New System.Drawing.Point(654, 337)
        Me.pbImagem.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pbImagem.Name = "pbImagem"
        Me.pbImagem.Size = New System.Drawing.Size(190, 190)
        Me.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagem.TabIndex = 222
        Me.pbImagem.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(450, 416)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 31)
        Me.Label9.TabIndex = 223
        Me.Label9.Text = "R$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(926, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 39)
        Me.Label5.TabIndex = 224
        Me.Label5.Text = "R$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(226, 6)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 225
        Me.Label6.Text = "Quant. Vendida:"
        Me.Label6.Visible = False
        '
        'txtQuantVendida
        '
        Me.txtQuantVendida.Enabled = False
        Me.txtQuantVendida.Location = New System.Drawing.Point(337, 3)
        Me.txtQuantVendida.Name = "txtQuantVendida"
        Me.txtQuantVendida.Size = New System.Drawing.Size(55, 23)
        Me.txtQuantVendida.TabIndex = 226
        Me.txtQuantVendida.Visible = False
        '
        'txtCodBarras
        '
        Me.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarras.Location = New System.Drawing.Point(450, 77)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(444, 38)
        Me.txtCodBarras.TabIndex = 227
        '
        'lblValorVenda
        '
        Me.lblValorVenda.AutoSize = True
        Me.lblValorVenda.BackColor = System.Drawing.Color.White
        Me.lblValorVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorVenda.ForeColor = System.Drawing.Color.Black
        Me.lblValorVenda.Location = New System.Drawing.Point(506, 414)
        Me.lblValorVenda.Name = "lblValorVenda"
        Me.lblValorVenda.Size = New System.Drawing.Size(23, 31)
        Me.lblValorVenda.TabIndex = 228
        Me.lblValorVenda.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(925, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 39)
        Me.Label3.TabIndex = 230
        Me.Label3.Text = "R$"
        '
        'lblTotalUnit
        '
        Me.lblTotalUnit.AutoSize = True
        Me.lblTotalUnit.BackColor = System.Drawing.Color.White
        Me.lblTotalUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUnit.ForeColor = System.Drawing.Color.Black
        Me.lblTotalUnit.Location = New System.Drawing.Point(980, 68)
        Me.lblTotalUnit.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTotalUnit.Name = "lblTotalUnit"
        Me.lblTotalUnit.Size = New System.Drawing.Size(28, 39)
        Me.lblTotalUnit.TabIndex = 229
        Me.lblTotalUnit.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(926, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 39)
        Me.Label4.TabIndex = 232
        Me.Label4.Text = "R$"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(926, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 39)
        Me.Label8.TabIndex = 234
        Me.Label8.Text = "R$"
        '
        'lblTotalFinal
        '
        Me.lblTotalFinal.AutoSize = True
        Me.lblTotalFinal.BackColor = System.Drawing.Color.White
        Me.lblTotalFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFinal.ForeColor = System.Drawing.Color.Green
        Me.lblTotalFinal.Location = New System.Drawing.Point(980, 336)
        Me.lblTotalFinal.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTotalFinal.Name = "lblTotalFinal"
        Me.lblTotalFinal.Size = New System.Drawing.Size(28, 39)
        Me.lblTotalFinal.TabIndex = 233
        Me.lblTotalFinal.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(926, 525)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 39)
        Me.Label13.TabIndex = 238
        Me.Label13.Text = "R$"
        '
        'lblTroco
        '
        Me.lblTroco.AutoSize = True
        Me.lblTroco.BackColor = System.Drawing.Color.White
        Me.lblTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroco.ForeColor = System.Drawing.Color.Red
        Me.lblTroco.Location = New System.Drawing.Point(980, 525)
        Me.lblTroco.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTroco.Name = "lblTroco"
        Me.lblTroco.Size = New System.Drawing.Size(28, 39)
        Me.lblTroco.TabIndex = 237
        Me.lblTroco.Text = "-"
        '
        'txtDesconto
        '
        Me.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Location = New System.Drawing.Point(983, 246)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(145, 38)
        Me.txtDesconto.TabIndex = 239
        '
        'txtValorRecebido
        '
        Me.txtValorRecebido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorRecebido.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorRecebido.Location = New System.Drawing.Point(983, 430)
        Me.txtValorRecebido.Name = "txtValorRecebido"
        Me.txtValorRecebido.Size = New System.Drawing.Size(145, 38)
        Me.txtValorRecebido.TabIndex = 241
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(925, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 39)
        Me.Label7.TabIndex = 240
        Me.Label7.Text = "R$"
        '
        'frmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1188, 587)
        Me.Controls.Add(Me.txtValorRecebido)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTroco)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTotalFinal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalUnit)
        Me.Controls.Add(Me.lblValorVenda)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btRel)
        Me.Controls.Add(Me.txtCodBarras)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtQuantVendida)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.pbImagem)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtEstoque)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtValorVenda)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.cbProduto)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas - PDV"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValorVenda As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents cbProduto As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btSair As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEstoque As TextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents pbImagem As PictureBox
    Friend WithEvents btRel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantVendida As TextBox
    Friend WithEvents txtCodBarras As TextBox
    Friend WithEvents lblValorVenda As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalUnit As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalFinal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTroco As Label
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents txtValorRecebido As TextBox
    Friend WithEvents Label7 As Label
End Class
