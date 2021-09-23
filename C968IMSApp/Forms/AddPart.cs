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
    public partial class AddPart : Form
    {
        
       //Save Button Validation
        private bool saveEnable()
        {
            int digit;
            double cash;
            return (!string.IsNullOrWhiteSpace(addPartName.Text)) &&
      (!string.IsNullOrWhiteSpace(addPartInventory.Text)) &&
      (Int32.TryParse(addPartInventory.Text, out digit)) &&
      (!string.IsNullOrWhiteSpace(addPartPrice.Text)) &&
   (Double.TryParse(addPartPrice.Text, out cash)) &&
      (!string.IsNullOrWhiteSpace(addPartMin.Text)) &&
      (Int32.TryParse(addPartMin.Text, out digit)) &&
      (!string.IsNullOrWhiteSpace(addPartMax.Text)) &&
      (Int32.TryParse(addPartMax.Text, out digit)) &&
    (!( string.IsNullOrWhiteSpace(addToggle.Text) &&
    (rbInHouse.Checked && !Int32.TryParse(addToggle.Text, out digit))));
        }
        //Radio Button Controls
        private void rbBtnSwitch()
        {
            int digit;
            if (rbInHouse.Checked && !string.IsNullOrWhiteSpace(addToggle.Text) && (rbInHouse.Checked && !Int32.TryParse(addToggle.Text, out digit)))
            {
                addToggle.BackColor = Color.Firebrick;
            }
            else
            {
                addToggle.BackColor = Color.White;
            }
            savePartBtn.Enabled = saveEnable();
            
        }
        public AddPart()
        {
            InitializeComponent();
            this.ActiveControl = addPartName;
            savePartBtn.Enabled = saveEnable();
          
        }
        //Save Part Button
        private void savePartBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(addPartMax.Text) < Convert.ToInt32(addPartMin.Text))
            {
                MessageBox.Show("Minimum cannot be more than the Maximum!");
                return;
            }

            if (Convert.ToInt32(addPartInventory.Text) < Convert.ToInt32(addPartMin.Text) || Convert.ToInt32(addPartInventory.Text) > Convert.ToInt32(addPartMax.Text))
            {
                MessageBox.Show("Inventory cannot be less than the minimum or more than the maximum allowed!");
                return;
            }

            if (rbInHouse.Checked)
            {
                Sys.Parts.Add(new InHouse(addPartName.Text, Convert.ToInt32(addPartInventory.Text), Convert.ToDouble(addPartPrice.Text), Convert.ToInt32(addPartMin.Text), Convert.ToInt32(addPartMax.Text), Convert.ToInt32(addToggle.Text)));
                this.Hide();
                HomeScreen home = new HomeScreen();
                home.Show();
            }else if (rbOutsource.Checked)
            {
                Sys.Parts.Add(new OutSource(addPartName.Text, Convert.ToInt32(addPartInventory.Text), Convert.ToDouble(addPartPrice.Text), Convert.ToInt32(addPartMin.Text), Convert.ToInt32(addPartMax.Text), addToggle.Text));
                this.Hide();
                HomeScreen home = new HomeScreen();
                home.Show();
            }
            else
            {
                MessageBox.Show("Please select 'In-House' or 'Outsourced' ");
            }

           
        }
        //Part Label Controls 
        private void rbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            addPartsLabel.Text = "Machine ID:";
        }

        private void rbOutsource_CheckedChanged(object sender, EventArgs e)
        {
            addPartsLabel.Text = "Company Name:";
        }
        //Cancel Button
        private void addCancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeScreen home = new HomeScreen();
            home.Show();
        }
        //TextBox Validations
        private void addPartName_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(addPartName.Text))
            {
                addPartName.BackColor = Color.White;
            }
            else
            {
                addPartName.BackColor = Color.Firebrick;
            }
            savePartBtn.Enabled = saveEnable();

        }

        private void addPartInventory_TextChanged(object sender, EventArgs e)
        {
            int digit;
            if (!string.IsNullOrWhiteSpace(addPartInventory.Text) && (Int32.TryParse(addPartInventory.Text, out digit)))
            {
                addPartInventory.BackColor = Color.White;
            }
            else
            {
                addPartInventory.BackColor = Color.Firebrick;
            }
            savePartBtn.Enabled = saveEnable();
        }

        private void addPartPrice_TextChanged(object sender, EventArgs e)
        {
            double cash;
            if (!string.IsNullOrWhiteSpace(addPartPrice.Text) && (Double.TryParse(addPartPrice.Text, out cash)))
            {
                addPartPrice.BackColor = Color.White;
            }
            else
            {
                addPartPrice.BackColor = Color.Firebrick;
            }
            savePartBtn.Enabled = saveEnable();
        }

        private void addPartMax_TextChanged(object sender, EventArgs e)
        {
            int digit;
            if (!string.IsNullOrWhiteSpace(addPartMax.Text) && (Int32.TryParse(addPartMax.Text, out digit)))
            {
                addPartMax.BackColor = Color.White;
            }
            else
            {
                addPartMax.BackColor = Color.Firebrick;
            }
            savePartBtn.Enabled = saveEnable();
        }

        private void addPartMin_TextChanged(object sender, EventArgs e)
        { int digit;
            if (!string.IsNullOrWhiteSpace(addPartMin.Text) && (Int32.TryParse(addPartMin.Text, out digit)))
            {
                addPartMin.BackColor = Color.White;
            }
            else
            {
                addPartMin.BackColor = Color.Firebrick;
            }
            savePartBtn.Enabled = saveEnable();
        }

        private void addToggle_TextChanged(object sender, EventArgs e)
        {
            rbBtnSwitch();
        }
    }
}
