using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;

namespace DemoApp
{
    internal class XMLSerialization
    {
        public void Xml()
        {
            Product pr1 = new Product()
            {
                id = 1,
                name = "Raj",
                price = 103,
                Instock = false,
                InventoryDate = DateTime.Now,
            };
            //Serialization

            serializeObjectToString(pr1);
            
            
            
            //Desirialize form 
            string xml = @"<?xml version=""1.0"" encoding=""utf-16""?>
                <Product xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
                <id>1</id>
                <name>Raj</name>
                <price>103</price>
                <Instock>false</Instock>
                <InventoryDate>2024-07-28T00:56:10.5212785+05:30</InventoryDate>
                </Product>";
            
            
            Product pro = DeserializeStringToObject(xml);

        }

        private Product DeserializeStringToObject(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Product));  
            using StringReader sr = new StringReader(xml);
            
            return serializer.Deserialize(sr) as Product;
         }

        private static void serializeObjectToString(Product pr1)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Product));
            StringWriter sw = new StringWriter();
            serializer.Serialize(sw, pr1);
            Console.WriteLine(sw.ToString());
            
        }

    }

    internal class JsonSerialization
    {
        public void newtonSoft()
        {
            Product pr = new Product()
            {
                id = 1, name = "viren", price = 102 ,Instock = true, InventoryDate = DateTime.Now, 
            };

            string str = JsonConvert.SerializeObject(pr);
            Console.WriteLine(str);

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
