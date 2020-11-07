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
    public partial class InventoryUI : Form
    {
        //To get MyStore to work I switched Inventory.cs and InventoryManager.cs to public
        public static InventoryManager MyStore { get; set; }
        public InventoryUI()
        {
            InitializeComponent();
            MyStore = new InventoryManager();
        }

        //Add Item button
        private void button1_Click(object sender, EventArgs e)
        {
            AddItemUI launchInventoryForm = new AddItemUI();
            launchInventoryForm.ShowDialog();
        }

        //Remove Item button
        private void button2_Click(object sender, EventArgs e)
        {
            RemoveItemUI launchInventoryForm = new RemoveItemUI();
            launchInventoryForm.ShowDialog();
        }

        //Restock button
        private void button3_Click(object sender, EventArgs e)
        {
            RestockItemUI launchInventoryForm = new RestockItemUI();
            launchInventoryForm.ShowDialog();
        }

        //Search by Price button
        private void button4_Click(object sender, EventArgs e)
        {
            PriceSearchUI launchInventoryForm = new PriceSearchUI();
            launchInventoryForm.ShowDialog();
        }

        //Search by Name button
        private void button5_Click(object sender, EventArgs e)
        {
            NameSearchUI launchInventoryForm = new NameSearchUI();
            launchInventoryForm.ShowDialog();
        }

        //Display Inventory button
        private void button6_Click(object sender, EventArgs e)
        {
            DisplayInventoryUI launchInventoryForm = new DisplayInventoryUI();
            launchInventoryForm.ShowDialog();
        }
    }
}
