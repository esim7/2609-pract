using System;
using System.Collections.Generic;
using System.Xml;

namespace XmlHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            XmlDocument document = new XmlDocument();
            document.Load("https://habr.com/ru/rss/interesting/");

            XmlElement rootElement = document.DocumentElement;

            foreach (XmlDocument itemElement in rootElement.ChildNodes)
            {
                if (itemElement.Name == "item")
                {
                    Item item = new Item();
                    int i = 0;
                    foreach (XmlElement itElement in itemElement.ChildNodes)
                    {                 
                        XmlElement itemTitleElement = itemElement.GetElementsByTagName("title")[i] as XmlElement;
                        XmlElement itemLinkElement = itemElement.GetElementsByTagName("link")[i] as XmlElement;
                        XmlElement itemDescriptionElement = itemElement.GetElementsByTagName("description")[i] as XmlElement;
                        XmlElement itemPubDateElement = itemElement.GetElementsByTagName("pubDate")[0] as XmlElement;

                        string type = cityPopulationElement.GetAttribute("type");
                        cities.Add(new City
                        {
                            Id = int.Parse(cityIdElement.InnerText),
                            Name = cityNameElement.InnerText,
                            Population = double.Parse(cityPopulationElement.InnerText),
                            PopulationCountType = Enum.Parse<PopulationCountType>(type)
                        });
                    }
                }

                
                Countries.Add(new Country
                {
                    Id = int.Parse(idElement.InnerText),
                    Name = nameElement.InnerText,
                    //    cities = citiesElement
                });
            }
        }
    }
}
