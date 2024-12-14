using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoRepeticaoWhile
{
    internal class SomaNumeros
    {
        //Peça ao usuário para digitar números inteiros até que ele digite o número 0.
        //Ao final, mostre a soma dos números digitados.

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int somaNumero = Convert.ToInt16(Console.ReadLine());
        }
    }
}
