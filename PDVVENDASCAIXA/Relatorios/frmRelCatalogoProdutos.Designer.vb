<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelCatalogoProdutos
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbProdutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosDataSet = New PDVVENDASCAIXA.ProdutosDataSet()
        Me.tbProdutosTableAdapter = New PDVVENDASCAIXA.ProdutosDataSetTableAdapters.tbProdutosTableAdapter()
        Me.ProdutosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATALOGOPRODUTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATALOGOPRODUTOSTableAdapter = New PDVVENDASCAIXA.ProdutosDataSetTableAdapters.CATALOGOPRODUTOSTableAdapter()
        CType(Me.tbProdutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATALOGOPRODUTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CATALOGOPRODUTOSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDVVENDASCAIXA.RelCatalogoProdutos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(863, 657)
        Me.ReportViewer1.TabIndex = 0
        '
        'tbProdutosBindingSource
        '
        Me.tbProdutosBindingSource.DataMember = "tbProdutos"
        Me.tbProdutosBindingSource.DataSource = Me.ProdutosDataSet
        '
        'ProdutosDataSet
        '
        Me.ProdutosDataSet.DataSetName = "ProdutosDataSet"
        Me.ProdutosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbProdutosTableAdapter
        '
        Me.tbProdutosTableAdapter.ClearBeforeFill = True
        '
        'ProdutosDataSetBindingSource
        '
        Me.ProdutosDataSetBindingSource.DataSource = Me.ProdutosDataSet
        Me.ProdutosDataSetBindingSource.Position = 0
        '
        'CATALOGOPRODUTOSBindingSource
        '
        Me.CATALOGOPRODUTOSBindingSource.DataMember = "CATALOGOPRODUTOS"
        Me.CATALOGOPRODUTOSBindingSource.DataSource = Me.ProdutosDataSetBindingSource
        '
        'CATALOGOPRODUTOSTableAdapter
        '
        Me.CATALOGOPRODUTOSTableAdapter.ClearBeforeFill = True
        '
        'frmRelCatalogoProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 657)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelCatalogoProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Produtos"
        CType(Me.tbProdutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATALOGOPRODUTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbProdutosBindingSource As BindingSource
    Friend WithEvents ProdutosDataSet As ProdutosDataSet
    Friend WithEvents tbProdutosTableAdapter As ProdutosDataSetTableAdapters.tbProdutosTableAdapter
    Friend WithEvents ProdutosDataSetBindingSource As BindingSource
    Friend WithEvents CATALOGOPRODUTOSBindingSource As BindingSource
    Friend WithEvents CATALOGOPRODUTOSTableAdapter As ProdutosDataSetTableAdapters.CATALOGOPRODUTOSTableAdapter
End Class
