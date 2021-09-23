
namespace C968IMSApp
{
    partial class HomeScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.idPartsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInventoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.prodIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodInventoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodMinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodMaxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchPartsBtn = new System.Windows.Forms.Button();
            this.prodSearchBtn = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.prodsearchTextbox = new System.Windows.Forms.TextBox();
            this.addPartBtn = new System.Windows.Forms.Button();
            this.modPartBtn = new System.Windows.Forms.Button();
            this.delPartBtn = new System.Windows.Forms.Button();
            this.delProdBtn = new System.Windows.Forms.Button();
            this.modProdBtn = new System.Windows.Forms.Button();
            this.addProdBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Products";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPartsColumn,
            this.partNameColumn,
            this.partInventoryColumn,
            this.partPriceColumn,
            this.partMinColumn,
            this.partMax});
            this.dgvParts.Location = new System.Drawing.Point(12, 99);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(419, 191);
            this.dgvParts.TabIndex = 3;
            this.dgvParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParts_CellClick);
            this.dgvParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.firstLoadSelect);
            // 
            // idPartsColumn
            // 
            this.idPartsColumn.DataPropertyName = "partID";
            this.idPartsColumn.HeaderText = "Part ID";
            this.idPartsColumn.Name = "idPartsColumn";
            this.idPartsColumn.ReadOnly = true;
            this.idPartsColumn.Width = 75;
            // 
            // partNameColumn
            // 
            this.partNameColumn.DataPropertyName = "partName";
            this.partNameColumn.HeaderText = "Name";
            this.partNameColumn.Name = "partNameColumn";
            this.partNameColumn.ReadOnly = true;
            // 
            // partInventoryColumn
            // 
            this.partInventoryColumn.DataPropertyName = "partInvtry";
            this.partInventoryColumn.HeaderText = "Inventory";
            this.partInventoryColumn.Name = "partInventoryColumn";
            this.partInventoryColumn.ReadOnly = true;
            this.partInventoryColumn.Width = 66;
            // 
            // partPriceColumn
            // 
            this.partPriceColumn.DataPropertyName = "partPrice";
            this.partPriceColumn.HeaderText = "Price";
            this.partPriceColumn.Name = "partPriceColumn";
            this.partPriceColumn.ReadOnly = true;
            this.partPriceColumn.Width = 75;
            // 
            // partMinColumn
            // 
            this.partMinColumn.DataPropertyName = "partMin";
            this.partMinColumn.HeaderText = "Min";
            this.partMinColumn.Name = "partMinColumn";
            this.partMinColumn.ReadOnly = true;
            this.partMinColumn.Width = 50;
            // 
            // partMax
            // 
            this.partMax.DataPropertyName = "partMax";
            this.partMax.HeaderText = "Max";
            this.partMax.Name = "partMax";
            this.partMax.ReadOnly = true;
            this.partMax.Width = 50;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDColumn,
            this.prodName,
            this.prodInventoryColumn,
            this.prodPriceColumn,
            this.prodMinColumn,
            this.prodMaxColumn});
            this.dgvProducts.Location = new System.Drawing.Point(459, 99);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(419, 191);
            this.dgvProducts.TabIndex = 4;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.firstProdLoaded);
            // 
            // prodIDColumn
            // 
            this.prodIDColumn.DataPropertyName = "prodID";
            this.prodIDColumn.HeaderText = "Product ID";
            this.prodIDColumn.Name = "prodIDColumn";
            this.prodIDColumn.ReadOnly = true;
            this.prodIDColumn.Width = 85;
            // 
            // prodName
            // 
            this.prodName.DataPropertyName = "prodName";
            this.prodName.HeaderText = "Name";
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            this.prodName.Width = 85;
            // 
            // prodInventoryColumn
            // 
            this.prodInventoryColumn.DataPropertyName = "prodInvntry";
            this.prodInventoryColumn.HeaderText = "Inventory";
            this.prodInventoryColumn.Name = "prodInventoryColumn";
            this.prodInventoryColumn.ReadOnly = true;
            this.prodInventoryColumn.Width = 71;
            // 
            // prodPriceColumn
            // 
            this.prodPriceColumn.DataPropertyName = "prodPrice";
            this.prodPriceColumn.HeaderText = "Price";
            this.prodPriceColumn.Name = "prodPriceColumn";
            this.prodPriceColumn.ReadOnly = true;
            this.prodPriceColumn.Width = 75;
            // 
            // prodMinColumn
            // 
            this.prodMinColumn.DataPropertyName = "prodMin";
            this.prodMinColumn.HeaderText = "Min";
            this.prodMinColumn.Name = "prodMinColumn";
            this.prodMinColumn.ReadOnly = true;
            this.prodMinColumn.Width = 50;
            // 
            // prodMaxColumn
            // 
            this.prodMaxColumn.DataPropertyName = "prodMax";
            this.prodMaxColumn.HeaderText = "Max";
            this.prodMaxColumn.Name = "prodMaxColumn";
            this.prodMaxColumn.ReadOnly = true;
            this.prodMaxColumn.Width = 50;
            // 
            // searchPartsBtn
            // 
            this.searchPartsBtn.Location = new System.Drawing.Point(169, 54);
            this.searchPartsBtn.Name = "searchPartsBtn";
            this.searchPartsBtn.Size = new System.Drawing.Size(75, 23);
            this.searchPartsBtn.TabIndex = 5;
            this.searchPartsBtn.Text = "Search";
            this.searchPartsBtn.UseVisualStyleBackColor = true;
            this.searchPartsBtn.Click += new System.EventHandler(this.searchPartsBtn_Click);
            // 
            // prodSearchBtn
            // 
            this.prodSearchBtn.Location = new System.Drawing.Point(593, 56);
            this.prodSearchBtn.Name = "prodSearchBtn";
            this.prodSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.prodSearchBtn.TabIndex = 6;
            this.prodSearchBtn.Text = "Search";
            this.prodSearchBtn.UseVisualStyleBackColor = true;
            this.prodSearchBtn.Click += new System.EventHandler(this.prodSearchBtn_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(263, 57);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(174, 20);
            this.searchTextbox.TabIndex = 7;
            // 
            // prodsearchTextbox
            // 
            this.prodsearchTextbox.Location = new System.Drawing.Point(704, 54);
            this.prodsearchTextbox.Name = "prodsearchTextbox";
            this.prodsearchTextbox.Size = new System.Drawing.Size(174, 20);
            this.prodsearchTextbox.TabIndex = 8;
            // 
            // addPartBtn
            // 
            this.addPartBtn.Location = new System.Drawing.Point(156, 296);
            this.addPartBtn.Name = "addPartBtn";
            this.addPartBtn.Size = new System.Drawing.Size(79, 38);
            this.addPartBtn.TabIndex = 9;
            this.addPartBtn.Text = "Add";
            this.addPartBtn.UseVisualStyleBackColor = true;
            this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
            // 
            // modPartBtn
            // 
            this.modPartBtn.Location = new System.Drawing.Point(254, 296);
            this.modPartBtn.Name = "modPartBtn";
            this.modPartBtn.Size = new System.Drawing.Size(79, 38);
            this.modPartBtn.TabIndex = 10;
            this.modPartBtn.Text = "Modify";
            this.modPartBtn.UseVisualStyleBackColor = true;
            this.modPartBtn.Click += new System.EventHandler(this.modPartBtn_Click);
            // 
            // delPartBtn
            // 
            this.delPartBtn.Location = new System.Drawing.Point(352, 296);
            this.delPartBtn.Name = "delPartBtn";
            this.delPartBtn.Size = new System.Drawing.Size(79, 38);
            this.delPartBtn.TabIndex = 11;
            this.delPartBtn.Text = "Delete";
            this.delPartBtn.UseVisualStyleBackColor = true;
            this.delPartBtn.Click += new System.EventHandler(this.delPartBtn_Click);
            // 
            // delProdBtn
            // 
            this.delProdBtn.Location = new System.Drawing.Point(799, 296);
            this.delProdBtn.Name = "delProdBtn";
            this.delProdBtn.Size = new System.Drawing.Size(79, 38);
            this.delProdBtn.TabIndex = 12;
            this.delProdBtn.Text = "Delete";
            this.delProdBtn.UseVisualStyleBackColor = true;
            this.delProdBtn.Click += new System.EventHandler(this.delProdBtn_Click);
            // 
            // modProdBtn
            // 
            this.modProdBtn.Location = new System.Drawing.Point(704, 296);
            this.modProdBtn.Name = "modProdBtn";
            this.modProdBtn.Size = new System.Drawing.Size(79, 38);
            this.modProdBtn.TabIndex = 13;
            this.modProdBtn.Text = "Modify";
            this.modProdBtn.UseVisualStyleBackColor = true;
            this.modProdBtn.Click += new System.EventHandler(this.modProdBtn_Click);
            // 
            // addProdBtn
            // 
            this.addProdBtn.Location = new System.Drawing.Point(608, 296);
            this.addProdBtn.Name = "addProdBtn";
            this.addProdBtn.Size = new System.Drawing.Size(79, 38);
            this.addProdBtn.TabIndex = 14;
            this.addProdBtn.Text = "Add";
            this.addProdBtn.UseVisualStyleBackColor = true;
            this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(799, 415);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(79, 38);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 465);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addProdBtn);
            this.Controls.Add(this.modProdBtn);
            this.Controls.Add(this.delProdBtn);
            this.Controls.Add(this.delPartBtn);
            this.Controls.Add(this.modPartBtn);
            this.Controls.Add(this.addPartBtn);
            this.Controls.Add(this.prodsearchTextbox);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.prodSearchBtn);
            this.Controls.Add(this.searchPartsBtn);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button searchPartsBtn;
        private System.Windows.Forms.Button prodSearchBtn;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.TextBox prodsearchTextbox;
        private System.Windows.Forms.Button addPartBtn;
        private System.Windows.Forms.Button modPartBtn;
        private System.Windows.Forms.Button delPartBtn;
        private System.Windows.Forms.Button delProdBtn;
        private System.Windows.Forms.Button modProdBtn;
        private System.Windows.Forms.Button addProdBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPartsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partInventoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodInventoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodMinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodMaxColumn;
    }
}

