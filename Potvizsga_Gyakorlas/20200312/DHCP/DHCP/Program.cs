using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHCP
{
    class Program
    {
        static List<DHCP> dhcp = new List<DHCP>();
        static List<DHCP> reserved = new List<DHCP>();
        static List<DHCP> excluded = new List<DHCP>();
        static List<DHCP> test = new List<DHCP>(); // field initializer

        static void request(string mac)
        {
            foreach (DHCP d in dhcp)
            {
                if (d.mac == mac)
                {
                    Console.WriteLine("Sikertelen IP cím kiosztás!");
                }
                else
                {
                    foreach (DHCP r in reserved)
                    {
                        if (r.mac == mac)
                        {
                            string ip = r.ip;

                            foreach (DHCP dd in dhcp)
                            {
                                if (dd.ip == ip)
                                {
                                    Console.WriteLine("Sikertelen IP cím kiosztás!");
                                }
                                else
                                {
                                    dd.mac
                                }
                            }
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {


            /*Első file beolvasása */
            List<string> dhcpSorok = File.ReadAllLines("../../dhcp.csv", Encoding.UTF8).ToList();

            foreach (string sor in dhcpSorok)
            {
                string[] adatok = sor.Split(';');

                DHCP d = new DHCP();
                d.mac = adatok[0];
                d.ip = adatok[1];

                dhcp.Add(d);
            }

            List<string> excludedLista = File.ReadAllLines("../../excluded.csv", Encoding.UTF8).ToList();

            foreach (string sor in excludedLista)
            {
                DHCP e = new DHCP();
                e.ip = sor;

                excluded.Add(e);
            }

            List<string> reservedSorok = File.ReadAllLines("../../reserved.csv", Encoding.UTF8).ToList();

            foreach (string sor in reservedSorok)
            {
                string[] adatok = sor.Split(';');

                DHCP r = new DHCP();
                r.mac = adatok[0];
                r.ip = adatok[1];

                reserved.Add(r);
            }

            List<string> testSorok = File.ReadAllLines("../../test.csv", Encoding.UTF8).ToList();

            foreach (string sor in testSorok)
            {
                string[] adatok = sor.Split(';');

                DHCP t = new DHCP();
                t.muvelet = adatok[0];

                if (t.muvelet == "release")
                {
                    t.ip = adatok[1];
                }
                else if (t.muvelet == "request")
                {
                    t.mac = adatok[1];
                }

                test.Add(t);

            }

            /*Fileok Beolvasása elkészült */

            foreach (DHCP testDHCP in test)
            {
                if (testDHCP.muvelet == "request")
                {
                    request(testDHCP.mac);
                }
            }


            Console.ReadKey();
        }
    }
}
