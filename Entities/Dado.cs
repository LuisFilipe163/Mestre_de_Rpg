using Mestre_de_Rpg.Contracts;
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

        /// <summary>
        /// Realiza a rolagem de um número específico de dados com um determinado número de lados.
        /// </summary>
        /// <param name="QtdDados">Quantidade de um tipo de Dado</param>
        /// <param name="QtdLados">Qauntidade de lados do Dado</param>
        /// <returns>Valor total obtido das rolagens de todos os dados.</returns>
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
