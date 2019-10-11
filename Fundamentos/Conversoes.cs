using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            //jeito 1
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //jeito 2 -> tem perda de informação
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            //string para idade
            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"idade inserida: {idadeInteiro}");
            //string para idade usando o system
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"resultado: {idadeInteiro}");
            //Melhor modo -> string para int
            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);//vai tentar conveter para int, se a pessoa tiver digitado uma string vai converter a string pra 0
            Console.WriteLine($"Primeiro numero: {numero}");
            //mesmo modo do de cima mas mais otimizado
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Segundo numero: {numero2}");



        }
    }
}
