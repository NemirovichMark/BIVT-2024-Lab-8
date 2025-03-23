using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Test_4();
        }

        static void Test_1()
        {
            Purple_1 p1 = new Purple_1("a abc, bcd");
            p1.Review();
            Console.WriteLine(p1.ToString());

            Purple_1 p2 = new Purple_1("a,abc,bcd               123");
            p2.Review();
            Console.WriteLine(p2.ToString());

            Purple_1 p3 = new Purple_1("    ");
            p3.Review();
            Console.WriteLine(p3.ToString());
        }

        static void Test_2()
        {
            Purple_2 p1 = new Purple_2("Ученики зашифровывают свои записки, записывая все слова наоборот. Знаки препинания оставить на своих местах. Составить программу, зашифровывающую и расшифровывающую сообщение. Свойство Output должно возвращать ");
            p1.Review();
            foreach (var item in p1.Output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(p1.ToString());

            Purple_2 p2 = new Purple_2("Ученики   ё ё");
            p2.Review();
            foreach (var item in p2.Output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(p2.ToString());
        }

        static void Test_3()
        {
            Purple_3 p1 = new Purple_3("Ученики зашифровывают свои записки, записывая все слова наоборот. Знаки препинания оставить на своих местах. Составить программу, зашифровывающую и расшифровывающую сообщение. Свойство Output должно возвращать ");
            p1.Review();
            Console.WriteLine(p1.Output);

            Purple_3 p2 = new Purple_3("абсабсабс");
            p2.Review();
            string incoded = p2.Output;
            Console.WriteLine(incoded);
            (string, char)[] codes = p2.Codes();

            foreach (var item in codes)
                Console.WriteLine(item);

        }

        static void Test_4()
        {
            Purple_3 p1 = new Purple_3("Ученики зашифровывают свои записки, записывая все слова наоборот. Знаки препинания оставить на своих местах. Составить программу, зашифровывающую и расшифровывающую сообщение. Свойство Output должно возвращать ");
            p1.Review();
            string incoded1 = p1.Output;
            Console.WriteLine(incoded1);
            (string, char)[] codes1 = p1.Codes();

            Purple_4 p1_1 = new Purple_4(incoded1, codes1);
            p1_1.Review();
            Console.WriteLine(p1_1.Output);

            Purple_3 p2 = new Purple_3("абсабсабс");
            p2.Review();
            string incoded2 = p2.Output;
            Console.WriteLine(incoded2);
            (string, char)[] codes2 = p2.Codes();

            Purple_4 p2_1 = new Purple_4(incoded2, codes2);
            p2_1.Review();
            Console.WriteLine(p2_1.Output);
        }
    }
}
