using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Avalie meu atendimento: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("pessimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:{
                        Console.WriteLine("Regular");
                        break;
                    }
                    
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("ótimo");
                    break;
                default:
                    Console.WriteLine("Nota invalida");break;
            }


        }
    }
}
