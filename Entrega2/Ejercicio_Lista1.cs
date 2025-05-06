using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Ejercicio_Lista1
    {
        // Solicitar al usuario que ingrese 5 números enteros y guardarlos en una lista. Luego calcular y mostrar la suma total de los elementos.
        public static void Ejecutar()
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"ingresar {i+1} número para sumar: ");
                int a = int.Parse(Console.ReadLine());
                nums.Add(a);
            }
            int suma = 0;
            for (int i = 0;i < 5;i++)
            {
                suma += nums[i];
            }
            Console.WriteLine($"la suma de los numeros es {suma}");
        }
    }
}
