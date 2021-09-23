
namespace C968IMSApp.Forms
{
    partial class ModProduct
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
            this.modProdMin = new System.Windows.Forms.TextBox();
            this.modProdMax = new System.Windows.Forms.TextBox();
            this.modProdPrice = new System.Windows.Forms.TextBox();
            this.modProdInventory = new System.Windows.Forms.TextBox();
            this.modProdName = new System.Windows.Forms.TextBox();
            this.modProdID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addProdBtn2 = new System.Windows.Forms.Button();
            this.cancelProdBtn = new System.Windows.Forms.Button();
            this.saveProdBtn = new System.Windows.Forms.Button();
            this.delAssociateBtn = new System.Windows.Forms.Button();
            this.searchModPartTextbox = new System.Windows.Forms.TextBox();
            this.modPartSearchBtn = new System.Windows.Forms.Button();
            this.dgvAllProd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.prodIDColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdInventoryColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPriceColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdMinColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdMaxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAssociatedPart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedPart)).BeginInit();
            this.SuspendLayout();
            // 
            // modProdMin
            // 
            this.modProdMin.Location = new System.Drawing.Point(205, 255);
            this.modProdMin.Name = "modProdMin";
            this.modProdMin.Size = new System.Drawing.Size(44, 20);
            this.modProdMin.TabIndex = 67;
            this.modProdMin.TextChanged += new System.EventHandler(this.modProdMin_TextChanged);
            // 
            // modProdMax
            // 
            this.modProdMax.Location = new System.Drawing.Point(50, 255);
            this.modProdMax.Name = "modProdMax";
            this.modProdMax.Size = new System.Drawing.Size(44, 20);
            this.modProdMax.TabIndex = 66;
            this.modProdMax.TextChanged += new System.EventHandler(this.modProdMax_TextChanged);
            // 
            // modProdPrice
            // 
            this.modProdPrice.Location = new System.Drawing.Point(84, 210);
            this.modProdPrice.Name = "modProdPrice";
            this.modProdPrice.Size = new System.Drawing.Size(126, 20);
            this.modProdPrice.TabIndex = 65;
            this.modProdPrice.TextChanged += new System.EventHandler(this.modProdPrice_TextChanged);
            // 
            // modProdInventory
            // 
            this.modProdInventory.Location = new System.Drawing.Point(84, 172);
            this.modProdInventory.Name = "modProdInventory";
            this.modProdInventory.Size = new System.Drawing.Size(126, 20);
            this.modProdInventory.TabIndex = 64;
            this.modProdInventory.TextChanged += new System.EventHandler(this.modProdInventory_TextChanged);
            // 
            // modProdName
            // 
            this.modProdName.Location = new System.Drawing.Point(84, 128);
            this.modProdName.Name = "modProdName";
            this.modProdName.Size = new System.Drawing.Size(126, 20);
            this.modProdName.TabIndex = 63;
            this.modProdName.TextChanged += new System.EventHandler(this.modProdName_TextChanged);
            // 
            // modProdID
            // 
            this.modProdID.Location = new System.Drawing.Point(84, 81);
            this.modProdID.Name = "modProdID";
            this.modProdID.ReadOnly = true;
            this.modProdID.Size = new System.Drawing.Size(126, 20);
            this.modProdID.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Min:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Inventory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Associated Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "All candidate Parts";
            // 
            // addProdBtn2
            // 
            this.addProdBtn2.Location = new System.Drawing.Point(799, 175);
            this.addProdBtn2.Name = "addProdBtn2";
            this.addProdBtn2.Size = new System.Drawing.Size(79, 38);
            this.addProdBtn2.TabIndex = 52;
            this.addProdBtn2.Text = "Add";
            this.addProdBtn2.UseVisualStyleBackColor = true;
            this.addProdBtn2.Click += new System.EventHandler(this.addProdBtn2_Click);
            // 
            // cancelProdBtn
            // 
            this.cancelProdBtn.Location = new System.Drawing.Point(799, 412);
            this.cancelProdBtn.Name = "cancelProdBtn";
            this.cancelProdBtn.Size = new System.Drawing.Size(79, 38);
            this.cancelProdBtn.TabIndex = 51;
            this.cancelProdBtn.Text = "Cancel";
            this.cancelProdBtn.UseVisualStyleBackColor = true;
            this.cancelProdBtn.Click += new System.EventHandler(this.cancelProdBtn_Click);
            // 
            // saveProdBtn
            // 
            this.saveProdBtn.Location = new System.Drawing.Point(704, 412);
            this.saveProdBtn.Name = "saveProdBtn";
            this.saveProdBtn.Size = new System.Drawing.Size(79, 38);
            this.saveProdBtn.TabIndex = 50;
            this.saveProdBtn.Text = "Save";
            this.saveProdBtn.UseVisualStyleBackColor = true;
            this.saveProdBtn.Click += new System.EventHandler(this.saveProdBtn_Click);
            // 
            // delAssociateBtn
            // 
            this.delAssociateBtn.Location = new System.Drawing.Point(799, 344);
            this.delAssociateBtn.Name = "delAssociateBtn";
            this.delAssociateBtn.Size = new System.Drawing.Size(79, 38);
            this.delAssociateBtn.TabIndex = 49;
            this.delAssociateBtn.Text = "Delete";
            this.delAssociateBtn.UseVisualStyleBackColor = true;
            this.delAssociateBtn.Click += new System.EventHandler(this.delAssociateBtn_Click);
            // 
            // searchModPartTextbox
            // 
            this.searchModPartTextbox.Location = new System.Drawing.Point(704, 18);
            this.searchModPartTextbox.Name = "searchModPartTextbox";
            this.searchModPartTextbox.Size = new System.Drawing.Size(174, 20);
            this.searchModPartTextbox.TabIndex = 48;
            // 
            // modPartSearchBtn
            // 
            this.modPartSearchBtn.Location = new System.Drawing.Point(623, 16);
            this.modPartSearchBtn.Name = "modPartSearchBtn";
            this.modPartSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.modPartSearchBtn.TabIndex = 47;
            this.modPartSearchBtn.Text = "Search";
            this.modPartSearchBtn.UseVisualStyleBackColor = true;
            this.modPartSearchBtn.Click += new System.EventHandler(this.modPartSearchBtn_Click);
            // 
            // dgvAllProd
            // 
            this.dgvAllProd.AllowUserToAddRows = false;
            this.dgvAllProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIDColumn1,
            this.prodNameColumn2,
            this.ProdInventoryColumn3,
            this.ProdPriceColumn4,
            this.ProdMinColumn5,
            this.ProdMaxColumn6});
            this.dgvAllProd.Location = new System.Drawing.Point(459, 60);
            this.dgvAllProd.MultiSelect = false;
            this.dgvAllProd.Name = "dgvAllProd";
            this.dgvAllProd.ReadOnly = true;
            this.dgvAllProd.RowHeadersVisible = false;
            this.dgvAllProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProd.Size = new System.Drawing.Size(419, 109);
            this.dgvAllProd.TabIndex = 46;
            this.dgvAllProd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.allCandidatePartsLoad);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 45;
            this.label1.Text = "Modify Product";
            // 
            // prodIDColumn1
            // 
            this.prodIDColumn1.DataPropertyName = "partID";
            this.prodIDColumn1.HeaderText = "Part ID";
            this.prodIDColumn1.Name = "prodIDColumn1";
            this.prodIDColumn1.ReadOnly = true;
            this.prodIDColumn1.Width = 75;
            // 
            // prodNameColumn2
            // 
            this.prodNameColumn2.DataPropertyName = "partName";
            this.prodNameColumn2.HeaderText = "Name";
            this.prodNameColumn2.Name = "prodNameColumn2";
            this.prodNameColumn2.ReadOnly = true;
            this.prodNameColumn2.Width = 79;
            // 
            // ProdInventoryColumn3
            // 
            this.ProdInventoryColumn3.DataPropertyName = "partInvtry";
            this.ProdInventoryColumn3.HeaderText = "Inventory";
            this.ProdInventoryColumn3.Name = "ProdInventoryColumn3";
            this.ProdInventoryColumn3.ReadOnly = true;
            this.ProdInventoryColumn3.Width = 65;
            // 
            // ProdPriceColumn4
            // 
            this.ProdPriceColumn4.DataPropertyName = "partPrice";
            this.ProdPriceColumn4.HeaderText = "Price";
            this.ProdPriceColumn4.Name = "ProdPriceColumn4";
            this.ProdPriceColumn4.ReadOnly = true;
            this.ProdPriceColumn4.Width = 80;
            // 
            // ProdMinColumn5
            // 
            this.ProdMinColumn5.DataPropertyName = "partMin";
            this.ProdMinColumn5.HeaderText = "Min";
            this.ProdMinColumn5.Name = "ProdMinColumn5";
            this.ProdMinColumn5.ReadOnly = true;
            this.ProdMinColumn5.Width = 50;
            // 
            // ProdMaxColumn6
            // 
            this.ProdMaxColumn6.DataPropertyName = "partMax";
            this.ProdMaxColumn6.HeaderText = "Max";
            this.ProdMaxColumn6.Name = "ProdMaxColumn6";
            this.ProdMaxColumn6.ReadOnly = true;
            this.ProdMaxColumn6.Width = 50;
            // 
            // dgvAssociatedPart
            // 
            this.dgvAssociatedPart.AllowUserToAddRows = false;
            this.dgvAssociatedPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvAssociatedPart.Location = new System.Drawing.Point(459, 229);
            this.dgvAssociatedPart.MultiSelect = false;
            this.dgvAssociatedPart.Name = "dgvAssociatedPart";
            this.dgvAssociatedPart.ReadOnly = true;
            this.dgvAssociatedPart.RowHeadersVisible = false;
            this.dgvAssociatedPart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssociatedPart.Size = new System.Drawing.Size(419, 109);
            this.dgvAssociatedPart.TabIndex = 68;
            this.dgvAssociatedPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssociateCellClick);
            this.dgvAssociatedPart.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.assocPartsLoaded);
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
            this.dataGridViewTextBoxColumn2.Width = 79;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "partInvtry";
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 65;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "partPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
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
            // ModProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 465);
            this.Controls.Add(this.dgvAssociatedPart);
            this.Controls.Add(this.modProdMin);
            this.Controls.Add(this.modProdMax);
            this.Controls.Add(this.modProdPrice);
            this.Controls.Add(this.modProdInventory);
            this.Controls.Add(this.modProdName);
            this.Controls.Add(this.modProdID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addProdBtn2);
            this.Controls.Add(this.cancelProdBtn);
            this.Controls.Add(this.saveProdBtn);
            this.Controls.Add(this.delAssociateBtn);
            this.Controls.Add(this.searchModPartTextbox);
            this.Controls.Add(this.modPartSearchBtn);
            this.Controls.Add(this.dgvAllProd);
            this.Controls.Add(this.label1);
            this.Name = "ModProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modProdMin;
        private System.Windows.Forms.TextBox modProdMax;
        private System.Windows.Forms.TextBox modProdPrice;
        private System.Windows.Forms.TextBox modProdInventory;
        private System.Windows.Forms.TextBox modProdName;
        private System.Windows.Forms.TextBox modProdID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addProdBtn2;
        private System.Windows.Forms.Button cancelProdBtn;
        private System.Windows.Forms.Button saveProdBtn;
        private System.Windows.Forms.Button delAssociateBtn;
        private System.Windows.Forms.TextBox searchModPartTextbox;
        private System.Windows.Forms.Button modPartSearchBtn;
        private System.Windows.Forms.DataGridView dgvAllProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIDColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdInventoryColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPriceColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdMinColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdMaxColumn6;
        private System.Windows.Forms.DataGridView dgvAssociatedPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}