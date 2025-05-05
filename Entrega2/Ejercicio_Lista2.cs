using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Ejercicio_Lista2
    {
        // Pedir al usuario que ingrese 7 números y guardarlos en una lista.
        // Luego pedir otro número y verificar si está en la lista. Mostrar un mensaje informando si se encontró o no.
        public static void Ejecutar()
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"ingresar {i + 1} número: ");
                int a = int.Parse(Console.ReadLine());
                nums.Add(a);
            }
            Console.WriteLine("ingresar números para guardar en una lista");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0;i < nums.Count;i++)
            {
                if (nums[i] == numero)
                    Console.WriteLine("el número se encuentra en la lista");
                else
                {
                    Console.WriteLine("el número no se encuentra en la lista");
                }
            }
        }
    }
}
