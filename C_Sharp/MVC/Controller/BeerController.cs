using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Model;
using System.IO;
using System.Text.RegularExpressions;

namespace MVC.Controller
{
    public class BeerController
    {
        private List<Beer> beers;

        public BeerController()
        {
            beers = new List<Beer>();
            beolvasSoroket();
        }

        public void beolvasSoroket()
        {
            // var: fordítás időben kitalálja a változó típusát

            var sorok = File.ReadAllLines("../../Datasources/beer.txt", Encoding.UTF8).Skip(1); // Skip(2) -> 1 sort ugrik a fájl olvasó

            foreach (var sor in sorok)
            {
                var data = sor.Split('\t');

                // Jól olvashatóság miatt -> segédváltozó
                int azonosito = Convert.ToInt32(data[0]);
                string marka = data[1];
                double alkoholTartalom = Convert.ToDouble(data[2]);
                int ar = Convert.ToInt32(data[3]);
                string gyarto = data[4];

                //új példányt hozunk létre a modellből.
                Beer beer = new Beer(azonosito, marka, alkoholTartalom, ar, gyarto);

                //Adott ciklusfutás során a settelt modellt listához hozzáadjuk
                beers.Add(beer);
            }
        }

        /// <summary>
        /// Sörlista gettere
        /// </summary>
        /// <returns></returns>
        public List<Beer> GetBeers()
        {
            return beers;
        }
    }
}
