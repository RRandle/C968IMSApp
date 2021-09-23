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
    public partial class ModProduct : Form
    {
        //Save Button Validation
        private bool saveEnable()
        {
            int digit;
            double cash;
            return (!string.IsNullOrWhiteSpace(modProdName.Text)) &&
      (!string.IsNullOrWhiteSpace(modProdInventory.Text)) &&
      (Int32.TryParse(modProdInventory.Text, out digit)) &&
      (!string.IsNullOrWhiteSpace(modProdPrice.Text)) &&
   (Double.TryParse(modProdPrice.Text, out cash)) &&
      (!string.IsNullOrWhiteSpace(modProdMin.Text)) &&
      (Int32.TryParse(modProdMin.Text, out digit)) &&
      (!string.IsNullOrWhiteSpace(modProdMax.Text)) &&
      (Int32.TryParse(modProdMax.Text, out digit));
        }
        private static int IndexSelectedAssocPart;
        public ModProduct()
        {
            InitializeComponent();
            dgvAllProd.DataSource = Sys.Parts;
            dgvAssociatedPart.DataSource = Sys.SelectedProd.AssocPart;
            modProdID.Text = Sys.SelectedProd.prodID.ToString();
            modProdName.Text = Sys.SelectedProd.prodName;
            modProdInventory.Text = Sys.SelectedProd.prodInvntry.ToString();
            modProdPrice.Text = Sys.SelectedProd.prodPrice.ToString();
            modProdMin.Text = Sys.SelectedProd.prodMin.ToString();
            modProdMax.Text = Sys.SelectedProd.prodMax.ToString();
            IndexSelectedAssocPart = -1;

        }



        //Save Button
        private void saveProdBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(modProdMax.Text) < Convert.ToInt32(modProdMin.Text))
            {
                MessageBox.Show("Minimum cannot be more than the Maximum!");
                return;
            }

            if (Convert.ToInt32(modProdInventory.Text) < Convert.ToInt32(modProdMin.Text) || Convert.ToInt32(modProdInventory.Text) > Convert.ToInt32(modProdMax.Text))
            {
                MessageBox.Show("Inventory cannot be less than the minimum or more than the maximum allowed!");
                return;
            }

            Product fullProd = new Product(Convert.ToInt32(modProdID.Text),modProdName.Text, Convert.ToInt32(modProdInventory.Text), Convert.ToDouble(modProdPrice.Text), Convert.ToInt32(modProdMin.Text), Convert.ToInt32(modProdMax.Text));
            foreach (Part addItem in Sys.SelectedProd.AssocPart)
            {
                fullProd.AddAssocPart(addItem);
            }
            Sys.ChangeProd(fullProd);
            this.Hide();
            HomeScreen home = new HomeScreen();
            home.Show();
        }
        //Cancel Button
        private void cancelProdBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeScreen home = new HomeScreen();
            home.Show();
        }
        //Add Part Button
        private void addProdBtn2_Click(object sender, EventArgs e)
        {
            Part associateParts = (Part)dgvAllProd.CurrentRow.DataBoundItem;
            Sys.SelectedProd.AssocPart.Add(associateParts);
        }
        //Delete Part Button
        private void delAssociateBtn_Click(object sender, EventArgs e)
        {
            if(IndexSelectedAssocPart >= 0)
            {
                dgvAssociatedPart.Rows.RemoveAt(IndexSelectedAssocPart);
            }
            else
            {
                MessageBox.Show("Please Select A Part.");
            }

        }
        //DGV Click Events
        private void dgvAssociateCellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexSelectedAssocPart = e.RowIndex;


        }

        private void allCandidatePartsLoad(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAllProd.ClearSelection();
        }

        private void assocPartsLoaded(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvAssociatedPart.ClearSelection();
        }
        //TextBox Validations
        private void modProdName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modProdName.Text))
            {
                modProdName.BackColor = Color.Firebrick;
            }
            else
            {
                modProdName.BackColor = Color.White;
            }
            saveProdBtn.Enabled = saveEnable();
        }

        private void modProdInventory_TextChanged(object sender, EventArgs e)
        {
            int digit;
            if (string.IsNullOrWhiteSpace(modProdInventory.Text) || (!Int32.TryParse(modProdInventory.Text, out digit)))
            {
                modProdInventory.BackColor = Color.Firebrick;
            }
            else
            {
                modProdInventory.BackColor = Color.White;
            }
            saveProdBtn.Enabled = saveEnable();
        }

        private void modProdPrice_TextChanged(object sender, EventArgs e)
        {
            double cash;
            if (string.IsNullOrWhiteSpace(modProdPrice.Text) || (!Double.TryParse(modProdPrice.Text, out cash)))
            {
                modProdPrice.BackColor = Color.Firebrick;
            }
            else
            {
                modProdPrice.BackColor = Color.White;
            }
            saveProdBtn.Enabled = saveEnable();
        }

        private void modProdMax_TextChanged(object sender, EventArgs e)
        {
            int digit;
            if (string.IsNullOrWhiteSpace(modProdMax.Text) || (!Int32.TryParse(modProdMax.Text, out digit)))
            {
                modProdMax.BackColor = Color.Firebrick;
            }
            else
            {
                modProdMax.BackColor = Color.White;
            }
            saveProdBtn.Enabled = saveEnable();
        }

        private void modProdMin_TextChanged(object sender, EventArgs e)
        {
            int digit;
            if (string.IsNullOrWhiteSpace(modProdMin.Text) || (!Int32.TryParse(modProdMin.Text, out digit)))
            {
                modProdMin.BackColor = Color.Firebrick;
            }
            else
            {
                modProdMin.BackColor = Color.White;
            }
            saveProdBtn.Enabled = saveEnable();
        }
        //Search Button
        private void modPartSearchBtn_Click(object sender, EventArgs e)
        {
            dgvAllProd.ClearSelection();
            dgvAllProd.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            bool located = false;
            if (searchModPartTextbox.Text != "")
            {
                for (int i = 0; i < Sys.Parts.Count; i++)
                {
                    if (Sys.Parts[i].partName.ToUpper().Contains(searchModPartTextbox.Text.ToUpper()))
                    {
                        dgvAllProd.Rows[i].Selected = true;
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
