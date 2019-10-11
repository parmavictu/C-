using System;
using System.IO;//Para trabalhar com arquivos

namespace CursoCSharp.API {
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||//Descobrir o sistema Os
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");//Substituir o ~pela home de cada sistema
            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo {
        public static void Executar() {
            //var s = @"\tste\nestes\a.txt";//@ antes é para mostrar que é todo string e não tem ppor exemplo \t que é um tab

            var path = @"~/primeiro_arquivo.txt".ParseHome();// ~ significa home

            if (!File.Exists(path))//para ver se o arquivo não existe
            {
                using (StreamWriter sw = File.CreateText(path))//Para criar um arquivo
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
                using (StreamWriter sw = File.AppendText(path))//Adicionar texto em arquivo ja criado
                {
                    sw.WriteLine("");
                    sw.WriteLine("é possivel");
                    sw.WriteLine("adicionar");
                    sw.WriteLine("mais texto");

                }
            }
        }
    }
}
