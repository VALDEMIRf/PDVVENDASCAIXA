<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaEstoque))
        Me.dtDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.rbEntrada = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.cbEntrada = New System.Windows.Forms.ComboBox()
        Me.lblSair = New System.Windows.Forms.Label()
        Me.lblDataInicial = New System.Windows.Forms.Label()
        Me.lblDataFinal = New System.Windows.Forms.Label()
        Me.dtDatafinal = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtDataInicio
        '
        Me.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataInicio.Location = New System.Drawing.Point(460, 53)
        Me.dtDataInicio.Name = "dtDataInicio"
        Me.dtDataInicio.Size = New System.Drawing.Size(157, 20)
        Me.dtDataInicio.TabIndex = 237
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbData.ForeColor = System.Drawing.Color.White
        Me.rbData.Location = New System.Drawing.Point(333, 50)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(57, 22)
        Me.rbData.TabIndex = 236
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'rbEntrada
        '
        Me.rbEntrada.AutoSize = True
        Me.rbEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEntrada.ForeColor = System.Drawing.Color.White
        Me.rbEntrada.Location = New System.Drawing.Point(201, 50)
        Me.rbEntrada.Name = "rbEntrada"
        Me.rbEntrada.Size = New System.Drawing.Size(126, 22)
        Me.rbEntrada.TabIndex = 234
        Me.rbEntrada.TabStop = True
        Me.rbEntrada.Text = "Entrada / Saída"
        Me.rbEntrada.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(136, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "Buscar:"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(4, 102)
        Me.dg.Margin = New System.Windows.Forms.Padding(4)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(643, 323)
        Me.dg.TabIndex = 232
        '
        'cbEntrada
        '
        Me.cbEntrada.FormattingEnabled = True
        Me.cbEntrada.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cbEntrada.Location = New System.Drawing.Point(460, 52)
        Me.cbEntrada.Name = "cbEntrada"
        Me.cbEntrada.Size = New System.Drawing.Size(157, 21)
        Me.cbEntrada.TabIndex = 240
        '
        'lblSair
        '
        Me.lblSair.AutoSize = True
        Me.lblSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSair.ForeColor = System.Drawing.Color.White
        Me.lblSair.Location = New System.Drawing.Point(592, 13)
        Me.lblSair.Name = "lblSair"
        Me.lblSair.Size = New System.Drawing.Size(41, 20)
        Me.lblSair.TabIndex = 242
        Me.lblSair.Text = "Sair"
        '
        'lblDataInicial
        '
        Me.lblDataInicial.AutoSize = True
        Me.lblDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataInicial.ForeColor = System.Drawing.Color.White
        Me.lblDataInicial.Location = New System.Drawing.Point(408, 52)
        Me.lblDataInicial.Name = "lblDataInicial"
        Me.lblDataInicial.Size = New System.Drawing.Size(46, 18)
        Me.lblDataInicial.TabIndex = 243
        Me.lblDataInicial.Text = "Início:"
        '
        'lblDataFinal
        '
        Me.lblDataFinal.AutoSize = True
        Me.lblDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataFinal.ForeColor = System.Drawing.Color.White
        Me.lblDataFinal.Location = New System.Drawing.Point(408, 80)
        Me.lblDataFinal.Name = "lblDataFinal"
        Me.lblDataFinal.Size = New System.Drawing.Size(43, 18)
        Me.lblDataFinal.TabIndex = 244
        Me.lblDataFinal.Text = "Final:"
        '
        'dtDatafinal
        '
        Me.dtDatafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDatafinal.Location = New System.Drawing.Point(460, 79)
        Me.dtDatafinal.Name = "dtDatafinal"
        Me.dtDatafinal.Size = New System.Drawing.Size(157, 20)
        Me.dtDatafinal.TabIndex = 245
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lblSair)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 44)
        Me.Panel1.TabIndex = 316
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Elephant", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(63, 9)
        Me.Label15.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(429, 26)
        Me.Label15.TabIndex = 311
        Me.Label15.Text = "LISTA DE PRODUTOS NO ESTOQUE"
        '
        'frmConsultaEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(656, 433)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtDatafinal)
        Me.Controls.Add(Me.lblDataFinal)
        Me.Controls.Add(Me.lblDataInicial)
        Me.Controls.Add(Me.cbEntrada)
        Me.Controls.Add(Me.dtDataInicio)
        Me.Controls.Add(Me.rbData)
        Me.Controls.Add(Me.rbEntrada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas no Estoque"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtDataInicio As DateTimePicker
    Friend WithEvents rbData As RadioButton
    Friend WithEvents rbEntrada As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dg As DataGridView
    Friend WithEvents cbEntrada As ComboBox
    Friend WithEvents lblSair As Label
    Friend WithEvents lblDataInicial As Label
    Friend WithEvents lblDataFinal As Label
    Friend WithEvents dtDatafinal As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
End Class
