/*
    Ebben a fájlban fogom lejegyzetelni a C# alapokat.

    Mint látható, a több soros kommentet ilyen módon tudunk létre hozni.

    !!! Alapjáraton a belépési függvény a 'Program.cs'-ben van létre hozva de akárhol létre hozhatjuk DE CSAK EGYSZER SZEREPELHET !!!
*/

//  Ez egy egysoros komment

using System; // Ezzel a 'System' nevű 'namespace'-t importáljuk a kódunkba

namespace magyarázatok // A 'namespace'- ek kód organizálásra és hivatkozásra szolgálnak. Osztályokat, konténereket és másik namespaceket tárol.
{ // Kapcsos zárójellel határozzuk meg egy kód blokk kezdetét és végét
    class Magyarázatok // Ezzel egy osztályt hozunk létre

    /*  Az 'internal' az egy hózáférési mód.
     *  A C#-ban meg lehet adni több féle hozzáférési módot (osztálynak, függvénynek, változónak, stb.?):
     *      
     *      - public: Ez a kód mindenkinek elérhető (még annak is aki már a program megírása után idézi meg a projekten kívül)
     *      - private: Ez a kód csak az adott osztályon belül elérhető
     *      - protected: Ez a kód csak az adott osztályon belül elérhető, és a leszármazott osztályokban
     *      - internal: Ez a kódot csak az adott projekten belül érhető el, viszont külsős már nem tudja meghívni
     *      - protected internal: Ezt a kódot az egész projekt látja, és a más projektekből leszármazott osztályok is látják.
     *      - private protected: Ezt a kódot csak az adott fájlon belül érheti el egy leszármazott osztály
     */
    {
        static private void Jegyzetek() // Ezzel egy függvényt hoztunk részre
        /*
         *  - Egy függvény felépítése:
         *      
         *        VisszatérésiÉrtékTípusa FüggvényNeve(paraméterlista)
         *        {
         *            utasítások;
         *            return visszatérési érték;
         *        }
         *      
         *    !! Ha egy függvénynek a 'void' érték típust adjuk meg akkor NINCS visszatérési értéke !!
         *    
         *    
         *  A 'static' egy 'modifier' amiből 15-öt különböztetünk meg a C#-ban, de azok közül ezek a főbbek:
         *  
         *      - abstract: Az absztrakt módosítóval jelölt osztályok nem példányosíthatók, csak leszármaztatás útján használhatók. 
         *      Az absztrakt osztályoknak lehetnek absztrakt metódusai, amelyeket az leszármaztatott osztályoknak felül kell írniuk.
         *      
         *      - const: A const módosító konstans értéket jelöl, amelyet nem lehet módosítani a program futása során. 
         *      Ezek a módosítóval jelölt mezők vagy tulajdonságok állandó értékeket képviselnek.
         *      
         *      - event: Az event módosító egy eseményt jelöl, amely lehetővé teszi az események létrehozását és kezelését a C# programokban. 
         *      Az események lehetővé teszik az osztályok közötti kommunikációt.
         *      
         *      - extern: Az extern módosítóval jelölt metódusokat vagy osztályokat külső, nem C# kódból importálhatjuk. 
         *      Ezek a módosítóval jelölt elemek a C# programba beágyazott, külső függvényeket vagy osztályokat képviselhetnek.
         *      
         *      - override: Az override módosítóval jelölt metódusok az ősosztályban vagy az absztrakt osztályban meghatározott metódusokat írják felül. 
         *      Ez lehetővé teszi az osztályokban az öröklött viselkedés testreszabását és kiterjesztését.
         *      
         *      -readonly: A readonly módosítóval jelölt mezők vagy tulajdonságok csak olvashatók, és az értéküket csak inicializáláskor vagy a konstruktorban lehet beállítani. 
         *      Később nem lehet módosítani az értéküket.
         *      
         *      - sealed: Az sealed módosítóval jelölt osztályokat vagy metódusokat lezárhatjuk, ami azt jelenti, hogy azokat nem lehet további leszármaztatásra vagy felülírásra használni.
         *      Ez a módosító általában akkor hasznos, ha nem szeretnénk, hogy az osztályt vagy metódust bővítsék vagy változtassák.
         *      
         *      -static: Az static módosítóval jelölt mezők, metódusok vagy tulajdonságok osztályszinten vannak definiálva, nem példányhoz kötődnek, és a program indítása során létrejönnek. 
         *      Az static elemekhez osztályon keresztül lehet hozzáférni, és nem igényelnek példányosítást.
         *      
         *      - unsafe: Az unsafe módosítóval jelölt kódrészletekben a C# nyelv biztonsági szabályaitól eltérő műveletek, például pointer műveletek használhatók. 
         *      Az unsafe módosítóval jelölt kód csak olyan kontextusban használható, amikor az erre engedélyt adó beállításokat engedélyezték.
         *  
         *      - virtual: Az virtual módosítóval jelölt metódusokat az ősosztályban alapértelmezetten implementálják, de azokat az leszármaztatott osztályokban felül lehet írni. 
         *      Ez lehetővé teszi a polimorfizmust, vagyis az azonos nevű metódusok eltérő viselkedését a leszármaztatott osztályokban.
         */

        {
            Console.WriteLine("Hello világ!");  // Ezzel íratunk ki valamit a konzolra
            Console.ReadKey();  // Ezzel megvárjuk amíg a felhasználó nyom egy gombot, hogy nyitva maradjon a konzol ablak.
        }
    }
}




// Így néz ki egy konzolra kiíratás egy 'internal' osztállyal, hogy meg lehessen hívni a 'Program.cs'-ben

namespace bemutatas
{
    internal class Bemutatas
    {
        internal static void Bemutat()
        {
            Console.WriteLine("Hello világ!");
            Console.ReadKey();
        }
    }
}