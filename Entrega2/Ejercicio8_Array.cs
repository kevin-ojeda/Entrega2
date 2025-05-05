using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Ejercicio8_Array
    {
        //Crear una matriz de 3x3.Reemplazar todos los elementos negativos por cero.
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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        matriz[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
        }
    }
}
