using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, resp;
            Console.WriteLine("\nPrograma que suma dos números");
            Console.WriteLine("\nDigitar el primer número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigitar el segundo número:");
            n2 = double.Parse(Console.ReadLine());
            resp = n1 + n2;
            Console.WriteLine("\nLa suma de los números digitados es:" + resp);
            Console.ReadKey();

            Console.WriteLine("\n...............................");
            Console.WriteLine("\nPrograma que multiplica dos números");

            int numero11;
            int numero22;
            int multiplicacion;
            Console.Write("Escriba el primer entero:");
            numero11 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el segundo entero:");
            numero22 = Convert.ToInt32(Console.ReadLine());
            multiplicacion = numero11 * numero22;
            Console.WriteLine("La multiplicacion es {0}", multiplicacion);

            Console.WriteLine("\n...............................");
            Console.WriteLine("\nPrograma que resta dos números");

            int numero444;
            int numero555;
            int resta;
            Console.Write("Escriba el primer entero:");
            numero444 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el segundo entero:");
            numero555 = Convert.ToInt32(Console.ReadLine());
            resta = numero444 - numero555;
            Console.WriteLine("La resta es {0}", resta);

            Console.WriteLine("\n...............................");
            Console.WriteLine("\nTarea 5");
            int numero55;
            int numero56;
            int suma1;
            int modulo;
            Console.Write("Escriba el primer entero:");
            numero55 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el segundo entero:");
            numero56 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el número 6:");
            modulo = Convert.ToInt32(Console.ReadLine());
            suma1 = (numero55 + numero56) % modulo;
            Console.WriteLine("El resultado es {0}", suma1);

            Console.WriteLine("\n...............................");
            Console.WriteLine("\nTarea 6");
            int numero4;
            int numero5;
            int multiplicar5;
            Console.Write("Escriba el primer entero:");
            numero4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el segundo entero:");
            numero5 = Convert.ToInt32(Console.ReadLine());
            multiplicar5 = numero4 * numero5;
            Console.WriteLine("El resultado es {0}", multiplicar5);

            Console.WriteLine("\n...............................");
            Console.WriteLine("\nTarea 7");
            int numero44;
            int numero556;
            int suma5;
            Console.Write("Escriba el primer entero:");
            numero44 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el segundo entero:");
            numero556 = Convert.ToInt32(Console.ReadLine());
            suma5 = numero44 + numero556;
            Console.WriteLine("La suma es {0}", suma5);

            Console.WriteLine("\n...............................");
            Console.WriteLine("\nTarea 8 y 9");
            int numero1;
            int numero2;
            int multiplicar;
            Console.Write("Escriba el primer entero:");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el segundo entero:");
            numero2 = Convert.ToInt32(Console.ReadLine());
            multiplicar = numero1 * numero2;
            Console.WriteLine("El resultado es {0}", multiplicar);

            Console.WriteLine("\n...............................");
            Console.WriteLine("\nTarea 12");

            Console.Write("Ingrese el primer número:");
            float num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número:");
            float num2 = Int32.Parse(Console.ReadLine());
            float Division = num1 / num2;
            {
                if (num2 != 0)
                    Console.WriteLine(Division);
                else
                    if (num2 == 0) Console.WriteLine("Error:No se puede dividir entre cero");
            }

            Console.WriteLine("\n...............................");
            Console.WriteLine("\nTarea 13");

            Console.WriteLine("Escriba un número del 1 al 5");
            int numero = Int32.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
            }



            Console.WriteLine("\n...............................");
            Console.WriteLine("\nTarea 14");

            int contador = 1;
            while (contador <= 10)
            {
                Console.Write("{0}", contador);
                contador++;
            }

            Console.WriteLine("\n...............................");
            Console.WriteLine("\nTarea 15");

            int conta = 1;
            do
            {
                Console.Write("{0}", conta);
                conta++;
            }
            while (conta <= 10);
            Console.WriteLine();


            Console.WriteLine("\n...............................");
            Console.WriteLine("\nTarea 16");
            for (int contado = 10; contado <= 20; contado++)
                Console.Write("{0}", contado);

            Console.WriteLine("\n...............................");

            int numeross;

            Console.WriteLine("Introduzca un número entero: ");
            numeross = Convert.ToInt32(Console.ReadLine());
            while (numeross != 0)

            {
                if (numeross % 2 == 0)
                    Console.WriteLine("El número ingresado es PAR");
                else
                    Console.WriteLine("El número ingresado es IMPAR");
                Console.WriteLine("Introduzca un número entero: ");
                numeross = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
            }



        }
    }
}
