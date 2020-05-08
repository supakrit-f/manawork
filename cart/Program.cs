using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace homework9
{

    class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            string path = @"D:\product.csv";
            string line;
            double total = 0.00;
            int i = 0;
            int j = 0;
            int e = 0;
            ArrayList productList = new ArrayList();
            var sku = new List<String>();
            var name = new List<String>();
            var price = new List<String>();
            ArrayList product = new ArrayList();
            using (StreamReader reader = new StreamReader(path, Encoding.Default, true))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    product.Add(line);
                    var values = line.Split(",");

                    sku.Add(values[0]);
                    name.Add(values[1]);
                    price.Add(values[2]);
                }
            }
            var SKU = sku.ToArray();
            var Name = name.ToArray();
            var Price = price.ToArray();
            String idProduct = " ";
            Console.WriteLine("Products in your cart are");
            Console.WriteLine("none\n---");
            Console.WriteLine("Total amount: 0 baht");
            do
            {
                Console.WriteLine("please input a product key: ");
                idProduct = Console.ReadLine();
                for (i = 1; i < SKU.Length; i++)
                {
                    int f = 0;
                    if (idProduct == SKU[i])
                    {
                        j++;
                        productList.Add(j + ". " + Name[i] + "    " + price[i]);
                        total = total + int.Parse(price[i]);
                    }                  
                }
                if (f != 2)
                    {
                        Console.WriteLine("not found");
                    }
                Console.WriteLine("Product in your cart are");
                foreach(var item in productList){
                    Console.WriteLine(item);
                }
                Console.WriteLine("-------");
                Console.WriteLine("Total amount: " + total + " baht");
            } while (Count == 0);
        }
    }
}
