using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_pagoda
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Console.WriteLine("Введите название города");
            //Console.WriteLine("36870 >Алма-Ата\n 35188 >Астана\n 38880 >Ашхабад\n 37850 >Баку\n 27612 >Москва\n 26730 >Вильнюс\n   26850 >Минск");
            //string numberCity;
            //numberCity =Console.ReadLine();
            //XDocument xdocument = XDocument.Load(@"http://informer.gismeteo.by/rss/"+numberCity+".xml");
            ////IEnumerable<XElement> emploes = xdocument.Elements();
            ////foreach (var item in emploes)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //foreach (XElement item in xdocument.Element("rss").Element("channel").Elements("item"))
            //{
            //    XElement timePagoda = item.Element("title");
            //    XElement znacheniePagoda = item.Element("description");
            //    Console.WriteLine("время "+timePagoda.Value);
            //    Console.WriteLine("описание "+znacheniePagoda.Value);
            //}
            //Console.ReadKey();
            #endregion


            bool x= true;
            Pagoda pagoda = new Pagoda();
            CityTable city = new CityTable();
            while (x)
            {
                int a;
                Console.WriteLine("1.Просмотр таблицы городов");
                Console.WriteLine("2.редактирование таблицы");
                Console.WriteLine("3.получение данных о погоде");
                Console.WriteLine("0. Exit");
                a =(int) int.Parse( Console.ReadLine());
                switch (a)
                {
                    case 1:
                        city.ShowTable();
                        break;
                    case 2:
                        city.CreatTable();
                        break;
                    case 3:
                        
                        pagoda.UseCity(pagoda.SelectionCity());
                        break;
                    case 4:
                        Statistics.Kurort();
                        break;
                    case 0:
                        x = false;
                        break;
                    
                }
            }
            


        }
    }
}
