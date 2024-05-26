using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTask
{
    internal class Inventory
    {   
            Dictionary<string, int> Products = new();

            public Inventory()
            {
                Products = new Dictionary<string, int>();
            }
            public void AddProduct(string name, int quantity)
            {

                foreach (var product in Products)
                {
                    if (name == product.Key)
                    {
                        Products[name] += quantity;
                        return;

                    }

                }

                Products.Add(name, quantity);



            }
            public void RemoveProduct(string name)
            {
                Products.Remove(name);
            }
            public void GetQuantityByProduct(string name)
            {


                foreach (var students in Products)
                {
                    if (name == students.Key)
                    {
                    Console.WriteLine($"{name}");
                    Console.WriteLine(students.Value);
                    return;

                    }

                    Console.WriteLine($"Sorry,we dont have product called {name} now");
                }
            }

            public void UpdateQuantity(string name, int quantity)
            {
                if (Products.Any(prop => prop.Key == name))
                {
                    Products[name] = quantity;
                Console.WriteLine("Updated");
                }
                else
                {
                    Console.WriteLine("Update counldnt work,theres no product like this");
                }

            }
    }
}
