using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor_de_unidades
{
    class Principal
    {

        //hacemos un metodo menu para que el usuario eliga que opcion necesita
        public void menu()
        {

            Console.WriteLine("Eliga una opcion");

            Console.WriteLine("1.-Convertir de cm a metros");
            Console.WriteLine("2.-Convertir de M a pulgadas");
            Console.WriteLine("3.-Convertir de Litros a Mililitros");
            Console.WriteLine("4.-Salir");

            Datos u = new Datos();
            int n = 0; double res = 0;

            n = int.Parse(Console.ReadLine());
            Operaciones op = new Operaciones();
            //hacemos un switch para que el usuario eliga la opcion
            switch (n)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad de centimetros que desea convertir a Metros: ");
                    u.Num = double.Parse(Console.ReadLine());
                    res = op.Convertir(u.Num);
                    Console.WriteLine("La cantidad en metros es " + " " + res);
                    Console.ReadKey();
                    Console.WriteLine(" ");
                    menu();
                    break;

                case 2:
                    Console.WriteLine("Ingrese la cantidad de metros que desea convertir a pulgadas: ");
                    u.Num = double.Parse(Console.ReadLine());
                    res = op.Convertir(u.Num, 39.37);
                    Console.WriteLine("La cantidad en pulgadas es" + " " + res);
                    Console.ReadKey();
                    Console.WriteLine(" ");
                    menu();
                    break;

                case 3:
                    Console.WriteLine("Ingrese la cantidad de Litros que desea convertir a mililitros: ");
                    u.Num = double.Parse(Console.ReadLine());
                    res = op.Convertir(u.Num, 10, 100);
                    Console.WriteLine("La cantidad en Mililitros es" + " " + res);
                    Console.ReadKey();
                    Console.WriteLine(" ");
                    menu();
                    break;

                case 4:
                    Console.WriteLine("Gracias por usar mi progama");
                    Console.ReadKey();
                    System.Environment.Exit(-1);
                    break;
            
                default:
                    Console.WriteLine("Ingrese un valor correcto");
                    Console.ReadKey();
                    Console.WriteLine(" ");
                    menu();
                    break;

            }
        }
    }
}
