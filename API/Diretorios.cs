using System;
using System.IO;

namespace CursoCSharp.API {
    class Diretorios {
        public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var DirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);//True é que vai excluir recursivo

            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));
            //Exibir as pastas
            Console.WriteLine("== Pastas =====================");
            var pastas = Directory.GetDirectories(DirProjeto);
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("\n\n== Arquivos ==============");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
            
        }
    }
}
