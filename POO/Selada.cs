using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Selada
    {

        //classes de tipo sealed não permitem herança
        sealed class SemFilho
        {
            public double ValorDaHerança()
            {
                return 1.407033;
            }
        }

      /*class Soufilho : semfilho
        {

        }
      */

        class Avo
        {

            //métodos virtuais podem ser sobrescritos
            public virtual bool HonrarNomeFamiliar()
            {
                return true;
            }
        }


        class Pai : Avo
        {
            public override bool HonrarNomeFamiliar()
            {
                return true;
            }
        }

        class FilhoRebelde : Pai
        {
            public override bool HonrarNomeFamiliar()
            {
                return false;
            }
        }


        public static void Executar()
        {
            SemFilho semfilho = new SemFilho();
            Console.WriteLine(semfilho.ValorDaHerança());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamiliar());
        }
    }
}
