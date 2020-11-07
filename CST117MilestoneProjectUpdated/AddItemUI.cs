using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117MilestoneProjectUpdated
{
    public partial class AddItemUI : Form
    {
        public AddItemUI()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            InventoryAddItem();
        }
        private void InventoryAddItem()
        {
            //Initialize variables
            string category;
            string name;
            string number;
            decimal price;

            // Get variable from form
            category = txtCategory.Text;
            name = txtName.Text;
            number = txtNumber.Text;
            //price = Convert.ToDecimal(txtPrice.Text);

            if (decimal.TryParse(txtPrice.Text, out price))
            {
                Inventory item1 = new Inventory(category, name, number, price);
                InventoryUI.MyStore.addItem(item1);
                MessageBox.Show(string.Format("New Item Added {0}, {1}, {2}, {3} ", item1.Category, item1.Name, item1.Number, item1.Price));
            }
            else
            {
                MessageBox.Show("You must enter a valid decimal.");
                txtPrice.Text = "";
                this.ActiveControl = txtPrice;
            }
        }
    }
}
