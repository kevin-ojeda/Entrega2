using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Ejercicio2_Array
    {
        //Solicitar al usuario 8 nombres y almacenarlos en un array. Mostrar cuántos empiezan con la letra 'A'.
        public static void Ejecutar()
        {
            Console.WriteLine("ingresar 8 nombres, se mostran los que inician con la letra A");
            string[] nombres = new string[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"ingresar el {i + 1}° nombre:");
                nombres[i] = Console.ReadLine();
            }
            int contador = 0;
            for (int i = 0; i < 8; i++)
            {
                if (nombres[i][0] == 'a' || nombres[i][0] == 'A')
                {
                    if (nombres[i][0] == 'a' || nombres[i][0] == 'A')
                    {
                        contador++;
                    }
                }
            }
            string[] conA = new string[contador]; //(lo hice de esta forma para no tener el array con espacios vacios)
            int a = 0;
            for (int i = 0; i < 8; i++)
            {
                if (nombres[i][0] == 'a' || nombres[i][0] == 'A')
                {
                    if (nombres[i][0] == 'a' || nombres[i][0] == 'A')
                    {
                        conA[a] = nombres[i];
                        a++;
                    }
                }
            }
            Console.WriteLine("Los nombres que inician con A son;");
            for (int i = 0;i < conA.Length;i++)
            {
                Console.WriteLine(conA[i]);
            }
        }
    }
}
