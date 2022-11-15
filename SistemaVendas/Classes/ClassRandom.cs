using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Classes
{
    internal class ClassRandom
    {
        private void Aleatorio()
        {
            Random rnd = new Random();

            byte[] buf = new byte[8];
            rnd.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            long result = (Math.Abs(longRand % (2000000000000000 - 1000000000000000)) + 1000000000000000);

            long random_seed = (long)rnd.Next(1000, 5000);
            random_seed = random_seed * result + rnd.Next(1000, 5000);

            var resultadoFinal = ((long)(random_seed / 655) % 10000000000000001).ToString();

            //return resultadoFinal;
        }
    }
}
