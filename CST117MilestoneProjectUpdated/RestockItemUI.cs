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
    public partial class RestockItemUI : Form
    {
        public RestockItemUI()
        {
            InitializeComponent();
        }

        private void RestockItemUI_Load(object sender, EventArgs e)
        {
            InventoryUI.MyStore.displayInventory(ItemQuantityList);
        }

        private void RestockButton_Click(object sender, EventArgs e)
        {
            int qty;
            if (int.TryParse(txtQty.Text, out qty))
            {
                Inventory item = InventoryUI.MyStore.Inventories[ItemQuantityList.SelectedIndex];
                InventoryUI.MyStore.restockItem(item, qty);
                InventoryUI.MyStore.displayInventory(ItemQuantityList);
            }
            else
            {
                MessageBox.Show("You must enter a valid integer.");
                txtQty.Text = "";
                this.ActiveControl = txtQty;
            }
        }
    }
}
