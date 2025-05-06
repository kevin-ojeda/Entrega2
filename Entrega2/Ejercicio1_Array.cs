using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Ejercicio1_Array
    {
        //Cargar un array con 10 números aleatorios entre 1 y 100. Mostrar el mayor y el menor.
        public static void Ejecutar()
        {
            int[] nums = new int[10];
            Random random = new Random();
            Console.WriteLine("los numeros son:");
            for (int i = 0; i < 10; i++)
            {
                nums[i] = random.Next(1, 101);
                Console.WriteLine(nums[i]);
            }
            int max = 0;
            int min = 100;
            for (int i = 0; i < 10; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine($"el maximo es {max} y el minimo es {min}");
        }
    }
}
