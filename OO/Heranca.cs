using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }else if (novaVelocidade >VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            }else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar() {//virtual significa que pode ser Sobrescrito
            return AlterarVelocidade(5);
        }
        public int Frear() {
            return AlterarVelocidade(-5);
        }

    }

    class Uno: Carro {
        public Uno() : base(200) {

        }
    }

    class Ferrari: Carro {
        public Ferrari() : base(350) {//se tivesse o construtor padrao na classe pai não precisaria chamar aqui assim

        }

        public override int Acelerar() {//override precisa do virtual no metodo da classe pai
            return AlterarVelocidade(15);
        }

        public new int Frear() {//new serve para sobrescrever também, mas não precisa colocar o virtual no metodo da classe pai
            return AlterarVelocidade(-15);
        }
    }


    class Heranca {
        public static void Executar() {
            Console.WriteLine("uno...");

            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());



            Console.WriteLine("Ferrari...");

            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());




            Console.WriteLine("Ferrari do tipo carro...");


            Carro carro3 = new Ferrari();//O problema de usar new é que quando vc usa o polimorfismo ele vai pegar os valores da classe pai e não o que vc sobreescreveu
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());




            Console.WriteLine("Uno do tipo carro...");


            carro3 = new Uno();//polimorfismo 
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
