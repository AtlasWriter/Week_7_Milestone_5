using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class InventoryCSH : Form
    {
        public InventoryCSH()
        {
            InitializeComponent();
        }

        private string productName = "";
        private int productNumber = 0;
        private int quantityOnHand = 0;
        private string productDescription = "";
        private double costOfGoods = 0;
        private double profit = 0;
        private double salePrice = 0;
        private string platformListed = "";
        private double totalSalesOfProduct = 0;
        private int productNumberFromSupplier = 0;
        private string supplierName = "";
        private string supplierCompany = "" ;
        private string tag = "";
        private decimal supplierContact = 0;


        }

        

        public void itemName()
        {

            Item1.productName = "Blipi";
            Item2.productName = "Barny";
            Item3.productName = "Louie";
            Item4.productName = "Morgan wallen";

        }




















        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
