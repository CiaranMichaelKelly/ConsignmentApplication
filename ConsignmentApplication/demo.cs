using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsignmentApplication
{
    public partial class demo : Form
    {
        private Store store = new Store();
        public demo()
        {
            InitializeComponent();
        }

        private void addToCart_Click(object sender, EventArgs e)
        {

        }

        private void SetUpData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Joe", LastName = "Kelly" });
            store.Vendors.Add(new Vendor { FirstName = "Henry", LastName = "Halls" });
            store.Vendors.Add(new Vendor { FirstName = "Barry", LastName = "White" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a Whale",
                Price = 5.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "iPhone 13",
                Description = "Apple iPhone 13",
                Price = 1000M,
                Owner = store.Vendors[2]
            });

            store.Items.Add(new Item
            {
                Title = "13 Laptop",
                Description = "Dell Latitude 7458",
                Price = 1500M,
                Owner = store.Vendors[3]
            });
        }
    }
}
