using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Ejercicio3_Array
    {
        // Ingresar 10 números y mostrar cuántos son positivos, negativos y ceros.
        public static void Ejecutar()
        {
            Console.WriteLine("ingresar 10 numeros");
            int[] nums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            int a = 0;
            int b = 0; 
            int c = 0;
            for (int i = 0; i < 10; i++)
            {
                if (nums[i] == 0)
                {
                    a++;
                }
                else if (nums[i] > 0)
                {
                    b++;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine($"Hay {a} numeros que soon 0, {b} que son positivos y {c} negativos");
        }
    }
}
