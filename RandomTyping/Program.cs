using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("RandomTyping");
                Console.WriteLine("Generate Random 140 character text? Y/N");
                string sel = Console.ReadLine();
                switch (sel.ToUpper())
                {
                    case "Y":
                        Console.Clear();
                        RandomType();
                        break;
                    case "N":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ingresa un dato correcto");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (option == 0);
        }

        static void RandomType()
        {
            string text = "";
            Random rd = new Random();
            do
            {
                int rn = rd.Next(0, 27);
                text = text + LASN(rn);
            } while (text.Length < 140);
            Console.WriteLine("\n"+text+"\n");

        }

        static string LASN(int number)
        {
            string ch;
            switch (number)
            {
                case 0:
                    ch = "a";
                    return ch;
                case 1:
                    ch = "b";
                    return ch;
                case 2:
                    ch = "c";
                    return ch;
                case 3:
                    ch = "d";
                    return ch; 
                case 4:
                    ch = "e";
                    return ch;
                case 5:
                    ch = "f";
                    return ch;
                case 6:
                    ch = "g";
                    return ch;
                case 7:
                    ch = "h";
                    return ch;
                case 8:
                    ch = "i";
                    return ch;
                case 9:
                    ch = "j";
                    return ch;
                case 10:
                    ch = "k";
                    return ch;
                case 11:
                    ch = "l";
                    return ch;
                case 12:
                    ch = "m";
                    return ch;
                case 13:
                    ch = "n";
                    return ch;
                case 14:
                    ch = "o";
                    return ch;
                case 15:
                    ch = "p";
                    return ch;
                case 16:
                    ch = "q";
                    return ch;
                case 17:
                    ch = "r";
                    return ch;
                case 18:
                    ch = "s";
                    return ch;
                case 19:
                    ch = "t";
                    return ch;
                case 20:
                    ch = "u";
                    return ch;
                case 21:
                    ch = "v";
                    return ch;
                case 22:
                    ch = "w";
                    return ch;
                case 23:
                    ch = "x";
                    return ch;
                case 24:
                    ch = "y";
                    return ch;
                case 25:
                    ch = "z";
                    return ch;
                case 26:
                    ch = " ";
                    return ch;
                default:
                    ch = "Never will get here";
                    return ch;
            }
        }
    }
}
