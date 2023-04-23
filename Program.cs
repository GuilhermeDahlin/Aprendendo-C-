using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Executando Projeto 13");

        // Queremos ter uma espécie de saída como essa:
        //*
        //**
        //***     Tendo um for pra cada linha e cada coluna
        //****
        //*****

        // Escrevendo asteriscos com o BREAK 

        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinha)
                    break;
            }
        }
        Console.WriteLine();
        // Quando se escreve o WriteLine sem nada (sem nenhum argumento), ele simplesmente pula a linha


        // Uma forma diferente de fazer o desenho de asteríscos
        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
