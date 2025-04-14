using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private readonly EcommerceDbContext _context;
        public Form2()
        {
            InitializeComponent();
            _context = new EcommerceDbContext();
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(InputId.Text);
            var Name = InputName.Text;
            var product = new Product() { ProductName = Name };
            _context.Products.Add(product);
            _context.SaveChanges();
            Form1 listForm = new Form1();
            listForm.Show();

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            var ProductId = int.Parse(Input_ID.Text);
            var res = _context.Products.Where(x => x.ProductId == ProductId)
                .ToList();

            Form1 listForm = new Form1(res);
            listForm.Show();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int inputToDelete = int.Parse(Input_Delete.Text);

            var product = _context.Products.FirstOrDefault(x => x.ProductId == inputToDelete);
            var orderDetails = _context.OrderDetails.Where(x => x.ProductId == inputToDelete).ToList();

            if (product != null)
            {
                if (orderDetails.Any())
                {
                    _context.OrderDetails.RemoveRange(orderDetails);
                }

                _context.Products.Remove(product);

                try
                {
                    _context.SaveChanges();
                    MessageBox.Show("Product and related order details deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during delete: {ex.Message}");
                }

                // Refresh the form or show updated list
                Form1 listForm = new Form1();
                listForm.Show();
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            int productId;
            if (!int.TryParse(InputId_Edit.Text, out productId))
            {
                MessageBox.Show("Invalid Product ID.");
                return;
            }

            string selectedField = comboBox_edit.SelectedItem?.ToString();
            string newValue = Input_Value.Text;

            if (string.IsNullOrEmpty(selectedField))
            {
                MessageBox.Show("Please select a field to update.");
                return;
            }

            var product = _context.Products.FirstOrDefault(x => x.ProductId == productId);

            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            try
            {
                switch (selectedField)
                {
                    case "Name":
                        product.ProductName = newValue;
                        break;

                    case "Price":
                        if (decimal.TryParse(newValue, out decimal newPrice))
                        {
                            product.Price = newPrice;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid number for price.");
                            return;
                        }
                        break;

                    case "Description":
                        product.Description = newValue;
                        break;

                    default:
                        MessageBox.Show("Invalid field selected.");
                        return;
                }

                _context.SaveChanges();
                MessageBox.Show("Product updated successfully.");

                // Optional: close or refresh
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during update: {ex.Message}");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox_edit.Items.Add("Name");
            comboBox_edit.Items.Add("Price");
            comboBox_edit.Items.Add("Description");
            comboBox_edit.SelectedIndex = 0; // Optional: select first by default
        }
    }
}

