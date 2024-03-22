<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContasPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContasPagar))
        Me.dgContasPagar = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtTotalContasPagar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalContasNaoPagas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalContasPagas = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSituacao = New System.Windows.Forms.ComboBox()
        Me.txtVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btTipoDocumento = New System.Windows.Forms.Button()
        Me.txtTipoDocto = New System.Windows.Forms.ComboBox()
        CType(Me.dgContasPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgContasPagar
        '
        Me.dgContasPagar.AllowUserToAddRows = False
        Me.dgContasPagar.AllowUserToDeleteRows = False
        Me.dgContasPagar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgContasPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContasPagar.GridColor = System.Drawing.Color.DarkBlue
        Me.dgContasPagar.Location = New System.Drawing.Point(7, 152)
        Me.dgContasPagar.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgContasPagar.Name = "dgContasPagar"
        Me.dgContasPagar.ReadOnly = True
        Me.dgContasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContasPagar.Size = New System.Drawing.Size(940, 287)
        Me.dgContasPagar.TabIndex = 190
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(756, 449)
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
        Me.lblTotal.Location = New System.Drawing.Point(874, 449)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 191
        Me.lblTotal.Text = "-"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btSalvar)
        Me.GroupBox5.Controls.Add(Me.btnEditar)
        Me.GroupBox5.Controls.Add(Me.btSair)
        Me.GroupBox5.Controls.Add(Me.btnExcluir)
        Me.GroupBox5.Controls.Add(Me.btNovo)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 513)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(476, 60)
        Me.GroupBox5.TabIndex = 194
        Me.GroupBox5.TabStop = False
        '
        'btSalvar
        '
        Me.btSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.FlatAppearance.BorderSize = 0
        Me.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.ForeColor = System.Drawing.Color.White
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.Location = New System.Drawing.Point(96, 15)
        Me.btSalvar.Margin = New System.Windows.Forms.Padding(5)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(89, 35)
        Me.btSalvar.TabIndex = 18
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(190, 15)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(90, 35)
        Me.btnEditar.TabIndex = 19
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.btSair.Location = New System.Drawing.Point(374, 15)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(85, 35)
        Me.btSair.TabIndex = 21
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(276, 12)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(101, 45)
        Me.btnExcluir.TabIndex = 20
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.Color.Transparent
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.ForeColor = System.Drawing.Color.White
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(5, 15)
        Me.btNovo.Margin = New System.Windows.Forms.Padding(5)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(87, 37)
        Me.btNovo.TabIndex = 17
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = False
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
        Me.txtTotalContasPagar.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTotalContasPagar.Location = New System.Drawing.Point(419, 471)
        Me.txtTotalContasPagar.Multiline = True
        Me.txtTotalContasPagar.Name = "txtTotalContasPagar"
        Me.txtTotalContasPagar.ReadOnly = True
        Me.txtTotalContasPagar.Size = New System.Drawing.Size(193, 33)
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
        Me.Label7.Location = New System.Drawing.Point(412, 448)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 197
        Me.Label7.Text = "Total de contas a Pagar:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(203, 449)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Total Contas Não Pagas"
        '
        'txtTotalContasNaoPagas
        '
        Me.txtTotalContasNaoPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasNaoPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasNaoPagas.ForeColor = System.Drawing.Color.Green
        Me.txtTotalContasNaoPagas.Location = New System.Drawing.Point(210, 472)
        Me.txtTotalContasNaoPagas.Multiline = True
        Me.txtTotalContasNaoPagas.Name = "txtTotalContasNaoPagas"
        Me.txtTotalContasNaoPagas.ReadOnly = True
        Me.txtTotalContasNaoPagas.Size = New System.Drawing.Size(193, 33)
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
        Me.Label2.Location = New System.Drawing.Point(3, 448)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 20)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "Total Contas Pagas"
        '
        'txtTotalContasPagas
        '
        Me.txtTotalContasPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasPagas.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalContasPagas.Location = New System.Drawing.Point(10, 471)
        Me.txtTotalContasPagas.Multiline = True
        Me.txtTotalContasPagas.Name = "txtTotalContasPagas"
        Me.txtTotalContasPagas.ReadOnly = True
        Me.txtTotalContasPagas.Size = New System.Drawing.Size(193, 33)
        Me.txtTotalContasPagas.TabIndex = 200
        Me.txtTotalContasPagas.Text = "R$ 0,00"
        Me.txtTotalContasPagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtData
        '
        Me.txtData.Enabled = False
        Me.txtData.Location = New System.Drawing.Point(630, 115)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(101, 24)
        Me.txtData.TabIndex = 215
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(895, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(51, 24)
        Me.txtCodigo.TabIndex = 214
        Me.txtCodigo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(314, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 213
        Me.Label3.Text = "N° Docto:"
        '
        'txtSituacao
        '
        Me.txtSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtSituacao.FormattingEnabled = True
        Me.txtSituacao.Items.AddRange(New Object() {"aberto", "pago"})
        Me.txtSituacao.Location = New System.Drawing.Point(396, 115)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(120, 26)
        Me.txtSituacao.TabIndex = 212
        '
        'txtVencimento
        '
        Me.txtVencimento.Location = New System.Drawing.Point(111, 120)
        Me.txtVencimento.Mask = "00/00/0000"
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(87, 24)
        Me.txtVencimento.TabIndex = 211
        Me.txtVencimento.ValidatingType = GetType(Date)
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Enabled = False
        Me.txtEmpresa.Location = New System.Drawing.Point(630, 61)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(317, 24)
        Me.txtEmpresa.TabIndex = 210
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(630, 89)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 24)
        Me.txtValor.TabIndex = 209
        '
        'txtDescricao
        '
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Location = New System.Drawing.Point(111, 59)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(405, 24)
        Me.txtDescricao.TabIndex = 208
        '
        'txtNDoc
        '
        Me.txtNDoc.Enabled = False
        Me.txtNDoc.Location = New System.Drawing.Point(396, 87)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(120, 24)
        Me.txtNDoc.TabIndex = 207
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(14, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 206
        Me.Label9.Text = "Tipo Docto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 205
        Me.Label6.Text = "Vencimento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(543, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "Empresa:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(543, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 203
        Me.Label5.Text = "Valor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(21, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 202
        Me.Label8.Text = "Descrição:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(518, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 20)
        Me.Label11.TabIndex = 216
        Me.Label11.Text = "Dt Alteração:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Constantia", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(278, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(354, 49)
        Me.Label12.TabIndex = 217
        Me.Label12.Text = "CONTAS A PAGAR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(312, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 20)
        Me.Label13.TabIndex = 218
        Me.Label13.Text = "Situação:"
        '
        'btTipoDocumento
        '
        Me.btTipoDocumento.BackColor = System.Drawing.Color.Transparent
        Me.btTipoDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btTipoDocumento.FlatAppearance.BorderSize = 0
        Me.btTipoDocumento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btTipoDocumento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btTipoDocumento.ForeColor = System.Drawing.Color.White
        Me.btTipoDocumento.Image = CType(resources.GetObject("btTipoDocumento.Image"), System.Drawing.Image)
        Me.btTipoDocumento.Location = New System.Drawing.Point(271, 88)
        Me.btTipoDocumento.Margin = New System.Windows.Forms.Padding(5)
        Me.btTipoDocumento.Name = "btTipoDocumento"
        Me.btTipoDocumento.Size = New System.Drawing.Size(35, 27)
        Me.btTipoDocumento.TabIndex = 22
        Me.btTipoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btTipoDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btTipoDocumento.UseVisualStyleBackColor = False
        '
        'txtTipoDocto
        '
        Me.txtTipoDocto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTipoDocto.FormattingEnabled = True
        Me.txtTipoDocto.Location = New System.Drawing.Point(111, 88)
        Me.txtTipoDocto.Name = "txtTipoDocto"
        Me.txtTipoDocto.Size = New System.Drawing.Size(159, 26)
        Me.txtTipoDocto.TabIndex = 229
        '
        'frmContasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(952, 577)
        Me.Controls.Add(Me.txtTipoDocto)
        Me.Controls.Add(Me.btTipoDocumento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSituacao)
        Me.Controls.Add(Me.txtVencimento)
        Me.Controls.Add(Me.txtEmpresa)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtNDoc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalContasPagas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalContasNaoPagas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalContasPagar)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.dgContasPagar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContasPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas a Pagar"
        CType(Me.dgContasPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgContasPagar As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btNovo As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btSair As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtTotalContasPagar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalContasNaoPagas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalContasPagas As TextBox
    Friend WithEvents txtData As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSituacao As ComboBox
    Friend WithEvents txtVencimento As MaskedTextBox
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btTipoDocumento As Button
    Friend WithEvents txtTipoDocto As ComboBox
End Class
