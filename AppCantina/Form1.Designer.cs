namespace AppCantina
{
    partial class FormPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEncerrarVenda = new System.Windows.Forms.Button();
            this.btnVenderItem = new System.Windows.Forms.Button();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridItensVenda = new System.Windows.Forms.DataGridView();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensVendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsItensVenda = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEncerrarVenda);
            this.panel1.Controls.Add(this.btnVenderItem);
            this.panel1.Controls.Add(this.btnNovaVenda);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 59);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Excluir Item Del";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEncerrarVenda
            // 
            this.btnEncerrarVenda.Location = new System.Drawing.Point(448, 20);
            this.btnEncerrarVenda.Name = "btnEncerrarVenda";
            this.btnEncerrarVenda.Size = new System.Drawing.Size(125, 59);
            this.btnEncerrarVenda.TabIndex = 2;
            this.btnEncerrarVenda.Text = "Encerrar Venda Venda F10";
            this.btnEncerrarVenda.UseVisualStyleBackColor = true;
            this.btnEncerrarVenda.Click += new System.EventHandler(this.btnEncerrarVenda_Click);
            // 
            // btnVenderItem
            // 
            this.btnVenderItem.Location = new System.Drawing.Point(163, 20);
            this.btnVenderItem.Name = "btnVenderItem";
            this.btnVenderItem.Size = new System.Drawing.Size(125, 59);
            this.btnVenderItem.TabIndex = 1;
            this.btnVenderItem.Text = "Vender Item F5";
            this.btnVenderItem.UseVisualStyleBackColor = true;
            this.btnVenderItem.Click += new System.EventHandler(this.btnVenderItem_Click);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(23, 20);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(125, 59);
            this.btnNovaVenda.TabIndex = 0;
            this.btnNovaVenda.Text = "Nova Venda F2";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridItensVenda);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 263);
            this.panel2.TabIndex = 1;
            // 
            // gridItensVenda
            // 
            this.gridItensVenda.AllowUserToAddRows = false;
            this.gridItensVenda.AutoGenerateColumns = false;
            this.gridItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.gridItensVenda.DataSource = this.itensVendaBindingSource1;
            this.gridItensVenda.Location = new System.Drawing.Point(3, 3);
            this.gridItensVenda.Name = "gridItensVenda";
            this.gridItensVenda.ReadOnly = true;
            this.gridItensVenda.Size = new System.Drawing.Size(594, 257);
            this.gridItensVenda.TabIndex = 0;
            this.gridItensVenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItensVenda_CellClick);
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "R$ Unitário";
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            this.valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "R$ Total";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itensVendaBindingSource1
            // 
            this.itensVendaBindingSource1.DataMember = "ItensVenda";
            this.itensVendaBindingSource1.DataSource = this.itensVendaBindingSource;
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.AllowNew = false;
            this.itensVendaBindingSource.DataSource = this.dsItensVenda;
            this.itensVendaBindingSource.Position = 0;
            // 
            // dsItensVenda
            // 
            this.dsItensVenda.DataSetName = "dsitensVenda";
            this.dsItensVenda.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.dataTable1.TableName = "ItensVenda";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "ItemId";
            this.dataColumn1.DataType = typeof(short);
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Produto";
            this.dataColumn2.ColumnName = "Produto";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Quantidade";
            this.dataColumn3.ColumnName = "Quantidade";
            this.dataColumn3.DataType = typeof(short);
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "ValorUnitario";
            this.dataColumn4.ColumnName = "ValorUnitario";
            this.dataColumn4.DataType = typeof(decimal);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "ValorTotal";
            this.dataColumn5.DataType = typeof(decimal);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 54);
            this.panel3.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(448, 16);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(138, 26);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda de Itens";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncerrarVenda;
        private System.Windows.Forms.Button btnVenderItem;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.DataGridView gridItensVenda;
        private System.Data.DataSet dsItensVenda;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.BindingSource itensVendaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;

    }
}

