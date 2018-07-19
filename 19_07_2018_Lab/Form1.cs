using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_07_2018_Lab
{
    public partial class Form1 : Form
    {
        Category[] Categories = new Category[2];
        Product[] products = new Product[3];
        public Form1()
        {
            InitializeComponent();

             Categories[0] = new Category() { CatName = "Avtomobil", };
             Categories[1] = new Category() { CatName = "Geyim" };
             FillCombobox(Categories, cmbCategory);

            products[0] = new Product()
            {
                Name = "Mercedes",
                CategoryName = Categories[0].CatName,
                Price = 1600
            };

            products[1] = new Product()
            {
                Name = "Opel",
                CategoryName = Categories[0].CatName,
                Price = 1250
            };

            products[2] = new Product()
            {
                Name = "Shalvar",
                CategoryName = Categories[1].CatName,
                Price = 5.5
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Categories[0].CatName);
        }


        void FillCombobox(Category[] categories, ComboBox cmb)
        { 
            foreach (Category cat in categories)
            {
                cmb.Items.Add(cat.CatName);
            }
        }

        void FillProductCombo(Product[] products, ComboBox cmb, string cat)
        {
            cmb.Items.Clear();
            foreach (Product pro in products)
            {
                if(pro.CategoryName == cat)
                {
                    cmb.Items.Add(pro.Name);
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillProductCombo(products, this.cmbProduct, cmbCategory.SelectedItem.ToString());
        }
    }
}
