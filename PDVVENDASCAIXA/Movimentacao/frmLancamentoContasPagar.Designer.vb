﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancamentoContasPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLancamentoContasPagar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.txtDataPagto = New System.Windows.Forms.MaskedTextBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtValorPago = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtJuros = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtValorParcelas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtParcelas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFormaPagto = New System.Windows.Forms.ComboBox()
        Me.btFormaPagto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.Label()
        Me.txtFornecedor = New System.Windows.Forms.ComboBox()
        Me.btFornecedor = New System.Windows.Forms.Button()
        Me.txtConta = New System.Windows.Forms.ComboBox()
        Me.btConta = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSituacao = New System.Windows.Forms.ComboBox()
        Me.txtVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtNDoc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.btSalvar)
        Me.Panel1.Controls.Add(Me.txtDataPagto)
        Me.Panel1.Controls.Add(Me.btnExcluir)
        Me.Panel1.Controls.Add(Me.btSair)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtValorPago)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtJuros)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtDesconto)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtValorParcelas)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtParcelas)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtObs)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtFormaPagto)
        Me.Panel1.Controls.Add(Me.btFormaPagto)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.txtFornecedor)
        Me.Panel1.Controls.Add(Me.btFornecedor)
        Me.Panel1.Controls.Add(Me.txtConta)
        Me.Panel1.Controls.Add(Me.btConta)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtSituacao)
        Me.Panel1.Controls.Add(Me.txtVencimento)
        Me.Panel1.Controls.Add(Me.txtValor)
        Me.Panel1.Controls.Add(Me.txtDescricao)
        Me.Panel1.Controls.Add(Me.txtNDoc)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 326)
        Me.Panel1.TabIndex = 0
        '
        'btSalvar
        '
        Me.btSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.FlatAppearance.BorderSize = 0
        Me.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalvar.ForeColor = System.Drawing.Color.White
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.Location = New System.Drawing.Point(15, 275)
        Me.btSalvar.Margin = New System.Windows.Forms.Padding(5)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(90, 45)
        Me.btSalvar.TabIndex = 10
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = False
        '
        'txtDataPagto
        '
        Me.txtDataPagto.Location = New System.Drawing.Point(120, 238)
        Me.txtDataPagto.Mask = "00/00/0000"
        Me.txtDataPagto.Name = "txtDataPagto"
        Me.txtDataPagto.Size = New System.Drawing.Size(87, 20)
        Me.txtDataPagto.TabIndex = 329
        Me.txtDataPagto.ValidatingType = GetType(Date)
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(131, 275)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(90, 45)
        Me.btnExcluir.TabIndex = 12
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btSair
        '
        Me.btSair.BackColor = System.Drawing.Color.Transparent
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSair.ForeColor = System.Drawing.Color.White
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(606, 269)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(109, 46)
        Me.btSair.TabIndex = 13
        Me.btSair.Text = "Voltar"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(745, 56)
        Me.Panel2.TabIndex = 328
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(132, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(439, 28)
        Me.Label16.TabIndex = 258
        Me.Label16.Text = "CADASTRO DE CONTAS A PAGAR"
        '
        'txtValorPago
        '
        Me.txtValorPago.Location = New System.Drawing.Point(477, 237)
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.Size = New System.Drawing.Size(100, 20)
        Me.txtValorPago.TabIndex = 326
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(475, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 20)
        Me.Label15.TabIndex = 327
        Me.Label15.Text = "Valor Pago:"
        '
        'txtJuros
        '
        Me.txtJuros.Location = New System.Drawing.Point(361, 237)
        Me.txtJuros.Name = "txtJuros"
        Me.txtJuros.Size = New System.Drawing.Size(100, 20)
        Me.txtJuros.TabIndex = 324
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(366, 214)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 20)
        Me.Label14.TabIndex = 325
        Me.Label14.Text = "Juros:"
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(245, 237)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(100, 20)
        Me.txtDesconto.TabIndex = 322
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(248, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 20)
        Me.Label12.TabIndex = 323
        Me.Label12.Text = "Desconto:"
        '
        'txtValorParcelas
        '
        Me.txtValorParcelas.Location = New System.Drawing.Point(574, 187)
        Me.txtValorParcelas.Name = "txtValorParcelas"
        Me.txtValorParcelas.Size = New System.Drawing.Size(141, 20)
        Me.txtValorParcelas.TabIndex = 320
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(570, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 20)
        Me.Label10.TabIndex = 321
        Me.Label10.Text = "Valor das Parcelas:"
        '
        'txtParcelas
        '
        Me.txtParcelas.Location = New System.Drawing.Point(440, 187)
        Me.txtParcelas.Name = "txtParcelas"
        Me.txtParcelas.Size = New System.Drawing.Size(100, 20)
        Me.txtParcelas.TabIndex = 318
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(441, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 319
        Me.Label7.Text = "Parcelas:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(7, 187)
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(411, 20)
        Me.txtObs.TabIndex = 316
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 317
        Me.Label2.Text = "Obs.:"
        '
        'txtFormaPagto
        '
        Me.txtFormaPagto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFormaPagto.FormattingEnabled = True
        Me.txtFormaPagto.Location = New System.Drawing.Point(414, 139)
        Me.txtFormaPagto.Name = "txtFormaPagto"
        Me.txtFormaPagto.Size = New System.Drawing.Size(159, 21)
        Me.txtFormaPagto.TabIndex = 313
        '
        'btFormaPagto
        '
        Me.btFormaPagto.BackColor = System.Drawing.Color.Transparent
        Me.btFormaPagto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFormaPagto.FlatAppearance.BorderSize = 0
        Me.btFormaPagto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btFormaPagto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btFormaPagto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFormaPagto.ForeColor = System.Drawing.Color.White
        Me.btFormaPagto.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Create
        Me.btFormaPagto.Location = New System.Drawing.Point(572, 134)
        Me.btFormaPagto.Margin = New System.Windows.Forms.Padding(5)
        Me.btFormaPagto.Name = "btFormaPagto"
        Me.btFormaPagto.Size = New System.Drawing.Size(35, 27)
        Me.btFormaPagto.TabIndex = 314
        Me.btFormaPagto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFormaPagto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFormaPagto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(411, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 315
        Me.Label1.Text = "Forma de Pagto:"
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = True
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(676, 64)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(18, 20)
        Me.txtCodigo.TabIndex = 310
        Me.txtCodigo.Text = "0"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFornecedor.FormattingEnabled = True
        Me.txtFornecedor.Location = New System.Drawing.Point(372, 93)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(305, 21)
        Me.txtFornecedor.TabIndex = 309
        '
        'btFornecedor
        '
        Me.btFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.btFornecedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btFornecedor.FlatAppearance.BorderSize = 0
        Me.btFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btFornecedor.ForeColor = System.Drawing.Color.White
        Me.btFornecedor.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Create
        Me.btFornecedor.Location = New System.Drawing.Point(680, 89)
        Me.btFornecedor.Margin = New System.Windows.Forms.Padding(5)
        Me.btFornecedor.Name = "btFornecedor"
        Me.btFornecedor.Size = New System.Drawing.Size(35, 27)
        Me.btFornecedor.TabIndex = 308
        Me.btFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btFornecedor.UseVisualStyleBackColor = False
        '
        'txtConta
        '
        Me.txtConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtConta.FormattingEnabled = True
        Me.txtConta.Location = New System.Drawing.Point(144, 93)
        Me.txtConta.Name = "txtConta"
        Me.txtConta.Size = New System.Drawing.Size(176, 21)
        Me.txtConta.TabIndex = 294
        '
        'btConta
        '
        Me.btConta.BackColor = System.Drawing.Color.Transparent
        Me.btConta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btConta.FlatAppearance.BorderSize = 0
        Me.btConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConta.ForeColor = System.Drawing.Color.White
        Me.btConta.Image = Global.PDVVENDASCAIXA.My.Resources.Resources.Create
        Me.btConta.Location = New System.Drawing.Point(323, 89)
        Me.btConta.Margin = New System.Windows.Forms.Padding(5)
        Me.btConta.Name = "btConta"
        Me.btConta.Size = New System.Drawing.Size(35, 27)
        Me.btConta.TabIndex = 295
        Me.btConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btConta.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(588, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 20)
        Me.Label13.TabIndex = 307
        Me.Label13.Text = "Situação:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(116, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 20)
        Me.Label11.TabIndex = 306
        Me.Label11.Text = "Dt Pagamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 305
        Me.Label3.Text = "N° Docto:"
        '
        'txtSituacao
        '
        Me.txtSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtSituacao.FormattingEnabled = True
        Me.txtSituacao.Items.AddRange(New Object() {"Pago", "Não Pago", "Atrasado"})
        Me.txtSituacao.Location = New System.Drawing.Point(584, 236)
        Me.txtSituacao.Name = "txtSituacao"
        Me.txtSituacao.Size = New System.Drawing.Size(131, 21)
        Me.txtSituacao.TabIndex = 298
        '
        'txtVencimento
        '
        Me.txtVencimento.Location = New System.Drawing.Point(10, 238)
        Me.txtVencimento.Mask = "00/00/0000"
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(87, 20)
        Me.txtVencimento.TabIndex = 297
        Me.txtVencimento.ValidatingType = GetType(Date)
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(615, 139)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 299
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(8, 139)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(400, 20)
        Me.txtDescricao.TabIndex = 293
        '
        'txtNDoc
        '
        Me.txtNDoc.Location = New System.Drawing.Point(7, 93)
        Me.txtNDoc.Name = "txtNDoc"
        Me.txtNDoc.Size = New System.Drawing.Size(120, 20)
        Me.txtNDoc.TabIndex = 296
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(143, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 304
        Me.Label9.Text = "Tipo Conta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 303
        Me.Label6.Text = "Vencimento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(381, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 302
        Me.Label4.Text = "Fornecedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(615, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 301
        Me.Label5.Text = "Valor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.TabIndex = 300
        Me.Label8.Text = "Descrição:"
        '
        'frmLancamentoContasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(769, 352)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLancamentoContasPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lancamento de Contas a Pagar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtValorPago As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtJuros As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtValorParcelas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtParcelas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFormaPagto As ComboBox
    Friend WithEvents btFormaPagto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btSair As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents txtCodigo As Label
    Friend WithEvents txtFornecedor As ComboBox
    Friend WithEvents btFornecedor As Button
    Friend WithEvents txtConta As ComboBox
    Friend WithEvents btConta As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSituacao As ComboBox
    Friend WithEvents txtVencimento As MaskedTextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtNDoc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDataPagto As MaskedTextBox
    Friend WithEvents btnExcluir As Button
End Class