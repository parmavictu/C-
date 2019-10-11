using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Dynamics {
        public static void Executar() {
            dynamic meuObjeto = "teste";//dynamic é um tipo de variavel que não tem tipagem tipo do js
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();//Tipo o objeto do Js
            aluno.nome = "João";
            aluno.nota = 8.9 ;
            aluno.idade = 24;
            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.idade}");
        }
    }
}
