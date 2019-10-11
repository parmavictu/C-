using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("ÁREA É " + area);
            //tipos internos
            bool estaChovendo = true;
            Console.WriteLine(estaChovendo);
            //byte
            byte maxByte = byte.MaxValue;
            Console.WriteLine("Max byte" + maxByte);
            byte minByte = byte.MinValue;
            Console.WriteLine("Min byte" + minByte);
            //sbyte
            sbyte maxSbyte = sbyte.MaxValue;
            Console.WriteLine("Max sbyte" + maxSbyte);
            sbyte minSbyte = sbyte.MinValue;
            Console.WriteLine("Min sbyte " + minSbyte);
            //short
            short maxShort = short.MaxValue;
            Console.WriteLine("Max short " + maxShort);
            short minShort = short.MinValue;
            Console.WriteLine("Min short " + minShort);

            //int
            int maxInt = int.MaxValue;
            Console.WriteLine("Max int " + maxInt);
            int minInt = int.MinValue;
            Console.WriteLine("Min int " + minInt);

            //uint -> mesma coisa que int só aceita positivo
            uint maxUInt = uint.MaxValue;
            Console.WriteLine("Max uint " + maxUInt);
            uint minUInt = uint.MinValue;
            Console.WriteLine("Min uint " + minUInt);

            //long
            long maxLong = long.MaxValue;
            Console.WriteLine("Max long " + maxLong);
            long minLong = long.MinValue;
            Console.WriteLine("Min long " + minLong);
            //Jeito que podemos escrever numeros
            long populacaoBrasileira = 7_600_000_000;

            //ulong -- long mas só positivo
            ulong maxuLong = ulong.MaxValue;
            Console.WriteLine("Max ulong " + maxuLong);
            ulong minuLong = ulong.MinValue;
            Console.WriteLine("Min ulong " + minuLong);

            //float 
            float precoComputador = 1299.99f;//tem que por o F
            Console.WriteLine("preco do computador " + precoComputador);
            //double -> mais usado dos reais -> ocupa mais memoria que o float
            double testeDouble = 1_000_000_000.96;
            Console.WriteLine("Teste double " + testeDouble);

            //decimal - é para valores gigantescos

            decimal maxDecimal = decimal.MaxValue;
            Console.WriteLine("maxDecimal: " + maxDecimal);

            //char --> letra -> usar aspas simples
            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            //string

            string texto = "Isso é uma string";
            Console.WriteLine(texto);
            



        }
    }
}
