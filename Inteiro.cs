using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace atvaav
{
    public class Inteiro
    {
        public int ValorA { get; set;}
        public int ValorB { get; set;}
        
        public void LerValor()
        {
            Console.WriteLine("Escreva o valor A");
            ValorA = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor A: " + ValorA);


            ValorB = ValorA;

            Console.WriteLine("Valor B: " + ValorB);



            Console.WriteLine("Escreva o valor B");
            ValorB = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor B: " + ValorB);


            ValorA = ValorB;

            Console.WriteLine("Valor A: " + ValorA);

        }


        public void Modulo()
        {
            Console.WriteLine("Escreva um numero inteiro");
            ValorA = int.Parse(Console.ReadLine());

            if (ValorA >= 0)
            {
                ValorA = ValorA;
                Console.WriteLine("Modulo do numero inteiro: " + ValorA);
            }else if(ValorA < 0)
            {
                ValorA = ValorA * (-1);
                Console.WriteLine("Modulo do numero inteiro: " + ValorA);

            }
        }
    }
}
