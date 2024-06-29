<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFornecedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFornecedores))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Cadastro = New System.Windows.Forms.TabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtAbertura = New System.Windows.Forms.TextBox()
        Me.txtTelContato = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.btBuscarEmpresa = New System.Windows.Forms.Button()
        Me.txtContato = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSituacao = New System.Windows.Forms.TextBox()
        Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.txtFantasia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCompl = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtUF = New System.Windows.Forms.ComboBox()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Consulta = New System.Windows.Forms.TabPage()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtBuscarCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.rbEmpresa = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbCNPJ = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Cadastro.SuspendLayout()
        Me.Consulta.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(101, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 32)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "FORNECEDORES"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Cadastro)
        Me.TabControl1.Controls.Add(Me.Consulta)
        Me.TabControl1.Location = New System.Drawing.Point(13, 56)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(548, 440)
        Me.TabControl1.TabIndex = 213
        '
        'Cadastro
        '
        Me.Cadastro.BackColor = System.Drawing.Color.SteelBlue
        Me.Cadastro.Controls.Add(Me.Label27)
        Me.Cadastro.Controls.Add(Me.txtAbertura)
        Me.Cadastro.Controls.Add(Me.txtTelContato)
        Me.Cadastro.Controls.Add(Me.Label19)
        Me.Cadastro.Controls.Add(Me.txtCNPJ)
        Me.Cadastro.Controls.Add(Me.btBuscarEmpresa)
        Me.Cadastro.Controls.Add(Me.txtContato)
        Me.Cadastro.Controls.Add(Me.Label4)
        Me.Cadastro.Controls.Add(Me.txtMotivo)
        Me.Cadastro.Controls.Add(Me.Label8)
        Me.Cadastro.Controls.Add(Me.txtSituacao)
        Me.Cadastro.Controls.Add(Me.txtRazaoSocial)
        Me.Cadastro.Controls.Add(Me.txtFantasia)
        Me.Cadastro.Controls.Add(Me.Label9)
        Me.Cadastro.Controls.Add(Me.Label11)
        Me.Cadastro.Controls.Add(Me.Label13)
        Me.Cadastro.Controls.Add(Me.txtEndereco)
        Me.Cadastro.Controls.Add(Me.Label12)
        Me.Cadastro.Controls.Add(Me.txtNumero)
        Me.Cadastro.Controls.Add(Me.Label7)
        Me.Cadastro.Controls.Add(Me.Label2)
        Me.Cadastro.Controls.Add(Me.txtTel)
        Me.Cadastro.Controls.Add(Me.Label14)
        Me.Cadastro.Controls.Add(Me.txtCompl)
        Me.Cadastro.Controls.Add(Me.txtBairro)
        Me.Cadastro.Controls.Add(Me.Label18)
        Me.Cadastro.Controls.Add(Me.Label16)
        Me.Cadastro.Controls.Add(Me.txtUF)
        Me.Cadastro.Controls.Add(Me.txtCEP)
        Me.Cadastro.Controls.Add(Me.Label15)
        Me.Cadastro.Controls.Add(Me.Label17)
        Me.Cadastro.Controls.Add(Me.Label5)
        Me.Cadastro.Controls.Add(Me.txtEmail)
        Me.Cadastro.Controls.Add(Me.txtCidade)
        Me.Cadastro.Controls.Add(Me.Label6)
        Me.Cadastro.Location = New System.Drawing.Point(4, 22)
        Me.Cadastro.Margin = New System.Windows.Forms.Padding(4)
        Me.Cadastro.Name = "Cadastro"
        Me.Cadastro.Padding = New System.Windows.Forms.Padding(4)
        Me.Cadastro.Size = New System.Drawing.Size(540, 414)
        Me.Cadastro.TabIndex = 0
        Me.Cadastro.Text = "Cadastro"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(313, 17)
        Me.Label27.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(50, 13)
        Me.Label27.TabIndex = 214
        Me.Label27.Text = "Abertura:"
        '
        'txtAbertura
        '
        Me.txtAbertura.Enabled = False
        Me.txtAbertura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbertura.Location = New System.Drawing.Point(376, 13)
        Me.txtAbertura.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtAbertura.Name = "txtAbertura"
        Me.txtAbertura.ReadOnly = True
        Me.txtAbertura.Size = New System.Drawing.Size(122, 21)
        Me.txtAbertura.TabIndex = 213
        '
        'txtTelContato
        '
        Me.txtTelContato.Location = New System.Drawing.Point(346, 373)
        Me.txtTelContato.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelContato.Mask = "(99) 00000-0000"
        Me.txtTelContato.Name = "txtTelContato"
        Me.txtTelContato.Size = New System.Drawing.Size(123, 20)
        Me.txtTelContato.TabIndex = 212
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(312, 376)
        Me.Label19.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 211
        Me.Label19.Text = "Tel.:"
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Location = New System.Drawing.Point(115, 9)
        Me.txtCNPJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCNPJ.Mask = "##.###.###/####-##"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(125, 20)
        Me.txtCNPJ.TabIndex = 31
        Me.txtCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'btBuscarEmpresa
        '
        Me.btBuscarEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.btBuscarEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscarEmpresa.FlatAppearance.BorderSize = 0
        Me.btBuscarEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btBuscarEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btBuscarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscarEmpresa.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscarEmpresa.ForeColor = System.Drawing.Color.Black
        Me.btBuscarEmpresa.Image = CType(resources.GetObject("btBuscarEmpresa.Image"), System.Drawing.Image)
        Me.btBuscarEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBuscarEmpresa.Location = New System.Drawing.Point(243, 4)
        Me.btBuscarEmpresa.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btBuscarEmpresa.Name = "btBuscarEmpresa"
        Me.btBuscarEmpresa.Size = New System.Drawing.Size(35, 27)
        Me.btBuscarEmpresa.TabIndex = 201
        Me.btBuscarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btBuscarEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btBuscarEmpresa.UseVisualStyleBackColor = False
        '
        'txtContato
        '
        Me.txtContato.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContato.Location = New System.Drawing.Point(115, 374)
        Me.txtContato.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtContato.Name = "txtContato"
        Me.txtContato.Size = New System.Drawing.Size(183, 21)
        Me.txtContato.TabIndex = 210
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(65, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "CNPJ:"
        '
        'txtMotivo
        '
        Me.txtMotivo.Enabled = False
        Me.txtMotivo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivo.Location = New System.Drawing.Point(114, 341)
        Me.txtMotivo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(387, 21)
        Me.txtMotivo.TabIndex = 206
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(57, 343)
        Me.Label8.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 207
        Me.Label8.Text = "Motivo:"
        '
        'txtSituacao
        '
        Me.txtSituacao.Enabled = False
        Me.txtSituacao.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSituacao.Location = New System.Drawing.Point(388, 244)
        Me.txtSituacao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(112, 21)
        Me.txtSituacao.TabIndex = 209
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.Enabled = False
        Me.txtRazaoSocial.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazaoSocial.Location = New System.Drawing.Point(114, 46)
        Me.txtRazaoSocial.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.ReadOnly = True
        Me.txtRazaoSocial.Size = New System.Drawing.Size(386, 21)
        Me.txtRazaoSocial.TabIndex = 1
        '
        'txtFantasia
        '
        Me.txtFantasia.Enabled = False
        Me.txtFantasia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFantasia.Location = New System.Drawing.Point(114, 77)
        Me.txtFantasia.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.ReadOnly = True
        Me.txtFantasia.Size = New System.Drawing.Size(386, 21)
        Me.txtFantasia.TabIndex = 113
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(324, 248)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 208
        Me.Label9.Text = "Situacao:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(50, 376)
        Me.Label11.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "Contato:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(82, 141)
        Me.Label13.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 13)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "N°:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(114, 109)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.ReadOnly = True
        Me.txtEndereco.Size = New System.Drawing.Size(387, 21)
        Me.txtEndereco.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(38, 112)
        Me.Label12.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Endereço:"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(114, 139)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(81, 21)
        Me.txtNumero.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(45, 80)
        Me.Label7.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Fantasia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(63, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Nome:"
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(115, 275)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(285, 21)
        Me.txtTel.TabIndex = 205
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(231, 144)
        Me.Label14.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "Compl.:"
        '
        'txtCompl
        '
        Me.txtCompl.Enabled = False
        Me.txtCompl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompl.Location = New System.Drawing.Point(287, 139)
        Me.txtCompl.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.ReadOnly = True
        Me.txtCompl.Size = New System.Drawing.Size(213, 21)
        Me.txtCompl.TabIndex = 12
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(114, 177)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(386, 21)
        Me.txtBairro.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(80, 244)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 13)
        Me.Label18.TabIndex = 124
        Me.Label18.Text = "UF:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(61, 179)
        Me.Label16.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "Bairro:"
        '
        'txtUF
        '
        Me.txtUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUF.Enabled = False
        Me.txtUF.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUF.FormattingEnabled = True
        Me.txtUF.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.txtUF.Location = New System.Drawing.Point(114, 241)
        Me.txtUF.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(53, 23)
        Me.txtUF.TabIndex = 16
        '
        'txtCEP
        '
        Me.txtCEP.Enabled = False
        Me.txtCEP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCEP.Location = New System.Drawing.Point(221, 243)
        Me.txtCEP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(89, 21)
        Me.txtCEP.TabIndex = 204
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(54, 211)
        Me.Label15.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 119
        Me.Label15.Text = "Cidade:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(179, 249)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 125
        Me.Label17.Text = "CEP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(65, 310)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(114, 308)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(384, 21)
        Me.txtEmail.TabIndex = 8
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(114, 209)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(386, 21)
        Me.txtCidade.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 277)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Telefone:"
        '
        'Consulta
        '
        Me.Consulta.BackColor = System.Drawing.Color.SteelBlue
        Me.Consulta.Controls.Add(Me.dg)
        Me.Consulta.Controls.Add(Me.lblTotal)
        Me.Consulta.Controls.Add(Me.Label20)
        Me.Consulta.Controls.Add(Me.txtBuscarCNPJ)
        Me.Consulta.Controls.Add(Me.rbEmpresa)
        Me.Consulta.Controls.Add(Me.txtBuscar)
        Me.Consulta.Controls.Add(Me.Label1)
        Me.Consulta.Controls.Add(Me.rbCNPJ)
        Me.Consulta.Location = New System.Drawing.Point(4, 22)
        Me.Consulta.Margin = New System.Windows.Forms.Padding(4)
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Padding = New System.Windows.Forms.Padding(4)
        Me.Consulta.Size = New System.Drawing.Size(540, 414)
        Me.Consulta.TabIndex = 1
        Me.Consulta.Text = "Consulta"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(12, 49)
        Me.dg.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(512, 326)
        Me.dg.TabIndex = 195
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(410, 382)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 17)
        Me.lblTotal.TabIndex = 202
        Me.lblTotal.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(350, 382)
        Me.Label20.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 17)
        Me.Label20.TabIndex = 203
        Me.Label20.Text = "Total:"
        '
        'txtBuscarCNPJ
        '
        Me.txtBuscarCNPJ.Location = New System.Drawing.Point(277, 17)
        Me.txtBuscarCNPJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscarCNPJ.Mask = "99,999,999/9999-99"
        Me.txtBuscarCNPJ.Name = "txtBuscarCNPJ"
        Me.txtBuscarCNPJ.Size = New System.Drawing.Size(247, 20)
        Me.txtBuscarCNPJ.TabIndex = 30
        '
        'rbEmpresa
        '
        Me.rbEmpresa.AutoSize = True
        Me.rbEmpresa.ForeColor = System.Drawing.Color.White
        Me.rbEmpresa.Location = New System.Drawing.Point(106, 15)
        Me.rbEmpresa.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbEmpresa.Name = "rbEmpresa"
        Me.rbEmpresa.Size = New System.Drawing.Size(66, 17)
        Me.rbEmpresa.TabIndex = 23
        Me.rbEmpresa.TabStop = True
        Me.rbEmpresa.Text = "Empresa"
        Me.rbEmpresa.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(277, 17)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(247, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar:"
        '
        'rbCNPJ
        '
        Me.rbCNPJ.AutoSize = True
        Me.rbCNPJ.ForeColor = System.Drawing.Color.White
        Me.rbCNPJ.Location = New System.Drawing.Point(202, 16)
        Me.rbCNPJ.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbCNPJ.Name = "rbCNPJ"
        Me.rbCNPJ.Size = New System.Drawing.Size(52, 17)
        Me.rbCNPJ.TabIndex = 24
        Me.rbCNPJ.TabStop = True
        Me.rbCNPJ.Text = "CNPJ"
        Me.rbCNPJ.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btLimpar)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.btSair)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.btnSalvar)
        Me.GroupBox4.Controls.Add(Me.btnExcluir)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Location = New System.Drawing.Point(27, 500)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(413, 57)
        Me.GroupBox4.TabIndex = 214
        Me.GroupBox4.TabStop = False
        '
        'btLimpar
        '
        Me.btLimpar.BackColor = System.Drawing.Color.Transparent
        Me.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimpar.FlatAppearance.BorderSize = 0
        Me.btLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLimpar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpar.ForeColor = System.Drawing.Color.White
        Me.btLimpar.Image = CType(resources.GetObject("btLimpar.Image"), System.Drawing.Image)
        Me.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btLimpar.Location = New System.Drawing.Point(208, 13)
        Me.btLimpar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(93, 37)
        Me.btLimpar.TabIndex = 206
        Me.btLimpar.Text = "Limpar Campos"
        Me.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btLimpar.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(385, -389)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 13)
        Me.Label21.TabIndex = 181
        Me.Label21.Text = "Produto:"
        '
        'btSair
        '
        Me.btSair.BackColor = System.Drawing.Color.Transparent
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSair.ForeColor = System.Drawing.Color.White
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSair.Location = New System.Drawing.Point(301, 18)
        Me.btSair.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(72, 32)
        Me.btSair.TabIndex = 199
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(701, -351)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 13)
        Me.Label22.TabIndex = 189
        Me.Label22.Text = "Estoque:"
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(12, 9)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(85, 37)
        Me.btnSalvar.TabIndex = 196
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
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(105, 10)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(90, 37)
        Me.btnExcluir.TabIndex = 198
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(160, -391)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 187
        Me.Label23.Text = "Núm Venda:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(713, -391)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 183
        Me.Label24.Text = "Cliente:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(161, -353)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 13)
        Me.Label25.TabIndex = 182
        Me.Label25.Text = "Quantidade:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(408, -351)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(34, 13)
        Me.Label26.TabIndex = 184
        Me.Label26.Text = "Valor:"
        '
        'frmFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(578, 561)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Fornecedores"
        Me.TabControl1.ResumeLayout(False)
        Me.Cadastro.ResumeLayout(False)
        Me.Cadastro.PerformLayout()
        Me.Consulta.ResumeLayout(False)
        Me.Consulta.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Cadastro As TabPage
    Friend WithEvents Label27 As Label
    Friend WithEvents txtAbertura As TextBox
    Friend WithEvents txtTelContato As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCNPJ As MaskedTextBox
    Friend WithEvents btBuscarEmpresa As Button
    Friend WithEvents txtContato As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSituacao As TextBox
    Friend WithEvents txtRazaoSocial As TextBox
    Friend WithEvents txtFantasia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCompl As TextBox
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtUF As ComboBox
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Consulta As TabPage
    Friend WithEvents dg As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtBuscarCNPJ As MaskedTextBox
    Friend WithEvents rbEmpresa As RadioButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbCNPJ As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btLimpar As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents btSair As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
End Class
