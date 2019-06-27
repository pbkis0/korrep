﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVC.Model;
using System.IO;
using MVC.exceptions;

namespace MVC.Controller
{
    public class BeerController
    {
        private static List<Beer> beers;
        private static List<Manufacturer> manufacturers;

        public BeerController()
        {
            beers = new List<Beer>();
            manufacturers = new List<Manufacturer>();
            beolvasSoroket();
        }

        public BeerController(bool modal)
        {
            // Kamu konstruktor
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
                Manufacturer gyarto = new Manufacturer(data[4]);

                //új példányt hozunk létre a modellből.
                Beer beer = new Beer(azonosito, marka, alkoholTartalom, ar, gyarto);

                //Adott ciklusfutás során a settelt modellt listához hozzáadjuk
                beers.Add(beer);

                //Adott ciklusfutás során a settelt modellt listához hozzáadjuk
                manufacturers.Add(gyarto);
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

        public List<Manufacturer> GetManufacturers()
        {
            return manufacturers;
        }

        /// <summary>
        /// Szűrés foreach-if (linerális kereső algoritmussal)
        /// </summary>
        /// <returns></returns>
        public List<string> GetManufacturerNames()
        {
            List<string>
                gyartok = new List<string>(); // GUI-n combobox-ba string listát tudok "adatkötni", ezt itt létrehozom

            foreach (var manufacturer in manufacturers
            ) // végig megyek Beer típussal a Beer listán (List<Beer>): ez tárolja minden beolvasott adatunkat a fájlból
            {
                if (!gyartok.Contains(manufacturer.getName())
                ) // megvizsgálom, hogy adott objektum gyártó adattagja (string) szerepel-e a gyartok (List<string> gyartok) listában?
                {
                    gyartok.Add(manufacturer.getName()); // Ha nem, akkor belefut ebbe a blokkba (itt hozzáadom getter elkéréssel az adott gyártót (string) a List<sting> gyartok listába, ha nem, akkor nem fut be a blokkba
                }
            }

            gyartok.Sort();
            return gyartok; // függvény végén vissztérek a feltöltött listával, combobox fogadni fogja


            /*
             SortedSet: szűri a redundáns adatokat, csak egyszer kerülhet bele egyféle érték + sorrendbe rakja (szám növekvő, stringnél ABC sorrend)
             SortedSet<string> gyartok = new SortedSet<string>();
             foreach (var beer in beers)
             {
             gyartok.Add(beer.getGyarto());
             }
             return gyartok.ToList();*/
        }

        /// <summary>
        /// Szűrés foreach-if (linerális kereső algoritmussal)
        /// </summary>
        /// <returns></returns>
        public List<string> GetAlcohol()
        {
            List<string>
                alkohol = new List<string>(); // GUI-n combobox-ba string listát tudok "adatkötni", ezt itt létrehozom

            foreach (var beer in beers
            ) // végig megyek Beer típussal a Beer listán (List<Beer>): ez tárolja minden beolvasott adatunkat a fájlból
            {
                if (!alkohol.Contains(beer.getAlkoholTartalom().ToString())
                ) // megvizsgálom, hogy adott objektum gyártó adattagja (string) szerepel-e a gyartok (List<string> gyartok) listában?
                {
                    alkohol.Add(beer.getAlkoholTartalom()
                        .ToString()); // Ha nem, akkor belefut ebbe a blokkba (itt hozzáadom getter elkéréssel az adott gyártót (string) a List<sting> gyartok listába, ha nem, akkor nem fut be a blokkba
                }
            }

            alkohol.Sort();
            return alkohol; // függvény végén vissztérek a feltöltött listával, combobox fogadni fogja


            /*
             SortedSet: szűri a redundáns adatokat, csak egyszer kerülhet bele egyféle érték + sorrendbe rakja (szám növekvő, stringnél ABC sorrend)
             SortedSet<string> alkohol = new SortedSet<string>();
             foreach (var beer in beers)
             {
             gyartok.Add(beer.getAlkoholTartalom().ToString());
             }
             return alkohol.ToList();
             */
        }

        public List<Beer> FilterManufacturer(string manufacturerName)
        {
            List<Beer> manufacterBeers = new List<Beer>();

            foreach (var beer in beers)
            {
                if (beer.getGyarto().getName() == manufacturerName)
                {
                    manufacterBeers.Add(beer);
                }
            }

            return manufacterBeers;
        }

        public List<Beer> FilterAlcohol(string alcohol)
        {
            List<Beer> alcoholBeers = new List<Beer>();

            foreach (var beer in beers)
            {
                if (beer.getAlkoholTartalom() == Convert.ToDouble(alcohol))
                {
                    alcoholBeers.Add(beer);
                }
            }

            return alcoholBeers;
        }

        public string GetNextID()
        {
            return (SearchMaxID() + 1).ToString(); // Nem szabad függni a lista hosszától
        }

        /// <summary>
        /// Maximum keresés prog. tétel
        /// </summary>
        /// <returns></returns>
        private int SearchMaxID()
        {
            int max = 0;

            foreach (Beer beer in beers)
            {
                if (beer.GetAzonosito() > max)
                {
                    max = beer.GetAzonosito();
                }
            }

            return max;
        }

        public void Delete(int index)
        {
            if (index < 0)
            {
                throw new DeleteException("Törlési hiba");
            }

            beers.RemoveAt(index);
        }
    }
}
