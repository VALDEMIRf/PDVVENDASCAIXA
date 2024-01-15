<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelVendaData
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
        Me.QuantidadeVendidaPorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosDataSet = New PDVVENDASCAIXA.ProdutosDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.QuantidadeVendidaPorDataTableAdapter = New PDVVENDASCAIXA.ProdutosDataSetTableAdapters.QuantidadeVendidaPorDataTableAdapter()
        Me.dtDatafinal = New System.Windows.Forms.DateTimePicker()
        Me.lblDataFinal = New System.Windows.Forms.Label()
        Me.lblDataInicial = New System.Windows.Forms.Label()
        Me.lblSair = New System.Windows.Forms.Label()
        Me.dtDataInicio = New System.Windows.Forms.DateTimePicker()
        CType(Me.QuantidadeVendidaPorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuantidadeVendidaPorDataBindingSource
        '
        Me.QuantidadeVendidaPorDataBindingSource.DataMember = "QuantidadeVendidaPorData"
        Me.QuantidadeVendidaPorDataBindingSource.DataSource = Me.ProdutosDataSet
        '
        'ProdutosDataSet
        '
        Me.ProdutosDataSet.DataSetName = "ProdutosDataSet"
        Me.ProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.QuantidadeVendidaPorDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDVVENDASCAIXA.RelVendasData.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 38)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(786, 400)
        Me.ReportViewer1.TabIndex = 0
        '
        'QuantidadeVendidaPorDataTableAdapter
        '
        Me.QuantidadeVendidaPorDataTableAdapter.ClearBeforeFill = True
        '
        'dtDatafinal
        '
        Me.dtDatafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDatafinal.Location = New System.Drawing.Point(567, 12)
        Me.dtDatafinal.Name = "dtDatafinal"
        Me.dtDatafinal.Size = New System.Drawing.Size(157, 20)
        Me.dtDatafinal.TabIndex = 264
        '
        'lblDataFinal
        '
        Me.lblDataFinal.AutoSize = True
        Me.lblDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataFinal.ForeColor = System.Drawing.Color.White
        Me.lblDataFinal.Location = New System.Drawing.Point(515, 13)
        Me.lblDataFinal.Name = "lblDataFinal"
        Me.lblDataFinal.Size = New System.Drawing.Size(43, 18)
        Me.lblDataFinal.TabIndex = 263
        Me.lblDataFinal.Text = "Final:"
        '
        'lblDataInicial
        '
        Me.lblDataInicial.AutoSize = True
        Me.lblDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataInicial.ForeColor = System.Drawing.Color.White
        Me.lblDataInicial.Location = New System.Drawing.Point(269, 11)
        Me.lblDataInicial.Name = "lblDataInicial"
        Me.lblDataInicial.Size = New System.Drawing.Size(46, 18)
        Me.lblDataInicial.TabIndex = 262
        Me.lblDataInicial.Text = "Início:"
        '
        'lblSair
        '
        Me.lblSair.AutoSize = True
        Me.lblSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSair.ForeColor = System.Drawing.Color.White
        Me.lblSair.Location = New System.Drawing.Point(8, 9)
        Me.lblSair.Name = "lblSair"
        Me.lblSair.Size = New System.Drawing.Size(41, 20)
        Me.lblSair.TabIndex = 261
        Me.lblSair.Text = "Sair"
        '
        'dtDataInicio
        '
        Me.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataInicio.Location = New System.Drawing.Point(321, 12)
        Me.dtDataInicio.Name = "dtDataInicio"
        Me.dtDataInicio.Size = New System.Drawing.Size(132, 20)
        Me.dtDataInicio.TabIndex = 260
        '
        'frmRelVendaData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtDatafinal)
        Me.Controls.Add(Me.lblDataFinal)
        Me.Controls.Add(Me.lblDataInicial)
        Me.Controls.Add(Me.lblSair)
        Me.Controls.Add(Me.dtDataInicio)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelVendaData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas por Data"
        CType(Me.QuantidadeVendidaPorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents QuantidadeVendidaPorDataBindingSource As BindingSource
    Friend WithEvents ProdutosDataSet As ProdutosDataSet
    Friend WithEvents QuantidadeVendidaPorDataTableAdapter As ProdutosDataSetTableAdapters.QuantidadeVendidaPorDataTableAdapter
    Friend WithEvents dtDatafinal As DateTimePicker
    Friend WithEvents lblDataFinal As Label
    Friend WithEvents lblDataInicial As Label
    Friend WithEvents lblSair As Label
    Friend WithEvents dtDataInicio As DateTimePicker
End Class
