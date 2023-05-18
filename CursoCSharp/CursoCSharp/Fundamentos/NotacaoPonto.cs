﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "ola".ToUpper()
                                .Insert(3, "World!")
                                .Replace("World!", "Mundo!");

            Console.WriteLine(saudacao);
            Console.WriteLine("Teste".Length);

            string ValorImportante = null;
            // Navegação segura ( ?. ) - Verifica se estara seguro, coloca o "vazio"
            Console.WriteLine(ValorImportante?.Length);
        }
    }
}
