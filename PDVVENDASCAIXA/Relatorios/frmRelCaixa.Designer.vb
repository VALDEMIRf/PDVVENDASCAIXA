<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelCaixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelCaixa))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btSair = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbFuncionario = New System.Windows.Forms.ComboBox()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.Caixa1DataSet1 = New PDVVENDASCAIXA.caixa1DataSet1()
        Me.TbCaixaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbCaixaTableAdapter = New PDVVENDASCAIXA.caixa1DataSet1TableAdapters.tbCaixaTableAdapter()
        Me.VendasDataSet1 = New PDVVENDASCAIXA.VendasDataSet1()
        Me.ListaVendasGeralBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaVendasGeralTableAdapter = New PDVVENDASCAIXA.VendasDataSet1TableAdapters.ListaVendasGeralTableAdapter()
        CType(Me.Caixa1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCaixaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaVendasGeralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btSair.TabIndex = 2
        Me.btSair.Text = "Sair"
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TbCaixaBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.ListaVendasGeralBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PDVVENDASCAIXA.RelCaixa.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 50)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(797, 503)
        Me.ReportViewer1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(412, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Funcionario:"
        '
        'cbFuncionario
        '
        Me.cbFuncionario.FormattingEnabled = True
        Me.cbFuncionario.Location = New System.Drawing.Point(514, 12)
        Me.cbFuncionario.Name = "cbFuncionario"
        Me.cbFuncionario.Size = New System.Drawing.Size(121, 21)
        Me.cbFuncionario.TabIndex = 5
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(677, 13)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(99, 20)
        Me.dtData.TabIndex = 4
        '
        'Caixa1DataSet1
        '
        Me.Caixa1DataSet1.DataSetName = "caixa1DataSet1"
        Me.Caixa1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbCaixaBindingSource
        '
        Me.TbCaixaBindingSource.DataMember = "tbCaixa"
        Me.TbCaixaBindingSource.DataSource = Me.Caixa1DataSet1
        '
        'TbCaixaTableAdapter
        '
        Me.TbCaixaTableAdapter.ClearBeforeFill = True
        '
        'VendasDataSet1
        '
        Me.VendasDataSet1.DataSetName = "VendasDataSet1"
        Me.VendasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaVendasGeralBindingSource
        '
        Me.ListaVendasGeralBindingSource.DataMember = "ListaVendasGeral"
        Me.ListaVendasGeralBindingSource.DataSource = Me.VendasDataSet1
        '
        'ListaVendasGeralTableAdapter
        '
        Me.ListaVendasGeralTableAdapter.ClearBeforeFill = True
        '
        'frmRelCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 557)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFuncionario)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btSair)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Final de Caixa"
        CType(Me.Caixa1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCaixaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaVendasGeralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btSair As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFuncionario As ComboBox
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents TbCaixaBindingSource As BindingSource
    Friend WithEvents Caixa1DataSet1 As caixa1DataSet1
    Friend WithEvents TbCaixaTableAdapter As caixa1DataSet1TableAdapters.tbCaixaTableAdapter
    Friend WithEvents ListaVendasGeralBindingSource As BindingSource
    Friend WithEvents VendasDataSet1 As VendasDataSet1
    Friend WithEvents ListaVendasGeralTableAdapter As VendasDataSet1TableAdapters.ListaVendasGeralTableAdapter
End Class
