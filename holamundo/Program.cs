using System;

namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Clear(); //limpiar terminal
            Console.WriteLine("Ingrese su nombre: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Su nombre es: " +name);

            //Casteo explicito
            double a = 9.56;
            int b = (int) a;
            System.Console.WriteLine(b);


            int x = 1;
            switch (x)
            {
                case 1:
                    System
                        .Console
                        .WriteLine("La variable x tine el valor de 1");
                    break;
                case 2:
                    System
                        .Console
                        .WriteLine("La variable x tine el valor de 2");
                    break;
                default:
                    System.Console.WriteLine("Error");
                    break;
            }
            */

            //Ejercicio 1
/*            Console.Clear();
            Console.WriteLine("Digite el primer numero: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero: ");
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("La suma de sus numeros es: " + (a+b));
            System.Console.WriteLine("El producto de sus numeros es: " + (a*b));
            System.Console.WriteLine();

            //Ejercicio 2
            Console.WriteLine("Digite el lado de su cuadro: ");
            int cuadrado = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("El perimeto de su cuadro es: " + (cuadrado*4));
            System.Console.WriteLine();

            //Ejercicio 3
            Console.WriteLine("Digite el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el cuarto numero: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("La suma de los dos primeros numeros es: " + (num1+num2));
            System.Console.WriteLine("El producto de los dos ultimos numeros es: " + (num3*num4));
            System.Console.WriteLine();

            //Ejercicio 4
            Console.WriteLine("Digite el primer valor: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("Digite el segundo valor: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("Digite el tercer valor: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("Digite el cuarto valor: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());  
            double promedio = (nota1+nota2+nota3+nota4)/4;
            System.Console.WriteLine("Su promedio es: "+promedio);
            System.Console.WriteLine();
*/
            Console.WriteLine("Digite su nombre");
            string nombre= System.Console.ReadLine();
            Console.WriteLine("Digite su apellido");
            string apellido= System.Console.ReadLine();

            System.Console.WriteLine("Su nombre es " + nombre + " " + apellido);

            string fullname = $"Su nombre es {nombre} {apellido}";
            System.Console.WriteLine(fullname);

            int a =10
            if (a>10)
            {
                System.Console.WriteLine("El numero es mayor a 10");
            }
            else
            {
                System.Console.WriteLine("El numero es menor a 10");
            }

            string cadena = (a>10) ? "numero mayor a 10" : "numero menor a 10";
            
        }
    }
}
