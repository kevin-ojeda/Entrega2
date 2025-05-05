using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Ejercicio4_Array
    {
        // Crear un array con los días de la semana y mostrar solo los días laborales.
        public static void Ejecutar()
        {
            string[] dias = {"domingo","lunes","martes","miercoles","jueves","viernes","sabado"};
            Console.WriteLine("los dias laborales son");
            for (int i = 0; i < dias.Length; i++)
            {
                if (dias[i] != "sabado" && dias[i] != "domingo")
                {
                    Console.WriteLine(dias[i]);
                }
            }
        }
    }
}
