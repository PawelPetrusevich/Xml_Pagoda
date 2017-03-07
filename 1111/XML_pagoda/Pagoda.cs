using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_pagoda
{
    public class Pagoda
    {
        string nameCity;
        string numberciry;
        public  string SelectionCity()
        {
            Console.WriteLine("Введите название города");            
            string numberCity;
            numberCity =(string) Console.ReadLine();
            return numberCity;
        }
        public  void UseCity(string numberCity)
        {
            XDocument xdocument = XDocument.Load ( numberCity + ".xml");
            //IEnumerable<XElement> emploes = xdocument.Elements();
            //foreach (var item in emploes)
            //{
            //    Console.WriteLine(itуem);
            //}
            foreach (XElement item in xdocument.Element("rss").Element("channel").Elements("item"))
            {
                XElement timePagoda = item.Element("title");
                XElement znacheniePagoda = item.Element("description");
                Console.WriteLine("время " + timePagoda.Value);
                Console.WriteLine("описание " + znacheniePagoda.Value);
            }
            
            Console.ReadKey();
        }

        

        
    }
}
