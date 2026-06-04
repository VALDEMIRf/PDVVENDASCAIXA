<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaValor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaValor))
        Me.txtCodBarras = New System.Windows.Forms.TextBox()
        Me.cbProduto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValorUnitario = New System.Windows.Forms.TextBox()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.txtUnidade = New System.Windows.Forms.TextBox()
        Me.btSair = New System.Windows.Forms.Button()
        Me.pbImagem = New System.Windows.Forms.PictureBox()
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodBarras
        '
        Me.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBarras.Location = New System.Drawing.Point(12, 58)
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.Size = New System.Drawing.Size(366, 46)
        Me.txtCodBarras.TabIndex = 20001
        Me.txtCodBarras.Visible = False
        '
        'cbProduto
        '
        Me.cbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProduto.FormattingEnabled = True
        Me.cbProduto.Location = New System.Drawing.Point(12, 58)
        Me.cbProduto.Name = "cbProduto"
        Me.cbProduto.Size = New System.Drawing.Size(366, 39)
        Me.cbProduto.TabIndex = 20003
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 46)
        Me.Label1.TabIndex = 20004
        Me.Label1.Text = "Consulta de Preço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 20005
        Me.Label2.Text = "Valor Unitário"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(45, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 20006
        Me.Label3.Text = "Unidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 19)
        Me.Label4.TabIndex = 20007
        Me.Label4.Text = "Descrição do Produto"
        '
        'txtValorUnitario
        '
        Me.txtValorUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorUnitario.Location = New System.Drawing.Point(13, 144)
        Me.txtValorUnitario.Multiline = True
        Me.txtValorUnitario.Name = "txtValorUnitario"
        Me.txtValorUnitario.Size = New System.Drawing.Size(168, 47)
        Me.txtValorUnitario.TabIndex = 20008
        Me.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProduto
        '
        Me.txtProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduto.Location = New System.Drawing.Point(13, 341)
        Me.txtProduto.Multiline = True
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(365, 80)
        Me.txtProduto.TabIndex = 20009
        Me.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUnidade
        '
        Me.txtUnidade.Location = New System.Drawing.Point(20, 225)
        Me.txtUnidade.Multiline = True
        Me.txtUnidade.Name = "txtUnidade"
        Me.txtUnidade.Size = New System.Drawing.Size(161, 30)
        Me.txtUnidade.TabIndex = 20010
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
        Me.btSair.Location = New System.Drawing.Point(16, 268)
        Me.btSair.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(73, 33)
        Me.btSair.TabIndex = 20011
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'pbImagem
        '
        Me.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImagem.Location = New System.Drawing.Point(188, 111)
        Me.pbImagem.Margin = New System.Windows.Forms.Padding(4)
        Me.pbImagem.Name = "pbImagem"
        Me.pbImagem.Size = New System.Drawing.Size(190, 190)
        Me.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagem.TabIndex = 20002
        Me.pbImagem.TabStop = False
        '
        'frmConsultaValor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(399, 433)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.txtUnidade)
        Me.Controls.Add(Me.txtProduto)
        Me.Controls.Add(Me.txtValorUnitario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodBarras)
        Me.Controls.Add(Me.pbImagem)
        Me.Controls.Add(Me.cbProduto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConsultaValor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaValor"
        CType(Me.pbImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodBarras As TextBox
    Friend WithEvents pbImagem As PictureBox
    Friend WithEvents cbProduto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValorUnitario As TextBox
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents txtUnidade As TextBox
    Friend WithEvents btSair As Button
End Class
