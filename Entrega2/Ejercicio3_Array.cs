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
            int ceros = 0;
            int positivos = 0; 
            int negativos = 0;
            for (int i = 0; i < 10; i++)
            {
                if (nums[i] == 0)
                {
                    ceros++;
                }
                else if (nums[i] > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }
            }
            Console.WriteLine($"Hay {ceros} numeros que soon 0, {positivos} que son positivos y {negativos} negativos");
        }
    }
}
