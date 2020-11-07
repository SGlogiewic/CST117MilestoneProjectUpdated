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
    public partial class PriceSearchUI : Form
    {
        public PriceSearchUI()
        {
            InitializeComponent();
        }

        private void PriceSearchUI_Load(object sender, EventArgs e)
        {
            InventoryUI.MyStore.displayInventory(PriceSearchResults);
        }

        private void PriceSearchButton_Click(object sender, EventArgs e)
        {
            decimal price;
            if (decimal.TryParse(txtPrice.Text, out price))
            {
                InventoryUI.MyStore.searchPrice(price, PriceSearchResults);
            }
            else
            {
                MessageBox.Show("Please enter a valid decimal.");
                txtPrice.Text = "";
                this.ActiveControl = txtPrice;
            }
        }
    }
}
