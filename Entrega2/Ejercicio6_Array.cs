using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Ejercicio6_Array
    {
        //Crear una matriz de 3x3. Solicitar al usuario que ingrese todos los elementos y luego mostrar la suma de cada fila.
        public static void Ejecutar()
        {
            int[,] matriz = new int[3, 3];
            for (int columna = 0; columna < 3; columna++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    Console.WriteLine($"ingresar el numero de la fila {fila + 1} columna {columna + 1}");
                    matriz[fila, columna] = int.Parse(Console.ReadLine());
                }
            }
            int sumafila1 = 0;
            int sumafila2 = 0;
            int sumafila3 = 0;
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    if (fila == 0)
                    {
                        sumafila1 += matriz[fila, columna];
                    }
                    else if (fila == 1)
                    {
                        sumafila2 += matriz[fila, columna];
                    }
                    else if (fila == 2)
                    {
                        sumafila3 += matriz[fila, columna];
                    }
                }
            }
            Console.WriteLine($"la suma de la fila 1 es {sumafila1}");
            Console.WriteLine($"la suma de la fila 2 es {sumafila2}");
            Console.WriteLine($"la suma de la fila 3 es {sumafila3}");
        }
    }
}
