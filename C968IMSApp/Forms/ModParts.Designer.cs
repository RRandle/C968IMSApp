
namespace C968IMSApp
{
    partial class ModParts
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
            this.rbModOutsource = new System.Windows.Forms.RadioButton();
            this.rbModInHouse = new System.Windows.Forms.RadioButton();
            this.modCancelBtn = new System.Windows.Forms.Button();
            this.modSaveBtn = new System.Windows.Forms.Button();
            this.modToggle = new System.Windows.Forms.TextBox();
            this.modLabelToggle = new System.Windows.Forms.Label();
            this.modPartMin = new System.Windows.Forms.TextBox();
            this.modPartMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modPartPrice = new System.Windows.Forms.TextBox();
            this.modPartInventory = new System.Windows.Forms.TextBox();
            this.modPartName = new System.Windows.Forms.TextBox();
            this.modPartID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbModOutsource
            // 
            this.rbModOutsource.AutoSize = true;
            this.rbModOutsource.Location = new System.Drawing.Point(243, 56);
            this.rbModOutsource.Name = "rbModOutsource";
            this.rbModOutsource.Size = new System.Drawing.Size(80, 17);
            this.rbModOutsource.TabIndex = 37;
            this.rbModOutsource.TabStop = true;
            this.rbModOutsource.Text = "Outsourced";
            this.rbModOutsource.UseVisualStyleBackColor = true;
            this.rbModOutsource.CheckedChanged += new System.EventHandler(this.rbModOutsource_CheckedChanged);
            // 
            // rbModInHouse
            // 
            this.rbModInHouse.AutoSize = true;
            this.rbModInHouse.Location = new System.Drawing.Point(131, 56);
            this.rbModInHouse.Name = "rbModInHouse";
            this.rbModInHouse.Size = new System.Drawing.Size(68, 17);
            this.rbModInHouse.TabIndex = 36;
            this.rbModInHouse.TabStop = true;
            this.rbModInHouse.Text = "In-House";
            this.rbModInHouse.UseVisualStyleBackColor = true;
            this.rbModInHouse.CheckedChanged += new System.EventHandler(this.rbModInHouse_CheckedChanged);
            // 
            // modCancelBtn
            // 
            this.modCancelBtn.Location = new System.Drawing.Point(347, 446);
            this.modCancelBtn.Name = "modCancelBtn";
            this.modCancelBtn.Size = new System.Drawing.Size(74, 29);
            this.modCancelBtn.TabIndex = 35;
            this.modCancelBtn.Text = "Cancel";
            this.modCancelBtn.UseVisualStyleBackColor = true;
            this.modCancelBtn.Click += new System.EventHandler(this.modCancelBtn_Click);
            // 
            // modSaveBtn
            // 
            this.modSaveBtn.Location = new System.Drawing.Point(249, 446);
            this.modSaveBtn.Name = "modSaveBtn";
            this.modSaveBtn.Size = new System.Drawing.Size(74, 29);
            this.modSaveBtn.TabIndex = 34;
            this.modSaveBtn.Text = "Save";
            this.modSaveBtn.UseVisualStyleBackColor = true;
            this.modSaveBtn.Click += new System.EventHandler(this.modSaveBtn_Click);
            // 
            // modToggle
            // 
            this.modToggle.Location = new System.Drawing.Point(166, 402);
            this.modToggle.Name = "modToggle";
            this.modToggle.Size = new System.Drawing.Size(131, 20);
            this.modToggle.TabIndex = 33;
            this.modToggle.TextChanged += new System.EventHandler(this.modToggle_TextChanged);
            // 
            // modLabelToggle
            // 
            this.modLabelToggle.AutoSize = true;
            this.modLabelToggle.Location = new System.Drawing.Point(81, 409);
            this.modLabelToggle.Name = "modLabelToggle";
            this.modLabelToggle.Size = new System.Drawing.Size(65, 13);
            this.modLabelToggle.TabIndex = 32;
            this.modLabelToggle.Text = "Machine ID:";
            // 
            // modPartMin
            // 
            this.modPartMin.Location = new System.Drawing.Point(279, 351);
            this.modPartMin.Name = "modPartMin";
            this.modPartMin.Size = new System.Drawing.Size(61, 20);
            this.modPartMin.TabIndex = 31;
            this.modPartMin.TextChanged += new System.EventHandler(this.modPartMin_TextChanged);
            // 
            // modPartMax
            // 
            this.modPartMax.Location = new System.Drawing.Point(131, 351);
            this.modPartMax.Name = "modPartMax";
            this.modPartMax.Size = new System.Drawing.Size(57, 20);
            this.modPartMax.TabIndex = 30;
            this.modPartMax.TextChanged += new System.EventHandler(this.modPartMax_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Min:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Max:";
            // 
            // modPartPrice
            // 
            this.modPartPrice.Location = new System.Drawing.Point(167, 285);
            this.modPartPrice.Name = "modPartPrice";
            this.modPartPrice.Size = new System.Drawing.Size(131, 20);
            this.modPartPrice.TabIndex = 27;
            this.modPartPrice.TextChanged += new System.EventHandler(this.modPartPrice_TextChanged);
            // 
            // modPartInventory
            // 
            this.modPartInventory.Location = new System.Drawing.Point(167, 225);
            this.modPartInventory.Name = "modPartInventory";
            this.modPartInventory.Size = new System.Drawing.Size(131, 20);
            this.modPartInventory.TabIndex = 26;
            this.modPartInventory.TextChanged += new System.EventHandler(this.modPartInventory_TextChanged);
            // 
            // modPartName
            // 
            this.modPartName.Location = new System.Drawing.Point(167, 165);
            this.modPartName.Name = "modPartName";
            this.modPartName.Size = new System.Drawing.Size(131, 20);
            this.modPartName.TabIndex = 25;
            this.modPartName.TextChanged += new System.EventHandler(this.modPartName_TextChanged);
            // 
            // modPartID
            // 
            this.modPartID.Location = new System.Drawing.Point(167, 114);
            this.modPartID.Name = "modPartID";
            this.modPartID.ReadOnly = true;
            this.modPartID.Size = new System.Drawing.Size(131, 20);
            this.modPartID.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Price / Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Inventory:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Modify Part";
            // 
            // ModParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 492);
            this.Controls.Add(this.rbModOutsource);
            this.Controls.Add(this.rbModInHouse);
            this.Controls.Add(this.modCancelBtn);
            this.Controls.Add(this.modSaveBtn);
            this.Controls.Add(this.modToggle);
            this.Controls.Add(this.modLabelToggle);
            this.Controls.Add(this.modPartMin);
            this.Controls.Add(this.modPartMax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.modPartPrice);
            this.Controls.Add(this.modPartInventory);
            this.Controls.Add(this.modPartName);
            this.Controls.Add(this.modPartID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbModOutsource;
        private System.Windows.Forms.RadioButton rbModInHouse;
        private System.Windows.Forms.Button modCancelBtn;
        private System.Windows.Forms.Button modSaveBtn;
        private System.Windows.Forms.TextBox modToggle;
        private System.Windows.Forms.Label modLabelToggle;
        private System.Windows.Forms.TextBox modPartMin;
        private System.Windows.Forms.TextBox modPartMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox modPartPrice;
        private System.Windows.Forms.TextBox modPartInventory;
        private System.Windows.Forms.TextBox modPartName;
        private System.Windows.Forms.TextBox modPartID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}