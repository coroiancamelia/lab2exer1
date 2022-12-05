using System;

namespace lab2exer1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Ex 1: Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
            citit de la tastatura.*/

            Console.WriteLine("Introduceti un numar:");
            int y = int.Parse(Console.ReadLine());
            int z;
            int suma = 0;

            while (y > 0)

            {
                z = y % 10;
                suma = suma + z;
                y = y / 10;

            }
            Console.WriteLine("Suma cifrelor este:" + suma);



        }
    }
}
