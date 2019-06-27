using System;
using System.Collections.Generic;
using System.Text;

namespace Drone
{
    class Drone
    {
        public enum OPERACAO
        {
            SOMA,
            SUBTRACAO
        }

        public string Movimentar(string entrada)
        {
            entrada = entrada.ToUpper();
            int moveX = 0, moveY = 0;
            int passo = 1;
            string StringNumber = "";

            for (int i = 0; i < entrada.Length; i++)
            {
                if (i < entrada.Length - 1)
                    if (entrada[i + 1] == 'X') continue;
                if (int.TryParse(entrada[i].ToString(), out int number))
                    StringNumber += number.ToString();
                else
                {

                    if (!int.TryParse(StringNumber, out passo))
                        return "999,999";

                    StringNumber = "";
                }
                switch (entrada[i])
                {
                    case 'N':
                        moveX = calcular(OPERACAO.SOMA, moveX, passo);
                        break;
                    case 'S':
                        moveX = calcular(OPERACAO.SUBTRACAO, moveX, passo);
                        break;
                    case 'L':
                        moveY = calcular(OPERACAO.SOMA, moveY, passo);
                        break;
                    case 'O':
                        moveY = calcular(OPERACAO.SUBTRACAO, moveY, passo);
                        break;
                    default:
                        break;
                }
            }
            passo = 1;
            return moveX + "," + moveY;
        }
        public int getNumber(int i, string entrada)
        {
            string StringNumber = "";
            while (int.TryParse(entrada[i].ToString(), out int number))
            {
                StringNumber += number.ToString();
                i++;
            }
            return int.Parse(StringNumber);
        }
        public int calcular(OPERACAO operacao, int total, int passo = 1)
        {

            if (operacao == OPERACAO.SOMA)
            {
                return total + passo;
            }
            else
            {
                return total - passo;
            }
        }
    }
}
