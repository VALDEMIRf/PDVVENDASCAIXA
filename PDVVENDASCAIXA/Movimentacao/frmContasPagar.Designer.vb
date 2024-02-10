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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.txtReferencia = New System.Windows.Forms.MaskedTextBox()
        Me.txtVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtDtPagto = New System.Windows.Forms.MaskedTextBox()
        Me.txtSituacao = New System.Windows.Forms.ComboBox()
        Me.dgContasPagar = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        CType(Me.dgContasPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Documento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(331, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(737, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Empresa:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(907, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Referência:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(489, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Vencimento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(688, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Data Pagamento:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(934, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Situação:"
        '
        'txtNDoc
        '
        Me.txtNDoc.Enabled = False
        Me.txtNDoc.Location = New System.Drawing.Point(119, 9)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(206, 24)
        Me.txtNDoc.TabIndex = 15
        '
        'txtDescricao
        '
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Location = New System.Drawing.Point(414, 9)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(310, 24)
        Me.txtDescricao.TabIndex = 16
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(789, 7)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 24)
        Me.txtValor.TabIndex = 17
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Enabled = False
        Me.txtEmpresa.Location = New System.Drawing.Point(119, 39)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(359, 24)
        Me.txtEmpresa.TabIndex = 18
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(996, 6)
        Me.txtReferencia.Mask = "00/00/0000"
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(87, 24)
        Me.txtReferencia.TabIndex = 20
        Me.txtReferencia.ValidatingType = GetType(Date)
        '
        'txtVencimento
        '
        Me.txtVencimento.Location = New System.Drawing.Point(583, 39)
        Me.txtVencimento.Mask = "00/00/0000"
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(87, 24)
        Me.txtVencimento.TabIndex = 21
        Me.txtVencimento.ValidatingType = GetType(Date)
        '
        'txtDtPagto
        '
        Me.txtDtPagto.Location = New System.Drawing.Point(817, 39)
        Me.txtDtPagto.Mask = "00/00/0000"
        Me.txtDtPagto.Name = "txtDtPagto"
        Me.txtDtPagto.Size = New System.Drawing.Size(87, 24)
        Me.txtDtPagto.TabIndex = 23
        Me.txtDtPagto.ValidatingType = GetType(Date)
        '
        'txtSituacao
        '
        Me.txtSituacao.FormattingEnabled = True
        Me.txtSituacao.Items.AddRange(New Object() {"Sim", "Não"})
        Me.txtSituacao.Location = New System.Drawing.Point(1006, 37)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(77, 26)
        Me.txtSituacao.TabIndex = 24
        '
        'dgContasPagar
        '
        Me.dgContasPagar.AllowUserToAddRows = False
        Me.dgContasPagar.AllowUserToDeleteRows = False
        Me.dgContasPagar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgContasPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContasPagar.GridColor = System.Drawing.Color.DarkBlue
        Me.dgContasPagar.Location = New System.Drawing.Point(9, 76)
        Me.dgContasPagar.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgContasPagar.Name = "dgContasPagar"
        Me.dgContasPagar.ReadOnly = True
        Me.dgContasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContasPagar.Size = New System.Drawing.Size(1096, 375)
        Me.dgContasPagar.TabIndex = 190
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(918, 461)
        Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 192
        Me.Label10.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(980, 461)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 191
        Me.lblTotal.Text = "-"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btNovo)
        Me.GroupBox5.Controls.Add(Me.btSalvar)
        Me.GroupBox5.Controls.Add(Me.btnEditar)
        Me.GroupBox5.Controls.Add(Me.btSair)
        Me.GroupBox5.Controls.Add(Me.btnExcluir)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 456)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(547, 60)
        Me.GroupBox5.TabIndex = 194
        Me.GroupBox5.TabStop = False
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
        Me.btNovo.Location = New System.Drawing.Point(9, 15)
        Me.btNovo.Margin = New System.Windows.Forms.Padding(5)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(87, 37)
        Me.btNovo.TabIndex = 17
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = False
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
        Me.btSalvar.Location = New System.Drawing.Point(100, 15)
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
        Me.btnEditar.Location = New System.Drawing.Point(207, 15)
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
        Me.btSair.Location = New System.Drawing.Point(453, 15)
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
        Me.btnExcluir.Location = New System.Drawing.Point(307, 15)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(108, 35)
        Me.btnExcluir.TabIndex = 20
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(6, 43)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(13, 18)
        Me.lblCodigo.TabIndex = 195
        Me.lblCodigo.Text = "-"
        '
        'frmContasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1110, 531)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.dgContasPagar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtSituacao)
        Me.Controls.Add(Me.txtDtPagto)
        Me.Controls.Add(Me.txtVencimento)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.txtEmpresa)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtNDoc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
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

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtEmpresa As TextBox
    Friend WithEvents txtReferencia As MaskedTextBox
    Friend WithEvents txtVencimento As MaskedTextBox
    Friend WithEvents txtDtPagto As MaskedTextBox
    Friend WithEvents txtSituacao As ComboBox
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
End Class
