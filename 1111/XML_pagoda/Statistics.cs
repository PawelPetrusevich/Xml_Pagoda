using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Collections;

namespace XML_pagoda
{
    class Statistics
    {
        
        public static void Kurort()
        {
           
            XDocument city_xdocument = XDocument.Load("city_table.xml");
            SortedDictionary<string,int> htTemperatur = new SortedDictionary<string, int>();
            foreach (XElement item in city_xdocument.Element("cityes").Elements("city"))
            {
                XElement id = item.Element("Id");
                int _id = int.Parse(id.Value);

                XDocument xdocument = XDocument.Load(_id + ".xml");
                string pattern = @"[-+]?\b\d{1,2}\b(?!\s)";
                Regex new_reg = new Regex(pattern);
                                
                foreach (XElement _item in xdocument.Element("rss").Element("channel").Elements("item"))
                {
                    XElement znacheniePagoda = _item.Element("description");
                    XElement timePagoda = _item.Element("title");
                    //Console.WriteLine("описание " + znacheniePagoda.Value);
                    MatchCollection matchs = new_reg.Matches(znacheniePagoda.Value);
                    foreach (Match  temp in matchs)
                    {
                        htTemperatur.Add((string)timePagoda.Value,Convert.ToInt32(temp.Value));
                    }                    
                }
            }
            
            foreach (var max in htTemperatur)
            {
                Console.WriteLine("Город = {0} ,\n Температрура = {1} ",max.Key,max.Value);
            }

        }
    }
}
