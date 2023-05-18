using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); // int.Parse converte String para Int

            Console.Write("Qual é o seu salario? ");
            double salario = double.Parse( Console.ReadLine(),
                                           CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {nome}  Idade:{idade} Salario: R${salario}");
        }
    }
}
