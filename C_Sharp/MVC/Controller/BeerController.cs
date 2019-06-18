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

            var sorok = File.ReadAllLines("../../Datasources/beer.txt", Encoding.UTF8)
                .Skip(1); // Skip(2) -> 1 sort ugrik a fájl olvasó

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

        /// <summary>
        /// Szűrés foreach-if (linerális kereső algoritmussal)
        /// </summary>
        /// <returns></returns>
        public List<string> GetManufacturers()
        {
            List<string> gyartok = new List<string>(); // GUI-n combobox-ba string listát tudok "adatkötni", ezt itt létrehozom

            foreach (var beer in beers) // végig megyek Beer típussal a Beer listán (List<Beer>): ez tárolja minden beolvasott adatunkat a fájlból
            {
                if (!gyartok.Contains(beer.getGyarto())) // megvizsgálom, hogy adott objektum gyártó adattagja (string) szerepel-e a gyartok (List<string> gyartok) listában?
                {
                    gyartok.Add(beer.getGyarto()); // Ha nem, akkor belefut ebbe a blokkba (itt hozzáadom getter elkéréssel az adott gyártót (string) a List<sting> gyartok listába, ha nem, akkor nem fut be a blokkba
                }
            }

            return gyartok; // függvény végén vissztérek a feltöltött listával, combobox fogadni fogja
        }

        /// <summary>
        /// Szűrés foreach-if (linerális kereső algoritmussal)
        /// </summary>
        /// <returns></returns>
        public List<string> GetAlcohol()
        {
            List<string> alkohol = new List<string>(); // GUI-n combobox-ba string listát tudok "adatkötni", ezt itt létrehozom

            foreach (var beer in beers) // végig megyek Beer típussal a Beer listán (List<Beer>): ez tárolja minden beolvasott adatunkat a fájlból
            {
                if (!alkohol.Contains(beer.getAlkoholTartalom().ToString())) // megvizsgálom, hogy adott objektum gyártó adattagja (string) szerepel-e a gyartok (List<string> gyartok) listában?
                {
                    alkohol.Add(beer.getAlkoholTartalom().ToString()); // Ha nem, akkor belefut ebbe a blokkba (itt hozzáadom getter elkéréssel az adott gyártót (string) a List<sting> gyartok listába, ha nem, akkor nem fut be a blokkba
                }
            }

            return alkohol; // függvény végén vissztérek a feltöltött listával, combobox fogadni fogja
        }
    }
}
