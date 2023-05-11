using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muveletek
{
    internal class Muveletek
    {
        internal static void muveletek1()
        {
            int x = 10;
            int y = 7;

            // A C# -ban megtalálható a 4 alapművelet, de kiegészül még logikai művelettekkel is
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y); // Maradékos osztás, a maradékot adja vissza
            Console.WriteLine(++x); // Egyet hozzá adunk az értékhez. Ennek a ciklusoknál lesz jelentősége.
            Console.WriteLine(--x); // Egyet elvonunk az értékből. Ennek a ciklusoknál lesz jelentősége.
            /* !! Nem mindegy, hogy a '--' vagy a '++' előre vagy hátra kerül !!
             * 
             *  Ha pl.: a 'Console.WriteLine();'-ban használjuk és HÁTRA írjuk a '++'-t akkor
             *  először kiírja és utána adja hozzá azt az egyet.
             */

            Console.WriteLine(x & y);
            Console.WriteLine(x | y);
            Console.WriteLine(x ^ y);
            /*  Ez a három művelet a bitenkénti ÉS és VAGY operátor.
             *  
             *  A logika mögöttük a következő:
             *  
             *      x = 10 = 1010
             *      y =  5 = 0101
             *  
             *  Az ÉS (&) megnézi, hogy ugyan azon a helyen (biten) mind a kettő egyenlő e 1-el, ha
             *  igen akkor az érték 1 lesz, különben 0.
             *  Az az: 1010 & 0111 = 0010
             *         (10)   (7)
             *         
             *  A VAGY (|) megnézi, hogy ugyan azon a helyen (biten) az egyik, vagy a másik
             *  egyenlő-e eggyel. Ha igen akkor 
             *  Az az: 1010 & 0111 = 1111
             *         (10)   (7)
             *         
             *  A XOR (kizáró vagy, ^) megnézi, hogy ugyan azon a helyen (biten) csak az
             *  egyik számnak az érteke egyenlő e 1-el, különben az érték 0 lesz.
             *  Az az: 1010 & 0111 = 1101
             *         (10)   (7)
             */

            Console.WriteLine(x > y); // Ezek az osszehasonlito muveletek, `Boolean´ erteket fognak vissza adni
            Console.WriteLine(x < y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x <= y);
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);

            //  Ezeket meg lehet fokozni az ES, VAGY vagy a NEM logikai operatorokkal
            Console.WriteLine(x > y && x > 5); // Ez csak akkor lesz 'True' ha mind a ketto oldal igaz
            Console.WriteLine(x > y || x > 20); // Ez csak akkor lesz igaz ha legalabb az egyik oldal igaz
            Console.WriteLine(!(x == y)); // Ez megforditja az eredmenyt (ha 'True' -> 'False' || ha 'False' -> 'True')
            Console.ReadKey();
        }
    }
}
