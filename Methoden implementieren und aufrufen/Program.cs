using System;

namespace Methoden_implementieren_und_aufrufen
{
    class Program
    {
        static void Main(string[] args)
        {

            short[] zimmernummer = { 45, 23, 3, 32 };
            string[] vorname = new string[4];
            vorname[0] = "John";
            vorname[1] = "Paul";
            vorname[2] = "George";
            vorname[3] = "Ringo";

            string[] nachname = new string[4];
            nachname[0] = "Lennon";
            nachname[1] = "McCartney";
            nachname[2] = "Harrison";
            nachname[3] = "Starr";
       
            short[] uebernachtungen = { 1, 4, 12, 3};
            double[] preise = { 82.46, 329.84, 989.52, 247.38 };

            Console.WriteLine("Bitte geben sie ihre Daten ein");
            string eingabe_str = Console.ReadLine();
            short eingabe_short;
            
            bool flag = short.TryParse(eingabe_str, out eingabe_short);

            if (flag == false)
            {
                Console.WriteLine((eingabe_short, zimmernummer, vorname, nachname,preise));
            }
            else
            {
               // GetData();
            }
              

       


        }

    }
}
