using System;
using System.Globalization;

namespace ExercicioLeituraArquivo.Entities
{
    class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
        }
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalPrice()
        {
            return Price * Quantity;
        }
        public string TotalItem()
        {
            return Name + "," + TotalPrice().ToString("F2", CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantity;
        }
    }
}
