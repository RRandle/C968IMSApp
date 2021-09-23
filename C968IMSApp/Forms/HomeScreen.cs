using C968IMSApp.Forms;
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

namespace C968IMSApp
{
    public partial class HomeScreen : Form
    {
        private static int IndexSelectedPart;
        private static int IndexSelectedProd;
        public HomeScreen()
        {
            InitializeComponent();
            dgvParts.DataSource = Sys.Parts;
            dgvProducts.DataSource = Sys.Products;
            IndexSelectedPart = -1;
            IndexSelectedProd = -1;
        }
        //DGV Formatting
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void firstLoadSelect(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
        }

        private void firstProdLoaded(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();
        }

        //Add Part Button

        private void addPartBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPart addPartView = new AddPart();
            addPartView.Show();

        }
        //Add Product Button
        private void addProdBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProdView = new AddProduct();
            addProdView.Show();
        }

        //Modify Part Button

        private void modPartBtn_Click(object sender, EventArgs e)
        {
            if (IndexSelectedPart >=0 )
            {
                this.Hide();
                ModParts modPartsView = new ModParts();
                modPartsView.Show();
            }
            else 
            {
                MessageBox.Show("Please Select A Part.");
            }
        }
        //Modify Product Button
        private void modProdBtn_Click(object sender, EventArgs e)
        {
            if(IndexSelectedProd >= 0)
            {
                this.Hide();
                ModProduct modProductView = new ModProduct();
                modProductView.Show();
            }
            else
            {
                MessageBox.Show("Please Select A Product.");
            }
        }
        //Delete Part Button
        private void delPartBtn_Click(object sender, EventArgs e)
        {
            if (IndexSelectedPart >= 0 )
            {
                string deletePrompt = "Are you sure you want to delete this part?";
                string promptTitle = "Delete Part";
                MessageBoxButtons deleteButtons = MessageBoxButtons.YesNo;
                DialogResult confirm = MessageBox.Show(deletePrompt, promptTitle, deleteButtons);
                if (confirm == DialogResult.Yes)
                {
                    dgvParts.Rows.RemoveAt(IndexSelectedPart);
                    MessageBox.Show("Part was deleted! ");
                }
               
             
            }
            else
            {
                MessageBox.Show("Please Select A Part.");
            }
        }
        //Delete Product Button
        private void delProdBtn_Click(object sender, EventArgs e)
        {
            Product delProd = Sys.SelectedProd;
            try
            {

  
                if (IndexSelectedProd >= 0)
                {
                    if (delProd.AssocPart.Count > 0)
                    {

                        throw new Exception();

                    }
                    string deletePrompt = "Are you sure you want to delete this product?";
                    string promptTitle = "Delete Product";
                    MessageBoxButtons deleteButtons = MessageBoxButtons.YesNo;
                    DialogResult confirm = MessageBox.Show(deletePrompt, promptTitle, deleteButtons);
                    if (confirm == DialogResult.Yes)
                    {
                        dgvProducts.Rows.RemoveAt(IndexSelectedProd);
                        MessageBox.Show("Product was deleted! ");
                    }


                }
                else
                {
                    MessageBox.Show("Please Select A Product.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Deleting a product with an attached part is not allowed.");
                return;
            }

            

        }
        //DGV Click Events
        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexSelectedPart = e.RowIndex;
            Sys.SelectPartID = (int)dgvParts.Rows[IndexSelectedPart].Cells[0].Value;
            Sys.SelectedPart = Sys.lookupPart(Sys.SelectPartID);
            dgvParts.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexSelectedProd = e.RowIndex;
            Sys.SelectedProdID = (int)dgvProducts.Rows[IndexSelectedProd].Cells[0].Value;
            Sys.SelectedProd = Sys.lookupProd(Sys.SelectedProdID);
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;

        }

        //Exit Button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Search Parts Button
        private void searchPartsBtn_Click(object sender, EventArgs e)
        {
            dgvParts.ClearSelection();
            dgvParts.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            bool located = false;
            if(searchTextbox.Text != "")
            {
                for(int i = 0; i < Sys.Parts.Count; i++)
                {
                    if (Sys.Parts[i].partName.ToUpper().Contains(searchTextbox.Text.ToUpper()))
                    {
                        dgvParts.Rows[i].Selected = true;
                        located = true;
                    }
                }
            }
            if (!located)
            {
                MessageBox.Show("Part Not Found.");
            }
        }
        //Search Products Button
        private void prodSearchBtn_Click(object sender, EventArgs e)
        {
            dgvProducts.ClearSelection();
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            bool located = false;
            if (prodsearchTextbox.Text != "")
            {
                for (int i = 0; i < Sys.Products.Count; i++)
                {
                    if (Sys.Products[i].prodName.ToUpper().Contains(prodsearchTextbox.Text.ToUpper()))
                    {
                        dgvProducts.Rows[i].Selected = true;
                        located = true;
                    }
                }
            }
            if (!located)
            {
                MessageBox.Show("Product Not Found.");
            }
        }
    }
}
