using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            //1º caso com codicional ou:   if (idadeJoao >= 18 || quantidadePessoas >= 2)
            //Podemos também fazer o teste com o condicional e (que no CSharp é representado por &&)
            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
            Console.ReadLine();
        }
    }
}
