using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvaav
{
    public class moeda
    {
        public double dolar { get; set; }
        public double real { get; set; }

        public double valor { get; set; }


        public void Converter()
        {
            Console.WriteLine("Escreva o valor atual do dolar");
            dolar = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva um valor em dolar");
            valor = int.Parse(Console.ReadLine());

            real = valor * dolar;

            Console.WriteLine("Valor Convertido: " + real);
        }
    }
}
