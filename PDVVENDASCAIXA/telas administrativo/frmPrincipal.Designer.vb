﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.lblTotalDoDia = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTextoCaixa = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHoraAb = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblVlrAb = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotSangria = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblHoraSangria = New System.Windows.Forms.Label()
        Me.lblVendasDia = New System.Windows.Forms.Label()
        Me.txtTotaliza = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblReforco = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblProdutosVendidos = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTotalCaixa = New System.Windows.Forms.Label()
        Me.imagem = New System.Windows.Forms.PictureBox()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadeDeMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaSaídaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NíveisBaixoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimentaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdemDeServiçoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrçamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDVRegistrarVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SangriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReforçosAsCaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogoDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioDoCaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaSaídaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NíveisDoEstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosMaisVendidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasPorFuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltroDeVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.MovimentaçãoToolStripMenuItem, Me.VendasToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(962, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(118, 29)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(14, 20)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bem Vindo:"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(118, 60)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(14, 20)
        Me.lblHora.TabIndex = 3
        Me.lblHora.Text = "-"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(32, 60)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(14, 20)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblData)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Controls.Add(Me.lblHora)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(24, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 89)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(23, 149)
        Me.dg.Margin = New System.Windows.Forms.Padding(4)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(456, 234)
        Me.dg.TabIndex = 222
        '
        'lblTotalDoDia
        '
        Me.lblTotalDoDia.AutoSize = True
        Me.lblTotalDoDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDoDia.ForeColor = System.Drawing.Color.White
        Me.lblTotalDoDia.Location = New System.Drawing.Point(450, 439)
        Me.lblTotalDoDia.Name = "lblTotalDoDia"
        Me.lblTotalDoDia.Size = New System.Drawing.Size(14, 18)
        Me.lblTotalDoDia.TabIndex = 224
        Me.lblTotalDoDia.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(330, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 18)
        Me.Label4.TabIndex = 225
        Me.Label4.Text = "Total Vendido:"
        '
        'lblTextoCaixa
        '
        Me.lblTextoCaixa.AutoSize = True
        Me.lblTextoCaixa.Font = New System.Drawing.Font("Arial", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoCaixa.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblTextoCaixa.Location = New System.Drawing.Point(324, 69)
        Me.lblTextoCaixa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTextoCaixa.Name = "lblTextoCaixa"
        Me.lblTextoCaixa.Size = New System.Drawing.Size(349, 51)
        Me.lblTextoCaixa.TabIndex = 226
        Me.lblTextoCaixa.Text = "CAIXA ABERTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(752, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 18)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "Caixa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(730, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 18)
        Me.Label3.TabIndex = 228
        Me.Label3.Text = "Vendas do Dia:"
        '
        'lblHoraAb
        '
        Me.lblHoraAb.AutoSize = True
        Me.lblHoraAb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraAb.Location = New System.Drawing.Point(633, 233)
        Me.lblHoraAb.Name = "lblHoraAb"
        Me.lblHoraAb.Size = New System.Drawing.Size(14, 18)
        Me.lblHoraAb.TabIndex = 229
        Me.lblHoraAb.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(718, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 18)
        Me.Label6.TabIndex = 230
        Me.Label6.Text = "Valor da Abertura:"
        '
        'lblVlrAb
        '
        Me.lblVlrAb.AutoSize = True
        Me.lblVlrAb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVlrAb.Location = New System.Drawing.Point(888, 233)
        Me.lblVlrAb.Name = "lblVlrAb"
        Me.lblVlrAb.Size = New System.Drawing.Size(14, 18)
        Me.lblVlrAb.TabIndex = 231
        Me.lblVlrAb.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(752, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 18)
        Me.Label8.TabIndex = 232
        Me.Label8.Text = "Total Sangria:"
        '
        'lblTotSangria
        '
        Me.lblTotSangria.AutoSize = True
        Me.lblTotSangria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSangria.Location = New System.Drawing.Point(890, 294)
        Me.lblTotSangria.Name = "lblTotSangria"
        Me.lblTotSangria.Size = New System.Drawing.Size(14, 18)
        Me.lblTotSangria.TabIndex = 233
        Me.lblTotSangria.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(486, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 18)
        Me.Label13.TabIndex = 237
        Me.Label13.Text = "Hora da Abertura:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(502, 294)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 18)
        Me.Label14.TabIndex = 238
        Me.Label14.Text = "Última Sangria:"
        '
        'lblHoraSangria
        '
        Me.lblHoraSangria.AutoSize = True
        Me.lblHoraSangria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraSangria.Location = New System.Drawing.Point(633, 295)
        Me.lblHoraSangria.Name = "lblHoraSangria"
        Me.lblHoraSangria.Size = New System.Drawing.Size(14, 18)
        Me.lblHoraSangria.TabIndex = 239
        Me.lblHoraSangria.Text = "-"
        '
        'lblVendasDia
        '
        Me.lblVendasDia.AutoSize = True
        Me.lblVendasDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendasDia.Location = New System.Drawing.Point(861, 125)
        Me.lblVendasDia.Name = "lblVendasDia"
        Me.lblVendasDia.Size = New System.Drawing.Size(14, 18)
        Me.lblVendasDia.TabIndex = 240
        Me.lblVendasDia.Text = "-"
        '
        'txtTotaliza
        '
        Me.txtTotaliza.Enabled = False
        Me.txtTotaliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotaliza.Location = New System.Drawing.Point(427, 465)
        Me.txtTotaliza.Name = "txtTotaliza"
        Me.txtTotaliza.ReadOnly = True
        Me.txtTotaliza.Size = New System.Drawing.Size(65, 24)
        Me.txtTotaliza.TabIndex = 241
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(863, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 18)
        Me.Label5.TabIndex = 243
        Me.Label5.Text = "R$"
        '
        'lblReforco
        '
        Me.lblReforco.AutoSize = True
        Me.lblReforco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReforco.Location = New System.Drawing.Point(894, 344)
        Me.lblReforco.Name = "lblReforco"
        Me.lblReforco.Size = New System.Drawing.Size(14, 18)
        Me.lblReforco.TabIndex = 246
        Me.lblReforco.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(723, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 18)
        Me.Label9.TabIndex = 245
        Me.Label9.Text = "Reforço do Caixa:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(860, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 18)
        Me.Label7.TabIndex = 247
        Me.Label7.Text = "R$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(863, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 18)
        Me.Label10.TabIndex = 248
        Me.Label10.Text = "R$"
        '
        'lblProdutosVendidos
        '
        Me.lblProdutosVendidos.AutoSize = True
        Me.lblProdutosVendidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdutosVendidos.Location = New System.Drawing.Point(653, 330)
        Me.lblProdutosVendidos.Name = "lblProdutosVendidos"
        Me.lblProdutosVendidos.Size = New System.Drawing.Size(14, 18)
        Me.lblProdutosVendidos.TabIndex = 250
        Me.lblProdutosVendidos.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(491, 329)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 18)
        Me.Label12.TabIndex = 249
        Me.Label12.Text = "Produtos Vendidos:"
        '
        'lblTotalCaixa
        '
        Me.lblTotalCaixa.AutoSize = True
        Me.lblTotalCaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCaixa.Location = New System.Drawing.Point(824, 168)
        Me.lblTotalCaixa.Name = "lblTotalCaixa"
        Me.lblTotalCaixa.Size = New System.Drawing.Size(14, 18)
        Me.lblTotalCaixa.TabIndex = 251
        Me.lblTotalCaixa.Text = "-"
        '
        'imagem
        '
        Me.imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.imagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagem.Location = New System.Drawing.Point(813, 69)
        Me.imagem.Name = "imagem"
        Me.imagem.Size = New System.Drawing.Size(25, 25)
        Me.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagem.TabIndex = 242
        Me.imagem.TabStop = False
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.CargosToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.ProdutosToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CadastrosToolStripMenuItem.Image = CType(resources.GetObject("CadastrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CargosToolStripMenuItem
        '
        Me.CargosToolStripMenuItem.Image = CType(resources.GetObject("CargosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CargosToolStripMenuItem.Name = "CargosToolStripMenuItem"
        Me.CargosToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.CargosToolStripMenuItem.Text = "Cargos"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Image = CType(resources.GetObject("FuncionáriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Image = CType(resources.GetObject("FornecedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Image = CType(resources.GetObject("EmpresaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem1, Me.CategoriasToolStripMenuItem, Me.UnidadeDeMedidaToolStripMenuItem})
        Me.ProdutosToolStripMenuItem.Image = CType(resources.GetObject("ProdutosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'ProdutosToolStripMenuItem1
        '
        Me.ProdutosToolStripMenuItem1.Image = CType(resources.GetObject("ProdutosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ProdutosToolStripMenuItem1.Name = "ProdutosToolStripMenuItem1"
        Me.ProdutosToolStripMenuItem1.Size = New System.Drawing.Size(207, 24)
        Me.ProdutosToolStripMenuItem1.Text = "Produtos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Image = CType(resources.GetObject("CategoriasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.CategoriasToolStripMenuItem.Text = "Categorias de Produtos"
        '
        'UnidadeDeMedidaToolStripMenuItem
        '
        Me.UnidadeDeMedidaToolStripMenuItem.Image = CType(resources.GetObject("UnidadeDeMedidaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UnidadeDeMedidaToolStripMenuItem.Name = "UnidadeDeMedidaToolStripMenuItem"
        Me.UnidadeDeMedidaToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.UnidadeDeMedidaToolStripMenuItem.Text = "Unidade de Medida"
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntradaSaídaToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.NíveisBaixoToolStripMenuItem})
        Me.EstoqueToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EstoqueToolStripMenuItem.Image = CType(resources.GetObject("EstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        Me.EstoqueToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.EstoqueToolStripMenuItem.Text = "Estoque"
        '
        'EntradaSaídaToolStripMenuItem
        '
        Me.EntradaSaídaToolStripMenuItem.Image = CType(resources.GetObject("EntradaSaídaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EntradaSaídaToolStripMenuItem.Name = "EntradaSaídaToolStripMenuItem"
        Me.EntradaSaídaToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.EntradaSaídaToolStripMenuItem.Text = "Entrada / Saída"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Image = CType(resources.GetObject("ConsultasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'NíveisBaixoToolStripMenuItem
        '
        Me.NíveisBaixoToolStripMenuItem.Image = CType(resources.GetObject("NíveisBaixoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NíveisBaixoToolStripMenuItem.Name = "NíveisBaixoToolStripMenuItem"
        Me.NíveisBaixoToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.NíveisBaixoToolStripMenuItem.Text = "Níveis Baixo"
        '
        'MovimentaçãoToolStripMenuItem
        '
        Me.MovimentaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdemDeServiçoToolStripMenuItem, Me.TiposDeServiçosToolStripMenuItem, Me.OrçamentoToolStripMenuItem})
        Me.MovimentaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MovimentaçãoToolStripMenuItem.Image = CType(resources.GetObject("MovimentaçãoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MovimentaçãoToolStripMenuItem.Name = "MovimentaçãoToolStripMenuItem"
        Me.MovimentaçãoToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.MovimentaçãoToolStripMenuItem.Text = "Movimentação"
        '
        'OrdemDeServiçoToolStripMenuItem
        '
        Me.OrdemDeServiçoToolStripMenuItem.Image = CType(resources.GetObject("OrdemDeServiçoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OrdemDeServiçoToolStripMenuItem.Name = "OrdemDeServiçoToolStripMenuItem"
        Me.OrdemDeServiçoToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.OrdemDeServiçoToolStripMenuItem.Text = "Ordem de Serviço"
        '
        'TiposDeServiçosToolStripMenuItem
        '
        Me.TiposDeServiçosToolStripMenuItem.Image = CType(resources.GetObject("TiposDeServiçosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TiposDeServiçosToolStripMenuItem.Name = "TiposDeServiçosToolStripMenuItem"
        Me.TiposDeServiçosToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.TiposDeServiçosToolStripMenuItem.Text = "Tipos de Serviços"
        '
        'OrçamentoToolStripMenuItem
        '
        Me.OrçamentoToolStripMenuItem.Name = "OrçamentoToolStripMenuItem"
        Me.OrçamentoToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.OrçamentoToolStripMenuItem.Text = "Orçamento"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PDVRegistrarVendaToolStripMenuItem, Me.ListarVendasToolStripMenuItem, Me.SangriaToolStripMenuItem, Me.ReforçosAsCaixaToolStripMenuItem})
        Me.VendasToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.VendasToolStripMenuItem.Image = CType(resources.GetObject("VendasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'PDVRegistrarVendaToolStripMenuItem
        '
        Me.PDVRegistrarVendaToolStripMenuItem.Image = CType(resources.GetObject("PDVRegistrarVendaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PDVRegistrarVendaToolStripMenuItem.Name = "PDVRegistrarVendaToolStripMenuItem"
        Me.PDVRegistrarVendaToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.PDVRegistrarVendaToolStripMenuItem.Text = "PDV - Registrar Venda"
        '
        'ListarVendasToolStripMenuItem
        '
        Me.ListarVendasToolStripMenuItem.Image = CType(resources.GetObject("ListarVendasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListarVendasToolStripMenuItem.Name = "ListarVendasToolStripMenuItem"
        Me.ListarVendasToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.ListarVendasToolStripMenuItem.Text = "Listar Vendas"
        '
        'SangriaToolStripMenuItem
        '
        Me.SangriaToolStripMenuItem.Image = CType(resources.GetObject("SangriaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SangriaToolStripMenuItem.Name = "SangriaToolStripMenuItem"
        Me.SangriaToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.SangriaToolStripMenuItem.Text = "Sangria"
        '
        'ReforçosAsCaixaToolStripMenuItem
        '
        Me.ReforçosAsCaixaToolStripMenuItem.Name = "ReforçosAsCaixaToolStripMenuItem"
        Me.ReforçosAsCaixaToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.ReforçosAsCaixaToolStripMenuItem.Text = "Reforços as Caixa"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogoDeProdutosToolStripMenuItem, Me.RelatórioDoCaixaToolStripMenuItem, Me.EntradaSaídaToolStripMenuItem1, Me.NíveisDoEstoqueToolStripMenuItem, Me.ProdutosMaisVendidosToolStripMenuItem, Me.VendasPorFuncionárioToolStripMenuItem, Me.FiltroDeVendasToolStripMenuItem, Me.ServiçosToolStripMenuItem})
        Me.RelatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.RelatóriosToolStripMenuItem.Image = CType(resources.GetObject("RelatóriosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'CatálogoDeProdutosToolStripMenuItem
        '
        Me.CatálogoDeProdutosToolStripMenuItem.Image = CType(resources.GetObject("CatálogoDeProdutosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CatálogoDeProdutosToolStripMenuItem.Name = "CatálogoDeProdutosToolStripMenuItem"
        Me.CatálogoDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.CatálogoDeProdutosToolStripMenuItem.Text = "Catálogo de Produtos"
        '
        'RelatórioDoCaixaToolStripMenuItem
        '
        Me.RelatórioDoCaixaToolStripMenuItem.Name = "RelatórioDoCaixaToolStripMenuItem"
        Me.RelatórioDoCaixaToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.RelatórioDoCaixaToolStripMenuItem.Text = "Relatório do Caixa"
        '
        'EntradaSaídaToolStripMenuItem1
        '
        Me.EntradaSaídaToolStripMenuItem1.Name = "EntradaSaídaToolStripMenuItem1"
        Me.EntradaSaídaToolStripMenuItem1.Size = New System.Drawing.Size(211, 24)
        Me.EntradaSaídaToolStripMenuItem1.Text = "Entrada / Saída"
        '
        'NíveisDoEstoqueToolStripMenuItem
        '
        Me.NíveisDoEstoqueToolStripMenuItem.Image = CType(resources.GetObject("NíveisDoEstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NíveisDoEstoqueToolStripMenuItem.Name = "NíveisDoEstoqueToolStripMenuItem"
        Me.NíveisDoEstoqueToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.NíveisDoEstoqueToolStripMenuItem.Text = "Níveis do Estoque"
        '
        'ProdutosMaisVendidosToolStripMenuItem
        '
        Me.ProdutosMaisVendidosToolStripMenuItem.Name = "ProdutosMaisVendidosToolStripMenuItem"
        Me.ProdutosMaisVendidosToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.ProdutosMaisVendidosToolStripMenuItem.Text = "Produtos mais Vendidos"
        '
        'VendasPorFuncionárioToolStripMenuItem
        '
        Me.VendasPorFuncionárioToolStripMenuItem.Name = "VendasPorFuncionárioToolStripMenuItem"
        Me.VendasPorFuncionárioToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.VendasPorFuncionárioToolStripMenuItem.Text = "Vendas por Funcionário"
        '
        'FiltroDeVendasToolStripMenuItem
        '
        Me.FiltroDeVendasToolStripMenuItem.Image = CType(resources.GetObject("FiltroDeVendasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FiltroDeVendasToolStripMenuItem.Name = "FiltroDeVendasToolStripMenuItem"
        Me.FiltroDeVendasToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.FiltroDeVendasToolStripMenuItem.Text = "Filtro de Vendas"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.Image = CType(resources.GetObject("ServiçosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(211, 24)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem1, Me.LogoffToolStripMenuItem})
        Me.SairToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Image = CType(resources.GetObject("SairToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(112, 24)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'LogoffToolStripMenuItem
        '
        Me.LogoffToolStripMenuItem.Image = CType(resources.GetObject("LogoffToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoffToolStripMenuItem.Name = "LogoffToolStripMenuItem"
        Me.LogoffToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.LogoffToolStripMenuItem.Text = "Logoff"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(962, 531)
        Me.Controls.Add(Me.lblTotalCaixa)
        Me.Controls.Add(Me.lblProdutosVendidos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblReforco)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.imagem)
        Me.Controls.Add(Me.txtTotaliza)
        Me.Controls.Add(Me.lblVendasDia)
        Me.Controls.Add(Me.lblHoraSangria)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTotSangria)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblVlrAb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblHoraAb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTextoCaixa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotalDoDia)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadeDeMedidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradaSaídaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NíveisBaixoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimentaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdemDeServiçoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrçamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PDVRegistrarVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SangriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogoDeProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioDoCaixaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradaSaídaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NíveisDoEstoqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosMaisVendidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasPorFuncionárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblData As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents lblTotalDoDia As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FiltroDeVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTextoCaixa As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHoraAb As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblVlrAb As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotSangria As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblHoraSangria As Label
    Friend WithEvents lblVendasDia As Label
    Friend WithEvents txtTotaliza As TextBox
    Friend WithEvents imagem As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ReforçosAsCaixaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblReforco As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblProdutosVendidos As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTotalCaixa As Label
End Class
