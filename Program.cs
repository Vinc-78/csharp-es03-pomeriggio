using System;

namespace csharp_geometria
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            /* Consegna: Nel progetto csharp-geometria creare le seguenti classi
             * 
                Creare una classe Rettangolo con due attributi interi: baseRettangolo 
            e altezzaRettangolo. Aggiungere un opportuno costruttore con parametri. 

            Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, 
            rispettivamente, l’area e il perimetro del rettangolo.

            Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, 
            da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo. 
            Dopo averlo istanziato, stampate a video il perimetro e l’area.

            Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi 
            (baseRettangolo e altezzaRettangolo) e provate a stampare le loro proprietà ad 
            esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:

            —— Rettangolo1 —— base: 20 cm altezza: 10 cm Perimetro: 60 cm Area: 200 cm2

            .*/

            double baseRettangolo, altezzaRettangolo;
            LeggiNumeri.ReadNum("valore della base: ", out baseRettangolo);
            LeggiNumeri.ReadNum("valore della base: ", out altezzaRettangolo);

            Rettangolo r1 = new Rettangolo(baseRettangolo, altezzaRettangolo, "r1");
            r1.Stampa();

            LeggiNumeri.ReadNum("valore della base: ", out baseRettangolo);
            LeggiNumeri.ReadNum("valore della base: ", out altezzaRettangolo);
            Rettangolo r2 = new Rettangolo(baseRettangolo, altezzaRettangolo, "r2");
            r2.Stampa();

            LeggiNumeri.ReadNum("valore della base: ", out baseRettangolo);
            LeggiNumeri.ReadNum("valore della base: ", out altezzaRettangolo);
            Rettangolo r3 = new Rettangolo(baseRettangolo, altezzaRettangolo, "r3");
            r3.Stampa();

        }


    }
}
