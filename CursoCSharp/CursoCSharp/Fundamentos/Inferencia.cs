using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Daniel"; //Detectou o tipo que foi criado e associou
            //nome = 123; <- Não aceita o valor do tipo int, pois ele foi determinado como int.
            Console.WriteLine(nome);

            //var idade; <- Apresenta erro, pois a variavel do tipo var precisa ser inicializada recebendo o valor.
            //idade = 32;
            var idade = 32;
            Console.WriteLine(idade);

            int a; // Declaração
            a = 3;

            int b = 2; // Declaração inicializando a variavel
            
            Console.WriteLine(a + b);
        }
    }
}
