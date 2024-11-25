<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContasReceber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContasReceber))
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblNumTotalContasReceber = New System.Windows.Forms.Label()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalContasAtrasadas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalContasPagas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalContasNaoPagas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalContasPagar = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBuscarCliente = New System.Windows.Forms.ComboBox()
        Me.txtBuscarConta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbConta = New System.Windows.Forms.RadioButton()
        Me.rbDescricao = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.txtBuscarDescricao = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbContasVencidas = New System.Windows.Forms.RadioButton()
        Me.rbContasReceber = New System.Windows.Forms.RadioButton()
        Me.rbContasRecebidas = New System.Windows.Forms.RadioButton()
        Me.rbTodas = New System.Windows.Forms.RadioButton()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(951, 490)
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
        Me.lblNumTotalContasReceber.Location = New System.Drawing.Point(1122, 490)
        Me.lblNumTotalContasReceber.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblNumTotalContasReceber.Name = "lblNumTotalContasReceber"
        Me.lblNumTotalContasReceber.Size = New System.Drawing.Size(14, 20)
        Me.lblNumTotalContasReceber.TabIndex = 332
        Me.lblNumTotalContasReceber.Text = "-"
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
        Me.btSair.Location = New System.Drawing.Point(1051, 15)
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
        Me.btnNovo.Location = New System.Drawing.Point(-229, 312)
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
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btSair)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 65)
        Me.Panel1.TabIndex = 334
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 54)
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
        Me.Label5.Location = New System.Drawing.Point(275, 5)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(510, 51)
        Me.Label5.TabIndex = 311
        Me.Label5.Text = "CONTAS A RECEBER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(385, 478)
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
        Me.txtTotalContasAtrasadas.Location = New System.Drawing.Point(380, 503)
        Me.txtTotalContasAtrasadas.Multiline = True
        Me.txtTotalContasAtrasadas.Name = "txtTotalContasAtrasadas"
        Me.txtTotalContasAtrasadas.ReadOnly = True
        Me.txtTotalContasAtrasadas.Size = New System.Drawing.Size(169, 33)
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
        Me.Label2.Location = New System.Drawing.Point(22, 478)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 341
        Me.Label2.Text = "Contas Recebidas"
        '
        'txtTotalContasPagas
        '
        Me.txtTotalContasPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasPagas.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalContasPagas.Location = New System.Drawing.Point(14, 502)
        Me.txtTotalContasPagas.Multiline = True
        Me.txtTotalContasPagas.Name = "txtTotalContasPagas"
        Me.txtTotalContasPagas.ReadOnly = True
        Me.txtTotalContasPagas.Size = New System.Drawing.Size(169, 33)
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
        Me.Label1.Location = New System.Drawing.Point(193, 478)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 339
        Me.Label1.Text = "Contas Não Recebidas"
        '
        'txtTotalContasNaoPagas
        '
        Me.txtTotalContasNaoPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasNaoPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasNaoPagas.ForeColor = System.Drawing.Color.Red
        Me.txtTotalContasNaoPagas.Location = New System.Drawing.Point(192, 503)
        Me.txtTotalContasNaoPagas.Multiline = True
        Me.txtTotalContasNaoPagas.Name = "txtTotalContasNaoPagas"
        Me.txtTotalContasNaoPagas.ReadOnly = True
        Me.txtTotalContasNaoPagas.Size = New System.Drawing.Size(169, 33)
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
        Me.Label7.Location = New System.Drawing.Point(569, 477)
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
        Me.txtTotalContasPagar.Location = New System.Drawing.Point(565, 502)
        Me.txtTotalContasPagar.Multiline = True
        Me.txtTotalContasPagar.Name = "txtTotalContasPagar"
        Me.txtTotalContasPagar.ReadOnly = True
        Me.txtTotalContasPagar.Size = New System.Drawing.Size(169, 33)
        Me.txtTotalContasPagar.TabIndex = 336
        Me.txtTotalContasPagar.Text = "R$ 0,00"
        Me.txtTotalContasPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBuscarCliente)
        Me.GroupBox3.Controls.Add(Me.txtBuscarConta)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.rbConta)
        Me.GroupBox3.Controls.Add(Me.rbDescricao)
        Me.GroupBox3.Controls.Add(Me.rbCliente)
        Me.GroupBox3.Controls.Add(Me.txtBuscarDescricao)
        Me.GroupBox3.Location = New System.Drawing.Point(331, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(815, 49)
        Me.GroupBox3.TabIndex = 336
        Me.GroupBox3.TabStop = False
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBuscarCliente.FormattingEnabled = True
        Me.txtBuscarCliente.Location = New System.Drawing.Point(413, 13)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(396, 28)
        Me.txtBuscarCliente.TabIndex = 310
        '
        'txtBuscarConta
        '
        Me.txtBuscarConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBuscarConta.FormattingEnabled = True
        Me.txtBuscarConta.Location = New System.Drawing.Point(413, 13)
        Me.txtBuscarConta.Name = "txtBuscarConta"
        Me.txtBuscarConta.Size = New System.Drawing.Size(396, 28)
        Me.txtBuscarConta.TabIndex = 295
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "Buscar:"
        '
        'rbConta
        '
        Me.rbConta.AutoSize = True
        Me.rbConta.ForeColor = System.Drawing.Color.White
        Me.rbConta.Location = New System.Drawing.Point(75, 17)
        Me.rbConta.Name = "rbConta"
        Me.rbConta.Size = New System.Drawing.Size(126, 24)
        Me.rbConta.TabIndex = 210
        Me.rbConta.TabStop = True
        Me.rbConta.Text = "Tipo de Conta"
        Me.rbConta.UseVisualStyleBackColor = True
        '
        'rbDescricao
        '
        Me.rbDescricao.AutoSize = True
        Me.rbDescricao.ForeColor = System.Drawing.Color.White
        Me.rbDescricao.Location = New System.Drawing.Point(307, 17)
        Me.rbDescricao.Name = "rbDescricao"
        Me.rbDescricao.Size = New System.Drawing.Size(98, 24)
        Me.rbDescricao.TabIndex = 216
        Me.rbDescricao.TabStop = True
        Me.rbDescricao.Text = "Descrição"
        Me.rbDescricao.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.ForeColor = System.Drawing.Color.White
        Me.rbCliente.Location = New System.Drawing.Point(215, 17)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(76, 24)
        Me.rbCliente.TabIndex = 211
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'txtBuscarDescricao
        '
        Me.txtBuscarDescricao.Location = New System.Drawing.Point(412, 14)
        Me.txtBuscarDescricao.Name = "txtBuscarDescricao"
        Me.txtBuscarDescricao.Size = New System.Drawing.Size(396, 26)
        Me.txtBuscarDescricao.TabIndex = 217
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbContasVencidas)
        Me.GroupBox2.Controls.Add(Me.rbContasReceber)
        Me.GroupBox2.Controls.Add(Me.rbContasRecebidas)
        Me.GroupBox2.Controls.Add(Me.rbTodas)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(6, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 75)
        Me.GroupBox2.TabIndex = 335
        Me.GroupBox2.TabStop = False
        '
        'rbContasVencidas
        '
        Me.rbContasVencidas.AutoSize = True
        Me.rbContasVencidas.Location = New System.Drawing.Point(175, 46)
        Me.rbContasVencidas.Name = "rbContasVencidas"
        Me.rbContasVencidas.Size = New System.Drawing.Size(132, 21)
        Me.rbContasVencidas.TabIndex = 209
        Me.rbContasVencidas.TabStop = True
        Me.rbContasVencidas.Text = "Contas Vencidas"
        Me.rbContasVencidas.UseVisualStyleBackColor = True
        '
        'rbContasReceber
        '
        Me.rbContasReceber.AutoSize = True
        Me.rbContasReceber.Location = New System.Drawing.Point(175, 16)
        Me.rbContasReceber.Name = "rbContasReceber"
        Me.rbContasReceber.Size = New System.Drawing.Size(140, 21)
        Me.rbContasReceber.TabIndex = 208
        Me.rbContasReceber.TabStop = True
        Me.rbContasReceber.Text = "Contas a Receber"
        Me.rbContasReceber.UseVisualStyleBackColor = True
        '
        'rbContasRecebidas
        '
        Me.rbContasRecebidas.AutoSize = True
        Me.rbContasRecebidas.Location = New System.Drawing.Point(6, 46)
        Me.rbContasRecebidas.Name = "rbContasRecebidas"
        Me.rbContasRecebidas.Size = New System.Drawing.Size(141, 21)
        Me.rbContasRecebidas.TabIndex = 207
        Me.rbContasRecebidas.TabStop = True
        Me.rbContasRecebidas.Text = "Contas Recebidas"
        Me.rbContasRecebidas.UseVisualStyleBackColor = True
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
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.Color.Transparent
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.ForeColor = System.Drawing.Color.White
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(1008, 115)
        Me.btNovo.Margin = New System.Windows.Forms.Padding(5)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(168, 43)
        Me.btNovo.TabIndex = 344
        Me.btNovo.Text = "Novo Cadastro"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(6, 157)
        Me.dg.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(1183, 311)
        Me.dg.TabIndex = 345
        '
        'frmContasReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1200, 550)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblNumTotalContasReceber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.txtTotalContasPagas)
        Me.Controls.Add(Me.txtTotalContasAtrasadas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalContasPagar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalContasNaoPagas)
        Me.Controls.Add(Me.Label1)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btSair As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents lblNumTotalContasReceber As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalContasAtrasadas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalContasPagas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalContasNaoPagas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalContasPagar As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBuscarConta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rbConta As RadioButton
    Friend WithEvents rbDescricao As RadioButton
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents txtBuscarCliente As ComboBox
    Friend WithEvents txtBuscarDescricao As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbContasVencidas As RadioButton
    Friend WithEvents rbContasReceber As RadioButton
    Friend WithEvents rbContasRecebidas As RadioButton
    Friend WithEvents rbTodas As RadioButton
    Friend WithEvents btNovo As Button
    Friend WithEvents dg As DataGridView
End Class
