<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelVenda))
        Me.ListaVendasGeralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendasDataSet1 = New PDVVENDASCAIXA.VendasDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btSair = New System.Windows.Forms.Button()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.cbFuncionario = New System.Windows.Forms.ComboBox()
        Me.ListaVendasGeralTableAdapter = New PDVVENDASCAIXA.VendasDataSet1TableAdapters.ListaVendasGeralTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ListaVendasGeralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaVendasGeralBindingSource
        '
        Me.ListaVendasGeralBindingSource.DataMember = "ListaVendasGeral"
        Me.ListaVendasGeralBindingSource.DataSource = Me.VendasDataSet1
        '
        'VendasDataSet1
        '
        Me.VendasDataSet1.DataSetName = "VendasDataSet1"
        Me.VendasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ListaVendasGeralBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDVVENDASCAIXA.relVenda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 61)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(865, 413)
        Me.ReportViewer1.TabIndex = 0
        '
        'btSair
        '
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSair.ForeColor = System.Drawing.Color.White
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(12, 12)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(84, 32)
        Me.btSair.TabIndex = 1
        Me.btSair.Text = "Sair"
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(676, 20)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(100, 20)
        Me.dtData.TabIndex = 2
        '
        'cbFuncionario
        '
        Me.cbFuncionario.FormattingEnabled = True
        Me.cbFuncionario.Location = New System.Drawing.Point(500, 20)
        Me.cbFuncionario.Name = "cbFuncionario"
        Me.cbFuncionario.Size = New System.Drawing.Size(157, 21)
        Me.cbFuncionario.TabIndex = 225
        '
        'ListaVendasGeralTableAdapter
        '
        Me.ListaVendasGeralTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(435, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 232
        Me.Label1.Text = "Buscar:"
        '
        'frmRelVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(880, 486)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFuncionario)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelVenda"
        Me.Text = "Relatório de Vendas"
        CType(Me.ListaVendasGeralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ListaVendasGeralBindingSource As BindingSource
    Friend WithEvents VendasDataSet1 As VendasDataSet1
    Friend WithEvents ListaVendasGeralTableAdapter As VendasDataSet1TableAdapters.ListaVendasGeralTableAdapter
    Friend WithEvents btSair As Button
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents cbFuncionario As ComboBox
    Friend WithEvents Label1 As Label
End Class
