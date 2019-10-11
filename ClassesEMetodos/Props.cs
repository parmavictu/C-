using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {
        double desconto = 0.1;//estao privadas
        string nome;
        public string Nome {//Um modo de fazer o metodo set e get
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;//value é o valor que vai receber no set
            }
        }
        //propriedade autoimplementada
        public double Preco { get; set; }
        //Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco);//lambda
            //get{
            // return Preco - (desconto * Preco);
            //}
        }
        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }


    class Props {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);

        }
    }
}
