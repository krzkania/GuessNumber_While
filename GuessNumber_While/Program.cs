using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //program ma dzialac na podstawie pętli while w celu przedstawienia jej wykorzystania na zajeciach koła naukowego Grupa .NET PG
            //schemat programu zostaje opisany przed przystapieniem do prac w celu kategaryzacji funkcji oraz pracy

                    //przedział od 0 do polowy
                    //przedzial od polowy do max
                    //zmiejszanie przedzialu o polowe czyli od 0 do polowa/2 i od polowa/2 do polowa i tak dalej
                    //zatwierdzanie przedzialow bedzie skutkowalo zmiana liczby poczatkowej jezeli odrzucony zostanie aktualny przedzial
                    //zatwierdzenie aktualnego przedzialu bedzie zwiekszalo wartosc liczby o 1 z przejsciem do kolejnego przedzialu

            //wypisanie informacji o programie
            Console.WriteLine("Hej! Ten program jest demonstracja petli while() ");
            Console.WriteLine("Celem programu jest zgadniecie numeru z przedziału");

            //PRAWIDLOWO ZMIENNE POWINNY BYC NAZYWANE W JEZYKU ANGIELSKIM! w celu ulatwienia na potrzeby zajec sa w jezyku Polskim!

            int _zgadujOd = 0;
            int _max = 100;
            int _zakresMax = _max / 2;
            int _iloscZgadniec = 0;
            string _odpowiedz;

            Console.WriteLine("zgadnijmy liczbe z przedziału otwartego od " + _zgadujOd + " do " + _max);

            while (_zgadujOd != _max)
            {                
                Console.WriteLine("Czy Twoja liczba jest z przedziału " + _zgadujOd + " do " + _zakresMax);
                _iloscZgadniec++;                                                   // sprawdzenie ilosci iteracji potrzebnych na zgadniecie liczby
                _odpowiedz = Console.ReadLine();
                bool _odpowiedziano = _odpowiedz != null && _odpowiedz.Length > 0;  //zmienna sluzaca do sprawdzenia czy jest odpowiedz (nie ma null)
                if (_odpowiedziano == true && _odpowiedz.ToLower()[0] == 'y')
                {
                    _max = _zakresMax;
                    _zakresMax = _zakresMax - (_zakresMax - _zgadujOd) /2;
                }
                else
                {
                    _zgadujOd = _zakresMax + 1;
                    int _pozostalaRoznica = _max - _zakresMax;
                    _zakresMax += (int)Math.Ceiling(_pozostalaRoznica / 2f);         //Math.Ceiling zaokragli wynik do wyzszej liczby
                                                                                     //Math.Ceiling zaokragla wartosc zmienno przecinkowa, wiec nie moga byc same int, jedna liczba musi byc floatem by wynik wyszedl f
                                                                                     // (int) zmieni wartosc zwracanej zmiennej na int (z double w tym przkypadku)
                  //BLAD -> zaokragla do mniejszej liczby w tym wypadku (3/2=1)   NYNN pokaze blad w obliczeniach dlatego powyzsze zaokraglenia!
                }
                if (_zgadujOd + 1 == _max)
                {
                    _iloscZgadniec++;
                    Console.WriteLine("Czy Twoja liczba to " + _zgadujOd + " ?");
                    _odpowiedz = Console.ReadLine();
                    if (_odpowiedziano == true && _odpowiedz.ToLower()[0] == 'y')
                    {                                                
                        break;                                                         // wyjscie z while()
                    }
                    else
                    {
                        Console.WriteLine("Twoja liczba to " + _max);
                        _zgadujOd = _max;                                              // wyjscie z while() poprzez spełnienie warunka powtarzania petli
                    }                 
                }
            }
            //wypisane informacji o liczbie oraz ilosci zgdaniec
            Console.WriteLine("SUPER, Twoja liczba to " + _zgadujOd + " WIEC KONCZYMY");
            Console.WriteLine("zgadlismy przy " + _iloscZgadniec + " zgadniec");
        }
    }
}