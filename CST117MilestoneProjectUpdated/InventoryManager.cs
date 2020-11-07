using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added so I can use list boxes
using System.Windows.Forms;

namespace CST117MilestoneProjectUpdated
{
    //When it just says 'class' it is internal by default because of
    //this I had to put the public keyword to specify that it was public
    public class InventoryManager
    {
        public List<Inventory> inventoryManagerList = new List<Inventory>();

        //Starts additem method
        public void addItem(Inventory item)
        {
            this.inventoryManagerList.Add(item);
        }

        //Starts removeItem method
        public void removeItem(int index)
        {
            if (index >= 0)
                this.inventoryManagerList.RemoveAt(index);
        }

        //Starts restockItem method
        public void restockItem(Inventory item, int quantity)
        {
            int index = 0;
            //If quantity is greater than 0, then enter the loop
            if (quantity > 0)
            {
                //While loop adds the number of items specified by quantity
                while (index < quantity)
                {
                    this.inventoryManagerList.Add(item);
                    index++;
                }
            }
        }

        //Starts quantity return
        public int Quantity
        {
            get { return this.inventoryManagerList.Count; }
        }

        //Establishes the inventory list
        public List<Inventory> Inventories
        {
            get { return this.inventoryManagerList; }
        }

        //Displays the inventory
        public void displayInventory(ListBox lstbox)
        {
            //Start with a clear Listbox
            lstbox.Items.Clear();

            //Cycle through each product in the list and add to the listbox
            foreach (Inventory product in this.inventoryManagerList)
            {
                lstbox.Items.Add(product.Category + ", " + product.Name + ", " + product.Number + ", " + product.Price);
            }
        }

        //Method to search for by item name
        public void searchName(string objectName, ListBox lstbox)
        {
            //Begin with clear list box
            lstbox.Items.Clear();

            //Cycles thru each item in the inventory manager list
            foreach (Inventory product in this.inventoryManagerList)
            {
                //Checks if search term matches item name
                if (String.Equals(product.Name, objectName, StringComparison.OrdinalIgnoreCase))
                {
                    lstbox.Items.Add(product.Category + ", " + product.Name + ", " + product.Number + ", " + product.Price);
                }
            }
        }

        //Method to search by item price
        public void searchPrice(decimal objectPrice, ListBox lstbox)
        {

            //Begin with clear list box
            lstbox.Items.Clear();

            //cycle through each item in the inventory manager list
            foreach (Inventory product in this.inventoryManagerList)
            {
                //Test if prices match
                if (product.Price == objectPrice)
                {
                    lstbox.Items.Add(product.Category + ", " + product.Name + ", " + product.Number + ", " + product.Price);
                }
            } 
        }
    }
}
