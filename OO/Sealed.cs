using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    sealed class SemFilho {//Sealed class sao classes que não podem ter herança,
        public double ValorDaFortuna() {
            return 1_407_033.65;
        }
    }
    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }

    }
    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() {//como foi selado não pode ser mais sobrescrita pelos filhos
            return true;
        }
    }
    //exemplo
    class FilhoRebelde : Pai {
        //  public override bool HonrarNomeFamilia() { -> mas se usar new ainda oculta
        //    return false;
        //}
    }
    class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
