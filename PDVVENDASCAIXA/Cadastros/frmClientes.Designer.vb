<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Cadastro = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtBuscarNome = New System.Windows.Forms.TextBox()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCPF = New System.Windows.Forms.MaskedTextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtCompl = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btBuscarCEP = New System.Windows.Forms.Button()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtUF = New System.Windows.Forms.ComboBox()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtNatural = New System.Windows.Forms.TextBox()
        Me.lblNatural = New System.Windows.Forms.Label()
        Me.cbEstCivil = New System.Windows.Forms.ComboBox()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.lblNasc = New System.Windows.Forms.Label()
        Me.txtdtNasc = New System.Windows.Forms.MaskedTextBox()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtTelCel = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PessoaJuridica = New System.Windows.Forms.TabPage()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblTotalPJ = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtObsPj = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbCNPJ = New System.Windows.Forms.RadioButton()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtBuscarNomePJ = New System.Windows.Forms.TextBox()
        Me.rbNomePJ = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.dgPJ = New System.Windows.Forms.DataGridView()
        Me.btNovoPJ = New System.Windows.Forms.Button()
        Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.btEscluirPJ = New System.Windows.Forms.Button()
        Me.txtFantasia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btSalvarPJ = New System.Windows.Forms.Button()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtTelPJ = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtComplPJ = New System.Windows.Forms.TextBox()
        Me.txtBairroPJ = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtUFPJ = New System.Windows.Forms.ComboBox()
        Me.txtCEPPJ = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtEmailPJ = New System.Windows.Forms.TextBox()
        Me.txtCidadePJ = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblSituacao = New System.Windows.Forms.Label()
        Me.txtSituacao = New System.Windows.Forms.TextBox()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btBuscarCNPJ = New System.Windows.Forms.Button()
        Me.txtIE = New System.Windows.Forms.MaskedTextBox()
        Me.txtCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Cadastro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PessoaJuridica.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgPJ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Cadastro)
        Me.TabControl1.Controls.Add(Me.PessoaJuridica)
        Me.TabControl1.Location = New System.Drawing.Point(6, 42)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(894, 510)
        Me.TabControl1.TabIndex = 0
        '
        'Cadastro
        '
        Me.Cadastro.BackColor = System.Drawing.Color.SteelBlue
        Me.Cadastro.Controls.Add(Me.btSair)
        Me.Cadastro.Controls.Add(Me.Label7)
        Me.Cadastro.Controls.Add(Me.lblTotal)
        Me.Cadastro.Controls.Add(Me.GroupBox1)
        Me.Cadastro.Controls.Add(Me.dg)
        Me.Cadastro.Controls.Add(Me.txtCompl)
        Me.Cadastro.Controls.Add(Me.Label11)
        Me.Cadastro.Controls.Add(Me.txtCidade)
        Me.Cadastro.Controls.Add(Me.Label15)
        Me.Cadastro.Controls.Add(Me.btnNovo)
        Me.Cadastro.Controls.Add(Me.btnExcluir)
        Me.Cadastro.Controls.Add(Me.txtBairro)
        Me.Cadastro.Controls.Add(Me.btnEditar)
        Me.Cadastro.Controls.Add(Me.Label16)
        Me.Cadastro.Controls.Add(Me.btnSalvar)
        Me.Cadastro.Controls.Add(Me.btBuscarCEP)
        Me.Cadastro.Controls.Add(Me.txtComplemento)
        Me.Cadastro.Controls.Add(Me.Label13)
        Me.Cadastro.Controls.Add(Me.txtNumero)
        Me.Cadastro.Controls.Add(Me.Label12)
        Me.Cadastro.Controls.Add(Me.txtEndereco)
        Me.Cadastro.Controls.Add(Me.Label1)
        Me.Cadastro.Controls.Add(Me.Label14)
        Me.Cadastro.Controls.Add(Me.txtUF)
        Me.Cadastro.Controls.Add(Me.txtCEP)
        Me.Cadastro.Controls.Add(Me.Label17)
        Me.Cadastro.Controls.Add(Me.Label20)
        Me.Cadastro.Controls.Add(Me.txtObs)
        Me.Cadastro.Controls.Add(Me.txtNatural)
        Me.Cadastro.Controls.Add(Me.lblNatural)
        Me.Cadastro.Controls.Add(Me.cbEstCivil)
        Me.Cadastro.Controls.Add(Me.lblEstadoCivil)
        Me.Cadastro.Controls.Add(Me.txtCPF)
        Me.Cadastro.Controls.Add(Me.Label10)
        Me.Cadastro.Controls.Add(Me.txtRG)
        Me.Cadastro.Controls.Add(Me.lblNasc)
        Me.Cadastro.Controls.Add(Me.txtdtNasc)
        Me.Cadastro.Controls.Add(Me.lblCPF)
        Me.Cadastro.Controls.Add(Me.lblSexo)
        Me.Cadastro.Controls.Add(Me.cbSexo)
        Me.Cadastro.Controls.Add(Me.Label2)
        Me.Cadastro.Controls.Add(Me.txtNome)
        Me.Cadastro.Controls.Add(Me.txtTelCel)
        Me.Cadastro.Controls.Add(Me.Label6)
        Me.Cadastro.Controls.Add(Me.txtTel)
        Me.Cadastro.Controls.Add(Me.Label5)
        Me.Cadastro.Controls.Add(Me.txtEmail)
        Me.Cadastro.Controls.Add(Me.Label9)
        Me.Cadastro.Location = New System.Drawing.Point(4, 25)
        Me.Cadastro.Margin = New System.Windows.Forms.Padding(4)
        Me.Cadastro.Name = "Cadastro"
        Me.Cadastro.Padding = New System.Windows.Forms.Padding(4)
        Me.Cadastro.Size = New System.Drawing.Size(886, 481)
        Me.Cadastro.TabIndex = 0
        Me.Cadastro.Text = "Pessoa Física"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(744, 420)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 323
        Me.Label7.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(806, 420)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 322
        Me.lblTotal.Text = "-"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCPF)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtBuscarNome)
        Me.GroupBox1.Controls.Add(Me.rbNome)
        Me.GroupBox1.Controls.Add(Me.txtBuscarCPF)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(20, 183)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(433, 45)
        Me.GroupBox1.TabIndex = 321
        Me.GroupBox1.TabStop = False
        '
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.ForeColor = System.Drawing.Color.White
        Me.rbCPF.Location = New System.Drawing.Point(147, 16)
        Me.rbCPF.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(52, 21)
        Me.rbCPF.TabIndex = 16
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "CPF"
        Me.rbCPF.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(12, 16)
        Me.Label21.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 17)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Buscar:"
        '
        'txtBuscarNome
        '
        Me.txtBuscarNome.Location = New System.Drawing.Point(222, 16)
        Me.txtBuscarNome.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscarNome.Name = "txtBuscarNome"
        Me.txtBuscarNome.Size = New System.Drawing.Size(170, 23)
        Me.txtBuscarNome.TabIndex = 17
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.ForeColor = System.Drawing.Color.White
        Me.rbNome.Location = New System.Drawing.Point(73, 16)
        Me.rbNome.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(63, 21)
        Me.rbNome.TabIndex = 15
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'txtBuscarCPF
        '
        Me.txtBuscarCPF.Location = New System.Drawing.Point(222, 16)
        Me.txtBuscarCPF.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscarCPF.Mask = "999,999,999-99"
        Me.txtBuscarCPF.Name = "txtBuscarCPF"
        Me.txtBuscarCPF.Size = New System.Drawing.Size(170, 23)
        Me.txtBuscarCPF.TabIndex = 18
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(17, 238)
        Me.dg.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(859, 170)
        Me.dg.TabIndex = 320
        '
        'txtCompl
        '
        Me.txtCompl.Enabled = False
        Me.txtCompl.Location = New System.Drawing.Point(589, 88)
        Me.txtCompl.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(287, 23)
        Me.txtCompl.TabIndex = 318
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(478, 91)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 17)
        Me.Label11.TabIndex = 319
        Me.Label11.Text = "Complemento2:"
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(544, 141)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(332, 23)
        Me.txtCidade.TabIndex = 310
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(487, 143)
        Me.Label15.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 17)
        Me.Label15.TabIndex = 314
        Me.Label15.Text = "Cidade:"
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(26, 423)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(81, 37)
        Me.btnNovo.TabIndex = 129
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(337, 423)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(90, 37)
        Me.btnExcluir.TabIndex = 132
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(544, 114)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(332, 23)
        Me.txtBairro.TabIndex = 309
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(225, 423)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(85, 37)
        Me.btnEditar.TabIndex = 131
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(489, 118)
        Me.Label16.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 17)
        Me.Label16.TabIndex = 315
        Me.Label16.Text = "Bairro:"
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(127, 423)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(88, 37)
        Me.btnSalvar.TabIndex = 130
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btBuscarCEP
        '
        Me.btBuscarCEP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscarCEP.FlatAppearance.BorderSize = 0
        Me.btBuscarCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscarCEP.Image = CType(resources.GetObject("btBuscarCEP.Image"), System.Drawing.Image)
        Me.btBuscarCEP.Location = New System.Drawing.Point(633, 4)
        Me.btBuscarCEP.Name = "btBuscarCEP"
        Me.btBuscarCEP.Size = New System.Drawing.Size(37, 26)
        Me.btBuscarCEP.TabIndex = 304
        Me.btBuscarCEP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btBuscarCEP.UseVisualStyleBackColor = True
        '
        'txtComplemento
        '
        Me.txtComplemento.Enabled = False
        Me.txtComplemento.Location = New System.Drawing.Point(664, 61)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(212, 23)
        Me.txtComplemento.TabIndex = 308
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(610, 65)
        Me.Label13.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 17)
        Me.Label13.TabIndex = 313
        Me.Label13.Text = "Compl.:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(542, 62)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(59, 23)
        Me.txtNumero.TabIndex = 307
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(509, 66)
        Me.Label12.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 17)
        Me.Label12.TabIndex = 312
        Me.Label12.Text = "N°:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(540, 36)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(336, 23)
        Me.txtEndereco.TabIndex = 306
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(462, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 311
        Me.Label1.Text = "Endereço:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(762, 13)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 17)
        Me.Label14.TabIndex = 316
        Me.Label14.Text = "UF:"
        '
        'txtUF
        '
        Me.txtUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUF.Enabled = False
        Me.txtUF.FormattingEnabled = True
        Me.txtUF.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.txtUF.Location = New System.Drawing.Point(797, 8)
        Me.txtUF.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(79, 24)
        Me.txtUF.TabIndex = 305
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(540, 9)
        Me.txtCEP.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCEP.Mask = "00000-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(93, 23)
        Me.txtCEP.TabIndex = 303
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(496, 13)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 17)
        Me.Label17.TabIndex = 317
        Me.Label17.Text = "CEP:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(497, 181)
        Me.Label20.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 17)
        Me.Label20.TabIndex = 288
        Me.Label20.Text = "Obs.:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(544, 167)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(332, 48)
        Me.txtObs.TabIndex = 287
        '
        'txtNatural
        '
        Me.txtNatural.Enabled = False
        Me.txtNatural.Location = New System.Drawing.Point(336, 61)
        Me.txtNatural.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtNatural.Name = "txtNatural"
        Me.txtNatural.Size = New System.Drawing.Size(120, 23)
        Me.txtNatural.TabIndex = 136
        '
        'lblNatural
        '
        Me.lblNatural.AutoSize = True
        Me.lblNatural.ForeColor = System.Drawing.Color.White
        Me.lblNatural.Location = New System.Drawing.Point(278, 64)
        Me.lblNatural.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblNatural.Name = "lblNatural"
        Me.lblNatural.Size = New System.Drawing.Size(58, 17)
        Me.lblNatural.TabIndex = 151
        Me.lblNatural.Text = "Natural:"
        '
        'cbEstCivil
        '
        Me.cbEstCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstCivil.Enabled = False
        Me.cbEstCivil.FormattingEnabled = True
        Me.cbEstCivil.Items.AddRange(New Object() {"Solteiro (a)", "Casado (a)", "Separado (a)", "Divorciado (a) ", "Viúvo (a) ", "Outros"})
        Me.cbEstCivil.Location = New System.Drawing.Point(91, 61)
        Me.cbEstCivil.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.cbEstCivil.Name = "cbEstCivil"
        Me.cbEstCivil.Size = New System.Drawing.Size(180, 24)
        Me.cbEstCivil.TabIndex = 135
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.ForeColor = System.Drawing.Color.White
        Me.lblEstadoCivil.Location = New System.Drawing.Point(6, 65)
        Me.lblEstadoCivil.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(83, 17)
        Me.lblEstadoCivil.TabIndex = 150
        Me.lblEstadoCivil.Text = "Estado civil:"
        '
        'txtCPF
        '
        Me.txtCPF.Enabled = False
        Me.txtCPF.Location = New System.Drawing.Point(90, 5)
        Me.txtCPF.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtCPF.Mask = "999,999,999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(130, 23)
        Me.txtCPF.TabIndex = 133
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(266, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 17)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "RG:"
        '
        'txtRG
        '
        Me.txtRG.Enabled = False
        Me.txtRG.Location = New System.Drawing.Point(302, 6)
        Me.txtRG.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(154, 23)
        Me.txtRG.TabIndex = 134
        '
        'lblNasc
        '
        Me.lblNasc.AutoSize = True
        Me.lblNasc.ForeColor = System.Drawing.Color.White
        Me.lblNasc.Location = New System.Drawing.Point(334, 92)
        Me.lblNasc.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblNasc.Name = "lblNasc"
        Me.lblNasc.Size = New System.Drawing.Size(44, 17)
        Me.lblNasc.TabIndex = 148
        Me.lblNasc.Text = "Nasc:"
        '
        'txtdtNasc
        '
        Me.txtdtNasc.Enabled = False
        Me.txtdtNasc.Location = New System.Drawing.Point(377, 89)
        Me.txtdtNasc.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtdtNasc.Mask = "00/00/0000"
        Me.txtdtNasc.Name = "txtdtNasc"
        Me.txtdtNasc.Size = New System.Drawing.Size(79, 23)
        Me.txtdtNasc.TabIndex = 138
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.ForeColor = System.Drawing.Color.White
        Me.lblCPF.Location = New System.Drawing.Point(53, 6)
        Me.lblCPF.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(38, 17)
        Me.lblCPF.TabIndex = 144
        Me.lblCPF.Text = "CPF:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.ForeColor = System.Drawing.Color.White
        Me.lblSexo.Location = New System.Drawing.Point(43, 97)
        Me.lblSexo.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(43, 17)
        Me.lblSexo.TabIndex = 143
        Me.lblSexo.Text = "Sexo:"
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.Enabled = False
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.cbSexo.Location = New System.Drawing.Point(91, 90)
        Me.cbSexo.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(180, 24)
        Me.cbSexo.TabIndex = 137
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(90, 33)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(366, 23)
        Me.txtNome.TabIndex = 132
        '
        'txtTelCel
        '
        Me.txtTelCel.Enabled = False
        Me.txtTelCel.Location = New System.Drawing.Point(334, 118)
        Me.txtTelCel.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtTelCel.Mask = "(00) 00000-0000"
        Me.txtTelCel.Name = "txtTelCel"
        Me.txtTelCel.Size = New System.Drawing.Size(122, 23)
        Me.txtTelCel.TabIndex = 140
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 122)
        Me.Label6.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Telefone:"
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(92, 119)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtTel.Mask = "(00) 0000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(111, 23)
        Me.txtTel.TabIndex = 139
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(27, 150)
        Me.Label5.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(91, 147)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(365, 23)
        Me.txtEmail.TabIndex = 141
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(275, 121)
        Me.Label9.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "Celular:"
        '
        'PessoaJuridica
        '
        Me.PessoaJuridica.BackColor = System.Drawing.Color.SteelBlue
        Me.PessoaJuridica.Controls.Add(Me.Label33)
        Me.PessoaJuridica.Controls.Add(Me.lblTotalPJ)
        Me.PessoaJuridica.Controls.Add(Me.Label27)
        Me.PessoaJuridica.Controls.Add(Me.txtObsPj)
        Me.PessoaJuridica.Controls.Add(Me.GroupBox2)
        Me.PessoaJuridica.Controls.Add(Me.dgPJ)
        Me.PessoaJuridica.Controls.Add(Me.btNovoPJ)
        Me.PessoaJuridica.Controls.Add(Me.txtRazaoSocial)
        Me.PessoaJuridica.Controls.Add(Me.btEscluirPJ)
        Me.PessoaJuridica.Controls.Add(Me.txtFantasia)
        Me.PessoaJuridica.Controls.Add(Me.Label8)
        Me.PessoaJuridica.Controls.Add(Me.btSalvarPJ)
        Me.PessoaJuridica.Controls.Add(Me.txtEnd)
        Me.PessoaJuridica.Controls.Add(Me.Label19)
        Me.PessoaJuridica.Controls.Add(Me.txtNum)
        Me.PessoaJuridica.Controls.Add(Me.Label22)
        Me.PessoaJuridica.Controls.Add(Me.Label23)
        Me.PessoaJuridica.Controls.Add(Me.txtTelPJ)
        Me.PessoaJuridica.Controls.Add(Me.Label24)
        Me.PessoaJuridica.Controls.Add(Me.txtComplPJ)
        Me.PessoaJuridica.Controls.Add(Me.txtBairroPJ)
        Me.PessoaJuridica.Controls.Add(Me.Label25)
        Me.PessoaJuridica.Controls.Add(Me.Label26)
        Me.PessoaJuridica.Controls.Add(Me.txtUFPJ)
        Me.PessoaJuridica.Controls.Add(Me.txtCEPPJ)
        Me.PessoaJuridica.Controls.Add(Me.Label28)
        Me.PessoaJuridica.Controls.Add(Me.Label29)
        Me.PessoaJuridica.Controls.Add(Me.Label30)
        Me.PessoaJuridica.Controls.Add(Me.txtEmailPJ)
        Me.PessoaJuridica.Controls.Add(Me.txtCidadePJ)
        Me.PessoaJuridica.Controls.Add(Me.Label31)
        Me.PessoaJuridica.Controls.Add(Me.lblSituacao)
        Me.PessoaJuridica.Controls.Add(Me.txtSituacao)
        Me.PessoaJuridica.Controls.Add(Me.lblMotivo)
        Me.PessoaJuridica.Controls.Add(Me.txtMotivo)
        Me.PessoaJuridica.Controls.Add(Me.Label3)
        Me.PessoaJuridica.Controls.Add(Me.Label4)
        Me.PessoaJuridica.Controls.Add(Me.btBuscarCNPJ)
        Me.PessoaJuridica.Controls.Add(Me.txtIE)
        Me.PessoaJuridica.Controls.Add(Me.txtCNPJ)
        Me.PessoaJuridica.Location = New System.Drawing.Point(4, 25)
        Me.PessoaJuridica.Name = "PessoaJuridica"
        Me.PessoaJuridica.Padding = New System.Windows.Forms.Padding(3)
        Me.PessoaJuridica.Size = New System.Drawing.Size(886, 481)
        Me.PessoaJuridica.TabIndex = 3
        Me.PessoaJuridica.Text = "Pessoa Jurídica"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(775, 443)
        Me.Label33.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(48, 20)
        Me.Label33.TabIndex = 329
        Me.Label33.Text = "Total:"
        '
        'lblTotalPJ
        '
        Me.lblTotalPJ.AutoSize = True
        Me.lblTotalPJ.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPJ.ForeColor = System.Drawing.Color.White
        Me.lblTotalPJ.Location = New System.Drawing.Point(837, 443)
        Me.lblTotalPJ.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotalPJ.Name = "lblTotalPJ"
        Me.lblTotalPJ.Size = New System.Drawing.Size(14, 20)
        Me.lblTotalPJ.TabIndex = 328
        Me.lblTotalPJ.Text = "-"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(485, 214)
        Me.Label27.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(42, 17)
        Me.Label27.TabIndex = 327
        Me.Label27.Text = "Obs.:"
        '
        'txtObsPj
        '
        Me.txtObsPj.Location = New System.Drawing.Point(532, 200)
        Me.txtObsPj.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtObsPj.Multiline = True
        Me.txtObsPj.Name = "txtObsPj"
        Me.txtObsPj.Size = New System.Drawing.Size(291, 48)
        Me.txtObsPj.TabIndex = 326
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbCNPJ)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.txtBuscarNomePJ)
        Me.GroupBox2.Controls.Add(Me.rbNomePJ)
        Me.GroupBox2.Controls.Add(Me.txtBuscarCNPJ)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(17, 202)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(433, 45)
        Me.GroupBox2.TabIndex = 325
        Me.GroupBox2.TabStop = False
        '
        'rbCNPJ
        '
        Me.rbCNPJ.AutoSize = True
        Me.rbCNPJ.ForeColor = System.Drawing.Color.White
        Me.rbCNPJ.Location = New System.Drawing.Point(147, 16)
        Me.rbCNPJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbCNPJ.Name = "rbCNPJ"
        Me.rbCNPJ.Size = New System.Drawing.Size(61, 21)
        Me.rbCNPJ.TabIndex = 16
        Me.rbCNPJ.TabStop = True
        Me.rbCNPJ.Text = "CNPJ"
        Me.rbCNPJ.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(12, 16)
        Me.Label32.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(56, 17)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Buscar:"
        '
        'txtBuscarNomePJ
        '
        Me.txtBuscarNomePJ.Location = New System.Drawing.Point(222, 15)
        Me.txtBuscarNomePJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscarNomePJ.Name = "txtBuscarNomePJ"
        Me.txtBuscarNomePJ.Size = New System.Drawing.Size(170, 23)
        Me.txtBuscarNomePJ.TabIndex = 17
        '
        'rbNomePJ
        '
        Me.rbNomePJ.AutoSize = True
        Me.rbNomePJ.ForeColor = System.Drawing.Color.White
        Me.rbNomePJ.Location = New System.Drawing.Point(73, 16)
        Me.rbNomePJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbNomePJ.Name = "rbNomePJ"
        Me.rbNomePJ.Size = New System.Drawing.Size(63, 21)
        Me.rbNomePJ.TabIndex = 15
        Me.rbNomePJ.TabStop = True
        Me.rbNomePJ.Text = "Nome"
        Me.rbNomePJ.UseVisualStyleBackColor = True
        '
        'txtBuscarCNPJ
        '
        Me.txtBuscarCNPJ.Location = New System.Drawing.Point(222, 16)
        Me.txtBuscarCNPJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscarCNPJ.Mask = "99,999,999/9999-99"
        Me.txtBuscarCNPJ.Name = "txtBuscarCNPJ"
        Me.txtBuscarCNPJ.Size = New System.Drawing.Size(170, 23)
        Me.txtBuscarCNPJ.TabIndex = 18
        '
        'dgPJ
        '
        Me.dgPJ.AllowUserToAddRows = False
        Me.dgPJ.AllowUserToDeleteRows = False
        Me.dgPJ.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgPJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPJ.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgPJ.Location = New System.Drawing.Point(9, 255)
        Me.dgPJ.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgPJ.Name = "dgPJ"
        Me.dgPJ.ReadOnly = True
        Me.dgPJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPJ.Size = New System.Drawing.Size(862, 170)
        Me.dgPJ.TabIndex = 324
        '
        'btNovoPJ
        '
        Me.btNovoPJ.BackColor = System.Drawing.Color.Transparent
        Me.btNovoPJ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovoPJ.FlatAppearance.BorderSize = 0
        Me.btNovoPJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btNovoPJ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btNovoPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovoPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovoPJ.ForeColor = System.Drawing.Color.White
        Me.btNovoPJ.Image = CType(resources.GetObject("btNovoPJ.Image"), System.Drawing.Image)
        Me.btNovoPJ.Location = New System.Drawing.Point(16, 433)
        Me.btNovoPJ.Margin = New System.Windows.Forms.Padding(5)
        Me.btNovoPJ.Name = "btNovoPJ"
        Me.btNovoPJ.Size = New System.Drawing.Size(81, 37)
        Me.btNovoPJ.TabIndex = 134
        Me.btNovoPJ.Text = "Novo"
        Me.btNovoPJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovoPJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovoPJ.UseVisualStyleBackColor = False
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.Enabled = False
        Me.txtRazaoSocial.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazaoSocial.Location = New System.Drawing.Point(110, 67)
        Me.txtRazaoSocial.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.ReadOnly = True
        Me.txtRazaoSocial.Size = New System.Drawing.Size(293, 21)
        Me.txtRazaoSocial.TabIndex = 302
        '
        'btEscluirPJ
        '
        Me.btEscluirPJ.BackColor = System.Drawing.Color.Transparent
        Me.btEscluirPJ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEscluirPJ.Enabled = False
        Me.btEscluirPJ.FlatAppearance.BorderSize = 0
        Me.btEscluirPJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btEscluirPJ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btEscluirPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEscluirPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEscluirPJ.ForeColor = System.Drawing.Color.White
        Me.btEscluirPJ.Image = CType(resources.GetObject("btEscluirPJ.Image"), System.Drawing.Image)
        Me.btEscluirPJ.Location = New System.Drawing.Point(206, 433)
        Me.btEscluirPJ.Margin = New System.Windows.Forms.Padding(5)
        Me.btEscluirPJ.Name = "btEscluirPJ"
        Me.btEscluirPJ.Size = New System.Drawing.Size(90, 37)
        Me.btEscluirPJ.TabIndex = 137
        Me.btEscluirPJ.Text = "Excluir"
        Me.btEscluirPJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btEscluirPJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEscluirPJ.UseVisualStyleBackColor = False
        '
        'txtFantasia
        '
        Me.txtFantasia.Enabled = False
        Me.txtFantasia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFantasia.Location = New System.Drawing.Point(110, 92)
        Me.txtFantasia.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.ReadOnly = True
        Me.txtFantasia.Size = New System.Drawing.Size(293, 21)
        Me.txtFantasia.TabIndex = 311
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(78, 145)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 17)
        Me.Label8.TabIndex = 316
        Me.Label8.Text = "N°:"
        '
        'btSalvarPJ
        '
        Me.btSalvarPJ.BackColor = System.Drawing.Color.Transparent
        Me.btSalvarPJ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvarPJ.Enabled = False
        Me.btSalvarPJ.FlatAppearance.BorderSize = 0
        Me.btSalvarPJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btSalvarPJ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btSalvarPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvarPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvarPJ.ForeColor = System.Drawing.Color.White
        Me.btSalvarPJ.Image = CType(resources.GetObject("btSalvarPJ.Image"), System.Drawing.Image)
        Me.btSalvarPJ.Location = New System.Drawing.Point(110, 433)
        Me.btSalvarPJ.Margin = New System.Windows.Forms.Padding(5)
        Me.btSalvarPJ.Name = "btSalvarPJ"
        Me.btSalvarPJ.Size = New System.Drawing.Size(88, 37)
        Me.btSalvarPJ.TabIndex = 135
        Me.btSalvarPJ.Text = "Salvar"
        Me.btSalvarPJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvarPJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvarPJ.UseVisualStyleBackColor = False
        '
        'txtEnd
        '
        Me.txtEnd.Enabled = False
        Me.txtEnd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.Location = New System.Drawing.Point(110, 118)
        Me.txtEnd.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.ReadOnly = True
        Me.txtEnd.Size = New System.Drawing.Size(293, 21)
        Me.txtEnd.TabIndex = 304
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(36, 120)
        Me.Label19.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 17)
        Me.Label19.TabIndex = 312
        Me.Label19.Text = "Endereço:"
        '
        'txtNum
        '
        Me.txtNum.Enabled = False
        Me.txtNum.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(110, 143)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.ReadOnly = True
        Me.txtNum.Size = New System.Drawing.Size(81, 21)
        Me.txtNum.TabIndex = 305
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(43, 94)
        Me.Label22.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 17)
        Me.Label22.TabIndex = 314
        Me.Label22.Text = "Fantasia:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(18, 70)
        Me.Label23.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 17)
        Me.Label23.TabIndex = 310
        Me.Label23.Text = "RazaoSocial:"
        '
        'txtTelPJ
        '
        Me.txtTelPJ.Enabled = False
        Me.txtTelPJ.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelPJ.Location = New System.Drawing.Point(529, 43)
        Me.txtTelPJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtTelPJ.Name = "txtTelPJ"
        Me.txtTelPJ.Size = New System.Drawing.Size(294, 21)
        Me.txtTelPJ.TabIndex = 323
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(203, 146)
        Me.Label24.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(55, 17)
        Me.Label24.TabIndex = 317
        Me.Label24.Text = "Compl.:"
        '
        'txtComplPJ
        '
        Me.txtComplPJ.Enabled = False
        Me.txtComplPJ.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplPJ.Location = New System.Drawing.Point(259, 143)
        Me.txtComplPJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtComplPJ.Name = "txtComplPJ"
        Me.txtComplPJ.ReadOnly = True
        Me.txtComplPJ.Size = New System.Drawing.Size(144, 21)
        Me.txtComplPJ.TabIndex = 306
        '
        'txtBairroPJ
        '
        Me.txtBairroPJ.Enabled = False
        Me.txtBairroPJ.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairroPJ.Location = New System.Drawing.Point(110, 169)
        Me.txtBairroPJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBairroPJ.Name = "txtBairroPJ"
        Me.txtBairroPJ.Size = New System.Drawing.Size(293, 21)
        Me.txtBairroPJ.TabIndex = 307
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(498, 174)
        Me.Label25.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 17)
        Me.Label25.TabIndex = 320
        Me.Label25.Text = "UF:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(57, 171)
        Me.Label26.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 17)
        Me.Label26.TabIndex = 319
        Me.Label26.Text = "Bairro:"
        '
        'txtUFPJ
        '
        Me.txtUFPJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUFPJ.Enabled = False
        Me.txtUFPJ.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUFPJ.FormattingEnabled = True
        Me.txtUFPJ.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.txtUFPJ.Location = New System.Drawing.Point(532, 171)
        Me.txtUFPJ.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUFPJ.Name = "txtUFPJ"
        Me.txtUFPJ.Size = New System.Drawing.Size(53, 23)
        Me.txtUFPJ.TabIndex = 309
        '
        'txtCEPPJ
        '
        Me.txtCEPPJ.Enabled = False
        Me.txtCEPPJ.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCEPPJ.Location = New System.Drawing.Point(639, 173)
        Me.txtCEPPJ.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCEPPJ.Name = "txtCEPPJ"
        Me.txtCEPPJ.Size = New System.Drawing.Size(89, 21)
        Me.txtCEPPJ.TabIndex = 322
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(470, 149)
        Me.Label28.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(56, 17)
        Me.Label28.TabIndex = 318
        Me.Label28.Text = "Cidade:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(597, 176)
        Me.Label29.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(39, 17)
        Me.Label29.TabIndex = 321
        Me.Label29.Text = "CEP:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(480, 70)
        Me.Label30.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(46, 17)
        Me.Label30.TabIndex = 315
        Me.Label30.Text = "Email:"
        '
        'txtEmailPJ
        '
        Me.txtEmailPJ.Enabled = False
        Me.txtEmailPJ.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailPJ.Location = New System.Drawing.Point(529, 68)
        Me.txtEmailPJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtEmailPJ.Name = "txtEmailPJ"
        Me.txtEmailPJ.Size = New System.Drawing.Size(294, 21)
        Me.txtEmailPJ.TabIndex = 303
        '
        'txtCidadePJ
        '
        Me.txtCidadePJ.Enabled = False
        Me.txtCidadePJ.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidadePJ.Location = New System.Drawing.Point(530, 147)
        Me.txtCidadePJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCidadePJ.Name = "txtCidadePJ"
        Me.txtCidadePJ.Size = New System.Drawing.Size(293, 21)
        Me.txtCidadePJ.TabIndex = 308
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(459, 44)
        Me.Label31.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(68, 17)
        Me.Label31.TabIndex = 313
        Me.Label31.Text = "Telefone:"
        '
        'lblSituacao
        '
        Me.lblSituacao.AutoSize = True
        Me.lblSituacao.ForeColor = System.Drawing.Color.White
        Me.lblSituacao.Location = New System.Drawing.Point(458, 96)
        Me.lblSituacao.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Size = New System.Drawing.Size(67, 17)
        Me.lblSituacao.TabIndex = 299
        Me.lblSituacao.Text = "Situação:"
        '
        'txtSituacao
        '
        Me.txtSituacao.Enabled = False
        Me.txtSituacao.Location = New System.Drawing.Point(529, 93)
        Me.txtSituacao.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(294, 23)
        Me.txtSituacao.TabIndex = 298
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.ForeColor = System.Drawing.Color.White
        Me.lblMotivo.Location = New System.Drawing.Point(465, 123)
        Me.lblMotivo.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(53, 17)
        Me.lblMotivo.TabIndex = 297
        Me.lblMotivo.Text = "Motivo:"
        '
        'txtMotivo
        '
        Me.txtMotivo.Enabled = False
        Me.txtMotivo.Location = New System.Drawing.Point(529, 120)
        Me.txtMotivo.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(294, 23)
        Me.txtMotivo.TabIndex = 296
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 295
        Me.Label3.Text = "Inscr. Estadual:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(58, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 294
        Me.Label4.Text = " CNPJ:"
        '
        'btBuscarCNPJ
        '
        Me.btBuscarCNPJ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscarCNPJ.FlatAppearance.BorderSize = 0
        Me.btBuscarCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscarCNPJ.Image = CType(resources.GetObject("btBuscarCNPJ.Image"), System.Drawing.Image)
        Me.btBuscarCNPJ.Location = New System.Drawing.Point(247, 11)
        Me.btBuscarCNPJ.Name = "btBuscarCNPJ"
        Me.btBuscarCNPJ.Size = New System.Drawing.Size(37, 26)
        Me.btBuscarCNPJ.TabIndex = 293
        Me.btBuscarCNPJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btBuscarCNPJ.UseVisualStyleBackColor = True
        '
        'txtIE
        '
        Me.txtIE.Location = New System.Drawing.Point(110, 42)
        Me.txtIE.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtIE.Mask = "###.###.###.###"
        Me.txtIE.Name = "txtIE"
        Me.txtIE.Size = New System.Drawing.Size(116, 23)
        Me.txtIE.TabIndex = 292
        Me.txtIE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Location = New System.Drawing.Point(110, 15)
        Me.txtCNPJ.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtCNPJ.Mask = "##.###.###/####-##"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(133, 23)
        Me.txtCNPJ.TabIndex = 291
        Me.txtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(205, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(486, 35)
        Me.Label18.TabIndex = 128
        Me.Label18.Text = "GERENCIAMENTO DE CLIENTES"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.ForeColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(772, 40)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(13, 17)
        Me.lblCodigo.TabIndex = 324
        Me.lblCodigo.Text = "-"
        Me.lblCodigo.Visible = False
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
        Me.btSair.Location = New System.Drawing.Point(437, 426)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(73, 30)
        Me.btSair.TabIndex = 325
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(916, 557)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Clientes"
        Me.TabControl1.ResumeLayout(False)
        Me.Cadastro.ResumeLayout(False)
        Me.Cadastro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PessoaJuridica.ResumeLayout(False)
        Me.PessoaJuridica.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgPJ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Cadastro As TabPage
    Friend WithEvents txtNatural As TextBox
    Friend WithEvents lblNatural As Label
    Friend WithEvents cbEstCivil As ComboBox
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRG As TextBox
    Friend WithEvents lblNasc As Label
    Friend WithEvents txtdtNasc As MaskedTextBox
    Friend WithEvents lblCPF As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtTelCel As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents PessoaJuridica As TabPage
    Friend WithEvents btNovoPJ As Button
    Friend WithEvents btEscluirPJ As Button
    Friend WithEvents btSalvarPJ As Button
    Friend WithEvents lblSituacao As Label
    Friend WithEvents txtSituacao As TextBox
    Friend WithEvents lblMotivo As Label
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btBuscarCNPJ As Button
    Friend WithEvents txtIE As MaskedTextBox
    Friend WithEvents txtCNPJ As MaskedTextBox
    Friend WithEvents txtCompl As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btBuscarCEP As Button
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtUF As ComboBox
    Friend WithEvents txtCEP As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtRazaoSocial As TextBox
    Friend WithEvents txtFantasia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEnd As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtTelPJ As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtComplPJ As TextBox
    Friend WithEvents txtBairroPJ As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtUFPJ As ComboBox
    Friend WithEvents txtCEPPJ As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtEmailPJ As TextBox
    Friend WithEvents txtCidadePJ As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents Label21 As Label
    Friend WithEvents txtBuscarNome As TextBox
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents txtBuscarCPF As MaskedTextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbCNPJ As RadioButton
    Friend WithEvents Label32 As Label
    Friend WithEvents txtBuscarNomePJ As TextBox
    Friend WithEvents rbNomePJ As RadioButton
    Friend WithEvents txtBuscarCNPJ As MaskedTextBox
    Friend WithEvents dgPJ As DataGridView
    Friend WithEvents Label27 As Label
    Friend WithEvents txtObsPj As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents lblTotalPJ As Label
    Friend WithEvents btSair As Button
End Class
