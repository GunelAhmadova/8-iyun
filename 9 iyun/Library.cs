using System;
using System.Collections.Generic;
using System.Text;

namespace _9_iyun
{
    class Library
    {
        public Product[] products = new Product[0];

        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public int GetJournalsCount ()
        { int count = 0;
            foreach (var item in products)
            {
                if (item is Journal)
                {
                    count++;
                   
                }
            }
            return count;
        }
        public int GetBooksCount()
        {
            int count = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] is Book)
                {
                    count++;
                }

            }
            return count;

        } 
        public Product[] GetProducts (bool isBook)
        {
            Product[] productss = new Product[0];
            if (isBook )
            {
                foreach (var item in products)
                { 
                    if (item is Book)
                    {
                        Array.Resize(ref productss, productss.Length + 1);
                        productss[productss.Length - 1] = item;
                    }

                }
            }
            else
            {
                foreach (var item in products)
                {
                    if(item is Journal)
                    {
                        Array.Resize(ref productss, productss.Length + 1);
                        productss[productss.Length - 1] = item;

                    }
                }
            }
            return productss;
        }
    }
}
