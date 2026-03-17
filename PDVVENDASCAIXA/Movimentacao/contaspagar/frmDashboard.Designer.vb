<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.lblTotalPendente = New System.Windows.Forms.Label()
        Me.lblTotalPago = New System.Windows.Forms.Label()
        Me.chartFinanceiro = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btSair = New System.Windows.Forms.Button()
        CType(Me.chartFinanceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalPendente
        '
        Me.lblTotalPendente.AutoSize = True
        Me.lblTotalPendente.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPendente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPendente.ForeColor = System.Drawing.Color.White
        Me.lblTotalPendente.Location = New System.Drawing.Point(30, 13)
        Me.lblTotalPendente.Name = "lblTotalPendente"
        Me.lblTotalPendente.Size = New System.Drawing.Size(117, 20)
        Me.lblTotalPendente.TabIndex = 0
        Me.lblTotalPendente.Text = "total Pendente:"
        '
        'lblTotalPago
        '
        Me.lblTotalPago.AutoSize = True
        Me.lblTotalPago.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPago.ForeColor = System.Drawing.Color.White
        Me.lblTotalPago.Location = New System.Drawing.Point(30, 43)
        Me.lblTotalPago.Name = "lblTotalPago"
        Me.lblTotalPago.Size = New System.Drawing.Size(89, 20)
        Me.lblTotalPago.TabIndex = 1
        Me.lblTotalPago.Text = "Total Pago:"
        '
        'chartFinanceiro
        '
        Me.chartFinanceiro.BackColor = System.Drawing.Color.Transparent
        Me.chartFinanceiro.BorderlineColor = System.Drawing.Color.DimGray
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Maroon
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisX2.InterlacedColor = System.Drawing.Color.White
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.White
        ChartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisY.InterlacedColor = System.Drawing.Color.White
        ChartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.White
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY2.InterlacedColor = System.Drawing.Color.White
        ChartArea1.AxisY2.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "Financeiro"
        ChartArea1.ShadowColor = System.Drawing.Color.Black
        Me.chartFinanceiro.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Legend1.ForeColor = System.Drawing.Color.White
        Legend1.IsTextAutoFit = False
        Legend1.ItemColumnSeparatorColor = System.Drawing.Color.OliveDrab
        Legend1.Name = "Legend1"
        Me.chartFinanceiro.Legends.Add(Legend1)
        Me.chartFinanceiro.Location = New System.Drawing.Point(12, 76)
        Me.chartFinanceiro.Name = "chartFinanceiro"
        Me.chartFinanceiro.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "Financeiro"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.LegendText = "Financeiro"
        Series1.Name = "Financeiro"
        Series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.LightGray
        Me.chartFinanceiro.Series.Add(Series1)
        Me.chartFinanceiro.Size = New System.Drawing.Size(473, 300)
        Me.chartFinanceiro.TabIndex = 2
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
        Me.btSair.Location = New System.Drawing.Point(396, 13)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(73, 30)
        Me.btSair.TabIndex = 326
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(498, 382)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.chartFinanceiro)
        Me.Controls.Add(Me.lblTotalPago)
        Me.Controls.Add(Me.lblTotalPendente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDashboard"
        CType(Me.chartFinanceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalPendente As Label
    Friend WithEvents lblTotalPago As Label
    Friend WithEvents chartFinanceiro As DataVisualization.Charting.Chart
    Friend WithEvents btSair As Button
End Class
