
namespace C968IMSApp.Forms
{
    partial class AddProduct
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
            this.addProdPartBtn = new System.Windows.Forms.Button();
            this.cancelAddProdBtn = new System.Windows.Forms.Button();
            this.saveProdBtn = new System.Windows.Forms.Button();
            this.delProdBtn2 = new System.Windows.Forms.Button();
            this.searchPartTextbox = new System.Windows.Forms.TextBox();
            this.searchPartAddBtn = new System.Windows.Forms.Button();
            this.dgvPartAdd = new System.Windows.Forms.DataGridView();
            this.AddPartIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPartNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPartInventoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPartPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPartMinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddPartMacColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addProdID = new System.Windows.Forms.TextBox();
            this.addProdName = new System.Windows.Forms.TextBox();
            this.addProdInventory = new System.Windows.Forms.TextBox();
            this.addProdPrice = new System.Windows.Forms.TextBox();
            this.addProdMax = new System.Windows.Forms.TextBox();
            this.addProdMin = new System.Windows.Forms.TextBox();
            this.dgvAssocParts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssocParts)).BeginInit();
            this.SuspendLayout();
            // 
            // addProdPartBtn
            // 
            this.addProdPartBtn.Location = new System.Drawing.Point(799, 178);
            this.addProdPartBtn.Name = "addProdPartBtn";
            this.addProdPartBtn.Size = new System.Drawing.Size(79, 38);
            this.addProdPartBtn.TabIndex = 29;
            this.addProdPartBtn.Text = "Add";
            this.addProdPartBtn.UseVisualStyleBackColor = true;
            this.addProdPartBtn.Click += new System.EventHandler(this.addProdPartBtn_Click);
            // 
            // cancelAddProdBtn
            // 
            this.cancelAddProdBtn.Location = new System.Drawing.Point(799, 415);
            this.cancelAddProdBtn.Name = "cancelAddProdBtn";
            this.cancelAddProdBtn.Size = new System.Drawing.Size(79, 38);
            this.cancelAddProdBtn.TabIndex = 28;
            this.cancelAddProdBtn.Text = "Cancel";
            this.cancelAddProdBtn.UseVisualStyleBackColor = true;
            this.cancelAddProdBtn.Click += new System.EventHandler(this.cancelAddProdBtn_Click);
            // 
            // saveProdBtn
            // 
            this.saveProdBtn.Location = new System.Drawing.Point(704, 415);
            this.saveProdBtn.Name = "saveProdBtn";
            this.saveProdBtn.Size = new System.Drawing.Size(79, 38);
            this.saveProdBtn.TabIndex = 27;
            this.saveProdBtn.Text = "Save";
            this.saveProdBtn.UseVisualStyleBackColor = true;
            this.saveProdBtn.Click += new System.EventHandler(this.saveProdBtn_Click);
            // 
            // delProdBtn2
            // 
            this.delProdBtn2.Location = new System.Drawing.Point(799, 347);
            this.delProdBtn2.Name = "delProdBtn2";
            this.delProdBtn2.Size = new System.Drawing.Size(79, 38);
            this.delProdBtn2.TabIndex = 26;
            this.delProdBtn2.Text = "Delete";
            this.delProdBtn2.UseVisualStyleBackColor = true;
            this.delProdBtn2.Click += new System.EventHandler(this.delProdBtn2_Click);
            // 
            // searchPartTextbox
            // 
            this.searchPartTextbox.Location = new System.Drawing.Point(704, 21);
            this.searchPartTextbox.Name = "searchPartTextbox";
            this.searchPartTextbox.Size = new System.Drawing.Size(174, 20);
            this.searchPartTextbox.TabIndex = 23;
            // 
            // searchPartAddBtn
            // 
            this.searchPartAddBtn.Location = new System.Drawing.Point(623, 19);
            this.searchPartAddBtn.Name = "searchPartAddBtn";
            this.searchPartAddBtn.Size = new System.Drawing.Size(75, 23);
            this.searchPartAddBtn.TabIndex = 21;
            this.searchPartAddBtn.Text = "Search";
            this.searchPartAddBtn.UseVisualStyleBackColor = true;
            this.searchPartAddBtn.Click += new System.EventHandler(this.searchPartAddBtn_Click);
            // 
            // dgvPartAdd
            // 
            this.dgvPartAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddPartIDColumn,
            this.AddPartNameColumn,
            this.AddPartInventoryColumn,
            this.AddPartPriceColumn,
            this.AddPartMinColumn,
            this.AddPartMacColumn});
            this.dgvPartAdd.Location = new System.Drawing.Point(459, 63);
            this.dgvPartAdd.MultiSelect = false;
            this.dgvPartAdd.Name = "dgvPartAdd";
            this.dgvPartAdd.ReadOnly = true;
            this.dgvPartAdd.RowHeadersVisible = false;
            this.dgvPartAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartAdd.Size = new System.Drawing.Size(419, 109);
            this.dgvPartAdd.TabIndex = 19;
            // 
            // AddPartIDColumn
            // 
            this.AddPartIDColumn.DataPropertyName = "partID";
            this.AddPartIDColumn.HeaderText = "Part ID";
            this.AddPartIDColumn.Name = "AddPartIDColumn";
            this.AddPartIDColumn.ReadOnly = true;
            this.AddPartIDColumn.Width = 75;
            // 
            // AddPartNameColumn
            // 
            this.AddPartNameColumn.DataPropertyName = "partName";
            this.AddPartNameColumn.HeaderText = "Name";
            this.AddPartNameColumn.Name = "AddPartNameColumn";
            this.AddPartNameColumn.ReadOnly = true;
            this.AddPartNameColumn.Width = 75;
            // 
            // AddPartInventoryColumn
            // 
            this.AddPartInventoryColumn.DataPropertyName = "partInvtry";
            this.AddPartInventoryColumn.HeaderText = "Inventory";
            this.AddPartInventoryColumn.Name = "AddPartInventoryColumn";
            this.AddPartInventoryColumn.ReadOnly = true;
            this.AddPartInventoryColumn.Width = 74;
            // 
            // AddPartPriceColumn
            // 
            this.AddPartPriceColumn.DataPropertyName = "partPrice";
            this.AddPartPriceColumn.HeaderText = "Price";
            this.AddPartPriceColumn.Name = "AddPartPriceColumn";
            this.AddPartPriceColumn.ReadOnly = true;
            this.AddPartPriceColumn.Width = 75;
            // 
            // AddPartMinColumn
            // 
            this.AddPartMinColumn.DataPropertyName = "partMin";
            this.AddPartMinColumn.HeaderText = "Min";
            this.AddPartMinColumn.Name = "AddPartMinColumn";
            this.AddPartMinColumn.ReadOnly = true;
            this.AddPartMinColumn.Width = 50;
            // 
            // AddPartMacColumn
            // 
            this.AddPartMacColumn.DataPropertyName = "partMax";
            this.AddPartMacColumn.HeaderText = "Max";
            this.AddPartMacColumn.Name = "AddPartMacColumn";
            this.AddPartMacColumn.ReadOnly = true;
            this.AddPartMacColumn.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "All candidate Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Associated Parts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Inventory:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Max:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Min:";
            // 
            // addProdID
            // 
            this.addProdID.Location = new System.Drawing.Point(84, 84);
            this.addProdID.Name = "addProdID";
            this.addProdID.ReadOnly = true;
            this.addProdID.Size = new System.Drawing.Size(126, 20);
            this.addProdID.TabIndex = 39;
            // 
            // addProdName
            // 
            this.addProdName.BackColor = System.Drawing.Color.Firebrick;
            this.addProdName.Location = new System.Drawing.Point(84, 131);
            this.addProdName.Name = "addProdName";
            this.addProdName.Size = new System.Drawing.Size(126, 20);
            this.addProdName.TabIndex = 40;
            this.addProdName.TextChanged += new System.EventHandler(this.addProdName_TextChanged);
            // 
            // addProdInventory
            // 
            this.addProdInventory.BackColor = System.Drawing.Color.Firebrick;
            this.addProdInventory.Location = new System.Drawing.Point(84, 175);
            this.addProdInventory.Name = "addProdInventory";
            this.addProdInventory.Size = new System.Drawing.Size(126, 20);
            this.addProdInventory.TabIndex = 41;
            this.addProdInventory.TextChanged += new System.EventHandler(this.addProdInventory_TextChanged);
            // 
            // addProdPrice
            // 
            this.addProdPrice.BackColor = System.Drawing.Color.Firebrick;
            this.addProdPrice.Location = new System.Drawing.Point(84, 213);
            this.addProdPrice.Name = "addProdPrice";
            this.addProdPrice.Size = new System.Drawing.Size(126, 20);
            this.addProdPrice.TabIndex = 42;
            this.addProdPrice.TextChanged += new System.EventHandler(this.addProdPrice_TextChanged);
            // 
            // addProdMax
            // 
            this.addProdMax.BackColor = System.Drawing.Color.Firebrick;
            this.addProdMax.Location = new System.Drawing.Point(50, 258);
            this.addProdMax.Name = "addProdMax";
            this.addProdMax.Size = new System.Drawing.Size(44, 20);
            this.addProdMax.TabIndex = 43;
            this.addProdMax.TextChanged += new System.EventHandler(this.addProdMax_TextChanged);
            // 
            // addProdMin
            // 
            this.addProdMin.BackColor = System.Drawing.Color.Firebrick;
            this.addProdMin.Location = new System.Drawing.Point(205, 258);
            this.addProdMin.Name = "addProdMin";
            this.addProdMin.Size = new System.Drawing.Size(44, 20);
            this.addProdMin.TabIndex = 44;
            this.addProdMin.TextChanged += new System.EventHandler(this.addProdMin_TextChanged);
            // 
            // dgvAssocParts
            // 
            this.dgvAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssocParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvAssocParts.Location = new System.Drawing.Point(459, 232);
            this.dgvAssocParts.MultiSelect = false;
            this.dgvAssocParts.Name = "dgvAssocParts";
            this.dgvAssocParts.ReadOnly = true;
            this.dgvAssocParts.RowHeadersVisible = false;
            this.dgvAssocParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssocParts.Size = new System.Drawing.Size(419, 109);
            this.dgvAssocParts.TabIndex = 45;
            this.dgvAssocParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssocPart_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "partID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "partName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "partInvtry";
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "partPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "partMin";
            this.dataGridViewTextBoxColumn5.HeaderText = "Min";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "partMax";
            this.dataGridViewTextBoxColumn6.HeaderText = "Max";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 465);
            this.Controls.Add(this.dgvAssocParts);
            this.Controls.Add(this.addProdMin);
            this.Controls.Add(this.addProdMax);
            this.Controls.Add(this.addProdPrice);
            this.Controls.Add(this.addProdInventory);
            this.Controls.Add(this.addProdName);
            this.Controls.Add(this.addProdID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addProdPartBtn);
            this.Controls.Add(this.cancelAddProdBtn);
            this.Controls.Add(this.saveProdBtn);
            this.Controls.Add(this.delProdBtn2);
            this.Controls.Add(this.searchPartTextbox);
            this.Controls.Add(this.searchPartAddBtn);
            this.Controls.Add(this.dgvPartAdd);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssocParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProdPartBtn;
        private System.Windows.Forms.Button cancelAddProdBtn;
        private System.Windows.Forms.Button saveProdBtn;
        private System.Windows.Forms.Button delProdBtn2;
        private System.Windows.Forms.TextBox searchPartTextbox;
        private System.Windows.Forms.Button searchPartAddBtn;
        private System.Windows.Forms.DataGridView dgvPartAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addProdID;
        private System.Windows.Forms.TextBox addProdName;
        private System.Windows.Forms.TextBox addProdInventory;
        private System.Windows.Forms.TextBox addProdPrice;
        private System.Windows.Forms.TextBox addProdMax;
        private System.Windows.Forms.TextBox addProdMin;
        private System.Windows.Forms.DataGridView dgvAssocParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddPartIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddPartNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddPartInventoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddPartPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddPartMinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddPartMacColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}