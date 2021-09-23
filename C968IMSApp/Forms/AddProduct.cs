using C968IMSApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968IMSApp.Forms
{
    public partial class AddProduct : Form
    {
        //Save Button Validation
        private bool saveEnable()
        {
            int digit;
            double cash;
            return (!string.IsNullOrWhiteSpace(addProdName.Text)) &&
      (!string.IsNullOrWhiteSpace(addProdInventory.Text)) &&
      (Int32.TryParse(addProdInventory.Text, out digit)) &&
      (!string.IsNullOrWhiteSpace(addProdPrice.Text)) &&
   (Double.TryParse(addProdPrice.Text, out cash)) &&
      (!string.IsNullOrWhiteSpace(addProdMin.Text)) &&
      (Int32.TryParse(addProdMin.Text, out digit)) &&
      (!string.IsNullOrWhiteSpace(addProdMax.Text)) &&
      (Int32.TryParse(addProdMax.Text, out digit));
        }



        public AddProduct()
        {
            InitializeComponent();
            this.ActiveControl = addProdName;
            dgvPartAdd.DataSource = Sys.Parts;
            dgvAssocParts.DataSource = Sys.AssociateParts;
            saveProdBtn.Enabled = saveEnable();
        }
        

        //Save Button
        private void saveProdBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(addProdMax.Text) < Convert.ToInt32(addProdMin.Text))
            {
                MessageBox.Show("Minimum cannot be more than the Maximum!");
                return;
            }

            if(Convert.ToInt32(addProdInventory.Text) < Convert.ToInt32(addProdMin.Text) || Convert.ToInt32(addProdInventory.Text ) > Convert.ToInt32(addProdMax.Text))
            {
                MessageBox.Show("Inventory cannot be less than the minimum or more than the maximum allowed!");
                return;
            }

            Product fullProd = new Product(addProdName.Text, Convert.ToInt32(addProdInventory.Text), Convert.ToDouble(addProdPrice.Text), Convert.ToInt32(addProdMin.Text), Convert.ToInt32(addProdMax.Text));
            Sys.Products.Add(fullProd);
            foreach(Part addItem in Sys.AssociateParts)
            {
                fullProd.AddAssocPart(addItem);
            }
            this.Hide();
            HomeScreen home = new HomeScreen();
            home.Show();
        }
        //Add Part Button
        private void addProdPartBtn_Click(object sender, EventArgs e)
        {
            Part associateParts = (Part)dgvPartAdd.CurrentRow.DataBoundItem;
            Sys.AssociateParts.Add(associateParts);
        }
        //Delete Part Button
        private void delProdBtn2_Click(object sender, EventArgs e)
        {

             foreach(DataGridViewRow row in dgvAssocParts.SelectedRows)
            {
                dgvAssocParts.Rows.RemoveAt(row.Index);
            }
        }

        private void dgvAssocPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }
        //Cancel Button
        private void cancelAddProdBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeScreen home = new HomeScreen();
            home.Show();
        }
        //TextBox Validations
        private void addProdName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(addProdName.Text))
            {
                addProdName.BackColor = Color.White;
            }
            else
            {
                addProdName.BackColor = Color.Firebrick;
            }
            saveProdBtn.Enabled = saveEnable();
        }

        private void addProdInventory_TextChanged(object sender, EventArgs e)
        {
            int digit;
            if (!string.IsNullOrWhiteSpace(addProdInventory.Text) && (Int32.TryParse(addProdInventory.Text, out digit)))
            {
                addProdInventory.BackColor = Color.White;
            }
            else
            {
                addProdInventory.BackColor = Color.Firebrick;
            }
            saveProdBtn.Enabled = saveEnable();
        }

        private void addProdPrice_TextChanged(object sender, EventArgs e)
        {
            double cash;
            if (!string.IsNullOrWhiteSpace(addProdPrice.Text) && (Double.TryParse(addProdPrice.Text, out cash)))
            {
                addProdPrice.BackColor = Color.White;
            }
            else
            {
                addProdPrice.BackColor = Color.Firebrick;
            }
            saveProdBtn.Enabled = saveEnable();
        }

        private void addProdMax_TextChanged(object sender, EventArgs e)
        {
            int digit;
            if (!string.IsNullOrWhiteSpace(addProdMax.Text) && (Int32.TryParse(addProdMax.Text, out digit)))
            {
                addProdMax.BackColor = Color.White;
            }
            else
            {
                addProdMax.BackColor = Color.Firebrick;
            }
            saveProdBtn.Enabled = saveEnable();
        }

        private void addProdMin_TextChanged(object sender, EventArgs e)
        {
            int digit;
            if (!string.IsNullOrWhiteSpace(addProdMin.Text) && (Int32.TryParse(addProdMin.Text, out digit)))
            {
                addProdMin.BackColor = Color.White;
            }
            else
            {
                addProdMin.BackColor = Color.Firebrick;
            }
            saveProdBtn.Enabled = saveEnable();
        }
        //Search Button
        private void searchPartAddBtn_Click(object sender, EventArgs e)
        {
            dgvPartAdd.ClearSelection();
            dgvPartAdd.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            bool located = false;
            if (searchPartTextbox.Text != "")
            {
                for (int i = 0; i < Sys.Parts.Count; i++)
                {
                    if (Sys.Parts[i].partName.ToUpper().Contains(searchPartTextbox.Text.ToUpper()))
                    {
                        dgvPartAdd.Rows[i].Selected = true;
                        located = true;
                    }
                }
            }
            if (!located)
            {
                MessageBox.Show("Part Not Found.");
            }
        }
    }
}
