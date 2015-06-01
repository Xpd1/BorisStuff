using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Namespace------
namespace ConsoleApplication3
{
    class Program   // Class -----
    {

        public static int EntryPoint() // Entry point funkcija
        {
        Val:
            Console.WriteLine("");
            Console.WriteLine("Molim Vas izaberite sta zelite da konvertujete:");
            Console.WriteLine("1. USD");
            Console.WriteLine("2. AUD");
            Console.WriteLine("3. BAM");
            Console.WriteLine("4. GBP");
            Console.WriteLine("5. DKK");
            Console.WriteLine("6. EUR");
            Console.WriteLine("7. HRK");
            Console.WriteLine("8. JPY");
            Console.WriteLine("9. CAD");
            Console.WriteLine("10. KWD");
            Console.WriteLine("11. HUF");
            Console.WriteLine("12. NOK");
            Console.WriteLine("");
            try
            {

                string temp = Console.ReadLine();
                int currency = Int16.Parse(temp);
                if (currency < 0 || currency > 12)
                {
                    Console.WriteLine("Unesite vrednost od 1 do 12");
                    goto Val;
                }
                return currency;
            }
            catch (SystemException)
            {
                Console.WriteLine("Unesite vrednost od 1 do 12");
                goto Val;
            }
        }

        public static int ReturnPoint()
        {
            Val:
            Console.WriteLine("");
            Console.WriteLine("Molim Vas izaberite u koju valutu zelite da konvertujete");
            Console.WriteLine("1. USD");
            Console.WriteLine("2. AUD");
            Console.WriteLine("3. BAM");
            Console.WriteLine("4. GBP");
            Console.WriteLine("5. DKK");
            Console.WriteLine("6. EUR");
            Console.WriteLine("7. HRK");
            Console.WriteLine("8. JPY");
            Console.WriteLine("9. CAD");
            Console.WriteLine("10. KWD");
            Console.WriteLine("11. HUF");
            Console.WriteLine("12. NOK");
            try
            {
                string temp = Console.ReadLine();
                int currency2 = Int16.Parse(temp);
                if (currency2 < 0 || currency2 > 12)
                {
                    Console.WriteLine("Unesite vrednost od 1 do 12");
                    goto Val;
                }
                return currency2;
            }
            catch (SystemException)
            {
                Console.WriteLine("Unesite vrednost od 1 do 12");
                goto Val;
            }

        }
        public static double Coverter(int currency, int currency2)
        {
            double sum = 0;
            // Izuzetak
            if (currency == currency2)
                Console.WriteLine("Nije moguce konvertovati identicne valute");

            // ..
            Console.WriteLine("Unesite iznos");
            string a = Console.ReadLine();
            var amount = double.Parse(a);



            //USD u druge valute
            if (currency == 1 && currency2 == 2)
                sum = amount * 1.21;

        else if (currency == 1 && currency2 == 3)
                sum = amount * 1.68;

            else if (currency == 1 && currency2 == 4)
                sum = amount * 0.65;

            else if (currency == 1 && currency2 == 5)
                sum = amount * 6.39;

            else if (currency == 1 && currency2 == 6)
                sum = amount * 0.85;

            else if (currency == 1 && currency2 == 8)
                sum = amount * 6.61;

            else if (currency == 1 && currency2 == 9)
                sum = amount * 116.60;

            else if (currency == 1 && currency2 == 10)
                sum = amount * 1.19;

            else if (currency == 1 && currency2 == 11)
                sum = amount * 278.71;

            else if (currency == 1 && currency2 == 12)
                sum = amount * 7.64;
            //kraj USD u druge valute
            //AUD u druge valute

            else if (currency == 2 && currency2 == 1)
                sum = amount * 0.82;

            else if (currency == 2 && currency2 == 3)
                sum = amount * 1.38;

            else if (currency == 2 && currency2 == 4)
                sum = amount * 0.54;

            else if (currency == 2 && currency2 == 5)
                sum = amount * 5.25;

            else if (currency == 2 && currency2 == 6)
                sum = amount * 0.70;

            else if (currency == 2 && currency2 == 7)
                sum = amount * 5.44;

            else if (currency == 2 && currency2 == 8)
                sum = amount * 95.97;

            else if (currency == 2 && currency2 == 9)
                sum = amount * 0.98;

            else if (currency == 2 && currency2 == 10)
                sum = amount * 0.24;

            else if (currency == 2 && currency2 == 11)
                sum = amount * 229.39;

            else if (currency == 2 && currency2 == 12)
                sum = amount * 6.29;
            //Kraj AUD u druge valute
            //Pocetak BAM u druge valute

            else if (currency == 3 && currency2 == 1)
                sum = amount * 0.59;

            else if (currency == 3 && currency2 == 2)
                sum = amount * 0.72;

            else if (currency == 3 && currency2 == 4)
                sum = amount * 0.39;

            else if (currency == 3 && currency2 == 5)
                sum = amount * 3.80;

            else if (currency == 3 && currency2 == 6)
                sum = amount * 0.51;

            else if (currency == 3 && currency2 == 7)
                sum = amount * 3.93;

            else if (currency == 3 && currency2 == 8)
                sum = amount * 69.35;

            else if (currency == 3 && currency2 == 9)
                sum = amount * 0.71;

            else if (currency == 3 && currency2 == 10)
                sum = amount * 0.17;

            else if (currency == 3 && currency2 == 11)
                sum = amount * 165.77;

            else if (currency == 3 && currency2 == 12)
                sum = amount * 4.54;
            //kraj BAM u druge valute
            //Pocetak GBP u druge valute

            else if (currency == 4 && currency2 == 1)
                sum = amount * 1.51;

            else if (currency == 4 && currency2 == 2)
                sum = amount * 1.84;

            else if (currency == 4 && currency2 == 3)
                sum = amount * 2.55;

            else if (currency == 4 && currency2 == 5)
                sum = amount * 9.69;

            else if (currency == 4 && currency2 == 6)
                sum = amount * 1.30;

            else if (currency == 4 && currency2 == 7)
                sum = amount * 10.02;

            else if (currency == 4 && currency2 == 8)
                sum = amount * 176.90;

            else if (currency == 4 && currency2 == 9)
                sum = amount * 1.81;

            else if (currency == 4 && currency2 == 10)
                sum = amount * 0.44;

            else if (currency == 4 && currency2 == 11)
                sum = amount * 422.83;

            else if (currency == 4 && currency2 == 12)
                sum = amount * 11.60;
            //kraj GBP u drugu valutu
            //Pocetak DKK u drugu valutu

            else if (currency == 5 && currency2 == 1)
                sum = amount * 0.15;

            else if (currency == 5 && currency2 == 2)
                sum = amount * 0.19;

            else if (currency == 5 && currency2 == 3)
                sum = amount * 0.26;

            else if (currency == 5 && currency2 == 4)
                sum = amount * 0.10;

            else if (currency == 5 && currency2 == 6)
                sum = amount * 0.13;

            else if (currency == 5 && currency2 == 7)
                sum = amount * 1.03;

            else if (currency == 5 && currency2 == 8)
                sum = amount * 18.24;

            else if (currency == 5 && currency2 == 9)
                sum = amount * 0.18;

            else if (currency == 5 && currency2 == 10)
                sum = amount * 0.04;

            else if (currency == 5 && currency2 == 11)
                sum = amount * 43.61;

            else if (currency == 5 && currency2 == 12)
                sum = amount * 1.19;
            //kraj DKK
            //Pocetak Euro

            else if (currency == 6 && currency2 == 1)
                sum = amount * 1.16;

            else if (currency == 6 && currency2 == 2)
                sum = amount * 1.41;

            else if (currency == 6 && currency2 == 3)
                sum = amount * 1.95;

            else if (currency == 6 && currency2 == 4)
                sum = amount * 0.76;

            else if (currency == 6 && currency2 == 5)
                sum = amount * 7.43;

            else if (currency == 6 && currency2 == 7)
                sum = amount * 7.69;

            else if (currency == 6 && currency2 == 8)
                sum = amount * 135.65;

            else if (currency == 6 && currency2 == 9)
                sum = amount * 1.39;

            else if (currency == 6 && currency2 == 10)
                sum = amount * 0.34;

            else if (currency == 6 && currency2 == 11)
                sum = amount * 324.23;

            else if (currency == 6 && currency2 == 12)
                sum = amount * 8.89;
            //kraj Euro
            //Pocetak HRK
            else if (currency == 7 && currency2 == 1)
                sum = amount * 0.15;

            else if (currency == 7 && currency2 == 2)
                sum = amount * 0.18;

            else if (currency == 7 && currency2 == 3)
                sum = amount * 0.25;

            else if (currency == 7 && currency2 == 4)
                sum = amount * 0.09;

            else if (currency == 7 && currency2 == 5)
                sum = amount * 0.96;

            else if (currency == 7 && currency2 == 6)
                sum = amount * 0.13;

            else if (currency == 7 && currency2 == 8)
                sum = amount * 17.63;

            else if (currency == 7 && currency2 == 9)
                sum = amount * 0.18;

            else if (currency == 7 && currency2 == 10)
                sum = amount * 0.04;

            else if (currency == 7 && currency2 == 11)
                sum = amount * 42.15;

            else if (currency == 7 && currency2 == 12)
                sum = amount * 1.15;
            //kraj HRK
            //Pocetak JPY

            else if (currency == 8 && currency2 == 1)
                sum = amount * 0.0085;

            else if (currency == 8 && currency2 == 2)
                sum = amount * 0.010;

            else if (currency == 8 && currency2 == 3)
                sum = amount * 0.014;

            else if (currency == 8 && currency2 == 4)
                sum = amount * 0.0056;

            else if (currency == 8 && currency2 == 5)
                sum = amount * 0.0548;

            else if (currency == 8 && currency2 == 6)
                sum = amount * 0.0073;

            else if (currency == 8 && currency2 == 7)
                sum = amount * 0.0566;

            else if (currency == 8 && currency2 == 9)
                sum = amount * 0.0102;

            else if (currency == 8 && currency2 == 10)
                sum = amount * 0.0025;

            else if (currency == 8 && currency2 == 11)
                sum = amount * 2.39;

            else if (currency == 8 && currency2 == 12)
                sum = amount * 0.0655;
            //kraj JPY
            //Pocetak CAD 
            else if (currency == 9 && currency2 == 1)
                sum = amount * 0.83;

            else if (currency == 9 && currency2 == 2)
                sum = amount * 1.015;

            else if (currency == 9 && currency2 == 3)
                sum = amount * 1.40;

            else if (currency == 9 && currency2 == 4)
                sum = amount * 0.55;

            else if (currency == 9 && currency2 == 5)
                sum = amount * 5.33;

            else if (currency == 9 && currency2 == 6)
                sum = amount * 0.71;

            else if (currency == 9 && currency2 == 7)
                sum = amount * 5.52;

            else if (currency == 9 && currency2 == 8)
                sum = amount * 97.42;

            else if (currency == 9 && currency2 == 10)
                sum = amount * 0.24;

            else if (currency == 9 && currency2 == 11)
                sum = amount * 232.87;

            else if (currency == 9 && currency2 == 12)
                sum = amount * 6.38;
            //Kraj CAD
            //Pocetak KWD 
            else if (currency == 10 && currency2 == 1)
                sum = amount * 3.39;

            else if (currency == 10 && currency2 == 2)
                sum = amount * 4.12;

            else if (currency == 10 && currency2 == 3)
                sum = amount * 5.71;

            else if (currency == 10 && currency2 == 4)
                sum = amount * 2.23;

            else if (currency == 10 && currency2 == 5)
                sum = amount * 21.71;

            else if (currency == 10 && currency2 == 6)
                sum = amount * 2.92;

            else if (currency == 10 && currency2 == 7)
                sum = amount * 22.46;

            else if (currency == 10 && currency2 == 8)
                sum = amount * 396.17;

            else if (currency == 10 && currency2 == 9)
                sum = amount * 4.06;

            else if (currency == 10 && currency2 == 11)
                sum = amount * 946.93;

            else if (currency == 10 && currency2 == 12)
                sum = amount * 25.98;
            //kraj KWD
            //pocetak HUF
            else if (currency == 11 && currency2 == 1)
                sum = amount * 0.00359;

            else if (currency == 11 && currency2 == 2)
                sum = amount * 0.00436;

            else if (currency == 11 && currency2 == 3)
                sum = amount * 0.00603;

            else if (currency == 11 && currency2 == 4)
                sum = amount * 0.00236;

            else if (currency == 11 && currency2 == 5)
                sum = amount * 0.02293;

            else if (currency == 11 && currency2 == 6)
                sum = amount * 0.00308;

            else if (currency == 11 && currency2 == 7)
                sum = amount * 0.02372;

            else if (currency == 11 && currency2 == 8)
                sum = amount * 0.41838;

            else if (currency == 11 && currency2 == 9)
                sum = amount * 0.00429;

            else if (currency == 11 && currency2 == 10)
                sum = amount * 0.00106;

            else if (currency == 11 && currency2 == 12)
                sum = amount * 0.02744;
            //kraj HUF
            //Pocetak NOK

            else if (currency == 12 && currency2 == 1)
                sum = amount * 0.13;

            else if (currency == 12 && currency2 == 2)
                sum = amount * 0.15;

            else if (currency == 12 && currency2 == 3)
                sum = amount * 0.21;

            else if (currency == 12 && currency2 == 4)
                sum = amount * 0.086;

            else if (currency == 12 && currency2 == 5)
                sum = amount * 0.83;

            else if (currency == 12 && currency2 == 6)
                sum = amount * 0.11;

            else if (currency == 12 && currency2 == 7)
                sum = amount * 0.86;

            else if (currency == 12 && currency2 == 8)
                sum = amount * 15.24;

            else if (currency == 12 && currency2 == 9)
                sum = amount * 0.15;

            else if (currency == 12 && currency2 == 10)
                sum = amount * 0.038;

            else if (currency == 12 && currency2 == 11)
                sum = amount * 36.44;
            //kraj NOK



            return sum;

        }
        static void Main(string[] args) // Main
        {
            // string  USD, AUD, BAM, GBP, DKK, EUR, HRK, JPY, CAD, KWD, HUF, NOK, sum;

            Start:
            var currency = EntryPoint();
            var currency2 = ReturnPoint();
            var sum = Coverter(currency, currency2);
            Console.WriteLine("Rezultat je: " + sum);
        Exiting:
            Console.WriteLine("Zelite li da izadjete iz prozora Y/N");
            var ex = Console.ReadLine();
            switch (ex)
            {
                case "Y":
                    System.Environment.Exit(0);
                    break;
                case "N":
                    goto Start;
                default:
                    Console.WriteLine("Unesite Y ili N");
                    goto Exiting;
            }
        }
    }
}


