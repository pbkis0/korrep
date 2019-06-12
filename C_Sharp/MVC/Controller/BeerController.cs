using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Model;
using System.IO;

namespace MVC.Controller
{
    public class BeerController
    {
        private List<Beer> sorok;

        public BeerController()
        {
            sorok = new List<Beer>();
        }

        public void beolvasSoroket()
        {
            // var: fordítás időben kitalálja a változó típusát

            var beolvasas = File.ReadAllText("../../Datasources/beer.txt", Encoding.UTF8);
        }
    }
}
