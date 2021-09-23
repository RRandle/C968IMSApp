
namespace C968IMSApp
{
    partial class AddPart
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addPartID = new System.Windows.Forms.TextBox();
            this.addPartName = new System.Windows.Forms.TextBox();
            this.addPartInventory = new System.Windows.Forms.TextBox();
            this.addPartPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addPartMax = new System.Windows.Forms.TextBox();
            this.addPartMin = new System.Windows.Forms.TextBox();
            this.addPartsLabel = new System.Windows.Forms.Label();
            this.addToggle = new System.Windows.Forms.TextBox();
            this.savePartBtn = new System.Windows.Forms.Button();
            this.addCancelBtn = new System.Windows.Forms.Button();
            this.rbInHouse = new System.Windows.Forms.RadioButton();
            this.rbOutsource = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inventory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price / Cost:";
            // 
            // addPartID
            // 
            this.addPartID.Location = new System.Drawing.Point(160, 106);
            this.addPartID.Name = "addPartID";
            this.addPartID.ReadOnly = true;
            this.addPartID.Size = new System.Drawing.Size(131, 20);
            this.addPartID.TabIndex = 5;
            // 
            // addPartName
            // 
            this.addPartName.BackColor = System.Drawing.Color.Firebrick;
            this.addPartName.Location = new System.Drawing.Point(160, 157);
            this.addPartName.Name = "addPartName";
            this.addPartName.Size = new System.Drawing.Size(131, 20);
            this.addPartName.TabIndex = 6;
            this.addPartName.TextChanged += new System.EventHandler(this.addPartName_TextChanged);
            // 
            // addPartInventory
            // 
            this.addPartInventory.BackColor = System.Drawing.Color.Firebrick;
            this.addPartInventory.Location = new System.Drawing.Point(160, 217);
            this.addPartInventory.Name = "addPartInventory";
            this.addPartInventory.Size = new System.Drawing.Size(131, 20);
            this.addPartInventory.TabIndex = 7;
            this.addPartInventory.TextChanged += new System.EventHandler(this.addPartInventory_TextChanged);
            // 
            // addPartPrice
            // 
            this.addPartPrice.BackColor = System.Drawing.Color.Firebrick;
            this.addPartPrice.Location = new System.Drawing.Point(160, 277);
            this.addPartPrice.Name = "addPartPrice";
            this.addPartPrice.Size = new System.Drawing.Size(131, 20);
            this.addPartPrice.TabIndex = 8;
            this.addPartPrice.TextChanged += new System.EventHandler(this.addPartPrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Min:";
            // 
            // addPartMax
            // 
            this.addPartMax.BackColor = System.Drawing.Color.Firebrick;
            this.addPartMax.Location = new System.Drawing.Point(124, 343);
            this.addPartMax.Name = "addPartMax";
            this.addPartMax.Size = new System.Drawing.Size(57, 20);
            this.addPartMax.TabIndex = 11;
            this.addPartMax.TextChanged += new System.EventHandler(this.addPartMax_TextChanged);
            // 
            // addPartMin
            // 
            this.addPartMin.BackColor = System.Drawing.Color.Firebrick;
            this.addPartMin.Location = new System.Drawing.Point(272, 343);
            this.addPartMin.Name = "addPartMin";
            this.addPartMin.Size = new System.Drawing.Size(61, 20);
            this.addPartMin.TabIndex = 12;
            this.addPartMin.TextChanged += new System.EventHandler(this.addPartMin_TextChanged);
            // 
            // addPartsLabel
            // 
            this.addPartsLabel.AutoSize = true;
            this.addPartsLabel.Location = new System.Drawing.Point(61, 401);
            this.addPartsLabel.Name = "addPartsLabel";
            this.addPartsLabel.Size = new System.Drawing.Size(65, 13);
            this.addPartsLabel.TabIndex = 13;
            this.addPartsLabel.Text = "Machine ID:";
            // 
            // addToggle
            // 
            this.addToggle.BackColor = System.Drawing.Color.Firebrick;
            this.addToggle.Location = new System.Drawing.Point(159, 394);
            this.addToggle.Name = "addToggle";
            this.addToggle.Size = new System.Drawing.Size(131, 20);
            this.addToggle.TabIndex = 14;
            this.addToggle.TextChanged += new System.EventHandler(this.addToggle_TextChanged);
            // 
            // savePartBtn
            // 
            this.savePartBtn.Location = new System.Drawing.Point(242, 438);
            this.savePartBtn.Name = "savePartBtn";
            this.savePartBtn.Size = new System.Drawing.Size(74, 29);
            this.savePartBtn.TabIndex = 15;
            this.savePartBtn.Text = "Save";
            this.savePartBtn.UseVisualStyleBackColor = true;
            this.savePartBtn.Click += new System.EventHandler(this.savePartBtn_Click);
            // 
            // addCancelBtn
            // 
            this.addCancelBtn.Location = new System.Drawing.Point(340, 438);
            this.addCancelBtn.Name = "addCancelBtn";
            this.addCancelBtn.Size = new System.Drawing.Size(74, 29);
            this.addCancelBtn.TabIndex = 16;
            this.addCancelBtn.Text = "Cancel";
            this.addCancelBtn.UseVisualStyleBackColor = true;
            this.addCancelBtn.Click += new System.EventHandler(this.addCancelBtn_Click);
            // 
            // rbInHouse
            // 
            this.rbInHouse.AutoSize = true;
            this.rbInHouse.Checked = true;
            this.rbInHouse.Location = new System.Drawing.Point(124, 48);
            this.rbInHouse.Name = "rbInHouse";
            this.rbInHouse.Size = new System.Drawing.Size(68, 17);
            this.rbInHouse.TabIndex = 17;
            this.rbInHouse.TabStop = true;
            this.rbInHouse.Text = "In-House";
            this.rbInHouse.UseVisualStyleBackColor = true;
            this.rbInHouse.CheckedChanged += new System.EventHandler(this.rbInHouse_CheckedChanged);
            // 
            // rbOutsource
            // 
            this.rbOutsource.AutoSize = true;
            this.rbOutsource.Location = new System.Drawing.Point(236, 48);
            this.rbOutsource.Name = "rbOutsource";
            this.rbOutsource.Size = new System.Drawing.Size(80, 17);
            this.rbOutsource.TabIndex = 18;
            this.rbOutsource.TabStop = true;
            this.rbOutsource.Text = "Outsourced";
            this.rbOutsource.UseVisualStyleBackColor = true;
            this.rbOutsource.CheckedChanged += new System.EventHandler(this.rbOutsource_CheckedChanged);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 492);
            this.Controls.Add(this.rbOutsource);
            this.Controls.Add(this.rbInHouse);
            this.Controls.Add(this.addCancelBtn);
            this.Controls.Add(this.savePartBtn);
            this.Controls.Add(this.addToggle);
            this.Controls.Add(this.addPartsLabel);
            this.Controls.Add(this.addPartMin);
            this.Controls.Add(this.addPartMax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addPartPrice);
            this.Controls.Add(this.addPartInventory);
            this.Controls.Add(this.addPartName);
            this.Controls.Add(this.addPartID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addPartID;
        private System.Windows.Forms.TextBox addPartName;
        private System.Windows.Forms.TextBox addPartInventory;
        private System.Windows.Forms.TextBox addPartPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addPartMax;
        private System.Windows.Forms.TextBox addPartMin;
        private System.Windows.Forms.Label addPartsLabel;
        private System.Windows.Forms.TextBox addToggle;
        private System.Windows.Forms.Button savePartBtn;
        private System.Windows.Forms.Button addCancelBtn;
        private System.Windows.Forms.RadioButton rbInHouse;
        private System.Windows.Forms.RadioButton rbOutsource;
    }
}