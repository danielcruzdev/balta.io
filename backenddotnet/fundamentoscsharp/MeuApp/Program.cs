﻿using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Testando";
            Console.WriteLine(texto);

            //Conversão Implicita de Dados
            float valor = 25.8f;
            int outro = 25;

            valor = outro;
        }
    }
}
