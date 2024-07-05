using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atvaav
{
    internal class estoque
    {
        public double EstoqueMedio;
        public void ValorMedio(int minino, int maximo)
        {
            EstoqueMedio = (minino + maximo) / 2;
        }
    }
}
