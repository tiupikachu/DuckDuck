﻿namespace WindowsFormsApp5
{
    partial class ProdutoCRUD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutoCRUD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.duck_DuckDataSet1 = new WindowsFormsApp5.Duck_DuckDataSet1();
            this.sRetornaCadastrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_Retorna_CadastrosTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.s_Retorna_CadastrosTableAdapter();
            this.duck_DuckDataSet = new WindowsFormsApp5.Duck_DuckDataSet1();
            this.duckDuckDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_loginTableAdapter = new WindowsFormsApp5.Duck_DuckDataSet1TableAdapters.t_loginTableAdapter();
            this.sRetornaCadastrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sRetornaCadastrosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tloginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tloginBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.GridTotal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlPesquisa = new System.Windows.Forms.Panel();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblPesqFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblPesq = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRetornaCadastrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckDuckDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRetornaCadastrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRetornaCadastrosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTotal)).BeginInit();
            this.PnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 73);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(365, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 25);
            this.label4.TabIndex = 1004;
            this.label4.Text = "Gerenciamento de Estoque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1003;
            this.label1.Text = "Duck ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1002;
            this.label2.Text = "Duck ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp5.Properties.Resources.Mesa_de_trabajo_1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1001;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::WindowsFormsApp5.Properties.Resources.leftarrow;
            this.pictureBox3.Location = new System.Drawing.Point(976, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lbluser
            // 
            this.lbluser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbluser.AutoSize = true;
            this.lbluser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(835, 10);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(165, 20);
            this.lbluser.TabIndex = 1004;
            this.lbluser.Text = "Pesquisar Produtos";
            this.lbluser.Click += new System.EventHandler(this.label4_Click);
            // 
            // duck_DuckDataSet1
            // 
            this.duck_DuckDataSet1.DataSetName = "Duck_DuckDataSet1";
            this.duck_DuckDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sRetornaCadastrosBindingSource
            // 
            this.sRetornaCadastrosBindingSource.DataMember = "s_Retorna_Cadastros";
            this.sRetornaCadastrosBindingSource.DataSource = this.duck_DuckDataSet1;
            // 
            // s_Retorna_CadastrosTableAdapter
            // 
            this.s_Retorna_CadastrosTableAdapter.ClearBeforeFill = true;
            // 
            // duck_DuckDataSet
            // 
            this.duck_DuckDataSet.DataSetName = "Duck_DuckDataSet";
            this.duck_DuckDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // duckDuckDataSetBindingSource
            // 
            this.duckDuckDataSetBindingSource.DataSource = this.duck_DuckDataSet;
            this.duckDuckDataSetBindingSource.Position = 0;
            // 
            // tloginBindingSource
            // 
            this.tloginBindingSource.DataMember = "t_login";
            this.tloginBindingSource.DataSource = this.duck_DuckDataSet1;
            // 
            // t_loginTableAdapter
            // 
            this.t_loginTableAdapter.ClearBeforeFill = true;
            // 
            // sRetornaCadastrosBindingSource1
            // 
            this.sRetornaCadastrosBindingSource1.DataMember = "s_Retorna_Cadastros";
            this.sRetornaCadastrosBindingSource1.DataSource = this.duck_DuckDataSet1;
            // 
            // sRetornaCadastrosBindingSource2
            // 
            this.sRetornaCadastrosBindingSource2.DataMember = "s_Retorna_Cadastros";
            this.sRetornaCadastrosBindingSource2.DataSource = this.duck_DuckDataSet1;
            // 
            // tloginBindingSource1
            // 
            this.tloginBindingSource1.DataMember = "t_login";
            this.tloginBindingSource1.DataSource = this.duck_DuckDataSet1;
            // 
            // tloginBindingSource2
            // 
            this.tloginBindingSource2.DataMember = "t_login";
            this.tloginBindingSource2.DataSource = this.duck_DuckDataSet1;
            // 
            // GridTotal
            // 
            this.GridTotal.AllowUserToAddRows = false;
            this.GridTotal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTotal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridTotal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTotal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nome,
            this.descrição,
            this.quantidade,
            this.preco,
            this.precoFornecedor,
            this.Fornecedor,
            this.Validade});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridTotal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridTotal.Location = new System.Drawing.Point(0, 73);
            this.GridTotal.MultiSelect = false;
            this.GridTotal.Name = "GridTotal";
            this.GridTotal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.GridTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTotal.ShowEditingIcon = false;
            this.GridTotal.Size = new System.Drawing.Size(1044, 404);
            this.GridTotal.TabIndex = 7;
            this.GridTotal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTotal_CellClick);
            this.GridTotal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTotal_CellContentClick);
            this.GridTotal.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridTotal_CellPainting);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // descrição
            // 
            this.descrição.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descrição.HeaderText = "Descrição";
            this.descrição.Name = "descrição";
            // 
            // quantidade
            // 
            this.quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // preco
            // 
            this.preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "NULL";
            this.preco.DefaultCellStyle = dataGridViewCellStyle3;
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            // 
            // precoFornecedor
            // 
            this.precoFornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.precoFornecedor.DefaultCellStyle = dataGridViewCellStyle4;
            this.precoFornecedor.HeaderText = "Preço Fornecedor";
            this.precoFornecedor.Name = "precoFornecedor";
            // 
            // Fornecedor
            // 
            this.Fornecedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fornecedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Validade
            // 
            this.Validade.HeaderText = "Data de validade";
            this.Validade.Name = "Validade";
            // 
            // PnlPesquisa
            // 
            this.PnlPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.PnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPesquisa.Controls.Add(this.lblFornecedor);
            this.PnlPesquisa.Controls.Add(this.lblPesqFornecedor);
            this.PnlPesquisa.Controls.Add(this.lbluser);
            this.PnlPesquisa.Controls.Add(this.label3);
            this.PnlPesquisa.Controls.Add(this.pictureBox6);
            this.PnlPesquisa.Controls.Add(this.lblPesq);
            this.PnlPesquisa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPesquisa.Location = new System.Drawing.Point(0, 440);
            this.PnlPesquisa.Name = "PnlPesquisa";
            this.PnlPesquisa.Size = new System.Drawing.Size(1044, 37);
            this.PnlPesquisa.TabIndex = 9;
            this.PnlPesquisa.Visible = false;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.ForeColor = System.Drawing.Color.White;
            this.lblFornecedor.Location = new System.Drawing.Point(351, 5);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(120, 24);
            this.lblFornecedor.TabIndex = 1007;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblPesqFornecedor
            // 
            this.lblPesqFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPesqFornecedor.Location = new System.Drawing.Point(423, 9);
            this.lblPesqFornecedor.Name = "lblPesqFornecedor";
            this.lblPesqFornecedor.Size = new System.Drawing.Size(268, 20);
            this.lblPesqFornecedor.TabIndex = 1006;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 1005;
            this.label3.Text = "Nome";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox6.Image = global::WindowsFormsApp5.Properties.Resources.cancel__1_;
            this.pictureBox6.Location = new System.Drawing.Point(1006, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1004;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // lblPesq
            // 
            this.lblPesq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPesq.Location = new System.Drawing.Point(75, 10);
            this.lblPesq.Name = "lblPesq";
            this.lblPesq.Size = new System.Drawing.Size(268, 20);
            this.lblPesq.TabIndex = 1003;
            this.lblPesq.TextChanged += new System.EventHandler(this.lblPesq_TextChanged);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblMensagem.Location = new System.Drawing.Point(245, 230);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(554, 90);
            this.lblMensagem.TabIndex = 10;
            this.lblMensagem.Text = ".";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::WindowsFormsApp5.Properties.Resources.excel;
            this.pictureBox4.Location = new System.Drawing.Point(13, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(931, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(823, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(705, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // lblContador
            // 
            this.lblContador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.White;
            this.lblContador.Location = new System.Drawing.Point(70, 22);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(25, 25);
            this.lblContador.TabIndex = 1004;
            this.lblContador.Text = "0";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(587, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 31);
            this.button4.TabIndex = 1020;
            this.button4.Text = "Filtro";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.lblContador);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 63);
            this.panel2.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(132)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(466, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 31);
            this.button5.TabIndex = 1021;
            this.button5.Text = "Inserção";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // ProdutoCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 540);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.PnlPesquisa);
            this.Controls.Add(this.GridTotal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdutoCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoCRUD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.ProdutoCRUD_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRetornaCadastrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duck_DuckDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duckDuckDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRetornaCadastrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRetornaCadastrosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tloginBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTotal)).EndInit();
            this.PnlPesquisa.ResumeLayout(false);
            this.PnlPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource sRetornaCadastrosBindingSource;
        private Duck_DuckDataSet1 duck_DuckDataSet1;
        private Duck_DuckDataSet1TableAdapters.s_Retorna_CadastrosTableAdapter s_Retorna_CadastrosTableAdapter;
        private System.Windows.Forms.BindingSource duckDuckDataSetBindingSource;
        private Duck_DuckDataSet1 duck_DuckDataSet;
        private System.Windows.Forms.BindingSource tloginBindingSource;
        private Duck_DuckDataSet1TableAdapters.t_loginTableAdapter t_loginTableAdapter;
        private System.Windows.Forms.BindingSource sRetornaCadastrosBindingSource1;
        private System.Windows.Forms.BindingSource sRetornaCadastrosBindingSource2;
        private System.Windows.Forms.BindingSource tloginBindingSource2;
        private System.Windows.Forms.BindingSource tloginBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView GridTotal;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Panel PnlPesquisa;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox lblPesq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMensagem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox lblPesqFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validade;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
    }
}