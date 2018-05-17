using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

/* Consignment Shop Demo
 * Written by Derek Evanson
 * With use of IAmTimCorey's educational material
 * 
 * Requirements
 * List of Vendor
 * List of Items per vendor
 * Each vendor should have defualt commission rate
 * Commissions can change
 * Track how much to pay the vendor
 * Track how much to pay the store
 */

namespace ConsignmentShopUI
{
    public partial class ConsignmentShopDemo : Form
    {
        private Store GameStore = new Store();
        private List<Item> shoppingChartData = new List<Item>();

        //Used to connects lists to listbox
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;
        private decimal shoppingTotal = 0;
        

        public ConsignmentShopDemo()
        {
            InitializeComponent();
            SetupData();

            //Set binding source to desired data source aka lists
            // .Where is a lambda expresstion to filter out sold items returning to a list
            itemsBinding.DataSource = GameStore.Items.Where(x => x.Sold == false).ToList();
            itemsListbox.DataSource = itemsBinding;

            //property to display in store items
            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingChartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";

            vendorsBinding.DataSource = GameStore.Vendors;

            
            vendorListbox.DataSource = vendorsBinding;
            vendorListbox.DisplayMember = "Display";
            vendorListbox.ValueMember = "Display";
        }

        private void SetupData()
        {
            //This will fill store will mock data
            GameStore.Vendors.Add(new Vendor { PublisherName = "Stonemaier Games", Commission = .2 });
            GameStore.Vendors.Add(new Vendor { PublisherName = "Stronghold Games", Commission = .25 });
            GameStore.Vendors.Add(new Vendor { PublisherName = "IELLO", Commission = .3 });
            GameStore.Vendors.Add(new Vendor { PublisherName = "Rio Grande", Commission = .2 });
            GameStore.Vendors.Add(new Vendor { PublisherName = "Days of Wonder", Commission = .25 });
            GameStore.Vendors.Add(new Vendor { PublisherName = "Asmodee", Commission = .3 });

            GameStore.Items.Add(new Item
            {
                Title = "Scythe",
                Description = "Game",
                Price = 60.00M,
                Owner = GameStore.Vendors[0]
            });

            GameStore.Items.Add(new Item
            {
                Title = "Terraforming Mars",
                Description = "Game",
                Price = 45.00M,
                Owner = GameStore.Vendors[1]
            });

            GameStore.Items.Add(new Item
            {
                Title = "Great Western ",
                Description = "Game",
                Price = 60.00M,
                Owner = GameStore.Vendors[1]
            });

            GameStore.Items.Add(new Item
            {
                Title = "King of Tokyo",
                Description = "Game",
                Price = 42.00M,
                Owner = GameStore.Vendors[2]
            });

            GameStore.Items.Add(new Item
            {
                Title = "Ticket To Ride",
                Description = "Game",
                Price = 37.00M,
                Owner = GameStore.Vendors[4]
            });

            GameStore.Items.Add(new Item
            {
                Title = "Small World",
                Description = "Game",
                Price = 36.00M,
                Owner = GameStore.Vendors[4]
            });

            GameStore.Items.Add(new Item
            {
                Title = "Carcassone",
                Description = "Game",
                Price = 50.00M,
                Owner = GameStore.Vendors[3]
            });

            GameStore.Items.Add(new Item
            {
                Title = "Power Grid",
                Description = "Game",
                Price = 34.00M,
                Owner = GameStore.Vendors[3]
            });

            GameStore.Items.Add(new Item
            {
                Title = "Catan",
                Description = "Game",
                Price = 36.49M,
                Owner = GameStore.Vendors[5]
            });

            GameStore.Name = "Local Fargo Store";
        }

        private void AddToChart_Click(object sender, EventArgs e)
        {
            // Take selected item from store items
            Item selectedItem = (Item)itemsListbox.SelectedItem;
            // copy it into shopping cart, refresh cart
            shoppingChartData.Add(selectedItem);
            //set to false because the type of list has not changed
            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            //changes items sold property and increments sale prices
            foreach (Item item in shoppingChartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                shoppingTotal += item.Price;
                //rounded value to two decimals
                item.Owner.PaymentDue = decimal.Round(item.Owner.PaymentDue, 2, MidpointRounding.AwayFromZero);
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;         
            }

            MessageBox.Show("You have made a purchase totaling $" + shoppingTotal);
            shoppingChartData.Clear();

            //${0} the 0 is replace by storeProfit
            storeProfitValue.Text = string.Format("${0:0.00}", storeProfit);
            //Filters out sold tems fromstore
            itemsBinding.DataSource = GameStore.Items.Where(x => x.Sold == false).ToList();
            //Reset UI
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
            shoppingTotal = 0;
        }

        private void itemsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
