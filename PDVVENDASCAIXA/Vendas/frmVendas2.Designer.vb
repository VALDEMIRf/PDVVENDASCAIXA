<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas2))
        Me.cbProduto = New System.Windows.Forms.ComboBox()
        Me.txtCodBarras = New System.Windows.Forms.TextBox()
        Me.btRel = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtValorUnitario = New System.Windows.Forms.TextBox()
        Me.txtVAlorTotalUnitario = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalVenda = New System.Windows.Forms.TextBox()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.txtEstoque = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btConsultaPreco = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProduto
        '
        Me.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.Location = New System.Drawing.Point(116, 109)
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(325, 39)
        Me.cbProduto.TabIndex = 20001
        '
        'txtCodBarras
        '
        Me.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodBarras.Enabled = False
        Me.txtCodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarras.Location = New System.Drawing.Point(31, 209)
        Me.txtCodBarras.Multiline = True
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(410, 67)
        Me.txtCodBarras.TabIndex = 20002
        '
        'btRel
        '
        Me.btRel.BackColor = System.Drawing.Color.Transparent
        Me.btRel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRel.FlatAppearance.BorderSize = 0
        Me.btRel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btRel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRel.ForeColor = System.Drawing.Color.White
        Me.btRel.Image = CType(resources.GetObject("btRel.Image"), System.Drawing.Image)
        Me.btRel.Location = New System.Drawing.Point(244, 847)
        Me.btRel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btRel.Name = "btRel"
        Me.btRel.Size = New System.Drawing.Size(105, 36)
        Me.btRel.TabIndex = 20014
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
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(31, 801)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(70, 37)
        Me.btnNovo.TabIndex = 20011
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = False
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
        Me.btnExcluir.Location = New System.Drawing.Point(21, 847)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(71, 37)
        Me.btnExcluir.TabIndex = 20013
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
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
        Me.btnSalvar.Location = New System.Drawing.Point(110, 801)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(77, 37)
        Me.btnSalvar.TabIndex = 20012
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValorUnitario.Enabled = False
        Me.txtValorUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnitario.Location = New System.Drawing.Point(31, 434)
        Me.txtValorUnitario.Multiline = True
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(410, 105)
        Me.txtValorUnitario.TabIndex = 20017
        '
        'txtVAlorTotalUnitario
        '
        Me.txtVAlorTotalUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVAlorTotalUnitario.Enabled = False
        Me.txtVAlorTotalUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAlorTotalUnitario.Location = New System.Drawing.Point(12, 321)
        Me.txtVAlorTotalUnitario.Multiline = True
        Me.txtVAlorTotalUnitario.Name = "txtVAlorTotalUnitario"
        Me.txtVAlorTotalUnitario.Size = New System.Drawing.Size(305, 60)
        Me.txtVAlorTotalUnitario.TabIndex = 20018
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(494, 209)
        Me.txtSubTotal.Multiline = True
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(279, 119)
        Me.txtSubTotal.TabIndex = 20019
        '
        'txtTotalVenda
        '
        Me.txtTotalVenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalVenda.Enabled = False
        Me.txtTotalVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVenda.Location = New System.Drawing.Point(21, 601)
        Me.txtTotalVenda.Multiline = True
        Me.txtTotalVenda.Name = "txtTotalVenda"
        Me.txtTotalVenda.Size = New System.Drawing.Size(437, 104)
        Me.txtTotalVenda.TabIndex = 20020
        '
        'txtProduto
        '
        Me.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProduto.Enabled = False
        Me.txtProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduto.Location = New System.Drawing.Point(522, 85)
        Me.txtProduto.Multiline = True
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(888, 78)
        Me.txtProduto.TabIndex = 20021
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(757, 522)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(16, 17)
        Me.lblCodigo.TabIndex = 20022
        Me.lblCodigo.Text = "0"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantidade.Location = New System.Drawing.Point(176, 331)
        Me.txtQuantidade.Margin = New System.Windows.Forms.Padding(5)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(201, 34)
        Me.txtQuantidade.TabIndex = 20023
        Me.txtQuantidade.Text = "1"
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
        Me.Panel1.Size = New System.Drawing.Size(1460, 79)
        Me.Panel1.TabIndex = 20024
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(111, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 312
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Elephant", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(440, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(563, 49)
        Me.Label5.TabIndex = 311
        Me.Label5.Text = "PDV - FRENTE DE CAIXA"
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
        Me.btSair.Location = New System.Drawing.Point(1325, 5)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(85, 35)
        Me.btSair.TabIndex = 13
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'txtEstoque
        '
        Me.txtEstoque.Enabled = False
        Me.txtEstoque.ForeColor = System.Drawing.Color.Black
        Me.txtEstoque.Location = New System.Drawing.Point(727, 547)
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.Size = New System.Drawing.Size(70, 20)
        Me.txtEstoque.TabIndex = 20025
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(711, 578)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(86, 20)
        Me.txtNum.TabIndex = 20026
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(371, 324)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 20027
        Me.Label1.Text = "Núm Venda"
        '
        'btEditar
        '
        Me.btEditar.BackColor = System.Drawing.Color.Transparent
        Me.btEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEditar.FlatAppearance.BorderSize = 0
        Me.btEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEditar.ForeColor = System.Drawing.Color.White
        Me.btEditar.Image = CType(resources.GetObject("btEditar.Image"), System.Drawing.Image)
        Me.btEditar.Location = New System.Drawing.Point(201, 800)
        Me.btEditar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(77, 37)
        Me.btEditar.TabIndex = 20028
        Me.btEditar.Text = "Editar"
        Me.btEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEditar.UseVisualStyleBackColor = False
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg.Location = New System.Drawing.Point(806, 181)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(624, 707)
        Me.dg.TabIndex = 20029
        '
        'btConsultaPreco
        '
        Me.btConsultaPreco.BackColor = System.Drawing.Color.Transparent
        Me.btConsultaPreco.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btConsultaPreco.FlatAppearance.BorderSize = 0
        Me.btConsultaPreco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btConsultaPreco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btConsultaPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConsultaPreco.ForeColor = System.Drawing.Color.White
        Me.btConsultaPreco.Image = CType(resources.GetObject("btConsultaPreco.Image"), System.Drawing.Image)
        Me.btConsultaPreco.Location = New System.Drawing.Point(116, 847)
        Me.btConsultaPreco.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btConsultaPreco.Name = "btConsultaPreco"
        Me.btConsultaPreco.Size = New System.Drawing.Size(105, 36)
        Me.btConsultaPreco.TabIndex = 20030
        Me.btConsultaPreco.Text = "Comprovante"
        Me.btConsultaPreco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btConsultaPreco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btConsultaPreco.UseVisualStyleBackColor = False
        '
        'frmVendas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PDVVENDASCAIXA.My.Resources.Resources.FRENTE_DE_CAIXA3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1460, 900)
        Me.Controls.Add(Me.btConsultaPreco)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtEstoque)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.txtTotalVenda)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.txtVAlorTotalUnitario)
        Me.Controls.Add(Me.txtValorUnitario)
        Me.Controls.Add(Me.btRel)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtCodBarras)
        Me.Controls.Add(Me.cbProduto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVendas2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas - PDV"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbProduto As ComboBox
    Friend WithEvents txtCodBarras As TextBox
    Friend WithEvents btRel As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents txtValorUnitario As TextBox
    Friend WithEvents txtVAlorTotalUnitario As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtTotalVenda As TextBox
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btSair As Button
    Friend WithEvents txtEstoque As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btEditar As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents btConsultaPreco As Button
End Class
