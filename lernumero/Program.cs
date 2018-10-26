using System;

namespace lernumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 3;

            switch(numero){
                case 3 : Console.WriteLine("Vain");
                    break;
                default : Console.WriteLine("Vain naum");
                    break;
            }

            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            //}
            //int numero, sucessor, antecessor;
            //string texto;

            //Console.WriteLine("Informe um numero: ");
            //numero = int.Parse(Console.ReadLine());

            //sucessor = numero ++;
            //antecessor = numero --;

            //texto = "numero: {0} sucessor: {1} antecessor: {2} ";
            //Console.WriteLine(texto, numero, sucessor, antecessor);
        }
    }
}
