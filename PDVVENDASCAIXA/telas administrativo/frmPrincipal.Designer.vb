<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.lblTotalDoDia = New System.Windows.Forms.Label()
        Me.lblTextoCaixa = New System.Windows.Forms.Label()
        Me.lblAbrirFechar = New System.Windows.Forms.Label()
        Me.lblHoraAb = New System.Windows.Forms.Label()
        Me.lblVlrAb = New System.Windows.Forms.Label()
        Me.lblTotSangria = New System.Windows.Forms.Label()
        Me.lblHoraSangria = New System.Windows.Forms.Label()
        Me.lblVendasDia = New System.Windows.Forms.Label()
        Me.lblReforco = New System.Windows.Forms.Label()
        Me.lblProdutosVendidos = New System.Windows.Forms.Label()
        Me.lblTotalCaixa = New System.Windows.Forms.Label()
        Me.imagem = New System.Windows.Forms.PictureBox()
        Me.txtTotaliza = New System.Windows.Forms.TextBox()
        Me.imagemNivel = New System.Windows.Forms.PictureBox()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagemNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.EstoqueToolStripMenuItem, Me.MovimentaçãoToolStripMenuItem, Me.VendasToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(962, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.EntradaSaídaToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.EntradaSaídaToolStripMenuItem.Text = "Entrada / Saída"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Image = CType(resources.GetObject("ConsultasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'NíveisBaixoToolStripMenuItem
        '
        Me.NíveisBaixoToolStripMenuItem.Image = CType(resources.GetObject("NíveisBaixoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NíveisBaixoToolStripMenuItem.Name = "NíveisBaixoToolStripMenuItem"
        Me.NíveisBaixoToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
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
        Me.CatálogoDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(249, 24)
        Me.CatálogoDeProdutosToolStripMenuItem.Text = "Catálogo de Produtos"
        '
        'RelatórioDoCaixaToolStripMenuItem
        '
        Me.RelatórioDoCaixaToolStripMenuItem.Image = CType(resources.GetObject("RelatórioDoCaixaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatórioDoCaixaToolStripMenuItem.Name = "RelatórioDoCaixaToolStripMenuItem"
        Me.RelatórioDoCaixaToolStripMenuItem.Size = New System.Drawing.Size(249, 24)
        Me.RelatórioDoCaixaToolStripMenuItem.Text = "Relatório do Caixa"
        '
        'EntradaSaídaToolStripMenuItem1
        '
        Me.EntradaSaídaToolStripMenuItem1.Image = CType(resources.GetObject("EntradaSaídaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EntradaSaídaToolStripMenuItem1.Name = "EntradaSaídaToolStripMenuItem1"
        Me.EntradaSaídaToolStripMenuItem1.Size = New System.Drawing.Size(249, 24)
        Me.EntradaSaídaToolStripMenuItem1.Text = "Entrada / Saída no Estoque"
        '
        'NíveisDoEstoqueToolStripMenuItem
        '
        Me.NíveisDoEstoqueToolStripMenuItem.Image = CType(resources.GetObject("NíveisDoEstoqueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NíveisDoEstoqueToolStripMenuItem.Name = "NíveisDoEstoqueToolStripMenuItem"
        Me.NíveisDoEstoqueToolStripMenuItem.Size = New System.Drawing.Size(249, 24)
        Me.NíveisDoEstoqueToolStripMenuItem.Text = "Níveis de Produtos em Estoque"
        '
        'ProdutosMaisVendidosToolStripMenuItem
        '
        Me.ProdutosMaisVendidosToolStripMenuItem.Image = CType(resources.GetObject("ProdutosMaisVendidosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutosMaisVendidosToolStripMenuItem.Name = "ProdutosMaisVendidosToolStripMenuItem"
        Me.ProdutosMaisVendidosToolStripMenuItem.Size = New System.Drawing.Size(249, 24)
        Me.ProdutosMaisVendidosToolStripMenuItem.Text = "Produtos mais Vendidos"
        '
        'VendasPorFuncionárioToolStripMenuItem
        '
        Me.VendasPorFuncionárioToolStripMenuItem.Image = CType(resources.GetObject("VendasPorFuncionárioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VendasPorFuncionárioToolStripMenuItem.Name = "VendasPorFuncionárioToolStripMenuItem"
        Me.VendasPorFuncionárioToolStripMenuItem.Size = New System.Drawing.Size(249, 24)
        Me.VendasPorFuncionárioToolStripMenuItem.Text = "Vendas por Funcionário"
        '
        'FiltroDeVendasToolStripMenuItem
        '
        Me.FiltroDeVendasToolStripMenuItem.Image = CType(resources.GetObject("FiltroDeVendasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FiltroDeVendasToolStripMenuItem.Name = "FiltroDeVendasToolStripMenuItem"
        Me.FiltroDeVendasToolStripMenuItem.Size = New System.Drawing.Size(249, 24)
        Me.FiltroDeVendasToolStripMenuItem.Text = "Filtro de Vendas"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.Image = CType(resources.GetObject("ServiçosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(249, 24)
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
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(236, 220)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(19, 26)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "-"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(366, 164)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(19, 26)
        Me.lblHora.TabIndex = 3
        Me.lblHora.Text = "-"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.BackColor = System.Drawing.Color.Transparent
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(236, 164)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(19, 26)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dg.Location = New System.Drawing.Point(522, 195)
        Me.dg.Margin = New System.Windows.Forms.Padding(4)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(408, 334)
        Me.dg.TabIndex = 222
        '
        'lblTotalDoDia
        '
        Me.lblTotalDoDia.AutoSize = True
        Me.lblTotalDoDia.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalDoDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDoDia.ForeColor = System.Drawing.Color.Black
        Me.lblTotalDoDia.Location = New System.Drawing.Point(236, 486)
        Me.lblTotalDoDia.Name = "lblTotalDoDia"
        Me.lblTotalDoDia.Size = New System.Drawing.Size(20, 26)
        Me.lblTotalDoDia.TabIndex = 224
        Me.lblTotalDoDia.Text = "-"
        '
        'lblTextoCaixa
        '
        Me.lblTextoCaixa.AutoSize = True
        Me.lblTextoCaixa.BackColor = System.Drawing.Color.Transparent
        Me.lblTextoCaixa.Font = New System.Drawing.Font("Arial", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoCaixa.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblTextoCaixa.Location = New System.Drawing.Point(292, 59)
        Me.lblTextoCaixa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTextoCaixa.Name = "lblTextoCaixa"
        Me.lblTextoCaixa.Size = New System.Drawing.Size(37, 51)
        Me.lblTextoCaixa.TabIndex = 226
        Me.lblTextoCaixa.Text = "-"
        '
        'lblAbrirFechar
        '
        Me.lblAbrirFechar.AutoSize = True
        Me.lblAbrirFechar.BackColor = System.Drawing.Color.Transparent
        Me.lblAbrirFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbrirFechar.Location = New System.Drawing.Point(826, 95)
        Me.lblAbrirFechar.Name = "lblAbrirFechar"
        Me.lblAbrirFechar.Size = New System.Drawing.Size(10, 13)
        Me.lblAbrirFechar.TabIndex = 227
        Me.lblAbrirFechar.Text = "-"
        '
        'lblHoraAb
        '
        Me.lblHoraAb.AutoSize = True
        Me.lblHoraAb.BackColor = System.Drawing.Color.Transparent
        Me.lblHoraAb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraAb.Location = New System.Drawing.Point(16, 59)
        Me.lblHoraAb.Name = "lblHoraAb"
        Me.lblHoraAb.Size = New System.Drawing.Size(14, 18)
        Me.lblHoraAb.TabIndex = 229
        Me.lblHoraAb.Text = "-"
        Me.lblHoraAb.Visible = False
        '
        'lblVlrAb
        '
        Me.lblVlrAb.AutoSize = True
        Me.lblVlrAb.BackColor = System.Drawing.Color.Transparent
        Me.lblVlrAb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVlrAb.Location = New System.Drawing.Point(16, 77)
        Me.lblVlrAb.Name = "lblVlrAb"
        Me.lblVlrAb.Size = New System.Drawing.Size(14, 18)
        Me.lblVlrAb.TabIndex = 231
        Me.lblVlrAb.Text = "-"
        Me.lblVlrAb.Visible = False
        '
        'lblTotSangria
        '
        Me.lblTotSangria.AutoSize = True
        Me.lblTotSangria.BackColor = System.Drawing.Color.Transparent
        Me.lblTotSangria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSangria.Location = New System.Drawing.Point(16, 95)
        Me.lblTotSangria.Name = "lblTotSangria"
        Me.lblTotSangria.Size = New System.Drawing.Size(14, 18)
        Me.lblTotSangria.TabIndex = 233
        Me.lblTotSangria.Text = "-"
        Me.lblTotSangria.Visible = False
        '
        'lblHoraSangria
        '
        Me.lblHoraSangria.AutoSize = True
        Me.lblHoraSangria.BackColor = System.Drawing.Color.Transparent
        Me.lblHoraSangria.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraSangria.Location = New System.Drawing.Point(236, 276)
        Me.lblHoraSangria.Name = "lblHoraSangria"
        Me.lblHoraSangria.Size = New System.Drawing.Size(20, 26)
        Me.lblHoraSangria.TabIndex = 239
        Me.lblHoraSangria.Text = "-"
        '
        'lblVendasDia
        '
        Me.lblVendasDia.AutoSize = True
        Me.lblVendasDia.BackColor = System.Drawing.Color.Transparent
        Me.lblVendasDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendasDia.Location = New System.Drawing.Point(236, 333)
        Me.lblVendasDia.Name = "lblVendasDia"
        Me.lblVendasDia.Size = New System.Drawing.Size(20, 26)
        Me.lblVendasDia.TabIndex = 240
        Me.lblVendasDia.Text = "-"
        '
        'lblReforco
        '
        Me.lblReforco.AutoSize = True
        Me.lblReforco.BackColor = System.Drawing.Color.Transparent
        Me.lblReforco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReforco.Location = New System.Drawing.Point(16, 113)
        Me.lblReforco.Name = "lblReforco"
        Me.lblReforco.Size = New System.Drawing.Size(14, 18)
        Me.lblReforco.TabIndex = 246
        Me.lblReforco.Text = "-"
        Me.lblReforco.Visible = False
        '
        'lblProdutosVendidos
        '
        Me.lblProdutosVendidos.AutoSize = True
        Me.lblProdutosVendidos.BackColor = System.Drawing.Color.Transparent
        Me.lblProdutosVendidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdutosVendidos.Location = New System.Drawing.Point(236, 390)
        Me.lblProdutosVendidos.Name = "lblProdutosVendidos"
        Me.lblProdutosVendidos.Size = New System.Drawing.Size(20, 26)
        Me.lblProdutosVendidos.TabIndex = 250
        Me.lblProdutosVendidos.Text = "-"
        '
        'lblTotalCaixa
        '
        Me.lblTotalCaixa.AutoSize = True
        Me.lblTotalCaixa.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCaixa.Location = New System.Drawing.Point(12, 40)
        Me.lblTotalCaixa.Name = "lblTotalCaixa"
        Me.lblTotalCaixa.Size = New System.Drawing.Size(14, 18)
        Me.lblTotalCaixa.TabIndex = 251
        Me.lblTotalCaixa.Text = "-"
        Me.lblTotalCaixa.Visible = False
        '
        'imagem
        '
        Me.imagem.BackColor = System.Drawing.Color.Transparent
        Me.imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.imagem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagem.Location = New System.Drawing.Point(796, 88)
        Me.imagem.Name = "imagem"
        Me.imagem.Size = New System.Drawing.Size(25, 25)
        Me.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagem.TabIndex = 242
        Me.imagem.TabStop = False
        '
        'txtTotaliza
        '
        Me.txtTotaliza.Enabled = False
        Me.txtTotaliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotaliza.Location = New System.Drawing.Point(0, 484)
        Me.txtTotaliza.Name = "txtTotaliza"
        Me.txtTotaliza.ReadOnly = True
        Me.txtTotaliza.Size = New System.Drawing.Size(10, 24)
        Me.txtTotaliza.TabIndex = 241
        Me.txtTotaliza.Visible = False
        '
        'imagemNivel
        '
        Me.imagemNivel.BackColor = System.Drawing.Color.Transparent
        Me.imagemNivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.imagemNivel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imagemNivel.Location = New System.Drawing.Point(796, 52)
        Me.imagemNivel.Name = "imagemNivel"
        Me.imagemNivel.Size = New System.Drawing.Size(25, 25)
        Me.imagemNivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagemNivel.TabIndex = 253
        Me.imagemNivel.TabStop = False
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.BackColor = System.Drawing.Color.Transparent
        Me.lblNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivel.Location = New System.Drawing.Point(826, 59)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(10, 13)
        Me.lblNivel.TabIndex = 252
        Me.lblNivel.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(54, 427)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 254
        Me.Label1.Text = "Nº CAIXA"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(962, 557)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imagemNivel)
        Me.Controls.Add(Me.lblNivel)
        Me.Controls.Add(Me.lblTotalCaixa)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblProdutosVendidos)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblReforco)
        Me.Controls.Add(Me.imagem)
        Me.Controls.Add(Me.txtTotaliza)
        Me.Controls.Add(Me.lblVendasDia)
        Me.Controls.Add(Me.lblHoraSangria)
        Me.Controls.Add(Me.lblTotSangria)
        Me.Controls.Add(Me.lblVlrAb)
        Me.Controls.Add(Me.lblHoraAb)
        Me.Controls.Add(Me.lblAbrirFechar)
        Me.Controls.Add(Me.lblTextoCaixa)
        Me.Controls.Add(Me.lblTotalDoDia)
        Me.Controls.Add(Me.dg)
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
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagemNivel, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblHora As Label
    Friend WithEvents lblData As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dg As DataGridView
    Friend WithEvents lblTotalDoDia As Label
    Friend WithEvents FiltroDeVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTextoCaixa As Label
    Friend WithEvents lblAbrirFechar As Label
    Friend WithEvents lblHoraAb As Label
    Friend WithEvents lblVlrAb As Label
    Friend WithEvents lblTotSangria As Label
    Friend WithEvents lblHoraSangria As Label
    Friend WithEvents lblVendasDia As Label
    Friend WithEvents imagem As PictureBox
    Friend WithEvents ReforçosAsCaixaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblReforco As Label
    Friend WithEvents lblProdutosVendidos As Label
    Friend WithEvents lblTotalCaixa As Label
    Friend WithEvents txtTotaliza As TextBox
    Friend WithEvents imagemNivel As PictureBox
    Friend WithEvents lblNivel As Label
    Friend WithEvents Label1 As Label
End Class
