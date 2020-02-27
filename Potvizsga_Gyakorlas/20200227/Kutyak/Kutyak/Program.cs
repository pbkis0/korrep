using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Kutyak
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<KutyaNev> kutyaNevek = new List<KutyaNev>();

            List<string> sorok = File.ReadAllLines("../../KutyaNevek.csv",Encoding.UTF8).Skip(1).ToList();

            foreach (string sor in sorok)
            {
                string[] adatok = sor.Split(';');

                KutyaNev k = new KutyaNev();
                k.id = Convert.ToInt32(adatok[0]);
                k.kutyanev = adatok[1];

                kutyaNevek.Add(k);
            }

            /*4. feladat */
            
            Console.WriteLine(kutyaNevek.Count);

            /*4. feladat */
            List<KutyaFajta> kutyaFajtak = new List<KutyaFajta>();
            List<string> kutyafajtaSorok = File.ReadAllLines("../../KutyaFajtak.csv",Encoding.UTF8).Skip(1).ToList();

            foreach (string sor in kutyafajtaSorok)
            {
                string[] adatok = sor.Split(';');

                KutyaFajta k = new KutyaFajta();
                k.id = Convert.ToInt32(adatok[0]);
                k.magyarNev = adatok[1];
                k.eredetiNev = adatok[2];

                kutyaFajtak.Add(k);
            }

            /*5. feladat */
            List<Kutya> kutyak = new List<Kutya>();
            List<string> kutyasorok = File.ReadAllLines("../../Kutyak.csv", Encoding.UTF8).Skip(1).ToList();
            foreach (string sor in kutyasorok)
            {
                string[] adatok = sor.Split(';');

                Kutya k = new Kutya();
                k.id = Convert.ToInt32(adatok[0]);
                k.fajtaID = Convert.ToInt32(adatok[1]);
                k.nevID = Convert.ToInt32(adatok[2]);
                k.eletkor = Convert.ToInt32(adatok[3]);
                k.utolsoOrvosiEllenorzes = Convert.ToDateTime(adatok[4]);

                kutyak.Add(k);
                
            }

            /*6. feladat összegzés tétel + átlag tétellel kiegészítve */
            int kutyaeletkorokösszege = 0;

            foreach (Kutya k in kutyak)
            {
                kutyaeletkorokösszege += k.eletkor;
            }

            double atlageletkor = (double)kutyaeletkorokösszege / kutyak.Count;

            Console.WriteLine(atlageletkor.ToString("0.00"));

            /*7. feladat, MAXIMUM keresés tétele*/

            int maxeletkor = 0;
            int maxEletkoruKutyanakANevIDje = 0;
            int maxEletkoruKutyanakAFajtaIDje = 0;

            foreach (Kutya k in kutyak)
            {
                if (maxeletkor < k.eletkor)
                {
                    maxeletkor = k.eletkor;
                    maxEletkoruKutyanakANevIDje = k.nevID;
                    maxEletkoruKutyanakAFajtaIDje = k.fajtaID;
                }
            }
            /*idáig meglesz a maxéletkor, megvan a max életkorú kutyának a névID-je + fajtaid-je*/

            string kutyanev = "";

            foreach (KutyaNev nev in kutyaNevek)
            {
                if (nev.id== maxEletkoruKutyanakANevIDje)
                {
                    kutyanev = nev.kutyanev;
                    break;
                }
            }

            string fajta = "";

            foreach (KutyaFajta kf in kutyaFajtak)
            {
                if (kf.id == maxEletkoruKutyanakAFajtaIDje)
                {
                    fajta = kf.magyarNev;
                    break;
                }
            }

            Console.WriteLine("A legisdősebb kutya " + maxeletkor + " éves, neve: " + kutyanev + ", fajtája:" + fajta);

            /*8. feladat*/
            DateTime orvosiDatum = new DateTime(2018, 01, 10);
            List<int> kutyaIDkOrvosnal = new List<int>();

            foreach (var k in kutyak)
            {
                if (k.utolsoOrvosiEllenorzes == orvosiDatum)
                {
                    kutyaIDkOrvosnal.Add(k.fajtaID);
                }
            }

            foreach (var kutyafajtaID in kutyaIDkOrvosnal)
            {
                foreach (var kf in kutyaFajtak)
                {
                    if (kf.id == kutyafajtaID)
                    {
                        Console.WriteLine(kf.magyarNev);
                    }
                }
            }

            Console.ReadKey();
        }

        
    }
}
