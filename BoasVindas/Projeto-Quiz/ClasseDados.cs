using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Quiz
{
    class ClasseDados
    {
        public static int Acertos = 0;  // Public Static Int declara essa variável como uma váriavel pública,
        public static int Erros = 0;    // reconhecida não somente dentro desse arqivo mas sim em todo o projeto.

        public static void Acertou()
        {
            Acertos++;
        }

        public static void Errou()
        {
            Erros++;
        }

        public static int getAcertos()
        {
            return Acertos;
        }
        public static int getErros()
        {
            return Erros;
        }

    }
}
