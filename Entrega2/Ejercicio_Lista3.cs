using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    //Generar una lista con 10 números aleatorios entre 1 y 100.
    //Luego pedir al usuario un valor límite y eliminar todos los elementos menores a ese valor.
    // Mostrar la lista resultante.
    internal class Ejercicio_Lista3
    {
        public static void Ejecutar()
        {
            Random random = new Random();
            List<int> nums = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int a = random.Next(1, 101);
                nums.Add(a);
            }
            Console.Write("ingresar valor limite: ");
            int limite = int.Parse(Console.ReadLine());
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (limite > nums[i])
                    nums.RemoveAt(i);
            }
            Console.Write("la lista quedaria: ");
            for (int i = 0;i < nums.Count; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
    }
}
