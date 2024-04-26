using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercico_Practico_2_LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();



            //Console.WriteLine("\nEmpleados ordenados por nombre \n*******");
            //ce.getEmpleadosOrdeandos();
            //Console.WriteLine("");

            //Console.WriteLine("Promedios por empresa \n**********");
            //ce.promedioSalario();
            //Console.WriteLine("");

            //Console.WriteLine("Peces Gordos \n*************");
            //ce.getCEO("CEO");
            //Console.WriteLine("");


            //Console.WriteLine("\nPlantilla ordenada por salario \n********");
            //ce.getEmpleadosOrdenadosSegun();
            //Console.WriteLine("");

            //Console.WriteLine("\nIngrese la empresa:(entero 1 a 3)\n1 para IAlpha\n2 para Udelar\n3 para SpaceZ");
            //string IDF = Console.ReadLine();
            //try
            //{
            //    int empresaF = int.Parse(IDF);
            //    ce.getEmpleadoEmpresa(empresaF);
            //}
            //catch
            //{
            //    Console.WriteLine("Ha introducido un Id erroneo.Debe ingresar un numero entero ");
            //}

            // EJERCICIOS del Pizarron!!
            //Mostrar cantidad de ceos en empresa 1
            //ce.ceoEmpresa();

            //Mostrar datos de emplado que gana mas
            //ce.mayorSalario();

            //Mostrar sueldos mayores a 2200
            //ce.mayoresSueldosEmpleados();

            //Motrar mayor sueldo por cargo
            //ce.mayorSueldoPorCargo();

            //Mostrar mayor sueldo por empresa
            //ce.mayorSueldoPorEmpresa();


            // EJERCICIO 3  COMPLEJIDAD COGNITIVA

            //Parte i- Complejidad 4
            //Parte ii-  
            //List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            //valores.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));

            //----------------------------------------------

            // EJERCICIO 4 
            // Parte i-a

            //List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            //Console.WriteLine("El valor de la suma total es : " + valores.Sum());

            //Parte i-b

            //Console.WriteLine(valores.Where(x => x % 2 == 0).Sum());


            //EJERCICIO 5
            //Parte i-a

            //List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //int sumaTotalValoresParesMayoresAOcho = 0;
            //int sumaTotalValoresParesMenoresAOcho = 0;
            //foreach (var valor in valores)
            //{
            //    if (valor % 2 == 0 && valor > 8)
            //    {
            //        sumaTotalValoresParesMayoresAOcho += valor;
            //    }
            //    else if (valor % 2 == 0 && valor < 8)
            //    {
            //        sumaTotalValoresParesMenoresAOcho += valor;
            //    }
            //}
            //Console.WriteLine($"La suma par < 8 es : " + sumaTotalValoresParesMenoresAOcho);
            //Console.WriteLine($"La suma par > 8 es : " + sumaTotalValoresParesMayoresAOcho);


            //Parte i-b

            //Console.WriteLine(("La suma total de los pares mayores a ocho es: "+ valores.Where(x => x % 2 == 0 && x > 8).Sum()));

            //Console.WriteLine(("La suma total de los pares menor a ocho es: " + valores.Where(x => x % 2 == 0 && x  < 8).Sum()));


            // EJERCICO 6
            //Parte i

            //LA COMPLEJIDAD ES 6

            //Parte ii

            //string letra = Console.ReadLine();
            //int posicion = 0;
            //char[] alfabeto = "abcdefg".ToCharArray();

            //while (posicion < alfabeto.Length && letra[0] != alfabeto[posicion])
            //{
            //    posicion++;
            //}
            //Console.WriteLine("La siguiente letra es :" + alfabeto[posicion + 1]);


        }
    }
}
