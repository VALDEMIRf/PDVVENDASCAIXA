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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtIE = New System.Windows.Forms.MaskedTextBox()
        Me.txtCompl = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.rbPF = New System.Windows.Forms.RadioButton()
        Me.rbPJ = New System.Windows.Forms.RadioButton()
        Me.txtCNPJ = New System.Windows.Forms.MaskedTextBox()
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
        Me.Consulta = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCPF = New System.Windows.Forms.MaskedTextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtBuscarNome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.txtTelJuridica = New System.Windows.Forms.TextBox()
        Me.btBuscarCNPJ = New System.Windows.Forms.Button()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.lblSituacao = New System.Windows.Forms.Label()
        Me.txtSituacao = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.Cadastro.SuspendLayout()
        Me.Consulta.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Cadastro)
        Me.TabControl1.Controls.Add(Me.Consulta)
        Me.TabControl1.Location = New System.Drawing.Point(13, 49)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1031, 420)
        Me.TabControl1.TabIndex = 0
        '
        'Cadastro
        '
        Me.Cadastro.BackColor = System.Drawing.Color.Teal
        Me.Cadastro.Controls.Add(Me.lblSituacao)
        Me.Cadastro.Controls.Add(Me.txtSituacao)
        Me.Cadastro.Controls.Add(Me.lblMotivo)
        Me.Cadastro.Controls.Add(Me.txtMotivo)
        Me.Cadastro.Controls.Add(Me.btBuscarCNPJ)
        Me.Cadastro.Controls.Add(Me.txtTelJuridica)
        Me.Cadastro.Controls.Add(Me.Label20)
        Me.Cadastro.Controls.Add(Me.txtObs)
        Me.Cadastro.Controls.Add(Me.txtIE)
        Me.Cadastro.Controls.Add(Me.txtCompl)
        Me.Cadastro.Controls.Add(Me.Label11)
        Me.Cadastro.Controls.Add(Me.txtCidade)
        Me.Cadastro.Controls.Add(Me.Label15)
        Me.Cadastro.Controls.Add(Me.txtBairro)
        Me.Cadastro.Controls.Add(Me.Label16)
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
        Me.Cadastro.Controls.Add(Me.rbPF)
        Me.Cadastro.Controls.Add(Me.rbPJ)
        Me.Cadastro.Controls.Add(Me.txtCNPJ)
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
        Me.Cadastro.Size = New System.Drawing.Size(1023, 391)
        Me.Cadastro.TabIndex = 0
        Me.Cadastro.Text = "Cadastro"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(598, 256)
        Me.Label20.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 17)
        Me.Label20.TabIndex = 288
        Me.Label20.Text = "Obs.:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(653, 253)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(361, 127)
        Me.txtObs.TabIndex = 287
        '
        'txtIE
        '
        Me.txtIE.Location = New System.Drawing.Point(409, 50)
        Me.txtIE.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtIE.Mask = "###.###.###.###"
        Me.txtIE.Name = "txtIE"
        Me.txtIE.Size = New System.Drawing.Size(154, 23)
        Me.txtIE.TabIndex = 286
        Me.txtIE.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtCompl
        '
        Me.txtCompl.Location = New System.Drawing.Point(698, 155)
        Me.txtCompl.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(318, 23)
        Me.txtCompl.TabIndex = 284
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(587, 158)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 17)
        Me.Label11.TabIndex = 285
        Me.Label11.Text = "Complemento2:"
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(653, 216)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(363, 23)
        Me.txtCidade.TabIndex = 276
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(596, 218)
        Me.Label15.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 17)
        Me.Label15.TabIndex = 280
        Me.Label15.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(653, 185)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(363, 23)
        Me.txtBairro.TabIndex = 275
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(598, 189)
        Me.Label16.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 17)
        Me.Label16.TabIndex = 281
        Me.Label16.Text = "Bairro:"
        '
        'btBuscarCEP
        '
        Me.btBuscarCEP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscarCEP.FlatAppearance.BorderSize = 0
        Me.btBuscarCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscarCEP.Image = CType(resources.GetObject("btBuscarCEP.Image"), System.Drawing.Image)
        Me.btBuscarCEP.Location = New System.Drawing.Point(750, 50)
        Me.btBuscarCEP.Name = "btBuscarCEP"
        Me.btBuscarCEP.Size = New System.Drawing.Size(37, 26)
        Me.btBuscarCEP.TabIndex = 270
        Me.btBuscarCEP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btBuscarCEP.UseVisualStyleBackColor = True
        '
        'txtComplemento
        '
        Me.txtComplemento.Enabled = False
        Me.txtComplemento.Location = New System.Drawing.Point(802, 120)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(212, 23)
        Me.txtComplemento.TabIndex = 274
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(740, 125)
        Me.Label13.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 17)
        Me.Label13.TabIndex = 279
        Me.Label13.Text = "Compl.:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(651, 120)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(81, 23)
        Me.txtNumero.TabIndex = 273
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(618, 123)
        Me.Label12.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 17)
        Me.Label12.TabIndex = 278
        Me.Label12.Text = "N°:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(649, 85)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(365, 23)
        Me.txtEndereco.TabIndex = 272
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(571, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 277
        Me.Label1.Text = "Endereço:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(900, 57)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 17)
        Me.Label14.TabIndex = 282
        Me.Label14.Text = "UF:"
        '
        'txtUF
        '
        Me.txtUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUF.Enabled = False
        Me.txtUF.FormattingEnabled = True
        Me.txtUF.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.txtUF.Location = New System.Drawing.Point(935, 52)
        Me.txtUF.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(79, 24)
        Me.txtUF.TabIndex = 271
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(649, 51)
        Me.txtCEP.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCEP.Mask = "00000-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(93, 23)
        Me.txtCEP.TabIndex = 269
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(605, 55)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 17)
        Me.Label17.TabIndex = 283
        Me.Label17.Text = "CEP:"
        '
        'rbPF
        '
        Me.rbPF.AutoSize = True
        Me.rbPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPF.ForeColor = System.Drawing.Color.White
        Me.rbPF.Location = New System.Drawing.Point(188, 15)
        Me.rbPF.Margin = New System.Windows.Forms.Padding(4)
        Me.rbPF.Name = "rbPF"
        Me.rbPF.Size = New System.Drawing.Size(120, 22)
        Me.rbPF.TabIndex = 267
        Me.rbPF.TabStop = True
        Me.rbPF.Text = "Pessoa Física"
        Me.rbPF.UseVisualStyleBackColor = True
        '
        'rbPJ
        '
        Me.rbPJ.AutoSize = True
        Me.rbPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPJ.ForeColor = System.Drawing.Color.White
        Me.rbPJ.Location = New System.Drawing.Point(367, 15)
        Me.rbPJ.Margin = New System.Windows.Forms.Padding(4)
        Me.rbPJ.Name = "rbPJ"
        Me.rbPJ.Size = New System.Drawing.Size(132, 22)
        Me.rbPJ.TabIndex = 266
        Me.rbPJ.TabStop = True
        Me.rbPJ.Text = "Pessoa Jurídica"
        Me.rbPJ.UseVisualStyleBackColor = True
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Location = New System.Drawing.Point(104, 47)
        Me.txtCNPJ.Margin = New System.Windows.Forms.Padding(11, 7, 11, 7)
        Me.txtCNPJ.Mask = "##.###.###/####-##"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(133, 23)
        Me.txtCNPJ.TabIndex = 264
        Me.txtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtNatural
        '
        Me.txtNatural.Location = New System.Drawing.Point(443, 115)
        Me.txtNatural.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtNatural.Name = "txtNatural"
        Me.txtNatural.Size = New System.Drawing.Size(120, 23)
        Me.txtNatural.TabIndex = 136
        '
        'lblNatural
        '
        Me.lblNatural.AutoSize = True
        Me.lblNatural.ForeColor = System.Drawing.Color.White
        Me.lblNatural.Location = New System.Drawing.Point(362, 118)
        Me.lblNatural.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblNatural.Name = "lblNatural"
        Me.lblNatural.Size = New System.Drawing.Size(82, 17)
        Me.lblNatural.TabIndex = 151
        Me.lblNatural.Text = "Naturidade:"
        '
        'cbEstCivil
        '
        Me.cbEstCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstCivil.FormattingEnabled = True
        Me.cbEstCivil.Items.AddRange(New Object() {"Solteiro (a)", "Casado (a)", "Separado (a)", "Divorciado (a) ", "Viúvo (a) ", "Outros"})
        Me.cbEstCivil.Location = New System.Drawing.Point(104, 115)
        Me.cbEstCivil.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.cbEstCivil.Name = "cbEstCivil"
        Me.cbEstCivil.Size = New System.Drawing.Size(240, 24)
        Me.cbEstCivil.TabIndex = 135
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.ForeColor = System.Drawing.Color.White
        Me.lblEstadoCivil.Location = New System.Drawing.Point(9, 118)
        Me.lblEstadoCivil.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(83, 17)
        Me.lblEstadoCivil.TabIndex = 150
        Me.lblEstadoCivil.Text = "Estado civil:"
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(105, 47)
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
        Me.Label10.Location = New System.Drawing.Point(348, 51)
        Me.Label10.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "RG / IE:"
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(409, 47)
        Me.txtRG.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(154, 23)
        Me.txtRG.TabIndex = 134
        '
        'lblNasc
        '
        Me.lblNasc.AutoSize = True
        Me.lblNasc.ForeColor = System.Drawing.Color.White
        Me.lblNasc.Location = New System.Drawing.Point(400, 154)
        Me.lblNasc.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblNasc.Name = "lblNasc"
        Me.lblNasc.Size = New System.Drawing.Size(44, 17)
        Me.lblNasc.TabIndex = 148
        Me.lblNasc.Text = "Nasc:"
        '
        'txtdtNasc
        '
        Me.txtdtNasc.Location = New System.Drawing.Point(458, 148)
        Me.txtdtNasc.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtdtNasc.Mask = "00/00/0000"
        Me.txtdtNasc.Name = "txtdtNasc"
        Me.txtdtNasc.Size = New System.Drawing.Size(105, 23)
        Me.txtdtNasc.TabIndex = 138
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.ForeColor = System.Drawing.Color.White
        Me.lblCPF.Location = New System.Drawing.Point(13, 50)
        Me.lblCPF.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(85, 17)
        Me.lblCPF.TabIndex = 144
        Me.lblCPF.Text = "CPF / CNPJ:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.ForeColor = System.Drawing.Color.White
        Me.lblSexo.Location = New System.Drawing.Point(55, 154)
        Me.lblSexo.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(43, 17)
        Me.lblSexo.TabIndex = 143
        Me.lblSexo.Text = "Sexo:"
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.cbSexo.Location = New System.Drawing.Point(104, 151)
        Me.cbSexo.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(240, 24)
        Me.cbSexo.TabIndex = 137
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(103, 80)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(459, 23)
        Me.txtNome.TabIndex = 132
        '
        'txtTelCel
        '
        Me.txtTelCel.Location = New System.Drawing.Point(440, 184)
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
        Me.Label6.Location = New System.Drawing.Point(24, 188)
        Me.Label6.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Telefone:"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(104, 184)
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
        Me.Label5.Location = New System.Drawing.Point(40, 219)
        Me.Label5.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(104, 216)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(458, 23)
        Me.txtEmail.TabIndex = 141
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(366, 190)
        Me.Label9.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "Celular:"
        '
        'Consulta
        '
        Me.Consulta.BackColor = System.Drawing.Color.Teal
        Me.Consulta.Controls.Add(Me.GroupBox1)
        Me.Consulta.Controls.Add(Me.dg)
        Me.Consulta.Controls.Add(Me.txtBuscarNome)
        Me.Consulta.Controls.Add(Me.Label7)
        Me.Consulta.Controls.Add(Me.lblTotal)
        Me.Consulta.Location = New System.Drawing.Point(4, 25)
        Me.Consulta.Margin = New System.Windows.Forms.Padding(4)
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Padding = New System.Windows.Forms.Padding(4)
        Me.Consulta.Size = New System.Drawing.Size(1023, 391)
        Me.Consulta.TabIndex = 1
        Me.Consulta.Text = "Consulta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCPF)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.rbNome)
        Me.GroupBox1.Controls.Add(Me.txtBuscarCPF)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(35, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(433, 45)
        Me.GroupBox1.TabIndex = 208
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
        Me.dg.Location = New System.Drawing.Point(12, 60)
        Me.dg.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(946, 296)
        Me.dg.TabIndex = 200
        '
        'txtBuscarNome
        '
        Me.txtBuscarNome.Location = New System.Drawing.Point(491, 20)
        Me.txtBuscarNome.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscarNome.Name = "txtBuscarNome"
        Me.txtBuscarNome.Size = New System.Drawing.Size(170, 23)
        Me.txtBuscarNome.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(871, 366)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 202
        Me.Label7.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(933, 366)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 201
        Me.lblTotal.Text = "-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(216, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(313, 29)
        Me.Label18.TabIndex = 128
        Me.Label18.Text = "CADASTRO DE CLIENTES"
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
        Me.btnNovo.Location = New System.Drawing.Point(17, 492)
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
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(291, 492)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(90, 37)
        Me.btnExcluir.TabIndex = 132
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
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
        Me.btnEditar.Location = New System.Drawing.Point(203, 492)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(85, 37)
        Me.btnEditar.TabIndex = 131
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.btnSalvar.Location = New System.Drawing.Point(107, 492)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(88, 37)
        Me.btnSalvar.TabIndex = 130
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
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
        Me.btSair.Location = New System.Drawing.Point(391, 494)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(81, 37)
        Me.btSair.TabIndex = 133
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'txtTelJuridica
        '
        Me.txtTelJuridica.Enabled = False
        Me.txtTelJuridica.Location = New System.Drawing.Point(103, 183)
        Me.txtTelJuridica.Name = "txtTelJuridica"
        Me.txtTelJuridica.Size = New System.Drawing.Size(459, 23)
        Me.txtTelJuridica.TabIndex = 289
        '
        'btBuscarCNPJ
        '
        Me.btBuscarCNPJ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscarCNPJ.FlatAppearance.BorderSize = 0
        Me.btBuscarCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscarCNPJ.Image = CType(resources.GetObject("btBuscarCNPJ.Image"), System.Drawing.Image)
        Me.btBuscarCNPJ.Location = New System.Drawing.Point(244, 46)
        Me.btBuscarCNPJ.Name = "btBuscarCNPJ"
        Me.btBuscarCNPJ.Size = New System.Drawing.Size(37, 26)
        Me.btBuscarCNPJ.TabIndex = 290
        Me.btBuscarCNPJ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btBuscarCNPJ.UseVisualStyleBackColor = True
        '
        'lblMotivo
        '
        Me.lblMotivo.AutoSize = True
        Me.lblMotivo.ForeColor = System.Drawing.Color.White
        Me.lblMotivo.Location = New System.Drawing.Point(39, 296)
        Me.lblMotivo.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(53, 17)
        Me.lblMotivo.TabIndex = 292
        Me.lblMotivo.Text = "Motivo:"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(103, 293)
        Me.txtMotivo.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(458, 23)
        Me.txtMotivo.TabIndex = 291
        '
        'lblSituacao
        '
        Me.lblSituacao.AutoSize = True
        Me.lblSituacao.ForeColor = System.Drawing.Color.White
        Me.lblSituacao.Location = New System.Drawing.Point(32, 259)
        Me.lblSituacao.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblSituacao.Name = "lblSituacao"
        Me.lblSituacao.Size = New System.Drawing.Size(67, 17)
        Me.lblSituacao.TabIndex = 294
        Me.lblSituacao.Text = "Situação:"
        '
        'txtSituacao
        '
        Me.txtSituacao.Location = New System.Drawing.Point(103, 256)
        Me.txtSituacao.Margin = New System.Windows.Forms.Padding(9, 7, 9, 7)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(458, 23)
        Me.txtSituacao.TabIndex = 293
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1064, 554)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Clientes"
        Me.TabControl1.ResumeLayout(False)
        Me.Cadastro.ResumeLayout(False)
        Me.Cadastro.PerformLayout()
        Me.Consulta.ResumeLayout(False)
        Me.Consulta.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Consulta As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCNPJ As MaskedTextBox
    Friend WithEvents rbPF As RadioButton
    Friend WithEvents rbPJ As RadioButton
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal As Label
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
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btSair As Button
    Friend WithEvents txtIE As MaskedTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents Label21 As Label
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents txtBuscarCPF As MaskedTextBox
    Friend WithEvents txtBuscarNome As TextBox
    Friend WithEvents txtTelJuridica As TextBox
    Friend WithEvents btBuscarCNPJ As Button
    Friend WithEvents lblSituacao As Label
    Friend WithEvents txtSituacao As TextBox
    Friend WithEvents lblMotivo As Label
    Friend WithEvents txtMotivo As TextBox
End Class
