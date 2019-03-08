using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECH
{
    class car
    {
        public class Product
        {
            private int productID;
            private string productCategory;
            private string productSubCategory;
            private string productName;
            private decimal productPrice;
            private decimal productDescription;
            private double productWeight;
            private int units;
            private bool productSaleItem;
            private decimal total;

            public int ProductID
            {
                get { return productID; }
            }
            public string ProductCategory
            {
                get { return productCategory; }
            }
            public string ProductSubCategory
            {
                get { return productCategory; }
            }
            public string ProductName
            {
                get { return productName; }
            }
            public string ProductDescription
            {
                get { return productDescription; }
            }
            public decimal ProductPrice
            {
                get { return productPrice; }
            }
            public double ProductWeight
            {
                get { return productWeight; }
                set { productWeight = value; }
            }
            public int Units
            {
                get { return units; }
                set { units = value; }
            }
            public decimal Total
            {
                get { return Units * ProductPrice; }
            }
            public bool ProductSaleItem
            {
                get { return productSaleItem; }
            }
        }
    }
}
