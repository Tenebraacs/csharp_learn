using System;


namespace valtozok
{
    internal class Valtozok
    {

        internal static void Valtozok1()
        {
            /*  Egy változó deklarálása így néz ki a C#-ban:
             *  
             *      típus VáltozóNeve = érték;
             *      
             *  A leggyakrabban elő forduló adat típusok:
             *      
             *      - int: egész számokat tárol '-2,147,483,648' -tól '2,147,483,648' -ig
             *      - long: egész számokat tárol '-9,223,372,036,854,775,808' -tól '9,223,372,036,854,775,808' -ig
             *      - float: tört számokat tárol. Kb. 6-9 számjegyig.
             *      - double: tört számokat tárol. Kb. 15-17 számjegyig.
             *      - decimal: tört számokat tárol. Kb. 28-29 számjegyig.
             *      - bool: 'true' vagy 'false' értéket tárol el.
             *      - char: Egy darab karaktert tárol el. 'A' - így deklaráljuk.
             *      - string: Karakterek sorozatát tárolja el. "Karakterek sorozata" - így deklaráljuk. 
             */
            int a = 1;
            long b = 2;
            float c = 1f / 3f;
            double d = 1.0 / 3.0; // '1d / 3d'
            decimal e = 1m / 3m;
            bool f = true;
            char g = 'a';
            string h = "szöveg";
            Console.WriteLine($"{a} -   {a.GetType()}"); // A '.GetType()' függvény visszaadja az adat típusát
            Console.WriteLine($"{b} -   {b.GetType()}");
            Console.WriteLine($"{c} -   {c.GetType()}");
            Console.WriteLine($"{d} -   {d.GetType()}");
            Console.WriteLine($"{e} -   {e.GetType()}");
            Console.WriteLine($"{f} -   {f.GetType()}");
            Console.WriteLine($"{g} -   {g.GetType()}");
            Console.WriteLine($"{h} -   {h.GetType()}");
            Console.ReadKey();

            /*  A C#-ban nagyon fontos megadni a változók típusát.
             *  
             *  Vannak dolgok amiket ő lekezel magától, de szinte soha nem úgy ahogy mi szeretnénk.
             *  Pl.: fentebb látható, hogy a 'double' típusú 'd' változó mögé nem raktam utótagot.
             *       Ez azért van mert a "lebegőpontos" számokat (pl.: 1.4) a C# 'double'-ként kezeli.
             *       
             *  Pár pont ami leírja, hogy a C# mit kezel minek:
             *      - 1 : integer
             *      - 1.4 : double
             *      
             *      
             *  Ez most azért fontos nekünk mert ha nem adjuk meg utótaggal a változó típusát akkor
             *  az alapból megadott típussal fogja elvégezni a műveletet ami vagy hibára vagy hibás
             *  eredményre fog futni.
             *  
             *  Ezért nagyon fontos, hogy mindig győződjünk meg arról, hogy jó adattípussal dolgozunk,
             *  mert nagyon könnyen hibára futhat.
             *  
             *  Egy 'integer'-t még át tud alakítani magától lebegő pontossá, de visszafelé ez már 
             *  nem igaz, SŐT! még egymás között sem tud átalakítást végezni.
             *  
             *  !!! MINDIG ELŐRE MEGADOTT TÍPUSÚ SZÁMMAL DOLGOZZUNK, VAGY ADJUNK NEKI UTÓ TAGOT !!!
             */
        }

        internal static void Valtozok2()
        {
            //  A C#-ban lehetőségünk van létre hozni több változót egyszerre.
            int a = 5, b = 6, c = 7;
            Console.WriteLine(a + b + c);

            //  De lehetőség van több változónak ugyan azt az értéket megadni egyszerre
            a = b = c = 5;
            Console.WriteLine(a + b + c);

            // Létre lehet hozni változókat 'modifier'-ekkel is

            const decimal pi = 3.14m;   // Ezt pl. nem lehet megváltoztatni

            //  internal string x = "Ezt a szöveget mindenki látja a projekten belül";
            //  Az ilyen változókat csak a függvényen kívül tudjuk megadni

            //  A usertől bekért adat az mindenképpen 'string'-ként fog vissza adódni
            //  Ezért átalakítjuk, hogy tudjunk vele dolgozni.
            Console.WriteLine("Kérem a kör sugarát!");
            int r = Convert.ToInt32(Console.ReadLine()); // A System 'namespace'-t meghívva a 'Convert.To{Adattípus}'-al tudunk változókat átalakítani
            Console.WriteLine(2 * r * pi);
            Console.ReadKey();
        }
    }
}

