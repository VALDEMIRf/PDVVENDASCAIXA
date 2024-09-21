<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContasReceber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContasReceber))
        Me.dgContasReceber = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNvenda = New System.Windows.Forms.RadioButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtBuscarNvenda = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblNumTotalContasReceber = New System.Windows.Forms.Label()
        Me.btnDebitosCliente = New System.Windows.Forms.Button()
        Me.btnQuitarConta = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbContasVencidas = New System.Windows.Forms.RadioButton()
        Me.rbContasPagar = New System.Windows.Forms.RadioButton()
        Me.rbContasPagas = New System.Windows.Forms.RadioButton()
        Me.rbTodas = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCliente = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalContasAtrasadas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalContasPagas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalContasNaoPagas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalContasPagar = New System.Windows.Forms.TextBox()
        CType(Me.dgContasReceber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgContasReceber
        '
        Me.dgContasReceber.AllowUserToAddRows = False
        Me.dgContasReceber.AllowUserToDeleteRows = False
        Me.dgContasReceber.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgContasReceber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContasReceber.GridColor = System.Drawing.Color.DarkBlue
        Me.dgContasReceber.Location = New System.Drawing.Point(7, 148)
        Me.dgContasReceber.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgContasReceber.Name = "dgContasReceber"
        Me.dgContasReceber.ReadOnly = True
        Me.dgContasReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContasReceber.Size = New System.Drawing.Size(1172, 328)
        Me.dgContasReceber.TabIndex = 241
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.rbNvenda)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.rbCliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(286, 79)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(546, 45)
        Me.GroupBox1.TabIndex = 322
        Me.GroupBox1.TabStop = False
        '
        'rbNvenda
        '
        Me.rbNvenda.AutoSize = True
        Me.rbNvenda.ForeColor = System.Drawing.Color.White
        Me.rbNvenda.Location = New System.Drawing.Point(147, 16)
        Me.rbNvenda.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbNvenda.Name = "rbNvenda"
        Me.rbNvenda.Size = New System.Drawing.Size(86, 21)
        Me.rbNvenda.TabIndex = 16
        Me.rbNvenda.TabStop = True
        Me.rbNvenda.Text = "Nº Venda"
        Me.rbNvenda.UseVisualStyleBackColor = True
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
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.ForeColor = System.Drawing.Color.White
        Me.rbCliente.Location = New System.Drawing.Point(73, 16)
        Me.rbCliente.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(69, 21)
        Me.rbCliente.TabIndex = 15
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(994, 79)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(170, 26)
        Me.txtBuscar.TabIndex = 17
        '
        'txtBuscarNvenda
        '
        Me.txtBuscarNvenda.Location = New System.Drawing.Point(973, 114)
        Me.txtBuscarNvenda.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtBuscarNvenda.Name = "txtBuscarNvenda"
        Me.txtBuscarNvenda.Size = New System.Drawing.Size(170, 26)
        Me.txtBuscarNvenda.TabIndex = 323
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(925, 551)
        Me.Label22.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(155, 20)
        Me.Label22.TabIndex = 333
        Me.Label22.Text = "Contas Encontradas"
        '
        'lblNumTotalContasReceber
        '
        Me.lblNumTotalContasReceber.AutoSize = True
        Me.lblNumTotalContasReceber.BackColor = System.Drawing.Color.Transparent
        Me.lblNumTotalContasReceber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTotalContasReceber.ForeColor = System.Drawing.Color.White
        Me.lblNumTotalContasReceber.Location = New System.Drawing.Point(895, 556)
        Me.lblNumTotalContasReceber.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblNumTotalContasReceber.Name = "lblNumTotalContasReceber"
        Me.lblNumTotalContasReceber.Size = New System.Drawing.Size(14, 20)
        Me.lblNumTotalContasReceber.TabIndex = 332
        Me.lblNumTotalContasReceber.Text = "-"
        '
        'btnDebitosCliente
        '
        Me.btnDebitosCliente.BackColor = System.Drawing.Color.Transparent
        Me.btnDebitosCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDebitosCliente.FlatAppearance.BorderSize = 0
        Me.btnDebitosCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnDebitosCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDebitosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDebitosCliente.ForeColor = System.Drawing.Color.White
        Me.btnDebitosCliente.Image = CType(resources.GetObject("btnDebitosCliente.Image"), System.Drawing.Image)
        Me.btnDebitosCliente.Location = New System.Drawing.Point(893, 482)
        Me.btnDebitosCliente.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnDebitosCliente.Name = "btnDebitosCliente"
        Me.btnDebitosCliente.Size = New System.Drawing.Size(218, 35)
        Me.btnDebitosCliente.TabIndex = 17
        Me.btnDebitosCliente.Text = "Débitos Total Cliente"
        Me.btnDebitosCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDebitosCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDebitosCliente.UseVisualStyleBackColor = False
        '
        'btnQuitarConta
        '
        Me.btnQuitarConta.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitarConta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarConta.FlatAppearance.BorderSize = 0
        Me.btnQuitarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnQuitarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuitarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarConta.ForeColor = System.Drawing.Color.White
        Me.btnQuitarConta.Image = CType(resources.GetObject("btnQuitarConta.Image"), System.Drawing.Image)
        Me.btnQuitarConta.Location = New System.Drawing.Point(603, 482)
        Me.btnQuitarConta.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnQuitarConta.Name = "btnQuitarConta"
        Me.btnQuitarConta.Size = New System.Drawing.Size(148, 37)
        Me.btnQuitarConta.TabIndex = 15
        Me.btnQuitarConta.Text = "Quitar a conta"
        Me.btnQuitarConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuitarConta.UseVisualStyleBackColor = False
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
        Me.btSair.Location = New System.Drawing.Point(1095, 537)
        Me.btSair.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(89, 33)
        Me.btSair.TabIndex = 19
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
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
        Me.btnNovo.Location = New System.Drawing.Point(247, 482)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(127, 35)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Nova Conta"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 334
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(81, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 312
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Elephant", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(337, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(510, 51)
        Me.Label5.TabIndex = 311
        Me.Label5.Text = "CONTAS A RECEBER"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbContasVencidas)
        Me.GroupBox5.Controls.Add(Me.rbContasPagar)
        Me.GroupBox5.Controls.Add(Me.rbContasPagas)
        Me.GroupBox5.Controls.Add(Me.rbTodas)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(7, 68)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(269, 75)
        Me.GroupBox5.TabIndex = 335
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pesquisar "
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
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBuscarCliente.FormattingEnabled = True
        Me.txtBuscarCliente.Location = New System.Drawing.Point(238, 16)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(293, 24)
        Me.txtBuscarCliente.TabIndex = 336
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(365, 519)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 343
        Me.Label4.Text = "Contas Atrasadas"
        '
        'txtTotalContasAtrasadas
        '
        Me.txtTotalContasAtrasadas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasAtrasadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasAtrasadas.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTotalContasAtrasadas.Location = New System.Drawing.Point(359, 544)
        Me.txtTotalContasAtrasadas.Multiline = True
        Me.txtTotalContasAtrasadas.Name = "txtTotalContasAtrasadas"
        Me.txtTotalContasAtrasadas.ReadOnly = True
        Me.txtTotalContasAtrasadas.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasAtrasadas.TabIndex = 342
        Me.txtTotalContasAtrasadas.Text = "R$ 0,00"
        Me.txtTotalContasAtrasadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 519)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 341
        Me.Label2.Text = "Contas Pagas"
        '
        'txtTotalContasPagas
        '
        Me.txtTotalContasPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasPagas.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalContasPagas.Location = New System.Drawing.Point(10, 543)
        Me.txtTotalContasPagas.Multiline = True
        Me.txtTotalContasPagas.Name = "txtTotalContasPagas"
        Me.txtTotalContasPagas.ReadOnly = True
        Me.txtTotalContasPagas.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasPagas.TabIndex = 340
        Me.txtTotalContasPagas.Text = "R$ 0,00"
        Me.txtTotalContasPagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(188, 519)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 339
        Me.Label1.Text = "Contas Não Pagas"
        '
        'txtTotalContasNaoPagas
        '
        Me.txtTotalContasNaoPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasNaoPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasNaoPagas.ForeColor = System.Drawing.Color.Red
        Me.txtTotalContasNaoPagas.Location = New System.Drawing.Point(186, 544)
        Me.txtTotalContasNaoPagas.Multiline = True
        Me.txtTotalContasNaoPagas.Name = "txtTotalContasNaoPagas"
        Me.txtTotalContasNaoPagas.ReadOnly = True
        Me.txtTotalContasNaoPagas.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasNaoPagas.TabIndex = 338
        Me.txtTotalContasNaoPagas.Text = "R$ 0,00"
        Me.txtTotalContasNaoPagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(540, 518)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 337
        Me.Label7.Text = "Total:"
        '
        'txtTotalContasPagar
        '
        Me.txtTotalContasPagar.BackColor = System.Drawing.Color.White
        Me.txtTotalContasPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasPagar.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtTotalContasPagar.Location = New System.Drawing.Point(531, 543)
        Me.txtTotalContasPagar.Multiline = True
        Me.txtTotalContasPagar.Name = "txtTotalContasPagar"
        Me.txtTotalContasPagar.ReadOnly = True
        Me.txtTotalContasPagar.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasPagar.TabIndex = 336
        Me.txtTotalContasPagar.Text = "R$ 0,00"
        Me.txtTotalContasPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmContasReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1200, 585)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalContasAtrasadas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalContasPagas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalContasNaoPagas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalContasPagar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDebitosCliente)
        Me.Controls.Add(Me.txtBuscarNvenda)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblNumTotalContasReceber)
        Me.Controls.Add(Me.btnQuitarConta)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgContasReceber)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContasReceber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas a Receber"
        CType(Me.dgContasReceber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgContasReceber As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNvenda As RadioButton
    Friend WithEvents Label21 As Label
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtBuscarNvenda As TextBox
    Friend WithEvents btSair As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnQuitarConta As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents lblNumTotalContasReceber As Label
    Friend WithEvents btnDebitosCliente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rbContasVencidas As RadioButton
    Friend WithEvents rbContasPagar As RadioButton
    Friend WithEvents rbContasPagas As RadioButton
    Friend WithEvents rbTodas As RadioButton
    Friend WithEvents txtBuscarCliente As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalContasAtrasadas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalContasPagas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalContasNaoPagas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalContasPagar As TextBox
End Class
