namespace E_Sales
{
    partial class Painel_Convidado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.painelAdm = new System.Windows.Forms.Panel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSair = new MaterialSkin.Controls.MaterialLabel();
            this.picConv = new System.Windows.Forms.PictureBox();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.tabAdm = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewRecentes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbsalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsalesDataSet = new E_Sales.dbsalesDataSet();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPesquisar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearchId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dbsalesTableAdapter = new E_Sales.dbsalesDataSetTableAdapters.dbsalesTableAdapter();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelLogado = new System.Windows.Forms.Panel();
            this.lblCalc = new MaterialSkin.Controls.MaterialLabel();
            this.lblSobre = new MaterialSkin.Controls.MaterialLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.painelAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConv)).BeginInit();
            this.tabAdm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsalesDataSet)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.panelLogado.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelAdm
            // 
            this.painelAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.painelAdm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.painelAdm.BackColor = System.Drawing.Color.Transparent;
            this.painelAdm.Controls.Add(this.materialLabel8);
            this.painelAdm.Controls.Add(this.lblSair);
            this.painelAdm.Controls.Add(this.picConv);
            this.painelAdm.Controls.Add(this.materialDivider6);
            this.painelAdm.Location = new System.Drawing.Point(693, 25);
            this.painelAdm.Name = "painelAdm";
            this.painelAdm.Size = new System.Drawing.Size(328, 38);
            this.painelAdm.TabIndex = 35;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(83, 10);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(193, 19);
            this.materialLabel8.TabIndex = 39;
            this.materialLabel8.Text = "Seja Bem-Vindo, Convidado";
            // 
            // lblSair
            // 
            this.lblSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSair.AutoSize = true;
            this.lblSair.BackColor = System.Drawing.Color.Transparent;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Depth = 0;
            this.lblSair.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSair.Location = new System.Drawing.Point(290, 10);
            this.lblSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(35, 19);
            this.lblSair.TabIndex = 38;
            this.lblSair.Text = "Sair";
            this.lblSair.MouseLeave += new System.EventHandler(this.lblSair_MouseLeave);
            this.lblSair.MouseHover += new System.EventHandler(this.lblSair_MouseHover);
            // 
            // picConv
            // 
            this.picConv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picConv.Image = global::E_Sales.Properties.Resources.Guest;
            this.picConv.Location = new System.Drawing.Point(34, 0);
            this.picConv.Name = "picConv";
            this.picConv.Size = new System.Drawing.Size(43, 38);
            this.picConv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConv.TabIndex = 40;
            this.picConv.TabStop = false;
            this.picConv.Click += new System.EventHandler(this.picConv_Click_1);
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.White;
            this.materialDivider6.Depth = 0;
            this.materialDivider6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.materialDivider6.Location = new System.Drawing.Point(282, 7);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(2, 28);
            this.materialDivider6.TabIndex = 35;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // tabAdm
            // 
            this.tabAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabAdm.Controls.Add(this.tabPage2);
            this.tabAdm.Depth = 0;
            this.tabAdm.Location = new System.Drawing.Point(-4, 66);
            this.tabAdm.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabAdm.Name = "tabAdm";
            this.tabAdm.SelectedIndex = 0;
            this.tabAdm.Size = new System.Drawing.Size(1025, 510);
            this.tabAdm.TabIndex = 36;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dataGridViewRecentes);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnPesquisar);
            this.tabPage2.Controls.Add(this.materialLabel9);
            this.tabPage2.Controls.Add(this.txtSearchId);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas";
            // 
            // dataGridViewRecentes
            // 
            this.dataGridViewRecentes.AllowUserToAddRows = false;
            this.dataGridViewRecentes.AllowUserToDeleteRows = false;
            this.dataGridViewRecentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecentes.AutoGenerateColumns = false;
            this.dataGridViewRecentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridViewRecentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridViewRecentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRecentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.descricao,
            this.status});
            this.dataGridViewRecentes.DataSource = this.dbsalesBindingSource;
            this.dataGridViewRecentes.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewRecentes.Name = "dataGridViewRecentes";
            this.dataGridViewRecentes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRecentes.Size = new System.Drawing.Size(999, 422);
            this.dataGridViewRecentes.TabIndex = 62;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MaxInputLength = 4;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nomeDataGridViewTextBoxColumn.MaxInputLength = 80;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoDataGridViewTextBoxColumn.MaxInputLength = 120;
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "N. de Série";
            this.serieDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telDataGridViewTextBoxColumn.MaxInputLength = 11;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MaxInputLength = 300;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MaxInputLength = 20;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // dbsalesBindingSource
            // 
            this.dbsalesBindingSource.DataMember = "dbsales";
            this.dbsalesBindingSource.DataSource = this.dbsalesDataSet;
            // 
            // dbsalesDataSet
            // 
            this.dbsalesDataSet.DataSetName = "dbsalesDataSet";
            this.dbsalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(366, 11);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPesquisar.Depth = 0;
            this.btnPesquisar.Icon = null;
            this.btnPesquisar.Location = new System.Drawing.Point(264, 11);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Primary = false;
            this.btnPesquisar.Size = new System.Drawing.Size(94, 36);
            this.btnPesquisar.TabIndex = 60;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(7, 28);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(98, 19);
            this.materialLabel9.TabIndex = 59;
            this.materialLabel9.Text = "Busca por ID:";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Depth = 0;
            this.txtSearchId.Hint = "Insira o ID";
            this.txtSearchId.Location = new System.Drawing.Point(111, 24);
            this.txtSearchId.MaxLength = 3;
            this.txtSearchId.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.PasswordChar = '\0';
            this.txtSearchId.SelectedText = "";
            this.txtSearchId.SelectionLength = 0;
            this.txtSearchId.SelectionStart = 0;
            this.txtSearchId.Size = new System.Drawing.Size(146, 23);
            this.txtSearchId.TabIndex = 58;
            this.txtSearchId.TabStop = false;
            this.toolTip1.SetToolTip(this.txtSearchId, "Pesquisar por ID");
            this.txtSearchId.UseSystemPasswordChar = false;
            // 
            // dbsalesTableAdapter
            // 
            this.dbsalesTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 578);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1024, 22);
            this.statusStrip.TabIndex = 37;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 17);
            this.lblStatus.Text = "Pronto";
            // 
            // panelLogado
            // 
            this.panelLogado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.panelLogado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLogado.Controls.Add(this.lblCalc);
            this.panelLogado.Controls.Add(this.lblSobre);
            this.panelLogado.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelLogado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLogado.Location = new System.Drawing.Point(693, 64);
            this.panelLogado.MaximumSize = new System.Drawing.Size(330, 70);
            this.panelLogado.Name = "panelLogado";
            this.panelLogado.Size = new System.Drawing.Size(330, 70);
            this.panelLogado.TabIndex = 63;
            // 
            // lblCalc
            // 
            this.lblCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCalc.AutoSize = true;
            this.lblCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCalc.Depth = 0;
            this.lblCalc.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCalc.Location = new System.Drawing.Point(3, 36);
            this.lblCalc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(89, 19);
            this.lblCalc.TabIndex = 2;
            this.lblCalc.Text = "Calculadora";
            this.lblCalc.Click += new System.EventHandler(this.lblCalc_Click);
            this.lblCalc.MouseLeave += new System.EventHandler(this.lblCalc_MouseLeave);
            this.lblCalc.MouseHover += new System.EventHandler(this.lblCalc_MouseHover);
            // 
            // lblSobre
            // 
            this.lblSobre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSobre.AutoSize = true;
            this.lblSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSobre.Depth = 0;
            this.lblSobre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSobre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSobre.Location = new System.Drawing.Point(3, 11);
            this.lblSobre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(48, 19);
            this.lblSobre.TabIndex = 1;
            this.lblSobre.Text = "Sobre";
            this.lblSobre.Click += new System.EventHandler(this.lblSobre_Click);
            this.lblSobre.MouseLeave += new System.EventHandler(this.lblSobre_MouseLeave);
            this.lblSobre.MouseHover += new System.EventHandler(this.lblSobre_MouseHover);
            // 
            // Painel_Convidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.panelLogado);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabAdm);
            this.Controls.Add(this.painelAdm);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1022, 600);
            this.Name = "Painel_Convidado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel Convidado";
            this.Load += new System.EventHandler(this.Painel_Convidado_Load);
            this.painelAdm.ResumeLayout(false);
            this.painelAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConv)).EndInit();
            this.tabAdm.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsalesDataSet)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelLogado.ResumeLayout(false);
            this.panelLogado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void picConv_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel painelAdm;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lblSair;
        private System.Windows.Forms.PictureBox picConv;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private MaterialSkin.Controls.MaterialTabControl tabAdm;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialFlatButton btnPesquisar;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchId;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private dbsalesDataSet dbsalesDataSet;
        private System.Windows.Forms.BindingSource dbsalesBindingSource;
        private dbsalesDataSetTableAdapters.dbsalesTableAdapter dbsalesTableAdapter;
        public System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.DataGridView dataGridViewRecentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel panelLogado;
        private MaterialSkin.Controls.MaterialLabel lblCalc;
        private MaterialSkin.Controls.MaterialLabel lblSobre;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}