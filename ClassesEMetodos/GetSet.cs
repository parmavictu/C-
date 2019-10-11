using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class GetSet {

        public class Moto {
            private string Marca;
            private string Modelo;
            private int Cilindrada;

            public Moto(string Marca, string Modelo, int Cilindrada) {
                //this.Marca = Marca;
                //this.Modelo = Modelo;
                // this.Cilindrada = Cilindrada;

                SetCilindrada(Cilindrada);
                SetMarca(Marca);
                SetModelo(Modelo);
            }
            
            public Moto() {

            }

            public string GetMarca() {
                return Marca;
            }
            public void SetMarca(string Marca) {
                this.Marca = Marca;
            }
            public string GetModelo() {
                return Modelo;
            }
            public void SetModelo(string Modelo) {
                this.Modelo = Modelo;
            }public int GetCilindrada() {
                return Cilindrada;
            }
            public void SetCilindrada(int Cilindrada) {//Outra alternativa para só aceitar numero positivo é deixar o tipo como uint
                 //Uma opção pra deixar positivo
                 //if (Cilindrada > 0)
                //{
                //   this.Cilindrada = Cilindrada;
                //}
                //outra opção
                this.Cilindrada = Math.Abs(Cilindrada);//se ele for negativo transforma em positivo
                
            }
        }
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja Z-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());


            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(123);

            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());
        }
    }
}
