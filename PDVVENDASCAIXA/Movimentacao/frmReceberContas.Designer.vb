<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceberContas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceberContas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbContasVencidas = New System.Windows.Forms.RadioButton()
        Me.rbContasRecaber = New System.Windows.Forms.RadioButton()
        Me.rbContasRecebidas = New System.Windows.Forms.RadioButton()
        Me.rbTodas = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBuscarConta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBuscarDescricao = New System.Windows.Forms.TextBox()
        Me.rbConta = New System.Windows.Forms.RadioButton()
        Me.rbDescricao = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCliente = New System.Windows.Forms.ComboBox()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalContasAtrasadas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalContasPagas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalContasNaoPagas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalContasPagar = New System.Windows.Forms.TextBox()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbSair = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.Controls.Add(Me.pbSair)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 60)
        Me.Panel1.TabIndex = 335
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Elephant", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(328, 5)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(510, 51)
        Me.Label5.TabIndex = 311
        Me.Label5.Text = "CONTAS A RECEBER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbContasVencidas)
        Me.GroupBox1.Controls.Add(Me.rbContasRecaber)
        Me.GroupBox1.Controls.Add(Me.rbContasRecebidas)
        Me.GroupBox1.Controls.Add(Me.rbTodas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(8, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 75)
        Me.GroupBox1.TabIndex = 336
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar "
        '
        'rbContasVencidas
        '
        Me.rbContasVencidas.AutoSize = True
        Me.rbContasVencidas.Location = New System.Drawing.Point(163, 46)
        Me.rbContasVencidas.Name = "rbContasVencidas"
        Me.rbContasVencidas.Size = New System.Drawing.Size(132, 21)
        Me.rbContasVencidas.TabIndex = 209
        Me.rbContasVencidas.TabStop = True
        Me.rbContasVencidas.Text = "Contas Vencidas"
        Me.rbContasVencidas.UseVisualStyleBackColor = True
        '
        'rbContasRecaber
        '
        Me.rbContasRecaber.AutoSize = True
        Me.rbContasRecaber.Location = New System.Drawing.Point(163, 16)
        Me.rbContasRecaber.Name = "rbContasRecaber"
        Me.rbContasRecaber.Size = New System.Drawing.Size(140, 21)
        Me.rbContasRecaber.TabIndex = 208
        Me.rbContasRecaber.TabStop = True
        Me.rbContasRecaber.Text = "Contas a Receber"
        Me.rbContasRecaber.UseVisualStyleBackColor = True
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBuscarConta)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtBuscarDescricao)
        Me.GroupBox3.Controls.Add(Me.rbConta)
        Me.GroupBox3.Controls.Add(Me.rbDescricao)
        Me.GroupBox3.Controls.Add(Me.txtBuscarCliente)
        Me.GroupBox3.Controls.Add(Me.rbCliente)
        Me.GroupBox3.Location = New System.Drawing.Point(327, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(649, 49)
        Me.GroupBox3.TabIndex = 337
        Me.GroupBox3.TabStop = False
        '
        'txtBuscarConta
        '
        Me.txtBuscarConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBuscarConta.FormattingEnabled = True
        Me.txtBuscarConta.Location = New System.Drawing.Point(310, 16)
        Me.txtBuscarConta.Name = "txtBuscarConta"
        Me.txtBuscarConta.Size = New System.Drawing.Size(330, 21)
        Me.txtBuscarConta.TabIndex = 295
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "Buscar:"
        '
        'txtBuscarDescricao
        '
        Me.txtBuscarDescricao.Location = New System.Drawing.Point(310, 16)
        Me.txtBuscarDescricao.Name = "txtBuscarDescricao"
        Me.txtBuscarDescricao.Size = New System.Drawing.Size(330, 20)
        Me.txtBuscarDescricao.TabIndex = 217
        '
        'rbConta
        '
        Me.rbConta.AutoSize = True
        Me.rbConta.ForeColor = System.Drawing.Color.White
        Me.rbConta.Location = New System.Drawing.Point(68, 19)
        Me.rbConta.Name = "rbConta"
        Me.rbConta.Size = New System.Drawing.Size(92, 17)
        Me.rbConta.TabIndex = 210
        Me.rbConta.TabStop = True
        Me.rbConta.Text = "Tipo de Conta"
        Me.rbConta.UseVisualStyleBackColor = True
        '
        'rbDescricao
        '
        Me.rbDescricao.AutoSize = True
        Me.rbDescricao.ForeColor = System.Drawing.Color.White
        Me.rbDescricao.Location = New System.Drawing.Point(234, 19)
        Me.rbDescricao.Name = "rbDescricao"
        Me.rbDescricao.Size = New System.Drawing.Size(73, 17)
        Me.rbDescricao.TabIndex = 216
        Me.rbDescricao.TabStop = True
        Me.rbDescricao.Text = "Descrição"
        Me.rbDescricao.UseVisualStyleBackColor = True
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtBuscarCliente.FormattingEnabled = True
        Me.txtBuscarCliente.Location = New System.Drawing.Point(310, 16)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(330, 21)
        Me.txtBuscarCliente.TabIndex = 310
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.ForeColor = System.Drawing.Color.White
        Me.rbCliente.Location = New System.Drawing.Point(168, 20)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(57, 17)
        Me.rbCliente.TabIndex = 211
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(957, 506)
        Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 20)
        Me.Label10.TabIndex = 341
        Me.Label10.Text = "Total de contas:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(1091, 506)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 340
        Me.lblTotal.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(395, 485)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 349
        Me.Label4.Text = "Contas Vencidas"
        '
        'txtTotalContasAtrasadas
        '
        Me.txtTotalContasAtrasadas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasAtrasadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasAtrasadas.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTotalContasAtrasadas.Location = New System.Drawing.Point(380, 510)
        Me.txtTotalContasAtrasadas.Multiline = True
        Me.txtTotalContasAtrasadas.Name = "txtTotalContasAtrasadas"
        Me.txtTotalContasAtrasadas.ReadOnly = True
        Me.txtTotalContasAtrasadas.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasAtrasadas.TabIndex = 348
        Me.txtTotalContasAtrasadas.Text = "R$ 0,00"
        Me.txtTotalContasAtrasadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 485)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 20)
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "Contas Recebidas"
        '
        'txtTotalContasPagas
        '
        Me.txtTotalContasPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasPagas.ForeColor = System.Drawing.Color.Green
        Me.txtTotalContasPagas.Location = New System.Drawing.Point(7, 510)
        Me.txtTotalContasPagas.Multiline = True
        Me.txtTotalContasPagas.Name = "txtTotalContasPagas"
        Me.txtTotalContasPagas.ReadOnly = True
        Me.txtTotalContasPagas.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasPagas.TabIndex = 346
        Me.txtTotalContasPagas.Text = "R$ 0,00"
        Me.txtTotalContasPagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(189, 485)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 345
        Me.Label1.Text = "Contas Não Recebidas"
        '
        'txtTotalContasNaoPagas
        '
        Me.txtTotalContasNaoPagas.BackColor = System.Drawing.Color.White
        Me.txtTotalContasNaoPagas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasNaoPagas.ForeColor = System.Drawing.Color.Red
        Me.txtTotalContasNaoPagas.Location = New System.Drawing.Point(187, 510)
        Me.txtTotalContasNaoPagas.Multiline = True
        Me.txtTotalContasNaoPagas.Name = "txtTotalContasNaoPagas"
        Me.txtTotalContasNaoPagas.ReadOnly = True
        Me.txtTotalContasNaoPagas.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasNaoPagas.TabIndex = 344
        Me.txtTotalContasNaoPagas.Text = "R$ 0,00"
        Me.txtTotalContasNaoPagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(587, 485)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 343
        Me.Label7.Text = "Total:"
        '
        'txtTotalContasPagar
        '
        Me.txtTotalContasPagar.BackColor = System.Drawing.Color.White
        Me.txtTotalContasPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContasPagar.ForeColor = System.Drawing.Color.Blue
        Me.txtTotalContasPagar.Location = New System.Drawing.Point(566, 510)
        Me.txtTotalContasPagar.Multiline = True
        Me.txtTotalContasPagar.Name = "txtTotalContasPagar"
        Me.txtTotalContasPagar.ReadOnly = True
        Me.txtTotalContasPagar.Size = New System.Drawing.Size(168, 33)
        Me.txtTotalContasPagar.TabIndex = 342
        Me.txtTotalContasPagar.Text = "R$ 0,00"
        Me.txtTotalContasPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkBlue
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dg1.BackgroundColor = System.Drawing.Color.White
        Me.dg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg1.DefaultCellStyle = DataGridViewCellStyle4
        Me.dg1.GridColor = System.Drawing.Color.CadetBlue
        Me.dg1.Location = New System.Drawing.Point(6, 140)
        Me.dg1.Margin = New System.Windows.Forms.Padding(4)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg1.Size = New System.Drawing.Size(1179, 337)
        Me.dg1.TabIndex = 371
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.Color.Transparent
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.ForeColor = System.Drawing.Color.White
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(1010, 69)
        Me.btNovo.Margin = New System.Windows.Forms.Padding(5)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(168, 43)
        Me.btNovo.TabIndex = 338
        Me.btNovo.Text = "Novo Cadastro"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 312
        Me.PictureBox2.TabStop = False
        '
        'pbSair
        '
        Me.pbSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSair.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.fechar
        Me.pbSair.Location = New System.Drawing.Point(1167, 2)
        Me.pbSair.Name = "pbSair"
        Me.pbSair.Size = New System.Drawing.Size(30, 30)
        Me.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSair.TabIndex = 313
        Me.pbSair.TabStop = False
        '
        'frmReceberContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1200, 550)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalContasAtrasadas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalContasPagas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalContasNaoPagas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalContasPagar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReceberContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReceberContas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbContasVencidas As RadioButton
    Friend WithEvents rbContasRecaber As RadioButton
    Friend WithEvents rbContasRecebidas As RadioButton
    Friend WithEvents rbTodas As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBuscarConta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rbConta As RadioButton
    Friend WithEvents rbDescricao As RadioButton
    Friend WithEvents txtBuscarCliente As ComboBox
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents txtBuscarDescricao As TextBox
    Friend WithEvents btNovo As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalContasAtrasadas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalContasPagas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalContasNaoPagas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalContasPagar As TextBox
    Friend WithEvents dg1 As DataGridView
    Friend WithEvents pbSair As PictureBox
End Class
