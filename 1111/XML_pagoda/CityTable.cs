using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_pagoda
{
    public class CityTable
    {
        public XDocument city_table = new XDocument();
        public  void CreatTable()
        {
            

                        XElement city = new XElement("city");
                        Console.WriteLine("Введите название города");
                        XElement city_name = new XElement("name", Console.ReadLine());
                        Console.WriteLine("Введите Id города");
                        XElement city_Id = new XElement("Id", Console.ReadLine());
                        if (city_name != null && city_Id != null)
                        {
                            city.Add(city_name);
                            city.Add(city_Id);
                        }
                        XElement citys = new XElement("cityes");
                        citys.Add(city);
                        city_table.Add(citys);
                        city_table.Save("city_table.xml");
                        Console.WriteLine("Город дабавлен");
                        Console.WriteLine();
               
            
            
        }

        public void ShowTable()
        {
            XDocument xdoc = XDocument.Load("city_table.xml");
            foreach (XElement item in xdoc.Element("cityes").Elements("city"))
            {
                Console.Write("Gorod "+item.Element("name").Value);
                Console.WriteLine("               Id "+item.Element("Id").Value);
            }
        }

    }
}
