<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelServicos
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
        Me.ORDEMSERVICODataSet1 = New PDVVENDASCAIXA.ORDEMSERVICODataSet1()
        Me.ListaDeServicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaDeServicosTableAdapter = New PDVVENDASCAIXA.ORDEMSERVICODataSet1TableAdapters.ListaDeServicosTableAdapter()
        CType(Me.ORDEMSERVICODataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaDeServicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ListaDeServicosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDVVENDASCAIXA.relServicos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 52)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1150, 432)
        Me.ReportViewer1.TabIndex = 0
        '
        'ORDEMSERVICODataSet1
        '
        Me.ORDEMSERVICODataSet1.DataSetName = "ORDEMSERVICODataSet1"
        Me.ORDEMSERVICODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaDeServicosBindingSource
        '
        Me.ListaDeServicosBindingSource.DataMember = "ListaDeServicos"
        Me.ListaDeServicosBindingSource.DataSource = Me.ORDEMSERVICODataSet1
        '
        'ListaDeServicosTableAdapter
        '
        Me.ListaDeServicosTableAdapter.ClearBeforeFill = True
        '
        'frmRelServicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1153, 496)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelServicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRelServicos"
        CType(Me.ORDEMSERVICODataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaDeServicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ListaDeServicosBindingSource As BindingSource
    Friend WithEvents ORDEMSERVICODataSet1 As ORDEMSERVICODataSet1
    Friend WithEvents ListaDeServicosTableAdapter As ORDEMSERVICODataSet1TableAdapters.ListaDeServicosTableAdapter
End Class
