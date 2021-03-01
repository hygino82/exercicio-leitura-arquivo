using ExercicioLeituraArquivo.Entities;
using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;

namespace ExercicioLeituraArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\lista.txt";
            string targetPath = @"c:\temp\out\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                List<Product> lista = new List<Product>();
                foreach (string linha in lines)//leitura das linhas
                {
                    string[] divide = linha.Split(',');
                    string name = divide[0];
                    double price = double.Parse(divide[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(divide[2]);

                    Product prod = new Product(name, price, quantity);
                    lista.Add(prod);
                }
                if (!Directory.Exists(targetPath))//caso não exista o diretório
                {
                    Directory.CreateDirectory(@"c:\temp\out");
                }
                //escrever os elementos da lista no arquivo
                using (StreamWriter sw = File.AppendText(targetPath))
                {

                    foreach (Product p in lista)
                    {
                        sw.WriteLine(p.TotalItem());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
