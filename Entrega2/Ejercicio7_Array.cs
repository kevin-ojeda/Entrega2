using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Ejercicio7_Array
    {
        //Cargar una matriz de 3x3. Mostrar la fila con mayor suma.
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
            if (sumafila1 > sumafila2 && sumafila1 > sumafila3)
            {
                Console.WriteLine($"la fila con la mayor suma es la 1 con un valor de  {sumafila1}");
            }
            else if (sumafila2 > sumafila1 && sumafila2 > sumafila3)
            {
                Console.WriteLine($"la fila con la mayor suma es la 2 con un valor de {sumafila2}");
            }
            else if (sumafila3 > sumafila1 && sumafila3 > sumafila2)
            {
                Console.WriteLine($"la fila con la mayor suma es la 3 con un valor de {sumafila3}");
            }
        }
    }
}
