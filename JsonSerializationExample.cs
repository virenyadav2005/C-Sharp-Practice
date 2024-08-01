using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    internal class JsonSerializationExample
    {

        internal static void JsonSerializationUsingSystemTextJson()
        {
            Product pro = new Product
            {
                id = 1,
                name = "Viren",
                Instock = true,
                InventoryDate = DateTime.Now,
                price = 2450,


            };

            //Serialized 
            string json = JsonSerializer.Serialize(pro, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(json);

            //Deserialize
            Product newPro = JsonSerializer.Deserialize<Product>(json);
        }

        public static void JsonSerializationusingNewtonSoftlib()
        {
            Product pro = new Product
            {
                id = 1,
                name = "Virendra",
                Instock = true,
                InventoryDate = DateTime.Now,
                price = 3333,

            };
            //same as system.text.json  only class name will change
            string json = JsonConvert.Serialize(pro, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(json);


        }
    }


    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public bool Instock { get; set; }

        public DateTime InventoryDate { get; set; }

    }
}