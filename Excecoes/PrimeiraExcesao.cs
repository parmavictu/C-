using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {
    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }
        public void Sacar(double valor) {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }
    class PrimeiraExcecao {
        public static void Executar() {

            var conta = new Conta(1_223.45);

            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }catch(Exception ex)//colocando só exception vai tratar todo tipo de erro
            {
                Console.WriteLine(ex.Message);
            }finally//sempre vai ser executado não importa se cair no catch ou não
            {
                Console.WriteLine("Obrigado!");
            }

        }
    }
}
