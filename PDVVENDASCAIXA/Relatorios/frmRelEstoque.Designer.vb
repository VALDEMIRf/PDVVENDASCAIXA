<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelEstoque
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelEstoque))
        Me.dtDatafinal = New System.Windows.Forms.DateTimePicker()
        Me.lblDataFinal = New System.Windows.Forms.Label()
        Me.lblDataInicial = New System.Windows.Forms.Label()
        Me.lblSair = New System.Windows.Forms.Label()
        Me.cbEntrada = New System.Windows.Forms.ComboBox()
        Me.dtDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.rbEntrada = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EstoquePorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESTOQUEDataSet1 = New PDVVENDASCAIXA.ESTOQUEDataSet1()
        Me.BuscarEntradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarSaidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstoquePorDataTableAdapter = New PDVVENDASCAIXA.ESTOQUEDataSet1TableAdapters.EstoquePorDataTableAdapter()
        Me.BuscarEntradasTableAdapter = New PDVVENDASCAIXA.ESTOQUEDataSet1TableAdapters.BuscarEntradasTableAdapter()
        Me.BuscarSaidasTableAdapter = New PDVVENDASCAIXA.ESTOQUEDataSet1TableAdapters.BuscarSaidasTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BuscarEntradasSaidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarEntradasSaidasTableAdapter = New PDVVENDASCAIXA.ESTOQUEDataSet1TableAdapters.BuscarEntradasSaidasTableAdapter()
        CType(Me.EstoquePorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTOQUEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarEntradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarSaidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarEntradasSaidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtDatafinal
        '
        Me.dtDatafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDatafinal.Location = New System.Drawing.Point(587, 38)
        Me.dtDatafinal.Name = "dtDatafinal"
        Me.dtDatafinal.Size = New System.Drawing.Size(157, 20)
        Me.dtDatafinal.TabIndex = 254
        '
        'lblDataFinal
        '
        Me.lblDataFinal.AutoSize = True
        Me.lblDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataFinal.ForeColor = System.Drawing.Color.White
        Me.lblDataFinal.Location = New System.Drawing.Point(535, 39)
        Me.lblDataFinal.Name = "lblDataFinal"
        Me.lblDataFinal.Size = New System.Drawing.Size(43, 18)
        Me.lblDataFinal.TabIndex = 253
        Me.lblDataFinal.Text = "Final:"
        '
        'lblDataInicial
        '
        Me.lblDataInicial.AutoSize = True
        Me.lblDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataInicial.ForeColor = System.Drawing.Color.White
        Me.lblDataInicial.Location = New System.Drawing.Point(535, 11)
        Me.lblDataInicial.Name = "lblDataInicial"
        Me.lblDataInicial.Size = New System.Drawing.Size(46, 18)
        Me.lblDataInicial.TabIndex = 252
        Me.lblDataInicial.Text = "Início:"
        '
        'lblSair
        '
        Me.lblSair.AutoSize = True
        Me.lblSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSair.ForeColor = System.Drawing.Color.White
        Me.lblSair.Location = New System.Drawing.Point(12, 10)
        Me.lblSair.Name = "lblSair"
        Me.lblSair.Size = New System.Drawing.Size(41, 20)
        Me.lblSair.TabIndex = 251
        Me.lblSair.Text = "Sair"
        '
        'cbEntrada
        '
        Me.cbEntrada.FormattingEnabled = True
        Me.cbEntrada.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.cbEntrada.Location = New System.Drawing.Point(587, 64)
        Me.cbEntrada.Name = "cbEntrada"
        Me.cbEntrada.Size = New System.Drawing.Size(157, 21)
        Me.cbEntrada.TabIndex = 250
        '
        'dtDataInicio
        '
        Me.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataInicio.Location = New System.Drawing.Point(587, 12)
        Me.dtDataInicio.Name = "dtDataInicio"
        Me.dtDataInicio.Size = New System.Drawing.Size(157, 20)
        Me.dtDataInicio.TabIndex = 249
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbData.ForeColor = System.Drawing.Color.White
        Me.rbData.Location = New System.Drawing.Point(460, 9)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(57, 22)
        Me.rbData.TabIndex = 248
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'rbEntrada
        '
        Me.rbEntrada.AutoSize = True
        Me.rbEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEntrada.ForeColor = System.Drawing.Color.White
        Me.rbEntrada.Location = New System.Drawing.Point(328, 9)
        Me.rbEntrada.Name = "rbEntrada"
        Me.rbEntrada.Size = New System.Drawing.Size(126, 22)
        Me.rbEntrada.TabIndex = 247
        Me.rbEntrada.TabStop = True
        Me.rbEntrada.Text = "Entrada / Saída"
        Me.rbEntrada.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(263, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 246
        Me.Label1.Text = "Buscar:"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EstoquePorDataBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.BuscarEntradasBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.BuscarSaidasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDVVENDASCAIXA.RelEstoqueData.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 91)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(752, 404)
        Me.ReportViewer1.TabIndex = 255
        '
        'EstoquePorDataBindingSource
        '
        Me.EstoquePorDataBindingSource.DataMember = "EstoquePorData"
        Me.EstoquePorDataBindingSource.DataSource = Me.ESTOQUEDataSet1
        '
        'ESTOQUEDataSet1
        '
        Me.ESTOQUEDataSet1.DataSetName = "ESTOQUEDataSet1"
        Me.ESTOQUEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuscarEntradasBindingSource
        '
        Me.BuscarEntradasBindingSource.DataMember = "BuscarEntradas"
        Me.BuscarEntradasBindingSource.DataSource = Me.ESTOQUEDataSet1
        '
        'BuscarSaidasBindingSource
        '
        Me.BuscarSaidasBindingSource.DataMember = "BuscarSaidas"
        Me.BuscarSaidasBindingSource.DataSource = Me.ESTOQUEDataSet1
        '
        'EstoquePorDataTableAdapter
        '
        Me.EstoquePorDataTableAdapter.ClearBeforeFill = True
        '
        'BuscarEntradasTableAdapter
        '
        Me.BuscarEntradasTableAdapter.ClearBeforeFill = True
        '
        'BuscarSaidasTableAdapter
        '
        Me.BuscarSaidasTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.DocumentMapWidth = 10
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.BuscarEntradasSaidasBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "PDVVENDASCAIXA.RelEntradaSaida.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(1, 91)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(752, 404)
        Me.ReportViewer2.TabIndex = 256
        '
        'BuscarEntradasSaidasBindingSource
        '
        Me.BuscarEntradasSaidasBindingSource.DataMember = "BuscarEntradasSaidas"
        Me.BuscarEntradasSaidasBindingSource.DataSource = Me.ESTOQUEDataSet1
        '
        'BuscarEntradasSaidasTableAdapter
        '
        Me.BuscarEntradasSaidasTableAdapter.ClearBeforeFill = True
        '
        'frmRelEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(765, 507)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.dtDatafinal)
        Me.Controls.Add(Me.lblDataFinal)
        Me.Controls.Add(Me.lblDataInicial)
        Me.Controls.Add(Me.lblSair)
        Me.Controls.Add(Me.cbEntrada)
        Me.Controls.Add(Me.dtDataInicio)
        Me.Controls.Add(Me.rbData)
        Me.Controls.Add(Me.rbEntrada)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Entradas e Saídas"
        CType(Me.EstoquePorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTOQUEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarEntradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarSaidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarEntradasSaidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtDatafinal As DateTimePicker
    Friend WithEvents lblDataFinal As Label
    Friend WithEvents lblDataInicial As Label
    Friend WithEvents lblSair As Label
    Friend WithEvents cbEntrada As ComboBox
    Friend WithEvents dtDataInicio As DateTimePicker
    Friend WithEvents rbData As RadioButton
    Friend WithEvents rbEntrada As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstoquePorDataBindingSource As BindingSource
    Friend WithEvents ESTOQUEDataSet1 As ESTOQUEDataSet1
    Friend WithEvents BuscarEntradasBindingSource As BindingSource
    Friend WithEvents BuscarSaidasBindingSource As BindingSource
    Friend WithEvents EstoquePorDataTableAdapter As ESTOQUEDataSet1TableAdapters.EstoquePorDataTableAdapter
    Friend WithEvents BuscarEntradasTableAdapter As ESTOQUEDataSet1TableAdapters.BuscarEntradasTableAdapter
    Friend WithEvents BuscarSaidasTableAdapter As ESTOQUEDataSet1TableAdapters.BuscarSaidasTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BuscarEntradasSaidasBindingSource As BindingSource
    Friend WithEvents BuscarEntradasSaidasTableAdapter As ESTOQUEDataSet1TableAdapters.BuscarEntradasSaidasTableAdapter
End Class
