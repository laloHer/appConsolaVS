using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appConsola1
{
    class Program
    {
        private static int[] sueldo;
        private static int[,] mat;
        static void Main(string[] args)
        {

            double n1 = 0, n2 = 0;
            Console.WriteLine("Ejemplo de Calculadora en C#");
            Console.WriteLine("----------------------------\n");

            //Ingresandi Valores

            Console.WriteLine("Ingrese un numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Ingrese otro numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            //Menú
            Console.WriteLine("Escoja una operacion a realizar");
            Console.WriteLine("\t Opcion s - Suma");
            Console.WriteLine("\t Opcion r - Resta");
            Console.WriteLine("\t Opcion m - Multiplicacion");
            Console.WriteLine("\t Opcion d - Divicion");
            Console.WriteLine("Opcion ?");

           

            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"La operacion es: {n1} + {n2} = " + (n1 + n2));
                    break;
                case "r":
                    Console.WriteLine($"La operacion es: {n1} - {n2} = " +(n1-n2));
                    break;
                case "m":
                    Console.WriteLine($"La operacion es: {n1} * {n2} = " + (n1 * n2));
                    break;
                case "d":
                    Console.WriteLine($"La operacion es: {n1} / {n2} = " + (n1 / n2));
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }




            Console.ReadKey();


            /*
            sueldo = new int[5];


            for (int i = 0; i < 5; i++)
            {
                sueldo[i] = i * 2; 
            }
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(sueldo[j]);
            }
            */



            #region Matriz
            /*mat = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    mat[i, j] = (i + j) * 3;
                }
            }

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {

                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Comentarios
            /*
             
            Console.WriteLine("Ejemplo de Estructuras de Control");

            Console.WriteLine("Ingrese un numero");
            int nume = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un numero mayor al anterior");
            int nume2 = int.Parse(Console.ReadLine());

            while (nume < nume2)
            {
                Console.WriteLine("valores: " + nume);
                nume++;
            }
            
            
            //tipos de datos
            int positivo = 10;
            float num = 3.6f;
            double miDouble = 50.33;
            decimal miDeci = 800.50m;
            byte diasSemana = 7;
            bool miBandera = true;

            string miCadena = "Probando Cadena";
          
                        if (nume==1)
                        {
                            Console.WriteLine("El valor es 1..");
                        }
                        else if (nume == 2)
                        {
                            Console.WriteLine("El valor es 2..");
                        }
                        else if(nume == 3)
                        {
                            Console.WriteLine("El valor es 3..");
                        }
                        else
                        {
                            Console.WriteLine("El valor no coincide..");
                        }
                        */

            /*
            switch (nume)
            {
                case 1:
                    Console.WriteLine("El valor es 1");
                    break;
                case 2:
                    Console.WriteLine("El valor es 2");
                    break;
                case 3:
                    Console.WriteLine("El valor es 3");
                    break;
                default:
                    Console.WriteLine("Valor no admitido");
                    break;
            }
           */
            #endregion


        }
    }
}
