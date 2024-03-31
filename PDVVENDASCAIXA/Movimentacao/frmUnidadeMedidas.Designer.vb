<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnidadeMedidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnidadeMedidas))
        Me.dgvUnidade = New System.Windows.Forms.DataGridView()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.lblUnidade = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.brSair = New System.Windows.Forms.Button()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btAlterar = New System.Windows.Forms.Button()
        Me.errErro = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvUnidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUnidade
        '
        Me.dgvUnidade.AllowUserToAddRows = False
        Me.dgvUnidade.AllowUserToDeleteRows = False
        Me.dgvUnidade.BackgroundColor = System.Drawing.Color.White
        Me.dgvUnidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnidade.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvUnidade.Location = New System.Drawing.Point(4, 79)
        Me.dgvUnidade.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUnidade.Name = "dgvUnidade"
        Me.dgvUnidade.ReadOnly = True
        Me.dgvUnidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnidade.Size = New System.Drawing.Size(168, 210)
        Me.dgvUnidade.TabIndex = 32
        '
        'txtUnidade
        '
        Me.txtUnidade.Location = New System.Drawing.Point(5, 47)
        Me.txtUnidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.Size = New System.Drawing.Size(167, 20)
        Me.txtUnidade.TabIndex = 31
        '
        'lblUnidade
        '
        Me.lblUnidade.AutoSize = True
        Me.lblUnidade.BackColor = System.Drawing.Color.Transparent
        Me.lblUnidade.ForeColor = System.Drawing.Color.White
        Me.lblUnidade.Location = New System.Drawing.Point(13, 9)
        Me.lblUnidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnidade.Name = "lblUnidade"
        Me.lblUnidade.Size = New System.Drawing.Size(13, 13)
        Me.lblUnidade.TabIndex = 30
        Me.lblUnidade.Text = "0"
        Me.lblUnidade.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 29)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Unidades de Medidas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btNovo)
        Me.GroupBox1.Controls.Add(Me.brSair)
        Me.GroupBox1.Controls.Add(Me.btExcluir)
        Me.GroupBox1.Controls.Add(Me.btSalvar)
        Me.GroupBox1.Controls.Add(Me.btAlterar)
        Me.GroupBox1.Location = New System.Drawing.Point(177, 46)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(143, 242)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
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
        Me.btNovo.Location = New System.Drawing.Point(5, 16)
        Me.btNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(90, 35)
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
        Me.brSair.Location = New System.Drawing.Point(5, 200)
        Me.brSair.Margin = New System.Windows.Forms.Padding(4)
        Me.brSair.Name = "brSair"
        Me.brSair.Size = New System.Drawing.Size(90, 35)
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
        Me.btExcluir.Location = New System.Drawing.Point(12, 157)
        Me.btExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(90, 35)
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
        Me.btSalvar.Location = New System.Drawing.Point(7, 65)
        Me.btSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(90, 35)
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
        Me.btAlterar.Location = New System.Drawing.Point(8, 112)
        Me.btAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btAlterar.Name = "btAlterar"
        Me.btAlterar.Size = New System.Drawing.Size(90, 35)
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
        'frmUnidadeMedidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(325, 297)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvUnidade)
        Me.Controls.Add(Me.txtUnidade)
        Me.Controls.Add(Me.lblUnidade)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUnidadeMedidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidades de Medidas"
        CType(Me.dgvUnidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.errErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUnidade As DataGridView
    Friend WithEvents txtUnidade As TextBox
    Friend WithEvents lblUnidade As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btNovo As Button
    Friend WithEvents brSair As Button
    Friend WithEvents btExcluir As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btAlterar As Button
    Friend WithEvents errErro As ErrorProvider
End Class
