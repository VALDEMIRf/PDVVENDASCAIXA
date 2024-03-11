<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionarios
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuncionarios))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Cadastro = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtSaida2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtEntrada2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSaida = New System.Windows.Forms.MaskedTextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.txtCTPS = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtCel = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtdtDemissao = New System.Windows.Forms.MaskedTextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtData = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPIS = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtdtNasc = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.btBuscarCEP = New System.Windows.Forms.Button()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCompl = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtUF = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.pbImagem = New System.Windows.Forms.PictureBox()
        Me.btImagem = New System.Windows.Forms.Button()
        Me.Consulta = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCPF = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.Cadastro.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Consulta.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Cadastro)
        Me.TabControl1.Controls.Add(Me.Consulta)
        Me.TabControl1.Location = New System.Drawing.Point(8, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(911, 420)
        Me.TabControl1.TabIndex = 122
        '
        'Cadastro
        '
        Me.Cadastro.BackColor = System.Drawing.Color.SteelBlue
        Me.Cadastro.Controls.Add(Me.GroupBox6)
        Me.Cadastro.Controls.Add(Me.GroupBox4)
        Me.Cadastro.Controls.Add(Me.GroupBox2)
        Me.Cadastro.Controls.Add(Me.GroupBox5)
        Me.Cadastro.Controls.Add(Me.pbImagem)
        Me.Cadastro.Controls.Add(Me.btImagem)
        Me.Cadastro.ForeColor = System.Drawing.Color.White
        Me.Cadastro.Location = New System.Drawing.Point(4, 22)
        Me.Cadastro.Name = "Cadastro"
        Me.Cadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.Cadastro.Size = New System.Drawing.Size(903, 394)
        Me.Cadastro.TabIndex = 0
        Me.Cadastro.Text = "Cadastro"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtSaida2)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.txtEntrada2)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(326, 300)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(308, 65)
        Me.GroupBox6.TabIndex = 122
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Entrada e Saída segundo turno de Trabalho"
        '
        'txtSaida2
        '
        Me.txtSaida2.Location = New System.Drawing.Point(204, 27)
        Me.txtSaida2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaida2.Mask = "90:00:00"
        Me.txtSaida2.Name = "txtSaida2"
        Me.txtSaida2.Size = New System.Drawing.Size(58, 23)
        Me.txtSaida2.TabIndex = 19
        Me.txtSaida2.ValidatingType = GetType(Date)
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(155, 29)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 17)
        Me.Label26.TabIndex = 121
        Me.Label26.Text = "Saída:"
        '
        'txtEntrada2
        '
        Me.txtEntrada2.Location = New System.Drawing.Point(79, 26)
        Me.txtEntrada2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEntrada2.Mask = "90:00:00"
        Me.txtEntrada2.Name = "txtEntrada2"
        Me.txtEntrada2.Size = New System.Drawing.Size(59, 23)
        Me.txtEntrada2.TabIndex = 18
        Me.txtEntrada2.ValidatingType = GetType(Date)
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 29)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 17)
        Me.Label27.TabIndex = 109
        Me.Label27.Text = "Entrada:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.txtSaida)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.txtEntrada)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(7, 298)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(305, 68)
        Me.GroupBox4.TabIndex = 120
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Entrada e Saída primeiro turno de Trabalho"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(137, 32)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 17)
        Me.Label25.TabIndex = 121
        Me.Label25.Text = "Saída:"
        '
        'txtSaida
        '
        Me.txtSaida.Location = New System.Drawing.Point(191, 29)
        Me.txtSaida.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaida.Mask = "90:00:00"
        Me.txtSaida.Name = "txtSaida"
        Me.txtSaida.Size = New System.Drawing.Size(57, 23)
        Me.txtSaida.TabIndex = 17
        Me.txtSaida.ValidatingType = GetType(Date)
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(10, 32)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 17)
        Me.Label24.TabIndex = 109
        Me.Label24.Text = "Entrada:"
        '
        'txtEntrada
        '
        Me.txtEntrada.Location = New System.Drawing.Point(74, 29)
        Me.txtEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEntrada.Mask = "90:00:00"
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.Size = New System.Drawing.Size(55, 23)
        Me.txtEntrada.TabIndex = 16
        Me.txtEntrada.ValidatingType = GetType(Date)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSalario)
        Me.GroupBox2.Controls.Add(Me.txtCTPS)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.txtCel)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtdtDemissao)
        Me.GroupBox2.Controls.Add(Me.txtSerie)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.dtData)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtPIS)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtNome)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCPF)
        Me.GroupBox2.Controls.Add(Me.txtdtNasc)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtRG)
        Me.GroupBox2.Controls.Add(Me.cbSexo)
        Me.GroupBox2.Controls.Add(Me.cbCargo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtTel)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(888, 146)
        Me.GroupBox2.TabIndex = 101
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados do Funcionário"
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(67, 79)
        Me.txtSalario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(111, 23)
        Me.txtSalario.TabIndex = 9
        '
        'txtCTPS
        '
        Me.txtCTPS.Location = New System.Drawing.Point(618, 48)
        Me.txtCTPS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCTPS.Name = "txtCTPS"
        Me.txtCTPS.Size = New System.Drawing.Size(81, 23)
        Me.txtCTPS.TabIndex = 7
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(7, 83)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(56, 17)
        Me.Label28.TabIndex = 105
        Me.Label28.Text = "Salário:"
        '
        'txtCel
        '
        Me.txtCel.Location = New System.Drawing.Point(438, 52)
        Me.txtCel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCel.Mask = "(00) 0 0000-0000"
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(102, 23)
        Me.txtCel.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(398, 55)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 17)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Cel:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(564, 52)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 17)
        Me.Label22.TabIndex = 102
        Me.Label22.Text = "CTPS :"
        '
        'txtdtDemissao
        '
        Me.txtdtDemissao.Location = New System.Drawing.Point(798, 111)
        Me.txtdtDemissao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdtDemissao.Mask = "00/00/0000"
        Me.txtdtDemissao.Name = "txtdtDemissao"
        Me.txtdtDemissao.Size = New System.Drawing.Size(72, 23)
        Me.txtdtDemissao.TabIndex = 15
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(795, 48)
        Me.txtSerie.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(72, 23)
        Me.txtSerie.TabIndex = 8
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(743, 51)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 17)
        Me.Label23.TabIndex = 103
        Me.Label23.Text = "Série:"
        '
        'dtData
        '
        Me.dtData.Location = New System.Drawing.Point(622, 112)
        Me.dtData.Margin = New System.Windows.Forms.Padding(4)
        Me.dtData.Mask = "00/00/0000"
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(70, 23)
        Me.dtData.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(545, 116)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Admissão:"
        '
        'txtPIS
        '
        Me.txtPIS.Location = New System.Drawing.Point(61, 49)
        Me.txtPIS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPIS.Mask = "000.00000.00-0"
        Me.txtPIS.Name = "txtPIS"
        Me.txtPIS.Size = New System.Drawing.Size(102, 23)
        Me.txtPIS.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(719, 114)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 17)
        Me.Label18.TabIndex = 96
        Me.Label18.Text = "Demissão:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(257, 117)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 17)
        Me.Label20.TabIndex = 98
        Me.Label20.Text = "Função :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(20, 53)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 17)
        Me.Label21.TabIndex = 99
        Me.Label21.Text = "PIS:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(61, 22)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(439, 23)
        Me.txtNome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Nome:"
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(554, 19)
        Me.txtCPF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCPF.Mask = "999,999,999-99"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(100, 23)
        Me.txtCPF.TabIndex = 2
        '
        'txtdtNasc
        '
        Me.txtdtNasc.Location = New System.Drawing.Point(77, 111)
        Me.txtdtNasc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdtNasc.Mask = "00/00/0000"
        Me.txtdtNasc.Name = "txtdtNasc"
        Me.txtdtNasc.Size = New System.Drawing.Size(75, 23)
        Me.txtdtNasc.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(10, 113)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 17)
        Me.Label19.TabIndex = 97
        Me.Label19.Text = "Dt Nasc:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(508, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "CPF:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(662, 22)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 17)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "RG:"
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(703, 19)
        Me.txtRG.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(164, 23)
        Me.txtRG.TabIndex = 3
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.cbSexo.Location = New System.Drawing.Point(750, 77)
        Me.cbSexo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(117, 24)
        Me.cbSexo.TabIndex = 11
        '
        'cbCargo
        '
        Me.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Items.AddRange(New Object() {"Manhã", "Tarde", "Noite", "Madrugada"})
        Me.cbCargo.Location = New System.Drawing.Point(323, 111)
        Me.cbCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(129, 24)
        Me.cbCargo.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(695, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Sexo:"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(260, 49)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTel.Mask = "(00) 0000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(102, 23)
        Me.txtTel.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 53)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 17)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Tel:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(260, 81)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(363, 23)
        Me.txtEmail.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 84)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Email:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtComplemento)
        Me.GroupBox5.Controls.Add(Me.btBuscarCEP)
        Me.GroupBox5.Controls.Add(Me.txtCEP)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtCompl)
        Me.GroupBox5.Controls.Add(Me.txtNumero)
        Me.GroupBox5.Controls.Add(Me.txtBairro)
        Me.GroupBox5.Controls.Add(Me.txtUF)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txtCidade)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txtEndereco)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(7, 161)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(688, 131)
        Me.GroupBox5.TabIndex = 119
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = " Endereço"
        '
        'txtComplemento
        '
        Me.txtComplemento.Enabled = False
        Me.txtComplemento.Location = New System.Drawing.Point(475, 48)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(198, 23)
        Me.txtComplemento.TabIndex = 121
        '
        'btBuscarCEP
        '
        Me.btBuscarCEP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btBuscarCEP.FlatAppearance.BorderSize = 0
        Me.btBuscarCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscarCEP.Image = CType(resources.GetObject("btBuscarCEP.Image"), System.Drawing.Image)
        Me.btBuscarCEP.Location = New System.Drawing.Point(165, 18)
        Me.btBuscarCEP.Name = "btBuscarCEP"
        Me.btBuscarCEP.Size = New System.Drawing.Size(37, 26)
        Me.btBuscarCEP.TabIndex = 21
        Me.btBuscarCEP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btBuscarCEP.UseVisualStyleBackColor = True
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(87, 22)
        Me.txtCEP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCEP.Mask = "00000-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(70, 23)
        Me.txtCEP.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(43, 22)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 17)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "CEP:"
        '
        'txtCompl
        '
        Me.txtCompl.Location = New System.Drawing.Point(447, 76)
        Me.txtCompl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(225, 23)
        Me.txtCompl.TabIndex = 23
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(86, 76)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(70, 23)
        Me.txtNumero.TabIndex = 22
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(86, 103)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.ReadOnly = True
        Me.txtBairro.Size = New System.Drawing.Size(259, 23)
        Me.txtBairro.TabIndex = 11
        '
        'txtUF
        '
        Me.txtUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUF.Enabled = False
        Me.txtUF.FormattingEnabled = True
        Me.txtUF.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.txtUF.Location = New System.Drawing.Point(605, 20)
        Me.txtUF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(67, 24)
        Me.txtUF.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(336, 78)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 17)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Complemento:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(567, 24)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 17)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "UF:"
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(417, 103)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.ReadOnly = True
        Me.txtCidade.Size = New System.Drawing.Size(255, 23)
        Me.txtCidade.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(353, 106)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 17)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Cidade:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(32, 107)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 17)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Bairro:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 80)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 17)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "N°:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 50)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Endereço:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(87, 48)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.ReadOnly = True
        Me.txtEndereco.Size = New System.Drawing.Size(303, 23)
        Me.txtEndereco.TabIndex = 8
        '
        'pbImagem
        '
        Me.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImagem.Location = New System.Drawing.Point(740, 170)
        Me.pbImagem.Name = "pbImagem"
        Me.pbImagem.Size = New System.Drawing.Size(135, 135)
        Me.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagem.TabIndex = 110
        Me.pbImagem.TabStop = False
        '
        'btImagem
        '
        Me.btImagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImagem.FlatAppearance.BorderSize = 0
        Me.btImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImagem.Image = CType(resources.GetObject("btImagem.Image"), System.Drawing.Image)
        Me.btImagem.Location = New System.Drawing.Point(815, 314)
        Me.btImagem.Name = "btImagem"
        Me.btImagem.Size = New System.Drawing.Size(37, 26)
        Me.btImagem.TabIndex = 24
        Me.btImagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btImagem.UseVisualStyleBackColor = True
        '
        'Consulta
        '
        Me.Consulta.BackColor = System.Drawing.Color.SteelBlue
        Me.Consulta.Controls.Add(Me.Label11)
        Me.Consulta.Controls.Add(Me.lblTotal)
        Me.Consulta.Controls.Add(Me.dg)
        Me.Consulta.Controls.Add(Me.GroupBox1)
        Me.Consulta.Location = New System.Drawing.Point(4, 22)
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Padding = New System.Windows.Forms.Padding(3)
        Me.Consulta.Size = New System.Drawing.Size(903, 394)
        Me.Consulta.TabIndex = 1
        Me.Consulta.Text = "Consulta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(809, 362)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 18)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(858, 361)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 18)
        Me.lblTotal.TabIndex = 111
        Me.lblTotal.Text = "-"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(7, 54)
        Me.dg.Margin = New System.Windows.Forms.Padding(4)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(884, 296)
        Me.dg.TabIndex = 113
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCPF)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.rbNome)
        Me.GroupBox1.Controls.Add(Me.txtBuscarCPF)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(18, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(370, 42)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        '
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.Location = New System.Drawing.Point(134, 14)
        Me.rbCPF.Margin = New System.Windows.Forms.Padding(4)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(52, 21)
        Me.rbCPF.TabIndex = 19
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "CPF"
        Me.rbCPF.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(191, 13)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(171, 23)
        Me.txtBuscar.TabIndex = 100
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(69, 13)
        Me.rbNome.Margin = New System.Windows.Forms.Padding(4)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(63, 21)
        Me.rbNome.TabIndex = 18
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'txtBuscarCPF
        '
        Me.txtBuscarCPF.Location = New System.Drawing.Point(192, 13)
        Me.txtBuscarCPF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBuscarCPF.Mask = "999,999,999-99"
        Me.txtBuscarCPF.Name = "txtBuscarCPF"
        Me.txtBuscarCPF.Size = New System.Drawing.Size(171, 23)
        Me.txtBuscarCPF.TabIndex = 30
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btSair)
        Me.GroupBox3.Controls.Add(Me.btExcluir)
        Me.GroupBox3.Controls.Add(Me.btEditar)
        Me.GroupBox3.Controls.Add(Me.btSalvar)
        Me.GroupBox3.Controls.Add(Me.btNovo)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 438)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 69)
        Me.GroupBox3.TabIndex = 123
        Me.GroupBox3.TabStop = False
        '
        'btSair
        '
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.ForeColor = System.Drawing.Color.White
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(323, 17)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(66, 30)
        Me.btSair.TabIndex = 28
        Me.btSair.Text = "Sair"
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'btExcluir
        '
        Me.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExcluir.FlatAppearance.BorderSize = 0
        Me.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExcluir.ForeColor = System.Drawing.Color.White
        Me.btExcluir.Image = CType(resources.GetObject("btExcluir.Image"), System.Drawing.Image)
        Me.btExcluir.Location = New System.Drawing.Point(243, 17)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(79, 35)
        Me.btExcluir.TabIndex = 27
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btExcluir.UseVisualStyleBackColor = True
        '
        'btEditar
        '
        Me.btEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEditar.FlatAppearance.BorderSize = 0
        Me.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEditar.ForeColor = System.Drawing.Color.White
        Me.btEditar.Image = CType(resources.GetObject("btEditar.Image"), System.Drawing.Image)
        Me.btEditar.Location = New System.Drawing.Point(163, 17)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(75, 35)
        Me.btEditar.TabIndex = 26
        Me.btEditar.Text = "Editar"
        Me.btEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btEditar.UseVisualStyleBackColor = True
        '
        'btSalvar
        '
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.FlatAppearance.BorderSize = 0
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.ForeColor = System.Drawing.Color.White
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.Location = New System.Drawing.Point(85, 17)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(77, 35)
        Me.btSalvar.TabIndex = 25
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btNovo
        '
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.ForeColor = System.Drawing.Color.White
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(11, 17)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(75, 35)
        Me.btNovo.TabIndex = 0
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = True
        '
        'errErro
        '
        Me.errErro.ContainerControl = Me
        '
        'frmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(930, 518)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento de Funcionarios"
        Me.TabControl1.ResumeLayout(False)
        Me.Cadastro.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Consulta.ResumeLayout(False)
        Me.Consulta.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Cadastro As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents txtdtNasc As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRG As TextBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtdtDemissao As MaskedTextBox
    Friend WithEvents dtData As MaskedTextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents btBuscarCEP As Button
    Friend WithEvents txtCEP As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCompl As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents txtUF As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pbImagem As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btImagem As Button
    Friend WithEvents cbCargo As ComboBox
    Friend WithEvents Consulta As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents dg As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents txtBuscarCPF As MaskedTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btSair As Button
    Friend WithEvents btExcluir As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents errErro As ErrorProvider
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtPIS As MaskedTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtSaida2 As MaskedTextBox
    Friend WithEvents txtEntrada2 As MaskedTextBox
    Friend WithEvents txtSaida As MaskedTextBox
    Friend WithEvents txtEntrada As MaskedTextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtCTPS As TextBox
    Friend WithEvents txtCel As MaskedTextBox
    Friend WithEvents Label9 As Label
End Class
