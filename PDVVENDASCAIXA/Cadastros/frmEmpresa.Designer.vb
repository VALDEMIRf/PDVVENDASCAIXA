<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresa))
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelResidencial = New System.Windows.Forms.MaskedTextBox()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.txtFantasia = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCompl = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtUF = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(210, 9)
        Me.Label28.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(339, 26)
        Me.Label28.TabIndex = 246
        Me.Label28.Text = "CADASTRAR MINHA EMPRESA"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(10, 222)
        Me.dg.Margin = New System.Windows.Forms.Padding(5)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(762, 141)
        Me.dg.TabIndex = 276
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(692, 111)
        Me.txtCEP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCEP.Mask = "00000-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(80, 23)
        Me.txtCEP.TabIndex = 259
        '
        'txtTelResidencial
        '
        Me.txtTelResidencial.Location = New System.Drawing.Point(473, 142)
        Me.txtTelResidencial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelResidencial.Mask = "(99) 0000-0000"
        Me.txtTelResidencial.Name = "txtTelResidencial"
        Me.txtTelResidencial.Size = New System.Drawing.Size(104, 23)
        Me.txtTelResidencial.TabIndex = 260
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(651, 142)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCelular.Mask = "(99) 00000-0000"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(121, 23)
        Me.txtCelular.TabIndex = 261
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(7, 136)
        Me.Label27.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(73, 17)
        Me.Label27.TabIndex = 275
        Me.Label27.Text = "Endereço:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(420, 180)
        Me.Label26.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 17)
        Me.Label26.TabIndex = 274
        Me.Label26.Text = "Email:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(589, 146)
        Me.Label25.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 17)
        Me.Label25.TabIndex = 273
        Me.Label25.Text = "Celular:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(399, 145)
        Me.Label24.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(68, 17)
        Me.Label24.TabIndex = 272
        Me.Label24.Text = "Telefone:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(31, 88)
        Me.Label23.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(49, 17)
        Me.Label23.TabIndex = 271
        Me.Label23.Text = "Nome:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(14, 112)
        Me.Label22.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 17)
        Me.Label22.TabIndex = 270
        Me.Label22.Text = "Fantasia:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(644, 114)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 17)
        Me.Label19.TabIndex = 269
        Me.Label19.Text = "CEP:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(437, 114)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 17)
        Me.Label11.TabIndex = 268
        Me.Label11.Text = "UF:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(417, 59)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 267
        Me.Label10.Text = "Bairro:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(24, 191)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 17)
        Me.Label9.TabIndex = 266
        Me.Label9.Text = "Compl.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(52, 166)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 17)
        Me.Label8.TabIndex = 265
        Me.Label8.Text = "N°:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(411, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 264
        Me.Label3.Text = "Cidade:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 263
        Me.Label1.Text = "CNPJ:"
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Location = New System.Drawing.Point(86, 57)
        Me.txtCNPJ.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtCNPJ.Mask = "##.###.###/####-##"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(133, 23)
        Me.txtCNPJ.TabIndex = 250
        Me.txtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazaoSocial.Location = New System.Drawing.Point(85, 84)
        Me.txtRazaoSocial.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.Size = New System.Drawing.Size(300, 21)
        Me.txtRazaoSocial.TabIndex = 251
        '
        'txtFantasia
        '
        Me.txtFantasia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFantasia.Location = New System.Drawing.Point(85, 110)
        Me.txtFantasia.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.Size = New System.Drawing.Size(300, 21)
        Me.txtFantasia.TabIndex = 252
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(85, 137)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(300, 21)
        Me.txtEndereco.TabIndex = 253
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(85, 164)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(120, 21)
        Me.txtNumero.TabIndex = 254
        '
        'txtCompl
        '
        Me.txtCompl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompl.Location = New System.Drawing.Point(86, 189)
        Me.txtCompl.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(220, 21)
        Me.txtCompl.TabIndex = 255
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(472, 57)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(300, 21)
        Me.txtBairro.TabIndex = 256
        '
        'txtUF
        '
        Me.txtUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUF.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUF.FormattingEnabled = True
        Me.txtUF.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.txtUF.Location = New System.Drawing.Point(472, 111)
        Me.txtUF.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(77, 23)
        Me.txtUF.TabIndex = 258
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(472, 176)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(300, 21)
        Me.txtEmail.TabIndex = 262
        '
        'txtCidade
        '
        Me.txtCidade.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(472, 84)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(300, 21)
        Me.txtCidade.TabIndex = 257
        '
        'btSair
        '
        Me.btSair.BackColor = System.Drawing.Color.Transparent
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSair.ForeColor = System.Drawing.Color.White
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(327, 370)
        Me.btSair.Margin = New System.Windows.Forms.Padding(4)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(75, 44)
        Me.btSair.TabIndex = 280
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
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(9, 368)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(100, 45)
        Me.btnSalvar.TabIndex = 277
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
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(114, 370)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(93, 44)
        Me.btnEditar.TabIndex = 278
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
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(215, 370)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(90, 43)
        Me.btnExcluir.TabIndex = 279
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'frmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(778, 417)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtCEP)
        Me.Controls.Add(Me.txtTelResidencial)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCNPJ)
        Me.Controls.Add(Me.txtRazaoSocial)
        Me.Controls.Add(Me.txtFantasia)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtCompl)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtUF)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label28)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmpresa"
        Me.Text = "Gerenciar Minha Empresa"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label28 As Label
    Friend WithEvents dg As DataGridView
    Friend WithEvents txtCEP As MaskedTextBox
    Friend WithEvents txtTelResidencial As MaskedTextBox
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCNPJ As MaskedTextBox
    Friend WithEvents txtRazaoSocial As TextBox
    Friend WithEvents txtFantasia As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCompl As TextBox
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents txtUF As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents btSair As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExcluir As Button
End Class
