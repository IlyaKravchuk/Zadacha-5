using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Single edge, basis, var;
            
            Console.WriteLine("Введите длину стороны основания пирамиды");
            basis = Single.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину грани пирамиды");
            edge = Single.Parse(Console.ReadLine());  

            if (((basis + edge) <= edge) || ((edge + edge) <= basis))
                Console.WriteLine("Данная фигура не является пирамидой");
            else
            {
                Console.WriteLine("Введите расстояние от основания пирамиды, на котором находится\nпараллельная плоскость");
                var = Single.Parse(Console.ReadLine());

                Pyramid tr = new Pyramid(basis, edge,var);

                Console.WriteLine("Высота пирамиды = {0}", tr.height);
                Console.WriteLine("Объем пирамиды = {0}", tr.Volume);
                Console.WriteLine("Объем параллелипипеда, в который вписана пирамида = {0}", tr.Parallelepiped);
                Console.WriteLine("Объем пирамиды, полученной отсечением плоскостью, параллельной\nоснованию, на заданном расстоянии от основания = {0}", tr.Pyramid2);                                
            }
            Console.ReadKey();
        }
    }
}
