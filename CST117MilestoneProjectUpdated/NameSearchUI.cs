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
    public partial class NameSearchUI : Form
    {
        public NameSearchUI()
        {
            InitializeComponent();
        }

        private void NameSearchUI_Load(object sender, EventArgs e)
        {
            InventoryUI.MyStore.displayInventory(NameSearchResults);
        }
        //Name search button
        private void button1_Click(object sender, EventArgs e)
        {
            InventoryUI.MyStore.searchName(txtName.Text, NameSearchResults);
        }
    }
}
