﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_07_Tipusok
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Típusok
             * Számok
             *   Egész
             *      int - 4B 
             *      byte, short, long
             *   Tört
             *      double - 8B
             *      float, decimal
             * Szöveg
             *   string - karakterlánc - "beégetett adat"
             * Karakter
             *   char - 1 db karakter - 'c'- 1B
             * Logikai
             *   bool - boolean - true, false              
             */

            // Változó deklarálása - definiálása, létrehozása
            // típus változó_név;
            // Inicializálás - kezdőérték adása
            // típus változó_név = kezdő_érték

            //int 17 - 10001 - 00000000000000000000000000010001
            //byte 17 -10001 - 00010001

            int a;
            //int a = 17;
            a = 2000000000;
            int b = 2000000001;

            Console.WriteLine(a+b);


            Console.ReadLine();
        }
    }
}
