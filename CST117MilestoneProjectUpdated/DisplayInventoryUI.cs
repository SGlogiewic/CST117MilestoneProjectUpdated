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
    public partial class DisplayInventoryUI : Form
    {
        public DisplayInventoryUI()
        {
            InitializeComponent();
        }

        private void DisplayInventoryUI_Load(object sender, EventArgs e)
        {
            InventoryUI.MyStore.displayInventory(DisplayInventoryList);
        }
    }
}
