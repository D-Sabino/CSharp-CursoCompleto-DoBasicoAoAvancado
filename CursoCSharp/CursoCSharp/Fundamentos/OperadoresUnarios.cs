using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            /*
                Ordem de execução com base na prioridade:
                Passo 01: Decrementa numero2 (pois o -- anterior a variavel tem prioridade);
                Passo 02: Compara numero1 com numero2;
                Passo 03: Incrementa numero1;
            */
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} e {numero2}");
        }
    }
}
