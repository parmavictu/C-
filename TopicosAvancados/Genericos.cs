using System;
using CursoCSharp.ClassesEMetodos;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {

    public class Caixa<T> {//Posso colocar qualquer letra ou palavra
        T valorPrivado;//Esse t você passa depois, e pode ter mais de um generics
        public T Coisa { get; set; }

        public Caixa(T coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }
        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }
        public T GetValor() {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int> {
        public CaixaInt() : base(0) {

        }
    }
    class CaixaProduto : Caixa<Produto> {
        public CaixaProduto() : base(new Produto()) {//Podemos passar uma instancia tbm

        }
    }
    class Genericos {
        public static void Executar() {
            var caixa1 = new Caixa<int>(1000);

            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());


            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("método"));

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa2.Coisa.GetType().Name);


        }
    }
}
