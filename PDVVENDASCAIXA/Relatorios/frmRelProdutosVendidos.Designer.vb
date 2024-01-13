<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelProdutosVendidos
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelProdutosVendidos))
        Me.dtDatafinal = New System.Windows.Forms.DateTimePicker()
        Me.lblDataFinal = New System.Windows.Forms.Label()
        Me.lblDataInicial = New System.Windows.Forms.Label()
        Me.lblSair = New System.Windows.Forms.Label()
        Me.dtDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.QuantidadeVendidaPorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosDataSet = New PDVVENDASCAIXA.ProdutosDataSet()
        Me.QuantidadeVendidaPorDataTableAdapter = New PDVVENDASCAIXA.ProdutosDataSetTableAdapters.QuantidadeVendidaPorDataTableAdapter()
        CType(Me.QuantidadeVendidaPorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtDatafinal
        '
        Me.dtDatafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDatafinal.Location = New System.Drawing.Point(677, 9)
        Me.dtDatafinal.Name = "dtDatafinal"
        Me.dtDatafinal.Size = New System.Drawing.Size(157, 20)
        Me.dtDatafinal.TabIndex = 259
        '
        'lblDataFinal
        '
        Me.lblDataFinal.AutoSize = True
        Me.lblDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataFinal.ForeColor = System.Drawing.Color.White
        Me.lblDataFinal.Location = New System.Drawing.Point(625, 10)
        Me.lblDataFinal.Name = "lblDataFinal"
        Me.lblDataFinal.Size = New System.Drawing.Size(43, 18)
        Me.lblDataFinal.TabIndex = 258
        Me.lblDataFinal.Text = "Final:"
        '
        'lblDataInicial
        '
        Me.lblDataInicial.AutoSize = True
        Me.lblDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataInicial.ForeColor = System.Drawing.Color.White
        Me.lblDataInicial.Location = New System.Drawing.Point(379, 8)
        Me.lblDataInicial.Name = "lblDataInicial"
        Me.lblDataInicial.Size = New System.Drawing.Size(46, 18)
        Me.lblDataInicial.TabIndex = 257
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
        Me.lblSair.TabIndex = 256
        Me.lblSair.Text = "Sair"
        '
        'dtDataInicio
        '
        Me.dtDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDataInicio.Location = New System.Drawing.Point(431, 9)
        Me.dtDataInicio.Name = "dtDataInicio"
        Me.dtDataInicio.Size = New System.Drawing.Size(132, 20)
        Me.dtDataInicio.TabIndex = 255
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.QuantidadeVendidaPorDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDVVENDASCAIXA.RelProdutosVenda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 35)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(853, 510)
        Me.ReportViewer1.TabIndex = 260
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
        'QuantidadeVendidaPorDataTableAdapter
        '
        Me.QuantidadeVendidaPorDataTableAdapter.ClearBeforeFill = True
        '
        'frmRelProdutosVendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(866, 557)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.dtDatafinal)
        Me.Controls.Add(Me.lblDataFinal)
        Me.Controls.Add(Me.lblDataInicial)
        Me.Controls.Add(Me.lblSair)
        Me.Controls.Add(Me.dtDataInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelProdutosVendidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos mais Vendidos"
        CType(Me.QuantidadeVendidaPorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtDatafinal As DateTimePicker
    Friend WithEvents lblDataFinal As Label
    Friend WithEvents lblDataInicial As Label
    Friend WithEvents lblSair As Label
    Friend WithEvents dtDataInicio As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents QuantidadeVendidaPorDataBindingSource As BindingSource
    Friend WithEvents ProdutosDataSet As ProdutosDataSet
    Friend WithEvents QuantidadeVendidaPorDataTableAdapter As ProdutosDataSetTableAdapters.QuantidadeVendidaPorDataTableAdapter
End Class
