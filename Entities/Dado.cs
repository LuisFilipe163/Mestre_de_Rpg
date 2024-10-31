using Mestre_de_Rpg.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestre_de_Rpg.Entities
{
    internal static class Dado
    {
        public static Random rolagem = new();

        public static int RolarDados(int QtdDados, int QtdLados)
        {

            if (QtdDados == 0)
            {
                return 0;
            }
            else
            {
                int total = 0;

                for (int i = 0; i < QtdDados; i++)
                {
                    total += rolagem.Next(1, QtdLados + 1);
                }
                return total;
            }
        }
    }
}
