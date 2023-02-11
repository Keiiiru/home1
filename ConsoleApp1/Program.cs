using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calc
    {
        public double z, x, y;

        public void num()
        {
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите z: ");
            z = Convert.ToDouble(Console.ReadLine());
        }



        public void Set_x(double px) { x = px; }
        public double Get_x() { return x; }
        public void Set_y(double py) { y = py; }
        public double Get_y() { return y; }
        public void Set_z(double pz) { z = pz; }
        public double Get_z() { return z; }

        public double d => Math.Log(Math.Pow(y, -1 * Math.Sqrt(Math.Abs(x))), 10) * (x - (y / 2)) + Math.Pow(Math.Sin(Math.Atan(z)), 2);

        public void inform()
        {
            Console.WriteLine("Ответ = {0:E}", d);
            Console.WriteLine("Ответ = {0:F3}", d);
            Console.WriteLine("Ответ = {0:G}", d);
            Console.WriteLine("Ответ = {0:N}", d);
            Console.ReadKey();
        }


    }
    class program
    {
        static void Main(string[] args)
        {
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            Calc p;
            p = new Calc();
            p.num();
            p.inform();
            
        }
    }
}
      


