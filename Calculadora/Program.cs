using System;

namespace calculadoraFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "";

            do
            {
                Console.WriteLine("\t Calculadora ");
                Console.WriteLine("\n 0 -> Salir");
                Console.WriteLine("\n 1 -> Suma");
                Console.WriteLine("\n 2 -> Resta");
                Console.WriteLine("\n 3 -> Multiplicacion");
                Console.WriteLine("\n 4 -> Dividision");

                short opcion;
                while(!Int16.TryParse(Console.ReadLine(),out opcion))
                {
                    Console.WriteLine("El elemento ingresado no es una opcion valida...!");
                    Console.WriteLine("Ingrese una opcion correcta: ");
                }
                Calcular(opcion);
                Console.WriteLine("Desea continuar?  (y / n)");
                resp = Console.ReadLine();

            } while(resp == "y");
        }

        private static void Calcular(int opcion)
        {

            Console.Clear();
            switch(opcion)
            {
                case 0:
                {
                    System.Environment.Exit(-1);
                    break;
                }

                case 1:
                {
                    Suma suma = new Suma();
                    double primerNumero,segundoNumero;
                    Console.WriteLine("\t Haz elegido la opcion de sumar");
                    Console.Write("Ingresa el primer numero: ");
                    while(!Double.TryParse(Console.ReadLine(), out primerNumero))
                    {
                        Console.WriteLine("Valor ingresado ha sido erroneo.");
                        Console.WriteLine("Favor ingresar un valor correcto nuevamente: ");
                    }
                    suma.PrimerNumeroSum = primerNumero;
                   
                
                    Console.Write("Ingresa el siguiente numero: ");
                    while(!Double.TryParse(Console.ReadLine(), out segundoNumero))
                    {
                        Console.WriteLine("Valor ingresado ha sido erroneo.");
                        Console.WriteLine("Favor ingresar un valor correcto nuevamente: ");
                    }
                     suma.SegundoNumeroSum = segundoNumero;

                     suma.Sumar();
                     Console.WriteLine($"El resultado de la suma es: {suma.ResultadoSum}");
                     break;
                }
                case 2:
                {
                    Resta resta = new Resta();
                    double primerNumero,segundoNumero;
                    Console.WriteLine("\t Haz elegido la opcion de restar");
                    Console.Write("Ingresa el primer numero: ");
                    while(!Double.TryParse(Console.ReadLine(), out primerNumero))
                    {
                        Console.WriteLine("Valor ingresado ha sido erroneo.");
                        Console.WriteLine("Favor ingresar un valor correcto nuevamente: ");
                    }
                    resta.PrimerNumeroRes = primerNumero;
                   
                
                    Console.Write("Ingresa el siguiente numero: ");
                    while(!Double.TryParse(Console.ReadLine(), out segundoNumero))
                    {
                        Console.WriteLine("Valor ingresado ha sido erroneo.");
                        Console.WriteLine("Favor ingresar un valor correcto nuevamente: ");
                    }
                     resta.SegundoNumeroRes = segundoNumero;

                     resta.Restar();
                     Console.WriteLine($"El resultado de la resta es: {resta.ResultadoRes}");
                     break;
                }
                case 3:
                {
                     Multiplicacion multiply = new Multiplicacion();
                    double primerNumero,segundoNumero;
                    Console.WriteLine("\t Haz elegido la opcion de Multiplicar");
                    Console.Write("Ingresa el primer numero: ");
                    while(!Double.TryParse(Console.ReadLine(), out primerNumero))
                    {
                        Console.WriteLine("Valor ingresado ha sido erroneo.");
                        Console.WriteLine("Favor ingresar un valor correcto nuevamente: ");
                    }
                    multiply.mulPrimerNumero = primerNumero;
                   
                
                    Console.Write("Ingresa el siguiente numero: ");
                    while(!Double.TryParse(Console.ReadLine(), out segundoNumero))
                    {
                        Console.WriteLine("Valor ingresado ha sido erroneo.");
                        Console.WriteLine("Favor ingresar un valor correcto nuevamente: ");
                    }
                     multiply.mulSegundoNumero = segundoNumero;

                     multiply.Multiplicar();
                     Console.WriteLine($"El resultado de la suma es: {multiply.mulResultado}");
                     break;
                }
                case 4:
                {
                     Division Divided = new Division();
                    double primerNumero,segundoNumero;
                    Console.WriteLine("\t Haz elegido la opcion de sumar");
                    try{
                    Console.Write("Ingresa el primer numero: ");
                    while(!Double.TryParse(Console.ReadLine(), out primerNumero))
                    {
                        Console.WriteLine("El elemento ingresado no es un numero.!");
                        Console.WriteLine("Favor ingresar un valor correcto nuevamente: ");
                        throw new FormatException("Error no es un numero..!");
                        
                    }
                    Divided.divPrimerNumero = primerNumero;
                   
                
                    Console.Write("Ingresa el siguiente numero: ");
                    while(!Double.TryParse(Console.ReadLine(), out segundoNumero))
                    {
                        Console.WriteLine("El elemento ingresado no es un numero.!");
                        Console.WriteLine("Favor ingresar un valor correcto nuevamente: ");
                        throw new FormatException("Error esto no es un numero!");
                    }
                     Divided.divSegundoNumero = segundoNumero;
                    if (primerNumero == 0 || segundoNumero == 0)
                    {
                        throw new DivideByZeroException("No se puede dividir entre 0");
                    }
                  
                     Divided.Dividir();
                     Console.WriteLine($"El resultado de la suma es: {Divided.divResultado}");
                    }
                      catch(DivideByZeroException a)
                    {
                        Console.WriteLine(a.Message);
                    }
                     break;
                }
                 default:
                 {
                    Console.WriteLine("Esta opcion no existe");
                    break;
                 }

            }


            


        }
    }
}

