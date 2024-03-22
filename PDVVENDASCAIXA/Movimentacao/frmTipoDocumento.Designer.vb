<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoDocumento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoDocumento))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvTipo = New System.Windows.Forms.DataGridView()
        Me.txtTipoDocumento = New System.Windows.Forms.TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.brSair = New System.Windows.Forms.Button()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btAlterar = New System.Windows.Forms.Button()
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btNovo)
        Me.GroupBox1.Controls.Add(Me.brSair)
        Me.GroupBox1.Controls.Add(Me.btExcluir)
        Me.GroupBox1.Controls.Add(Me.btSalvar)
        Me.GroupBox1.Controls.Add(Me.btAlterar)
        Me.GroupBox1.Location = New System.Drawing.Point(214, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(93, 229)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'dgvTipo
        '
        Me.dgvTipo.AllowUserToAddRows = False
        Me.dgvTipo.AllowUserToDeleteRows = False
        Me.dgvTipo.BackgroundColor = System.Drawing.Color.White
        Me.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipo.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvTipo.Location = New System.Drawing.Point(3, 54)
        Me.dgvTipo.Name = "dgvTipo"
        Me.dgvTipo.ReadOnly = True
        Me.dgvTipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTipo.Size = New System.Drawing.Size(205, 207)
        Me.dgvTipo.TabIndex = 24
        '
        'txtTipoDocumento
        '
        Me.txtTipoDocumento.Location = New System.Drawing.Point(3, 32)
        Me.txtTipoDocumento.Name = "txtTipoDocumento"
        Me.txtTipoDocumento.Size = New System.Drawing.Size(205, 20)
        Me.txtTipoDocumento.TabIndex = 23
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(307, 9)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(13, 13)
        Me.lblTipo.TabIndex = 22
        Me.lblTipo.Text = "0"
        Me.lblTipo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "TIPO DE DOCUMENTO"
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.Color.Transparent
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNovo.ForeColor = System.Drawing.Color.White
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(4, 13)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(90, 41)
        Me.btNovo.TabIndex = 18
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'brSair
        '
        Me.brSair.BackColor = System.Drawing.Color.Transparent
        Me.brSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.brSair.FlatAppearance.BorderSize = 0
        Me.brSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brSair.ForeColor = System.Drawing.Color.White
        Me.brSair.Image = CType(resources.GetObject("brSair.Image"), System.Drawing.Image)
        Me.brSair.Location = New System.Drawing.Point(3, 187)
        Me.brSair.Name = "brSair"
        Me.brSair.Size = New System.Drawing.Size(74, 38)
        Me.brSair.TabIndex = 16
        Me.brSair.Text = "Sair"
        Me.brSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.brSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.brSair.UseVisualStyleBackColor = False
        '
        'btExcluir
        '
        Me.btExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExcluir.FlatAppearance.BorderSize = 0
        Me.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExcluir.ForeColor = System.Drawing.Color.White
        Me.btExcluir.Image = CType(resources.GetObject("btExcluir.Image"), System.Drawing.Image)
        Me.btExcluir.Location = New System.Drawing.Point(6, 143)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(88, 38)
        Me.btExcluir.TabIndex = 17
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btExcluir.UseVisualStyleBackColor = False
        '
        'btSalvar
        '
        Me.btSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.FlatAppearance.BorderSize = 0
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.ForeColor = System.Drawing.Color.White
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.Location = New System.Drawing.Point(4, 60)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(90, 37)
        Me.btSalvar.TabIndex = 14
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = False
        '
        'btAlterar
        '
        Me.btAlterar.BackColor = System.Drawing.Color.Transparent
        Me.btAlterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAlterar.FlatAppearance.BorderSize = 0
        Me.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAlterar.ForeColor = System.Drawing.Color.White
        Me.btAlterar.Image = CType(resources.GetObject("btAlterar.Image"), System.Drawing.Image)
        Me.btAlterar.Location = New System.Drawing.Point(4, 103)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(90, 34)
        Me.btAlterar.TabIndex = 15
        Me.btAlterar.Text = "Editar"
        Me.btAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btAlterar.UseVisualStyleBackColor = False
        '
        'errErro
        '
        Me.errErro.ContainerControl = Me
        '
        'frmTipoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(312, 269)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvTipo)
        Me.Controls.Add(Me.txtTipoDocumento)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTipoDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Documento"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btNovo As Button
    Friend WithEvents brSair As Button
    Friend WithEvents btExcluir As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btAlterar As Button
    Friend WithEvents dgvTipo As DataGridView
    Friend WithEvents txtTipoDocumento As TextBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents errErro As ErrorProvider
End Class
