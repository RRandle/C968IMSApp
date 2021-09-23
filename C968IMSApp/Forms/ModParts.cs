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
    public partial class ModParts : Form
    {
        //Save Button Validation
        bool isInHouse;

        private bool saveEnable()
        {
            int digit;
            double cash;
            return (!string.IsNullOrWhiteSpace(modPartName.Text)) && 
      (!string.IsNullOrWhiteSpace(modPartInventory.Text)) &&
      (Int32.TryParse(modPartInventory.Text, out digit)) &&
      (!string.IsNullOrWhiteSpace(modPartPrice.Text))  &&
   (Double.TryParse(modPartPrice.Text, out cash)) &&
      (!string.IsNullOrWhiteSpace(modPartMin.Text)) &&
      (Int32.TryParse(modPartMin.Text, out digit)) &&
      (!string.IsNullOrWhiteSpace(modPartMax.Text)) &&
      (Int32.TryParse(modPartMax.Text, out digit)) &&
    (!(string.IsNullOrWhiteSpace(modToggle.Text) || 
    (isInHouse && !Int32.TryParse(modToggle.Text, out digit))));
        }


        //Radio Button Validation
        private void rbBtnToggle()
        {
            int digit;
            if (string.IsNullOrWhiteSpace(modToggle.Text) || (isInHouse && !Int32.TryParse(modToggle.Text, out digit)))
            {
                modToggle.BackColor = Color.Firebrick;
            }
            else
            {
                modToggle.BackColor = Color.White;
            }
            modSaveBtn.Enabled = saveEnable();
        }
        public ModParts()
        {
          
            InitializeComponent();
            modPartID.Text = Sys.SelectedPart.partID.ToString();
            modPartName.Text = Sys.SelectedPart.partName;
            modPartInventory.Text = Sys.SelectedPart.partInvtry.ToString();
            modPartPrice.Text = Sys.SelectedPart.partPrice.ToString();
            modPartMin.Text = Sys.SelectedPart.partMin.ToString();
            modPartMax.Text = Sys.SelectedPart.partMax.ToString();

           

            if (Sys.SelectedPart.GetType() == typeof(InHouse))
            {
                InHouse e = Sys.SelectedPart as InHouse;
                modToggle.Text = e.MachineID.ToString();
                rbModInHouse.Checked = true;
                isInHouse = true;

            }
            else
            {
                OutSource e = (OutSource)Sys.SelectedPart;
                modToggle.Text = e.CompanyName;
                rbModOutsource.Checked = true;
                isInHouse = false;
            }
            this.ActiveControl = modPartName;
        }
        //Save Button
        private void modSaveBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(modPartMax.Text) < Convert.ToInt32(modPartMin.Text))
            {
                MessageBox.Show("Minimum cannot be more than the Maximum!");
                return;
            }

            if (Convert.ToInt32(modPartInventory.Text) < Convert.ToInt32(modPartMin.Text) || Convert.ToInt32(modPartInventory.Text) > Convert.ToInt32(modPartMax.Text))
            {
                MessageBox.Show("Inventory cannot be less than the minimum or more than the maximum allowed!");
                return;
            }
            if (isInHouse)
            {
                Part itm = new InHouse(Convert.ToInt32(modPartID.Text),modPartName.Text, Convert.ToInt32(modPartInventory.Text), Convert.ToDouble(modPartPrice.Text), Convert.ToInt32(modPartMin.Text), Convert.ToInt32(modPartMax.Text),Convert.ToInt32(modToggle.Text));
                Sys.Change(itm);

                this.Hide();
                HomeScreen home = new HomeScreen();
                home.Show();
            }
            else
            {
                Part itm = new OutSource(Convert.ToInt32(modPartID.Text), modPartName.Text, Convert.ToInt32(modPartInventory.Text), Convert.ToDouble(modPartPrice.Text), Convert.ToInt32(modPartMin.Text), Convert.ToInt32(modPartMax.Text),modToggle.Text);
                Sys.Change(itm);

                this.Hide();
                HomeScreen home = new HomeScreen();
                home.Show();
            }

        }
        //Cancel Button
        private void modCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeScreen home = new HomeScreen();
            home.Show();
        }
        //Radio Button Controls
        private void rbModInHouse_CheckedChanged(object sender, EventArgs e)
        {
            modLabelToggle.Text = "Machine ID:";
            isInHouse = true;
            rbBtnToggle();

        }

        private void rbModOutsource_CheckedChanged(object sender, EventArgs e)
        {
            modLabelToggle.Text = "Company Name:";
            isInHouse = false;
            rbBtnToggle();
        }
        //TextBox Validations
        private void modPartName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modPartName.Text))
            {
                modPartName.BackColor = Color.Firebrick;
            }
            else
            {
                modPartName.BackColor = Color.White;
            }
            modSaveBtn.Enabled = saveEnable();
        }

        private void modPartInventory_TextChanged(object sender, EventArgs e)
        {
            int digit;
            if (string.IsNullOrWhiteSpace(modPartInventory.Text) || (!Int32.TryParse(modPartInventory.Text, out digit)))
            {
                modPartInventory.BackColor = Color.Firebrick;
               
            }
            else
            {
                modPartInventory.BackColor = Color.White;
      
            }
            modSaveBtn.Enabled = saveEnable();
        }

        private void modPartPrice_TextChanged(object sender, EventArgs e)
        {
            double cash;
            if (string.IsNullOrWhiteSpace(modPartPrice.Text) || !Double.TryParse(modPartPrice.Text, out cash))
            {
                modPartPrice.BackColor = Color.Firebrick;
     
            }
            else
            {
                modPartPrice.BackColor = Color.White;
              
            }
            modSaveBtn.Enabled = saveEnable();
        }

        private void modPartMax_TextChanged(object sender, EventArgs e)
        {
            int digit;
            if (string.IsNullOrWhiteSpace(modPartMax.Text) || !Int32.TryParse(modPartMax.Text, out digit))
            {
                modPartMax.BackColor = Color.Firebrick;
            
            }
            else
            {
                modPartMax.BackColor = Color.White;
           
            }
            modSaveBtn.Enabled = saveEnable();
        }

        private void modPartMin_TextChanged(object sender, EventArgs e)
        {
            int digit;
            if (string.IsNullOrWhiteSpace(modPartMin.Text) || !Int32.TryParse(modPartMin.Text, out digit))
            {
                modPartMin.BackColor = Color.Firebrick;
       
            }
            else
            {
                modPartMin.BackColor = Color.White;
             
            }
            modSaveBtn.Enabled = saveEnable();
        }

        private void modToggle_TextChanged(object sender, EventArgs e)
        {
            rbBtnToggle();
        }
    }
}
