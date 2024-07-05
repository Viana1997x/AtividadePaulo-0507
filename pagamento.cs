using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvaav
{
    public class pagamento
    {
        public string Nome { get; set; }
        public int CodPeca { get; set; }
        public double ValorPeca { get; set; }
        public int QteVendida { get; set; }
        public double VendaTotal { get; set; }

        public double comissao { get; set; }


        public void Comissao()
        {
            Console.WriteLine("Qual é o valor da peça que foi vendida?");
            ValorPeca = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual foi a qte vendida?");
            QteVendida = int.Parse(Console.ReadLine());


            VendaTotal = ValorPeca * QteVendida;
            comissao = (VendaTotal) * 0.5;

            Console.WriteLine("a comissão do " + Nome + " é: " + comissao);
        }
    }
}
