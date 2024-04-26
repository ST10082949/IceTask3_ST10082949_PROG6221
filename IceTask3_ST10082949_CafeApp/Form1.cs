using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IceTask3_ST10082949_CafeApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> menu = new Dictionary<string, double>()
        {
            {"Coffee", 15.00},
            {"Tea", 12.00},
            {"Sandwich", 25.00},
            {"Cupcake", 6.00},
            {"Donut", 7.00},
            {"Orange Juice", 16.00},
            // Add more items as needed
        };

        List<string> orderItems = new List<string>();
        List<int> orderQuantities = new List<int>();

        public Form1()
        {
            InitializeComponent();
            PopulateItems(); // Populate items when the form loads
        }

        private void PopulateItems()
        {
            foreach (var item in menu)
            {
                comboBoxItem.Items.Add(item.Key);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBoxItem.SelectedItem?.ToString(); // Check if an item is selected
            if (selectedItem != null)
            {
                int quantity = (int)numericUpDownQuantity.Value;

                if (quantity > 0)
                {
                    orderItems.Add(selectedItem);
                    orderQuantities.Add(quantity);

                    MessageBox.Show("Item added to order.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            double total = 0;
            listBoxDisplay.Items.Clear();

            
            for (int i = 0; i < orderItems.Count; i++)
            {
                string item = orderItems[i];
                int quantity = orderQuantities[i];
                double price = menu[item];
                double subtotal = price * quantity;

                total += subtotal;

                listBoxDisplay.Items.Add($"{item} : {quantity} x R {price}  = Subtotal: R {subtotal} ");
               
                
            }

            listBoxDisplay.Items.Add($"\n\nTotal: R {total}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            orderItems.Clear();
            orderQuantities.Clear();
            listBoxDisplay.Items.Clear();
        }
    }
}
